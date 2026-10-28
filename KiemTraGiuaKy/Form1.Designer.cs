namespace KiemTraGiuaKy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpThongTin = new GroupBox();
            txtLuongCB = new TextBox();
            txtTenNV = new TextBox();
            txtMaNV = new TextBox();
            lblLuongCB = new Label();
            lblTenNV = new Label();
            lblMaNV = new Label();
            grpThaoTac = new GroupBox();
            grpChucNang = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            grpDanhSach = new GroupBox();
            dgvNhanVien = new DataGridView();
            grpThongTin.SuspendLayout();
            grpThaoTac.SuspendLayout();
            grpChucNang.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(txtLuongCB);
            grpThongTin.Controls.Add(txtTenNV);
            grpThongTin.Controls.Add(txtMaNV);
            grpThongTin.Controls.Add(lblLuongCB);
            grpThongTin.Controls.Add(lblTenNV);
            grpThongTin.Controls.Add(lblMaNV);
            grpThongTin.Font = new Font("Segoe UI", 9F);
            grpThongTin.Location = new Point(18, 16);
            grpThongTin.Margin = new Padding(3, 4, 3, 4);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(3, 4, 3, 4);
            grpThongTin.Size = new Size(446, 200);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin nhân viên";
            // 
            // txtLuongCB
            // 
            txtLuongCB.Font = new Font("Segoe UI", 9.5F);
            txtLuongCB.Location = new Point(149, 140);
            txtLuongCB.Margin = new Padding(3, 4, 3, 4);
            txtLuongCB.MaxLength = 12;
            txtLuongCB.Name = "txtLuongCB";
            txtLuongCB.Size = new Size(274, 29);
            txtLuongCB.TabIndex = 5;
            txtLuongCB.KeyPress += txtLuongCB_KeyPress;
            // 
            // txtTenNV
            // 
            txtTenNV.Font = new Font("Segoe UI", 9.5F);
            txtTenNV.Location = new Point(149, 91);
            txtTenNV.Margin = new Padding(3, 4, 3, 4);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(274, 29);
            txtTenNV.TabIndex = 4;
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Segoe UI", 9.5F);
            txtMaNV.Location = new Point(149, 40);
            txtMaNV.Margin = new Padding(3, 4, 3, 4);
            txtMaNV.MaxLength = 10;
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(274, 29);
            txtMaNV.TabIndex = 3;
            txtMaNV.TextChanged += txtMaNV_TextChanged;
            // 
            // lblLuongCB
            // 
            lblLuongCB.AutoSize = true;
            lblLuongCB.Font = new Font("Segoe UI", 9F);
            lblLuongCB.Location = new Point(18, 144);
            lblLuongCB.Name = "lblLuongCB";
            lblLuongCB.Size = new Size(103, 20);
            lblLuongCB.TabIndex = 2;
            lblLuongCB.Text = "Lương cơ bản:";
            // 
            // lblTenNV
            // 
            lblTenNV.AutoSize = true;
            lblTenNV.Font = new Font("Segoe UI", 9F);
            lblTenNV.Location = new Point(18, 95);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(102, 20);
            lblTenNV.TabIndex = 1;
            lblTenNV.Text = "Tên nhân viên:";
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Font = new Font("Segoe UI", 9F);
            lblMaNV.Location = new Point(18, 44);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(100, 20);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "Mã nhân viên:";
            // 
            // grpThaoTac
            // 
            grpThaoTac.Controls.Add(grpChucNang);
            grpThaoTac.Font = new Font("Segoe UI", 9F);
            grpThaoTac.Location = new Point(478, 16);
            grpThaoTac.Margin = new Padding(3, 4, 3, 4);
            grpThaoTac.Name = "grpThaoTac";
            grpThaoTac.Padding = new Padding(3, 4, 3, 4);
            grpThaoTac.Size = new Size(297, 200);
            grpThaoTac.TabIndex = 1;
            grpThaoTac.TabStop = false;
            grpThaoTac.Text = "Thao tác";
            // 
            // grpChucNang
            // 
            grpChucNang.Controls.Add(btnXoa);
            grpChucNang.Controls.Add(btnSua);
            grpChucNang.Controls.Add(btnThoat);
            grpChucNang.Controls.Add(btnThem);
            grpChucNang.Location = new Point(17, 24);
            grpChucNang.Margin = new Padding(3, 4, 3, 4);
            grpChucNang.Name = "grpChucNang";
            grpChucNang.Padding = new Padding(3, 4, 3, 4);
            grpChucNang.Size = new Size(263, 160);
            grpChucNang.TabIndex = 0;
            grpChucNang.TabStop = false;
            grpChucNang.Text = "Các chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(137, 93);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Padding = new Padding(9, 0, 0, 0);
            btnXoa.Size = new Size(109, 48);
            btnXoa.TabIndex = 3;
            btnXoa.Text = " Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Cursor = Cursors.Hand;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(17, 93);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Padding = new Padding(9, 0, 0, 0);
            btnSua.Size = new Size(109, 48);
            btnSua.TabIndex = 2;
            btnSua.Text = " Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(137, 32);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Padding = new Padding(7, 0, 0, 0);
            btnThoat.Size = new Size(109, 48);
            btnThoat.TabIndex = 1;
            btnThoat.Text = " Thoát";
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.Cursor = Cursors.Hand;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(17, 32);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Padding = new Padding(7, 0, 0, 0);
            btnThem.Size = new Size(109, 48);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(dgvNhanVien);
            grpDanhSach.Font = new Font("Segoe UI", 9F);
            grpDanhSach.Location = new Point(18, 229);
            grpDanhSach.Margin = new Padding(3, 4, 3, 4);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Padding = new Padding(3, 4, 3, 4);
            grpDanhSach.Size = new Size(757, 299);
            grpDanhSach.TabIndex = 2;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách nhân viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = SystemColors.Window;
            dgvNhanVien.BorderStyle = BorderStyle.Fixed3D;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(3, 24);
            dgvNhanVien.Margin = new Padding(3, 4, 3, 4);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 35;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(751, 271);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 536);
            Controls.Add(grpDanhSach);
            Controls.Add(grpThaoTac);
            Controls.Add(grpThongTin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Nhân viên / Nhân sự - VP104";
            Load += Form1_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpThaoTac.ResumeLayout(false);
            grpChucNang.ResumeLayout(false);
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTin;
        private Label lblMaNV;
        private Label lblTenNV;
        private Label lblLuongCB;
        private TextBox txtLuongCB;
        private TextBox txtTenNV;
        private TextBox txtMaNV;
        private GroupBox grpThaoTac;
        private GroupBox grpChucNang;
        private Button btnThem;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private GroupBox grpDanhSach;
        private DataGridView dgvNhanVien;
    }
}
