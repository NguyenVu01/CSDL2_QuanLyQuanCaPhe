using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CoffeeStore
{
    public partial class frmBan : Form
    {
        DataTable tblBan = new DataTable();
        public frmBan()
        {
            InitializeComponent();
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            txtMaBan.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            Load_DataGridView();
            string sql = "SELECT DISTINCT TrangThai FROM Ban where trangthai = 'Trong'";
            DAO.FillCombo(sql, cbxTrangThai, "TrangThai", "TrangThai");
            ResetValues();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT * FROM BAN";
            tblBan = DAO.LoadDataToTable(sql);
            dataGridView.DataSource = tblBan;
            dataGridView.Columns[0].Width = 70;
            dataGridView.Columns[1].Width = 70;
            dataGridView.Columns[2].Width = 100;
        }
        private void ResetValues()
        {
            txtMaBan.Text = "";
            txtTenBan.Text = "";
            cbxTrangThai.Text = "";
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
            txtMaBan.Enabled = true;
            ResetValues();
            txtMaBan.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaBan.Focus();
                return;
            }
            if (txtTenBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenBan.Focus();
                return;
            }
            sql = "SELECT MaBan FROM Ban WHERE MaBan = N'" + txtMaBan.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Mã bàn này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaBan.Focus();
                txtMaBan.Text = "";
                return;
            }
            sql = "SET IDENTITY_INSERT BAN ON";
            DAO.RunSql(sql);
            sql = "INSERT INTO Ban(MaBan,TenBan, TrangThai) VALUES(N'" + txtMaBan.Text + "',N'" + txtTenBan.Text + "',N'" + cbxTrangThai.Text  + "')";
            DAO.RunSql(sql);
            sql = "SET IDENTITY_INSERT BAN OFF";
            DAO.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaBan.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaBan.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblBan.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaBan.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenBan.Focus();
                return;
            }
            sql = "UPDATE BAN SET TenBan = N'" + txtTenBan.Text.ToString() + "' , TrangThai = '" + cbxTrangThai.Text.ToString()
                 + "' WHERE MaBan = N'" + txtMaBan.Text + "'";
            DAO.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblBan.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaBan.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE BAN WHERE MaBan = N'" + txtMaBan.Text + "'";
                DAO.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string sql;
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Hãy nhập tên bàn tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM BAN WHERE 1=1";
            if (txtTimKiem.Text != "")
                sql = sql + " AND TenBan Like N'%" + txtTimKiem.Text + "%'";
            tblBan = DAO.LoadDataToTable(sql);
            if (tblBan.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblBan.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dataGridView.DataSource = tblBan;
            ResetValues();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaBan.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txtTenBan.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            cbxTrangThai.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
