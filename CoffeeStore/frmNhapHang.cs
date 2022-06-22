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
    public partial class frmNhapHang : Form
    {
        DataTable tblNL = new DataTable();
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            txtMaNL.Enabled = false;
            txtTenNL.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonViTinh.Enabled = false;
            btnBoQua.Enabled = true;
            Load_DataGridView();
        }

        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT MaNL, TenNL, SoLuong, DonViTinh FROM NGUYENLIEU";
            tblNL = DAO.LoadDataToTable(sql);
            dataGridView.DataSource = tblNL;
            dataGridView.Columns[0].HeaderText = "Mã nguyên liệu";
            dataGridView.Columns[1].HeaderText = "Tên nguyên liệu";
            dataGridView.Columns[2].HeaderText = "Số lượng";
            dataGridView.Columns[3].HeaderText = "Đơn vị tính";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            Load_DataGridView();
        }
        private void ResetValues()
        {
            txtMaNL.Text = "";
            txtTenNL.Text = "";
            txtSoLuong.Text = "";
            nmrSoLuongNhap.Value = 0;
            txtDonViTinh.Text = "";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Hãy nhập tên nguyên liệu tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT MaNL, TenNL, SoLuong, DonViTinh FROM NGUYENLIEU WHERE 1=1";
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNL.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txtTenNL.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txtDonViTinh.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = true;
            btnSua.Enabled = true;
            txtMaNL.Enabled = false;
            txtTenNL.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonViTinh.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
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
                label8.Focus();
                return;
            }
            if (txtDonViTinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonViTinh.Focus();
                return;
            }
            int Quantity = int.Parse(txtSoLuong.Text) + (int)nmrSoLuongNhap.Value;
            try
            {
                if(Quantity >= 0)
                {
                    sql = "UPDATE NGUYENLIEU SET  SoLuong = " + Quantity + " WHERE MaNL = '" + txtMaNL.Text + "'";
                    DAO.RunSql(sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lẽ bạn đã nhập sai thông tin ở đâu đó :(" + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Load_DataGridView();
            ResetValues();
            btnBoQua.Enabled = true;
        }
    }
}
