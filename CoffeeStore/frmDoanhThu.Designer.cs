﻿namespace CoffeeStore
{
    partial class frmDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoanhThu));
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThang = new System.Windows.Forms.Button();
            this.btnNam = new System.Windows.Forms.Button();
            this.btnQuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDoanhThu
            // 
            this.chartDoanhThu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chartDoanhThu.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Doanh thu ";
            legend1.TitleForeColor = System.Drawing.Color.Red;
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(21, 55);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "DoanhThu";
            series1.YValuesPerPoint = 5;
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(724, 467);
            this.chartDoanhThu.TabIndex = 0;
            this.chartDoanhThu.Text = "Doanh thu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(217, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ DOANH THU ";
            // 
            // btnThang
            // 
            this.btnThang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThang.ForeColor = System.Drawing.Color.Navy;
            this.btnThang.Location = new System.Drawing.Point(255, 528);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(80, 40);
            this.btnThang.TabIndex = 2;
            this.btnThang.Text = "Tháng";
            this.btnThang.UseVisualStyleBackColor = true;
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // btnNam
            // 
            this.btnNam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNam.ForeColor = System.Drawing.Color.Navy;
            this.btnNam.Location = new System.Drawing.Point(427, 528);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(80, 40);
            this.btnNam.TabIndex = 3;
            this.btnNam.Text = "Năm";
            this.btnNam.UseVisualStyleBackColor = true;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // btnQuy
            // 
            this.btnQuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuy.ForeColor = System.Drawing.Color.Navy;
            this.btnQuy.Location = new System.Drawing.Point(341, 528);
            this.btnQuy.Name = "btnQuy";
            this.btnQuy.Size = new System.Drawing.Size(80, 40);
            this.btnQuy.TabIndex = 4;
            this.btnQuy.Text = "Quý";
            this.btnQuy.UseVisualStyleBackColor = true;
            this.btnQuy.Click += new System.EventHandler(this.btnQuy_Click);
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(764, 578);
            this.Controls.Add(this.btnQuy);
            this.Controls.Add(this.btnNam);
            this.Controls.Add(this.btnThang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartDoanhThu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu theo tháng";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Button btnQuy;
    }
}