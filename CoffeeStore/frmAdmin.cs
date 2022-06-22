using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeStore
{
    public partial class frmAdmin : Form
    {
        BindingSource accountList = new BindingSource();
        public Account loginAccount;
        DataTable myTable = new DataTable();
        public frmAdmin()
        {
            InitializeComponent();
            Loading();
        }
        
        void Loading()
        {
            dtgvAccount.DataSource = accountList;
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadAccount();
            AddAccountBinding();
        }
        void AddAccountBinding()
        {
            txtTenTaiKhoan.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "TenDangNhap", true, DataSourceUpdateMode.Never));
            txtTenHienThi.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "TenNguoiDung", true, DataSourceUpdateMode.Never));
            nmrLoaiTaiKhoan.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "LoaiTaiKhoan", true, DataSourceUpdateMode.Never));
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            string sql = "SELECT TenNL, SoLuong FROM NGUYENLIEU";
            myTable = DAO.LoadDataToTable(sql);
            chartNguyenLieu.DataSource = myTable;
            chartNguyenLieu.ChartAreas["ChartArea1"].AxisX.Title = "Nguyên liệu";
            chartNguyenLieu.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";
            chartNguyenLieu.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chartNguyenLieu.Series["NguyenLieu"].XValueMember = "TenNL";
            chartNguyenLieu.Series["NguyenLieu"].YValueMembers = "SoLuong";
            chartNguyenLieu.Series["NguyenLieu"]["PixelPointWidth"] = "8";
            chartNguyenLieu.Series["NguyenLieu"].IsValueShownAsLabel = true;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dataGridViewHoaDon.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            frmDoanhThu f = new frmDoanhThu();
            f.ShowDialog();
        }

        private void btnThemAcc_Click(object sender, EventArgs e)
        {
            string userName = txtTenTaiKhoan.Text;
            string displayName = txtTenHienThi.Text;
            int type = (int)nmrLoaiTaiKhoan.Value;
            string sql = "SELECT TenDangNhap FROM TAIKHOAN WHERE TenDangNhap = N'" + txtTenTaiKhoan.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Tên tài khoản này đã có ai đó dùng, bạn phải nhập tên tài khoản khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTaiKhoan.Focus();
                txtTenTaiKhoan.Text = "";
                return;
            }
            try
            {
                AddAccount(userName, displayName, type);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi gì đó rùi!" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnXoaAcc_Click(object sender, EventArgs e)
        {
            string userName = txtTenTaiKhoan.Text;

            DeleteAccount(userName);
        }

        private void btnSuaAcc_Click(object sender, EventArgs e)
        {
            string userName = txtTenTaiKhoan.Text;
            string displayName = txtTenHienThi.Text;
            int type = (int)nmrLoaiTaiKhoan.Value;

            EditAccount(userName, displayName, type);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string userName = txtTenTaiKhoan.Text;

            ResetPass(userName);
        }

        private void btnXemAcc_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xóa chính bạn?");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }
    }
}
