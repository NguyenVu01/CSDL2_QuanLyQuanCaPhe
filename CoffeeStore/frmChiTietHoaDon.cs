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
    public partial class frmChiTietHoaDon : Form
    {
        DataTable tblCTHD = new DataTable();
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }
        public void Load_DataGridView()
        {
            string sql;
            sql = "select ct.MaMon, TenMon, SoLuong, Gia, SoLuong*Gia as ThanhTien from CHITIETHD ct, MON m  where ct.MaMon = m.MaMon and MaHD = '" + txtMaHDBan.Text + "'";
            tblCTHD = DAO.LoadDataToTable(sql);
            dataGridView.DataSource = tblCTHD;
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }
    }
}
