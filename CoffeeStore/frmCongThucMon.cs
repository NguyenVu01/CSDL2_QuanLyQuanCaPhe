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
    public partial class frmCongThucMon : Form
    {
        DataTable tblCongThuc = new DataTable();
        public frmCongThucMon()
        {
            InitializeComponent();
        }
        private void frmCongThucMon_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        public void Load_DataGridView()
        {
            string sql;
            sql = "select TenNL, HamLuong, DonVi from nguyenlieu nl, CONGTHUC ct  where nl.MaNL = ct.MaNL and Mamon = '" + frmMon.MonID.ToString() + "'";
            tblCongThuc = DAO.LoadDataToTable(sql);
            dataGridView.DataSource = tblCongThuc;
        }
    }
}
