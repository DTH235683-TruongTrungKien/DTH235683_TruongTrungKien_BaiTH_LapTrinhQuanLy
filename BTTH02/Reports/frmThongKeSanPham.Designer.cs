using System;
using System.Drawing;
using System.Windows.Forms;
namespace BTTH02.Reports
{
    partial class frmThongKeSanPham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLocKetQua = new System.Windows.Forms.Button();
            this.cboLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboHangSanXuat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLocKetQua);
            this.panel1.Controls.Add(this.cboLoaiSanPham);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboHangSanXuat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 105);
            this.panel1.TabIndex = 0;
            // 
            // btnLocKetQua
            // 
            this.btnLocKetQua.Location = new System.Drawing.Point(664, 43);
            this.btnLocKetQua.Name = "btnLocKetQua";
            this.btnLocKetQua.Size = new System.Drawing.Size(114, 29);
            this.btnLocKetQua.TabIndex = 4;
            this.btnLocKetQua.Text = "Lọc kết quả";
            this.btnLocKetQua.UseVisualStyleBackColor = true;
            this.btnLocKetQua.Click += new System.EventHandler(this.btnLocKetQua_Click);
            // 
            // cboLoaiSanPham
            // 
            this.cboLoaiSanPham.FormattingEnabled = true;
            this.cboLoaiSanPham.Location = new System.Drawing.Point(507, 44);
            this.cboLoaiSanPham.Name = "cboLoaiSanPham";
            this.cboLoaiSanPham.Size = new System.Drawing.Size(151, 28);
            this.cboLoaiSanPham.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại sản phẩm";
            // 
            // cboHangSanXuat
            // 
            this.cboHangSanXuat.FormattingEnabled = true;
            this.cboHangSanXuat.Location = new System.Drawing.Point(220, 44);
            this.cboHangSanXuat.Name = "cboHangSanXuat";
            this.cboHangSanXuat.Size = new System.Drawing.Size(151, 28);
            this.cboHangSanXuat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hãng sản xuất:";
            // 
            // frmThongKeSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmThongKeSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê sản phẩm";
            this.Load += new System.EventHandler(this.frmThongKeSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Panel panel1;
        private ComboBox cboHangSanXuat;
        private Label label1;
        private Button btnLocKetQua;
        private ComboBox cboLoaiSanPham;
        private Label label2;
    }
}