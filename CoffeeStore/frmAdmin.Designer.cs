namespace CoffeeStore
{
    partial class frmAdmin
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tpTaiKhoan = new System.Windows.Forms.TabPage();
            this.panel23 = new System.Windows.Forms.Panel();
            this.btnCaiLaiMatKhau = new System.Windows.Forms.Button();
            this.panel24 = new System.Windows.Forms.Panel();
            this.txtLoaiTaiKhoan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.txtTenHienThi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.tpDoanhThu = new System.Windows.Forms.TabPage();
            this.panel22 = new System.Windows.Forms.Panel();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.panel21 = new System.Windows.Forms.Panel();
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.tpTaiKhoan.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tpDoanhThu.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
            this.tcAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 459);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer
            // 
            this.reportViewer.Location = new System.Drawing.Point(3, 3);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(770, 450);
            this.reportViewer.TabIndex = 0;
            // 
            // tpTaiKhoan
            // 
            this.tpTaiKhoan.Controls.Add(this.panel23);
            this.tpTaiKhoan.Controls.Add(this.panel2);
            this.tpTaiKhoan.Controls.Add(this.panel1);
            this.tpTaiKhoan.Location = new System.Drawing.Point(4, 22);
            this.tpTaiKhoan.Name = "tpTaiKhoan";
            this.tpTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tpTaiKhoan.Size = new System.Drawing.Size(776, 459);
            this.tpTaiKhoan.TabIndex = 4;
            this.tpTaiKhoan.Text = "Tài khoản";
            this.tpTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.btnCaiLaiMatKhau);
            this.panel23.Controls.Add(this.panel24);
            this.panel23.Controls.Add(this.panel25);
            this.panel23.Controls.Add(this.panel26);
            this.panel23.Location = new System.Drawing.Point(424, 75);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(349, 378);
            this.panel23.TabIndex = 9;
            // 
            // btnCaiLaiMatKhau
            // 
            this.btnCaiLaiMatKhau.Location = new System.Drawing.Point(243, 219);
            this.btnCaiLaiMatKhau.Name = "btnCaiLaiMatKhau";
            this.btnCaiLaiMatKhau.Size = new System.Drawing.Size(94, 50);
            this.btnCaiLaiMatKhau.TabIndex = 4;
            this.btnCaiLaiMatKhau.Text = "Đổi mật khẩu";
            this.btnCaiLaiMatKhau.UseVisualStyleBackColor = true;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.txtLoaiTaiKhoan);
            this.panel24.Controls.Add(this.label9);
            this.panel24.Location = new System.Drawing.Point(3, 147);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(346, 66);
            this.panel24.TabIndex = 3;
            // 
            // txtLoaiTaiKhoan
            // 
            this.txtLoaiTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiTaiKhoan.Location = new System.Drawing.Point(119, 21);
            this.txtLoaiTaiKhoan.Name = "txtLoaiTaiKhoan";
            this.txtLoaiTaiKhoan.Size = new System.Drawing.Size(215, 26);
            this.txtLoaiTaiKhoan.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(10, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Loại tài khoản";
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.txtTenHienThi);
            this.panel25.Controls.Add(this.label10);
            this.panel25.Location = new System.Drawing.Point(3, 75);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(346, 66);
            this.panel25.TabIndex = 2;
            // 
            // txtTenHienThi
            // 
            this.txtTenHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHienThi.Location = new System.Drawing.Point(119, 21);
            this.txtTenHienThi.Name = "txtTenHienThi";
            this.txtTenHienThi.Size = new System.Drawing.Size(215, 26);
            this.txtTenHienThi.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(10, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên hiển thị";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.txtTenTaiKhoan);
            this.panel26.Controls.Add(this.label11);
            this.panel26.Location = new System.Drawing.Point(3, 3);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(346, 66);
            this.panel26.TabIndex = 1;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(119, 21);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(215, 26);
            this.txtTenTaiKhoan.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(10, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên tài khoản";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(3, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 378);
            this.panel2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(412, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 69);
            this.panel1.TabIndex = 7;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(312, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(97, 63);
            this.button10.TabIndex = 3;
            this.button10.Text = "Xem";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(209, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(97, 63);
            this.button11.TabIndex = 2;
            this.button11.Text = "Sửa";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(106, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(97, 63);
            this.button12.TabIndex = 1;
            this.button12.Text = "Xóa";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(3, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(97, 63);
            this.button13.TabIndex = 0;
            this.button13.Text = "Thêm";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // tpDoanhThu
            // 
            this.tpDoanhThu.Controls.Add(this.panel22);
            this.tpDoanhThu.Controls.Add(this.panel21);
            this.tpDoanhThu.Location = new System.Drawing.Point(4, 22);
            this.tpDoanhThu.Name = "tpDoanhThu";
            this.tpDoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tpDoanhThu.Size = new System.Drawing.Size(776, 459);
            this.tpDoanhThu.TabIndex = 0;
            this.tpDoanhThu.Text = "Doanh thu";
            this.tpDoanhThu.UseVisualStyleBackColor = true;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.btnDoanhThu);
            this.panel22.Controls.Add(this.dtpkToDate);
            this.panel22.Controls.Add(this.btnThongKe);
            this.panel22.Controls.Add(this.dtpkFromDate);
            this.panel22.Location = new System.Drawing.Point(3, 3);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(770, 44);
            this.panel22.TabIndex = 1;
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.Location = new System.Drawing.Point(262, 4);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(110, 40);
            this.btnDoanhThu.TabIndex = 3;
            this.btnDoanhThu.Text = "Doanh thu";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Location = new System.Drawing.Point(558, 12);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(200, 20);
            this.dtpkToDate.TabIndex = 2;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(405, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(110, 40);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Location = new System.Drawing.Point(25, 12);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(200, 20);
            this.dtpkFromDate.TabIndex = 0;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.dataGridViewHoaDon);
            this.panel21.Location = new System.Drawing.Point(3, 50);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(770, 403);
            this.panel21.TabIndex = 1;
            // 
            // dataGridViewHoaDon
            // 
            this.dataGridViewHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDon.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.Size = new System.Drawing.Size(764, 397);
            this.dataGridViewHoaDon.TabIndex = 0;
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpDoanhThu);
            this.tcAdmin.Controls.Add(this.tpTaiKhoan);
            this.tcAdmin.Controls.Add(this.tabPage1);
            this.tcAdmin.Location = new System.Drawing.Point(12, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(784, 485);
            this.tcAdmin.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 506);
            this.Controls.Add(this.tcAdmin);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Quản lý";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.tabPage1.ResumeLayout(false);
            this.tpTaiKhoan.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tpDoanhThu.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            this.tcAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.TabPage tpTaiKhoan;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Button btnCaiLaiMatKhau;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.TextBox txtLoaiTaiKhoan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.TextBox txtTenHienThi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TabPage tpDoanhThu;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.DataGridView dataGridViewHoaDon;
        private System.Windows.Forms.TabControl tcAdmin;
    }
}