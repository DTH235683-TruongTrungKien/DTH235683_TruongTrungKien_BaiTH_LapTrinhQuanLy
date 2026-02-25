namespace BTTH02.Forms
{
    partial class frmSanPham
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            label4 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            groupBox1 = new GroupBox();
            txtTenSanPham = new TextBox();
            btnDoiAnh = new Button();
            btnThem = new Button();
            cboHangSanXuat = new ComboBox();
            cboLoaiSanPham = new ComboBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            picHinhAnh = new PictureBox();
            btnSua = new Button();
            btnXoa = new Button();
            button1 = new Button();
            label1 = new Label();
            txtMoTa = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai, TenHangSanXuat, TenSanPham, SoLuong, DonGia, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1133, 376);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 98.48723F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.FillWeight = 137.061386F;
            TenLoai.HeaderText = "Phân loại";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.FillWeight = 137.061386F;
            TenHangSanXuat.HeaderText = "Hãng sản xuất";
            TenHangSanXuat.MinimumWidth = 6;
            TenHangSanXuat.Name = "TenHangSanXuat";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.FillWeight = 137.061386F;
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.FillWeight = 137.061386F;
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            DonGia.DefaultCellStyle = dataGridViewCellStyle3;
            DonGia.FillWeight = 137.061386F;
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            HinhAnh.DefaultCellStyle = dataGridViewCellStyle4;
            HinhAnh.FillWeight = 137.061386F;
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(1, 257);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1139, 402);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại sản phẩm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 67);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 20;
            label4.Text = "Đơn giá (*):";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(440, 34);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 16;
            label6.Text = "Số lượng (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 67);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 14;
            label3.Text = "Hãng sản xuất (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 100);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 12;
            label2.Text = "Tên sản phẩm (*):";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(943, 167);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 36);
            btnXuat.TabIndex = 11;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(843, 167);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 36);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(743, 167);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 36);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(643, 167);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 36);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(543, 167);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 36);
            btnHuyBo.TabIndex = 7;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(443, 167);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 36);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1139, 239);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.ImeMode = ImeMode.NoControl;
            txtTenSanPham.Location = new Point(143, 97);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(597, 27);
            txtTenSanPham.TabIndex = 26;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(929, 31);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(94, 29);
            btnDoiAnh.TabIndex = 28;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(143, 167);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 36);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(142, 63);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(218, 28);
            cboHangSanXuat.TabIndex = 27;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(142, 31);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(218, 28);
            cboLoaiSanPham.TabIndex = 26;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(538, 67);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(202, 27);
            numDonGia.TabIndex = 25;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(538, 32);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(202, 27);
            numSoLuong.TabIndex = 24;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(763, 32);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(150, 126);
            picHinhAnh.TabIndex = 23;
            picHinhAnh.TabStop = false;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(243, 167);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 36);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(343, 167);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 36);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
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
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Phân loại (*):";
            // 
            // txtMoTa
            // 
            txtMoTa.ImeMode = ImeMode.NoControl;
            txtMoTa.Location = new Point(143, 142);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(598, 27);
            txtMoTa.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 145);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 24;
            label7.Text = "Mô tả sản phẩm:";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 661);
            Controls.Add(txtMoTa);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSanPham";
            Text = "frmSanPham";
            Load += frmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView;
        private GroupBox groupBox2;
        private TextBox txtMatKhau;
        private Label label4;
        private Label label5;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox txtTenDangNhap;
        private Label label6;
        private TextBox txtDiaChi;
        private Label label3;
        private TextBox txtDienThoai;
        private Label label2;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private TextBox txtPhanLoai;
        private GroupBox groupBox1;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button button1;
        private Label label1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn HinhAnh;
        private PictureBox picHinhAnh;
        private TextBox txtMoTa;
        private Label label7;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private ComboBox cboHangSanXuat;
        private ComboBox cboLoaiSanPham;
        private Button btnDoiAnh;
        private TextBox txtTenSanPham;
    }
}