using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace CoffeeStore
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            DAO.Connect();
            LoadTable();
            LoadCategory();
            LoadComboboxTable(cbxChuyenBan);
        }
        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }
        private void mnuThongTinCaNhan_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan f = new frmThongTinCaNhan();
            f.ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAO.Disconnect();
                Application.Exit();
            }
        }

        private void mnuAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            f.ShowDialog();
        }

        private void mnuTroGiup_Click(object sender, EventArgs e)
        {
            frmTroGiup f = new frmTroGiup();
            f.ShowDialog();
        }

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            f.ShowDialog();
        }

        private void mnuLoaiMon_Click(object sender, EventArgs e)
        {
            frmLoaiMon f = new frmLoaiMon();
            f.ShowDialog();
        }

        private void mnuBan_Click(object sender, EventArgs e)
        {
            frmBan f = new frmBan();
            f.ShowDialog();
        }

        private void mnuMon_Click(object sender, EventArgs e)
        {
            frmMon f = new frmMon();
            f.ShowDialog();
        }

        private void mnuChucNang_ThanhToan_Click(object sender, EventArgs e)
        {
            btnThanhToan_Click(this, new EventArgs());
        }

        private void mnuChucNang_ThemMon_Click(object sender, EventArgs e)
        {
            btnThemMon_Click(this, new EventArgs());
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trong":
                        btn.BackColor = Color.Green;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            decimal TongTien = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                TongTien += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTongTien.Text = TongTien.ToString("c", culture);
        }

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        //Hien thi LOAIMON
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbxMaLoaiMon.DataSource = listCategory;
            cbxMaLoaiMon.DisplayMember  = "Name";
        }

        //Hien thi MON theo MALOAIMON
        void LoadFoodListByCategoryID(string id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbxMon.DataSource = listFood;
            cbxMon.DisplayMember = "Name";
        }

        private void cbxLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = "";

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            string foodID = (cbxMon.SelectedItem as Food).ID;
            int count = (int)nmrSoLuongMon.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                try
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Hãy thử lại! Số lượng món đã không còn! " + ex.Message.ToString(),"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ShowBill(table.ID);
            LoadTable();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmrGiamGia.Value;
            double totalPrice = Convert.ToDouble(txtTongTien.Text.Split(',')[0].Replace(".", ""));
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n=> {1} - ({1} / 100) x {2} = {3}", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, totalPrice);
                    ShowBill(table.ID);
                    LoadTable();

                    // Khởi động chương trình Excel
                    COMExcel.Application exApp = new COMExcel.Application();
                    COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
                    COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
                    COMExcel.Range exRange;
                    string sql;
                    int hang = 0, cot = 0;
                    DataTable tblThongtinHD, tblThongtinMon;
                    exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
                    exSheet = exBook.Worksheets[1];
                    // Định dạng chung
                    exRange = exSheet.Cells[1, 1];
                    exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
                    exRange.Range["A1:B3"].Font.Size = 10;
                    exRange.Range["A1:B3"].Font.Bold = true;
                    exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
                    exRange.Range["A1:A1"].ColumnWidth = 7;
                    exRange.Range["B1:B1"].ColumnWidth = 15;
                    exRange.Range["A1:B1"].MergeCells = true;
                    exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                    exRange.Range["A1:B1"].Value = "Quán cà phê J02 - Có 102";
                    exRange.Range["A2:B2"].MergeCells = true;
                    exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                    exRange.Range["A2:B2"].Value = "Chùa Bộc - Hà Nội";
                    exRange.Range["A3:B3"].MergeCells = true;
                    exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                    exRange.Range["A3:B3"].Value = "Điện thoại: (+84)66771508";
                    exRange.Range["C2:E2"].Font.Size = 16;
                    exRange.Range["C2:E2"].Font.Bold = true;
                    exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
                    exRange.Range["C2:E2"].MergeCells = true;
                    exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                    exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN HÀNG";
                    // Biểu diễn thông tin chung của hóa đơn bán
                    sql = "SELECT a.MaHD, a.NgayDat, a.Maban, b.TenNV, GiamGia, TongTien*(100-GiamGia) as ThanhTien FROM HOADON AS a, Nhanvien AS b WHERE a.MaHD =" + idBill + "AND a.MaNV = b.MaNV";
                    tblThongtinHD = DAO.LoadDataToTable(sql);
                    exRange.Range["B5:C9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                    exRange.Range["B5:C9"].Font.Size = 12;
                    exRange.Range["B5:B5"].Value = "Mã hóa đơn:";
                    exRange.Range["C5:E5"].MergeCells = true;
                    exRange.Range["C5:E5"].Value = tblThongtinHD.Rows[0][0].ToString();
                    exRange.Range["B6:B6"].Value = "Ngày đặt:";
                    exRange.Range["C6:E6"].MergeCells = true;
                    exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][1].ToString();
                    exRange.Range["B7:B7"].Value = "Bàn:";
                    exRange.Range["C7:E7"].MergeCells = true;
                    exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][2].ToString();
                    exRange.Range["B8:B8"].Value = "Nhân viên:";
                    exRange.Range["C8:E8"].MergeCells = true;
                    exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][3].ToString();
                    exRange.Range["B9:B9"].Value = "Giảm giá:";
                    exRange.Range["C9:E9"].MergeCells = true;
                    exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][4].ToString();
                    //Lấy thông tin các mặt hàng
                    sql = "select TenMon, SoLuong, Gia, (SoLuong*Gia) as ThanhTien from chitiethd ct, mon m where ct.MaMon = m.MaMon and MaHD = " + idBill;
                    tblThongtinMon = DAO.LoadDataToTable(sql);
                    //Tạo dòng tiêu đề bảng
                    exRange.Range["A11:F11"].Font.Bold = true;
                    exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                    exRange.Range["C11:F11"].ColumnWidth = 12;
                    exRange.Range["A11:A11"].Value = "STT";
                    exRange.Range["B11:B11"].Value = "Tên món";
                    exRange.Range["C11:C11"].Value = "Số lượng";
                    exRange.Range["D11:D11"].Value = "Giá";
                    exRange.Range["E11:E11"].Value = "Thành tiền";

                    for (hang = 0; hang < tblThongtinMon.Rows.Count; hang++)
                    {
                        //Điền số thứ tự vào cột 1 từ dòng 12: 1,2,3,4 món
                        exSheet.Cells[1][hang + 12] = hang + 1;
                        for (cot = 0; cot < tblThongtinMon.Columns.Count; cot++)
                        //Điền thông tin hàng từ cột thứ 2, dòng 12: Tên món, số lượng, giá, thành tiền
                        {
                            exSheet.Cells[cot + 2][hang + 12] = tblThongtinMon.Rows[hang][cot].ToString();
                            if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinMon.Rows[hang][cot].ToString();
                        }
                    }
                    exRange = exSheet.Cells[cot][hang + 14];
                    exRange.Font.Bold = true;
                    exRange.Value2 = "Tổng tiền:";
                    exRange = exSheet.Cells[cot + 1][hang + 14];
                    exRange.Font.Bold = true;
                    exRange.Value2 = tblThongtinHD.Rows[0][5].ToString();
                    exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
                    exRange.Range["A1:F1"].MergeCells = true;
                    exRange.Range["A1:F1"].Font.Bold = true;
                    exRange.Range["A1:F1"].Font.Italic = true;
                    exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
                    exRange.Range["A1:F1"].Value = "Bằng chữ: " + DAO.ChuyenSoSangChu(tblThongtinHD.Rows[0][5].ToString());
                    exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
                    exRange.Range["A1:C1"].MergeCells = true;
                    exRange.Range["A1:C1"].Font.Italic = true;
                    exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                    DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
                    exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
                    exRange.Range["A2:C2"].MergeCells = true;
                    exRange.Range["A2:C2"].Font.Italic = true;
                    exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                    exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
                    exRange.Range["A6:C6"].MergeCells = true;
                    exRange.Range["A6:C6"].Font.Italic = true;
                    exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                    exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][3];
                    exSheet.Name = "Hóa đơn nhập";
                    exApp.Visible = true;
                }
            }
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).ID;

            int id2 = (cbxChuyenBan.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Name, (cbxChuyenBan.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);
                LoadTable();
            }
        }

        private void mnuNguyenLieu_Click(object sender, EventArgs e)
        {
            frmNguyenLieu f = new frmNguyenLieu();
            f.ShowDialog();
        }

        private void mnuNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang f = new frmNhapHang();
            f.ShowDialog();
        }
    }
}
