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
    public partial class frmNguyenLieu : Form
    {
        DataTable tblNL = new DataTable();
        public frmNguyenLieu()
        {
            InitializeComponent();
        }

        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {
            txtMaNL.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            string sql = "SELECT DISTINCT DonViTinh FROM NGUYENLIEU";
            DAO.FillCombo(sql, cbxDonViTinh, "DonViTinh", "DonViTinh");
            string sql1 = "SELECT MaNCC FROM NHACUNGCAP";
            DAO.FillCombo(sql1, cbxMaNCC, "MaNCC", "MaNCC");
            Load_DataGridView();
        }
        private void ResetValues()
        {
            txtMaNL.Text = "";
            txtTenNL.Text = "";
            txtSoLuong.Text = "";
            cbxDonViTinh.Text = "";
            cbxMaNCC.Text = "";
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT * FROM NGUYENLIEU";
            tblNL = DAO.LoadDataToTable(sql);
            dataGridView.DataSource = tblNL;
            dataGridView.Columns[0].HeaderText = "Mã nguyên liệu";
            dataGridView.Columns[1].HeaderText = "Tên nguyên liệu";
            dataGridView.Columns[2].HeaderText = "Số lượng";
            dataGridView.Columns[3].HeaderText = "Đơn vị tính";
            dataGridView.Columns[4].HeaderText = "Mã nhà cung cấp";
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNL.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txtTenNL.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            cbxDonViTinh.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            cbxMaNCC.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMaNL.Enabled = true;
            ResetValues();
            txtMaNL.Focus();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaNL.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNL.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nguyên liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNL.Focus();
                return;
            }
            if (txtSoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }
            if (cbxDonViTinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxDonViTinh.Focus();
                return;
            }
            if (cbxMaNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxMaNCC.Focus();
                return;
            }
            try
            {
                sql = "UPDATE NGUYENLIEU SET  TenNL = N'" + txtTenNL.Text.Trim().ToString() +
                     "', SoLuong = " + txtSoLuong.Text +
                     "', DonViTinh = N'" + cbxDonViTinh.Text.ToString() +
                     "', MaNCC = N'" + cbxMaNCC.Text.ToString() +
                     "' WHERE MaNL = '" + txtMaNL.Text + "'";
                DAO.RunSql(sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lẽ bạn đã nhập sai thông tin ở đâu đó :(" + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Load_DataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaNL.Text.Trim().Length ==  0)
            {
                MessageBox.Show("Bạn chưa nhập mã nguyên liệu, mã nguyên liệu có định dạng NL000", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nguyên liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNL.Focus();
                return;
            }
            if (txtSoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }
            if (cbxDonViTinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxDonViTinh.Focus();
                return;
            }
            if (cbxMaNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxMaNCC.Focus();
                return;
            }
            sql = "SELECT MaNL FROM NGUYENLIEU WHERE MaNL = '" + txtMaNL.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Mã nguyên liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNL.Focus();
                txtMaNL.Text = "";
                return;
            }
            try
            {
                sql = "INSERT INTO NGUYENLIEU(MaNL,TenNL, SoLuong, DonViTinh, MaNCC) " +
                    "VALUES('" + txtMaNL.Text + "',N'" + txtTenNL.Text + "',N'" + txtSoLuong.Text + "', '" + cbxDonViTinh.Text + "', '" + cbxMaNCC.Text + "')";
                DAO.RunSql(sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Chắc là đã có lỗi gì rồi" + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNL.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNL.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "DELETE NGUYENLIEU WHERE MaNL = N'" + txtMaNL.Text + "'";
                    DAO.RunSqlDel(sql);
                    Load_DataGridView();
                    ResetValues();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi gì đó thì phải!" + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Hãy nhập tên nguyên liệu tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM NGUYENLIEU WHERE 1=1";
            if (txtTimKiem.Text != "")
                sql = sql + " AND TenNL Like N'%" + txtTimKiem.Text + "%'";
            tblNL = DAO.LoadDataToTable(sql);
            if (tblNL.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblNL.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dataGridView.DataSource = tblNL;
            ResetValues();
        }
    }
}
