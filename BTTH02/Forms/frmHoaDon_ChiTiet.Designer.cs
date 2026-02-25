namespace BTTH02.Forms
{
    partial class frmHoaDon_ChiTiet
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            cboNhanVien = new ComboBox();
            btnInHoaDon = new Button();
            btnLuuHoaDon = new Button();
            groupBox1 = new GroupBox();
            txtGhiChuHoaDon = new TextBox();
            cboKhachHang = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            button1 = new Button();
            label1 = new Label();
            btnThoat = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox3 = new GroupBox();
            dataGridView = new DataGridView();
            SanPhamID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            label4 = new Label();
            btnXacNhanBan = new Button();
            cboSanPham = new ComboBox();
            numDonGiaBan = new NumericUpDown();
            numSoLuongBan = new NumericUpDown();
            label2 = new Label();
            btnXoa = new Button();
            button4 = new Button();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            SuspendLayout();
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(142, 31);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(218, 28);
            cboNhanVien.TabIndex = 26;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(408, 425);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(121, 36);
            btnInHoaDon.TabIndex = 11;
            btnInHoaDon.Text = "In hóa đơn...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.BackColor = SystemColors.ButtonHighlight;
            btnLuuHoaDon.ForeColor = SystemColors.HotTrack;
            btnLuuHoaDon.Location = new Point(286, 425);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(116, 36);
            btnLuuHoaDon.TabIndex = 6;
            btnLuuHoaDon.Text = "Lưu hóa đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = false;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGhiChuHoaDon);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(937, 101);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Location = new Point(142, 64);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(614, 27);
            txtGhiChuHoaDon.TabIndex = 28;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(538, 31);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(218, 28);
            cboKhachHang.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(423, 34);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 16;
            label6.Text = "Khách hàng (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 67);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 14;
            label3.Text = "Ghi chú hóa đơn:";
            // 
            // button1
            // 
            button1.Location = new Point(77, 96);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 34);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên lập (*):";
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(535, 425);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 36);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(btnThoat);
            groupBox3.Controls.Add(btnInHoaDon);
            groupBox3.Controls.Add(btnLuuHoaDon);
            groupBox3.Controls.Add(btnXacNhanBan);
            groupBox3.Controls.Add(cboSanPham);
            groupBox3.Controls.Add(numDonGiaBan);
            groupBox3.Controls.Add(numSoLuongBan);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(6, 110);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(937, 479);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin chi tiết hóa đơn";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeight = 29;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SanPhamID, TenSanPham, DonGiaBan, SoLuongBan, ThanhTien });
            dataGridView.Location = new Point(3, 110);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(931, 299);
            dataGridView.TabIndex = 0;
            // 
            // SanPhamID
            // 
            SanPhamID.DataPropertyName = "SanPhamID";
            SanPhamID.FillWeight = 66.63807F;
            SanPhamID.HeaderText = "ID";
            SanPhamID.MinimumWidth = 6;
            SanPhamID.Name = "SanPhamID";
            SanPhamID.Width = 125;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.FillWeight = 181.769135F;
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.Width = 200;
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle9;
            DonGiaBan.FillWeight = 160.156845F;
            DonGiaBan.HeaderText = "Đơn giá bán";
            DonGiaBan.MinimumWidth = 6;
            DonGiaBan.Name = "DonGiaBan";
            DonGiaBan.Width = 200;
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            SoLuongBan.FillWeight = 134.41481F;
            SoLuongBan.HeaderText = "Số lượng bán";
            SoLuongBan.MinimumWidth = 6;
            SoLuongBan.Name = "SoLuongBan";
            SoLuongBan.Width = 200;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.ForeColor = Color.Blue;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle10;
            ThanhTien.FillWeight = 103.753937F;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.Width = 200;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(455, 34);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 27;
            label4.Text = "Số lượng bán (*):";
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Location = new Point(624, 54);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(129, 36);
            btnXacNhanBan.TabIndex = 3;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = true;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(13, 62);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(218, 28);
            cboSanPham.TabIndex = 26;
            cboSanPham.SelectionChangeCommitted += cboSanPham_SelectionChangeCommitted;
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(272, 63);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(146, 27);
            numDonGiaBan.TabIndex = 25;
            numDonGiaBan.ThousandsSeparator = true;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(455, 62);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(143, 27);
            numSoLuongBan.TabIndex = 24;
            numSoLuongBan.ThousandsSeparator = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 34);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 20;
            label2.Text = "Đơn giá bán (*):";
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(759, 54);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 36);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // button4
            // 
            button4.Location = new Point(77, 96);
            button4.Name = "button4";
            button4.Size = new Size(8, 8);
            button4.TabIndex = 0;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 34);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 0;
            label8.Text = "Sản phẩm (*):";
            // 
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 591);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "frmHoaDon_ChiTiet";
            Text = "frmHoaDon_ChiTiet";
            Load += frmHoaDon_ChiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTenSanPham;
        private Button btnDoiAnh;
        private ComboBox cboHangSanXuat;
        private ComboBox cboNhanVien;
        private Button btnInHoaDon;
        private Button btnNhap;
        private NumericUpDown numDonGia;
        private Button btnTimKiem;
        private PictureBox picHinhAnh;
        private Button btnSua;
        private Button btnLuuHoaDon;
        private GroupBox groupBox1;
        private Label label3;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button button1;
        private Label label1;
        private TextBox txtMoTa;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private GroupBox groupBox3;
        private Button btnXacNhanBan;
        private ComboBox cboSanPham;
        private NumericUpDown numDonGiaBan;
        private NumericUpDown numSoLuongBan;
        private Label label2;
        private Button btnXoa;
        private Button button4;
        private Label label8;
        private Label label6;
        private ComboBox cboKhachHang;
        private TextBox txtGhiChuHoaDon;
        private Label label4;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn SanPhamID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}