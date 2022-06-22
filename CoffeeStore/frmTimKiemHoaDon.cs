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
    public partial class frmTimKiemHoaDon : Form
    {
        DataTable tblHDB;
        public frmTimKiemHoaDon()
        {
            InitializeComponent();
        }
        private void frmTimKiemHoaDon_Load(object sender, EventArgs e)
        {
            ResetValues();
            DataGridView.DataSource = null;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ResetValues()
        {
            txtMaHDBan.Text = "";
            txtManhanvien.Text = "";
            txtNam.Text = "";
            txtThang.Text = "";
            txtMaban.Text = "";
            txtTongtien.Text = "";
            txtMaHDBan.Focus();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaHDBan.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") &&
               (txtManhanvien.Text == "") && (txtMaban.Text == "") &&
               (txtTongtien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yeu cau ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT MaHD, MaNV, NgayDat, MaBan, TongTien FROM HOADON WHERE 1=1";
            if (txtMaHDBan.Text != "")
                sql = sql + " AND MaHD = "+ txtMaHDBan.Text;
            if (txtThang.Text != "")
                sql = sql + " AND MONTH(NgayDat) =" + txtThang.Text;
            if (txtNam.Text != "")
                sql = sql + " AND YEAR(NgayDat) =" + txtNam.Text;
            if (txtManhanvien.Text != "")
                sql = sql + " AND MaNV = " + txtManhanvien.Text;
            if (txtMaban.Text != "")
                sql = sql + " AND MaBan =" + txtMaban.Text;
            if (txtTongtien.Text != "")
                sql = sql + " AND TongTien <=" + txtTongtien.Text;
            try
            {
                tblHDB = DAO.LoadDataToTable(sql);
                if (tblHDB.Rows.Count == 0)
                {
                    MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ResetValues();
                }
                else
                    MessageBox.Show("Có " + tblHDB.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataGridView.DataSource = tblHDB;
                Load_DataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bạn đã nhập sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_DataGridView()
        {
            DataGridView.Columns[0].HeaderText = "Mã hóa đơn";
            DataGridView.Columns[1].HeaderText = "Mã nhân viên";
            DataGridView.Columns[2].HeaderText = "Ngày đặt";
            DataGridView.Columns[3].HeaderText = "Mã bàn";
            DataGridView.Columns[4].HeaderText = "Tổng tiền";
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            DataGridView.DataSource = null;
        }

        private void txtTongtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            string mahd;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = DataGridView.CurrentRow.Cells["MaHD"].Value.ToString();
                frmChiTietHoaDon frm = new frmChiTietHoaDon();
                frm.txtMaHDBan.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
        }
    }
}
