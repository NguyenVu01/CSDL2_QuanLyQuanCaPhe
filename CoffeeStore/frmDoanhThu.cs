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
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            string sql = "Select MONTH(NgayGiao) as [Tháng], sum(TongTien) as DoanhThu from HOADON group by MONTH(NgayGiao)";
            DataTable myTable = new DataTable();
            myTable = DAO.LoadDataToTable(sql);
            chartDoanhThu.DataSource = myTable;
            chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Doanh số";
            chartDoanhThu.Series["DoanhThu"].XValueMember = "Tháng";
            chartDoanhThu.Series["DoanhThu"].YValueMembers = "DoanhThu";
            chartDoanhThu.Series["DoanhThu"]["PixelPointWidth"] = "15";
            chartDoanhThu.Series["DoanhThu"].IsValueShownAsLabel = true;
        }
    }
}
