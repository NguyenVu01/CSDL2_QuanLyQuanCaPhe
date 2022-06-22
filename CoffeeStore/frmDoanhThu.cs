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
        DataTable myTable = new DataTable();
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            chartDoanhThu.DataSource = myTable;
            chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Doanh số";
            chartDoanhThu.Series["DoanhThu"].XValueMember = "Tháng";
            chartDoanhThu.Series["DoanhThu"].YValueMembers = "DoanhThu";
            chartDoanhThu.Series["DoanhThu"]["PixelPointWidth"] = "15";
            chartDoanhThu.Series["DoanhThu"].IsValueShownAsLabel = true;
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            string sql = "Select MONTH(NgayGiao) as [Tháng], sum(TongTien) as DoanhThu from HOADON group by MONTH(NgayGiao)";
            myTable = DAO.LoadDataToTable(sql);
            chartDoanhThu.DataSource = myTable;
            chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Doanh số";
            chartDoanhThu.Series["DoanhThu"].XValueMember = "Tháng";
            chartDoanhThu.Series["DoanhThu"].YValueMembers = "DoanhThu";
            chartDoanhThu.Series["DoanhThu"]["PixelPointWidth"] = "15";
            chartDoanhThu.Series["DoanhThu"].IsValueShownAsLabel = true;
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            string sql = "Select YEAR(NgayGiao) as [Năm], sum(TongTien) as DoanhThu from HOADON group by YEAR(NgayGiao)";
            myTable = DAO.LoadDataToTable(sql);
            chartDoanhThu.DataSource = myTable;
            chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Năm";
            chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Doanh số";
            chartDoanhThu.Series["DoanhThu"].XValueMember = "Năm";
            chartDoanhThu.Series["DoanhThu"].YValueMembers = "DoanhThu";
            chartDoanhThu.Series["DoanhThu"]["PixelPointWidth"] = "15";
            chartDoanhThu.Series["DoanhThu"].IsValueShownAsLabel = true;
        }

        private void btnQuy_Click(object sender, EventArgs e)
        {
            string sql = "Select DATEPART(QUARTER, NgayGiao) as [Quý], sum(TongTien) as DoanhThu from HOADON group by DATEPART(QUARTER, NgayGiao)";
            myTable = DAO.LoadDataToTable(sql);
            chartDoanhThu.DataSource = myTable;
            chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Quý";
            chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Doanh số";
            chartDoanhThu.Series["DoanhThu"].XValueMember = "Quý";
            chartDoanhThu.Series["DoanhThu"].YValueMembers = "DoanhThu";
            chartDoanhThu.Series["DoanhThu"]["PixelPointWidth"] = "15";
            chartDoanhThu.Series["DoanhThu"].IsValueShownAsLabel = true;
        }
    }
}
