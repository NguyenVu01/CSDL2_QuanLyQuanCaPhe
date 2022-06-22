using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CoffeeStore
{
    public partial class frmMenu : Form
    {
        public static string MonID = "";
        DataTable tblMon = new DataTable();
        public frmMenu()
        {
            InitializeComponent();
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            txtMaMon.Enabled = false;
            txtTenMon.Enabled = false;
            txtGia.Enabled = false;
            Load_DataGridView();
            string sql = "SELECT MaLoaiMon FROM LOAIMON";
            DAO.FillCombo(sql, cbxMaLoaiMon, "MaLoaiMon", "MaLoaiMon");
            ResetValues();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT * FROM Mon";
            tblMon = DAO.LoadDataToTable(sql);
            dataGridView.DataSource = tblMon;
            dataGridView.Columns[0].Width = 70;
            dataGridView.Columns[1].Width = 150;
            dataGridView.Columns[2].Width = 80;
            dataGridView.Columns[3].Width = 100;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Hãy nhập tên món tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM MON WHERE 1=1";
            if (txtTimKiem.Text != "")
                sql = sql + " AND TenMon Like N'%" + txtTimKiem.Text + "%'";
            tblMon = DAO.LoadDataToTable(sql);
            if (tblMon.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblMon.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dataGridView.DataSource = tblMon;
            ResetValues();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            Load_DataGridView();
        }
        private void ResetValues()
        {
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            txtGia.Text = "";
            cbxMaLoaiMon.Text = "";
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMon.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txtTenMon.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txtGia.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            cbxMaLoaiMon.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
