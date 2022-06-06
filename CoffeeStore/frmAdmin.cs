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
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

            this.reportViewer.RefreshReport();
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
    }
}
