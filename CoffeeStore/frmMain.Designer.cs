namespace CoffeeStore
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiMon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNguyenLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTinCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang_ThanhToan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang_ThemMon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrGiamGia = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbxChuyenBan = new System.Windows.Forms.ComboBox();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.nmrSoLuongMon = new System.Windows.Forms.NumericUpDown();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.cbxMon = new System.Windows.Forms.ComboBox();
            this.cbxMaLoaiMon = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiamGia)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuongMon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.mnuThongTinTaiKhoan,
            this.mnuTroGiup,
            this.mnuChucNang,
            this.mnuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin,
            this.mnuBan,
            this.mnuNhanVien,
            this.mnuNhaCungCap,
            this.mnuLoaiMon,
            this.mnuNguyenLieu,
            this.mnuMon,
            this.mnuNhapHang});
            this.mnuDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("mnuDanhMuc.Image")));
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(91, 20);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(249, 22);
            this.mnuAdmin.Text = "Admin";
            this.mnuAdmin.Click += new System.EventHandler(this.mnuAdmin_Click);
            // 
            // mnuBan
            // 
            this.mnuBan.Name = "mnuBan";
            this.mnuBan.Size = new System.Drawing.Size(249, 22);
            this.mnuBan.Text = "Quản lý bàn (Admin)";
            this.mnuBan.Click += new System.EventHandler(this.mnuBan_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(249, 22);
            this.mnuNhanVien.Text = "Thông tin nhân viên (Admin)";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuNhaCungCap
            // 
            this.mnuNhaCungCap.Name = "mnuNhaCungCap";
            this.mnuNhaCungCap.Size = new System.Drawing.Size(249, 22);
            this.mnuNhaCungCap.Text = "Thông tin nhà cung cấp (Admin)";
            this.mnuNhaCungCap.Click += new System.EventHandler(this.mnuNhaCungCap_Click);
            // 
            // mnuLoaiMon
            // 
            this.mnuLoaiMon.Name = "mnuLoaiMon";
            this.mnuLoaiMon.Size = new System.Drawing.Size(249, 22);
            this.mnuLoaiMon.Text = "Quản lý loại món (Admin)";
            this.mnuLoaiMon.Click += new System.EventHandler(this.mnuLoaiMon_Click);
            // 
            // mnuNguyenLieu
            // 
            this.mnuNguyenLieu.Name = "mnuNguyenLieu";
            this.mnuNguyenLieu.Size = new System.Drawing.Size(249, 22);
            this.mnuNguyenLieu.Text = "Quán lý nguyên liệu (Admin) ";
            this.mnuNguyenLieu.Click += new System.EventHandler(this.mnuNguyenLieu_Click);
            // 
            // mnuMon
            // 
            this.mnuMon.Name = "mnuMon";
            this.mnuMon.Size = new System.Drawing.Size(249, 22);
            this.mnuMon.Text = "Quản lý món/đồ uống (Admin)";
            this.mnuMon.Click += new System.EventHandler(this.mnuMon_Click);
            // 
            // mnuNhapHang
            // 
            this.mnuNhapHang.Name = "mnuNhapHang";
            this.mnuNhapHang.Size = new System.Drawing.Size(249, 22);
            this.mnuNhapHang.Text = "Nhập nguyên liệu (NV)";
            this.mnuNhapHang.Click += new System.EventHandler(this.mnuNhapHang_Click);
            // 
            // mnuThongTinTaiKhoan
            // 
            this.mnuThongTinTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongTinCaNhan,
            this.mnuDangXuat});
            this.mnuThongTinTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuThongTinTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("mnuThongTinTaiKhoan.Image")));
            this.mnuThongTinTaiKhoan.Name = "mnuThongTinTaiKhoan";
            this.mnuThongTinTaiKhoan.Size = new System.Drawing.Size(142, 20);
            this.mnuThongTinTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // mnuThongTinCaNhan
            // 
            this.mnuThongTinCaNhan.Name = "mnuThongTinCaNhan";
            this.mnuThongTinCaNhan.Size = new System.Drawing.Size(172, 22);
            this.mnuThongTinCaNhan.Text = "Thông tin cá nhân";
            this.mnuThongTinCaNhan.Click += new System.EventHandler(this.mnuThongTinCaNhan_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(172, 22);
            this.mnuDangXuat.Text = "Đăng xuất";
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTroGiup.Image = ((System.Drawing.Image)(resources.GetObject("mnuTroGiup.Image")));
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(81, 20);
            this.mnuTroGiup.Text = "Trợ giúp";
            this.mnuTroGiup.Click += new System.EventHandler(this.mnuTroGiup_Click);
            // 
            // mnuChucNang
            // 
            this.mnuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucNang_ThanhToan,
            this.mnuChucNang_ThemMon});
            this.mnuChucNang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuChucNang.Image = ((System.Drawing.Image)(resources.GetObject("mnuChucNang.Image")));
            this.mnuChucNang.Name = "mnuChucNang";
            this.mnuChucNang.Size = new System.Drawing.Size(151, 20);
            this.mnuChucNang.Text = "Chức năng (Phím tắt)";
            // 
            // mnuChucNang_ThanhToan
            // 
            this.mnuChucNang_ThanhToan.Name = "mnuChucNang_ThanhToan";
            this.mnuChucNang_ThanhToan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mnuChucNang_ThanhToan.Size = new System.Drawing.Size(182, 22);
            this.mnuChucNang_ThanhToan.Text = "Thanh toán ";
            this.mnuChucNang_ThanhToan.Click += new System.EventHandler(this.mnuChucNang_ThanhToan_Click);
            // 
            // mnuChucNang_ThemMon
            // 
            this.mnuChucNang_ThemMon.AutoToolTip = true;
            this.mnuChucNang_ThemMon.Name = "mnuChucNang_ThemMon";
            this.mnuChucNang_ThemMon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuChucNang_ThemMon.Size = new System.Drawing.Size(182, 22);
            this.mnuChucNang_ThemMon.Text = "Thêm món";
            this.mnuChucNang_ThemMon.Click += new System.EventHandler(this.mnuChucNang_ThemMon_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuThoat.Image = ((System.Drawing.Image)(resources.GetObject("mnuThoat.Image")));
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(67, 20);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nmrGiamGia);
            this.panel2.Location = new System.Drawing.Point(471, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 71);
            this.panel2.TabIndex = 2;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Navy;
            this.btnThanhToan.Location = new System.Drawing.Point(407, 7);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(101, 57);
            this.btnThanhToan.TabIndex = 9;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(226, 22);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(175, 26);
            this.txtTongTien.TabIndex = 7;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giảm giá (%)";
            // 
            // nmrGiamGia
            // 
            this.nmrGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrGiamGia.Location = new System.Drawing.Point(105, 25);
            this.nmrGiamGia.Name = "nmrGiamGia";
            this.nmrGiamGia.Size = new System.Drawing.Size(83, 22);
            this.nmrGiamGia.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvBill);
            this.panel3.Location = new System.Drawing.Point(471, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 346);
            this.panel3.TabIndex = 3;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, 3);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(527, 340);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 249;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 120;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbxChuyenBan);
            this.panel4.Controls.Add(this.btnChuyenBan);
            this.panel4.Controls.Add(this.nmrSoLuongMon);
            this.panel4.Controls.Add(this.btnThemMon);
            this.panel4.Controls.Add(this.cbxMon);
            this.panel4.Controls.Add(this.cbxMaLoaiMon);
            this.panel4.Location = new System.Drawing.Point(471, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(533, 112);
            this.panel4.TabIndex = 4;
            // 
            // cbxChuyenBan
            // 
            this.cbxChuyenBan.FormattingEnabled = true;
            this.cbxChuyenBan.Location = new System.Drawing.Point(393, 65);
            this.cbxChuyenBan.Name = "cbxChuyenBan";
            this.cbxChuyenBan.Size = new System.Drawing.Size(115, 21);
            this.cbxChuyenBan.TabIndex = 4;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.ForeColor = System.Drawing.Color.Navy;
            this.btnChuyenBan.Location = new System.Drawing.Point(393, 25);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(115, 33);
            this.btnChuyenBan.TabIndex = 5;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // nmrSoLuongMon
            // 
            this.nmrSoLuongMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrSoLuongMon.ForeColor = System.Drawing.Color.Navy;
            this.nmrSoLuongMon.Location = new System.Drawing.Point(313, 43);
            this.nmrSoLuongMon.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmrSoLuongMon.Name = "nmrSoLuongMon";
            this.nmrSoLuongMon.Size = new System.Drawing.Size(53, 22);
            this.nmrSoLuongMon.TabIndex = 3;
            this.nmrSoLuongMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmrSoLuongMon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemMon
            // 
            this.btnThemMon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.ForeColor = System.Drawing.Color.Navy;
            this.btnThemMon.Location = new System.Drawing.Point(206, 25);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(101, 57);
            this.btnThemMon.TabIndex = 2;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // cbxMon
            // 
            this.cbxMon.FormattingEnabled = true;
            this.cbxMon.Location = new System.Drawing.Point(15, 61);
            this.cbxMon.Name = "cbxMon";
            this.cbxMon.Size = new System.Drawing.Size(185, 21);
            this.cbxMon.TabIndex = 1;
            // 
            // cbxMaLoaiMon
            // 
            this.cbxMaLoaiMon.FormattingEnabled = true;
            this.cbxMaLoaiMon.Location = new System.Drawing.Point(15, 25);
            this.cbxMaLoaiMon.Name = "cbxMaLoaiMon";
            this.cbxMaLoaiMon.Size = new System.Drawing.Size(185, 21);
            this.cbxMaLoaiMon.TabIndex = 0;
            this.cbxMaLoaiMon.SelectedIndexChanged += new System.EventHandler(this.cbxLoaiMon_SelectedIndexChanged);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(12, 27);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(453, 541);
            this.flpTable.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 574);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán cà phê";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiamGia)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuongMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinCaNhan;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuBan;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiMon;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuNguyenLieu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbxChuyenBan;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.NumericUpDown nmrSoLuongMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.ComboBox cbxMon;
        private System.Windows.Forms.ComboBox cbxMaLoaiMon;
        private System.Windows.Forms.NumericUpDown nmrGiamGia;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem mnuMon;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang_ThanhToan;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang_ThemMon;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapHang;
    }
}