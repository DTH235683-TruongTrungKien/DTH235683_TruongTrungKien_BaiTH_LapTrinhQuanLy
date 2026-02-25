namespace BTTH02.Forms
{
    partial class frmHoaDon
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            HoVaTenKhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTienHoaDon = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnXuat = new Button();
            btnInHoaDon = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLapHoaDon = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTenNhanVien, HoVaTenKhachHang, NgayLap, TongTienHoaDon, XemChiTiet });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1133, 376);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 32.08556F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // HoVaTenNhanVien
            // 
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.FillWeight = 113.582886F;
            HoVaTenNhanVien.HeaderText = "Nhân Viên";
            HoVaTenNhanVien.MinimumWidth = 6;
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            // 
            // HoVaTenKhachHang
            // 
            HoVaTenKhachHang.DataPropertyName = "HoVaTenKhachHang";
            HoVaTenKhachHang.FillWeight = 113.582886F;
            HoVaTenKhachHang.HeaderText = "Khách hàng";
            HoVaTenKhachHang.MinimumWidth = 6;
            HoVaTenKhachHang.Name = "HoVaTenKhachHang";
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            NgayLap.DefaultCellStyle = dataGridViewCellStyle4;
            NgayLap.FillWeight = 113.582886F;
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            // 
            // TongTienHoaDon
            // 
            TongTienHoaDon.DataPropertyName = "TongTienHoaDon";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.ForeColor = Color.Blue;
            TongTienHoaDon.DefaultCellStyle = dataGridViewCellStyle5;
            TongTienHoaDon.FillWeight = 113.582886F;
            TongTienHoaDon.HeaderText = "Tổng tiền";
            TongTienHoaDon.MinimumWidth = 6;
            TongTienHoaDon.Name = "TongTienHoaDon";
            // 
            // XemChiTiet
            // 
            XemChiTiet.DataPropertyName = "XemChiTiet";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopCenter;
            XemChiTiet.DefaultCellStyle = dataGridViewCellStyle6;
            XemChiTiet.FillWeight = 113.582886F;
            XemChiTiet.HeaderText = "Chi tiết";
            XemChiTiet.MinimumWidth = 6;
            XemChiTiet.Name = "XemChiTiet";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(11, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1139, 402);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hóa đơn";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(856, 433);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(112, 36);
            btnXuat.TabIndex = 11;
            btnXuat.Text = "Xuất Excel...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(340, 433);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(110, 36);
            btnInHoaDon.TabIndex = 10;
            btnInHoaDon.Text = "In hóa đơn...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(756, 433);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 36);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(656, 433);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 36);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(556, 433);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 36);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(456, 433);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 36);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.Location = new Point(185, 433);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(149, 36);
            btnLapHoaDon.TabIndex = 3;
            btnLapHoaDon.Text = "Lập hóa đơn mới...";
            btnLapHoaDon.UseVisualStyleBackColor = true;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 485);
            Controls.Add(groupBox2);
            Controls.Add(btnXoa);
            Controls.Add(btnLapHoaDon);
            Controls.Add(btnSua);
            Controls.Add(btnThoat);
            Controls.Add(btnTimKiem);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnXuat);
            Name = "frmHoaDon";
            Text = "frmHoaDon";
            Load += frmHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView;
        private GroupBox groupBox2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnXuat;
        private Button btnInHoaDon;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLapHoaDon;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn HoVaTenKhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTienHoaDon;
        private DataGridViewTextBoxColumn XemChiTiet;
    }
}