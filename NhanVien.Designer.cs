
namespace WindowsFormsApp1
{
    partial class frmNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoVaTenDemNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinhNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinhNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDTNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoVaTenDemNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChiNV = new System.Windows.Forms.RichTextBox();
            this.txtSoDienThoaiNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpNgaySinhNV = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboGioiTinhNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboLoaiNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnNVSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnNVXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnNVThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiemNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnInSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuuNV = new Guna.UI2.WinForms.Guna2Button();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.dgvNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNV.ColumnHeadersHeight = 40;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colHoVaTenDemNV,
            this.colTenNV,
            this.colGioiTinhNV,
            this.colNgaySinhNV,
            this.colSDTNV,
            this.colDiaChiNV,
            this.colEmail,
            this.colLoaiNV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNV.EnableHeadersVisualStyles = false;
            this.dgvNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNV.Location = new System.Drawing.Point(0, 332);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersVisible = false;
            this.dgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.Size = new System.Drawing.Size(840, 254);
            this.dgvNV.TabIndex = 0;
            this.dgvNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNV.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.dgvNV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNV.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvNV.ThemeStyle.ReadOnly = false;
            this.dgvNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNV.ThemeStyle.RowsStyle.Height = 22;
            this.dgvNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNV_CellClick);
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNV";
            this.colMaNV.HeaderText = "Mã NV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.ReadOnly = true;
            // 
            // colHoVaTenDemNV
            // 
            this.colHoVaTenDemNV.DataPropertyName = "HoVaTenDem";
            this.colHoVaTenDemNV.HeaderText = "Họ và Tên Đệm";
            this.colHoVaTenDemNV.Name = "colHoVaTenDemNV";
            this.colHoVaTenDemNV.ReadOnly = true;
            // 
            // colTenNV
            // 
            this.colTenNV.DataPropertyName = "Ten";
            this.colTenNV.HeaderText = "Tên";
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.ReadOnly = true;
            // 
            // colGioiTinhNV
            // 
            this.colGioiTinhNV.DataPropertyName = "GioiTinh";
            this.colGioiTinhNV.HeaderText = "Giới Tính";
            this.colGioiTinhNV.Name = "colGioiTinhNV";
            this.colGioiTinhNV.ReadOnly = true;
            // 
            // colNgaySinhNV
            // 
            this.colNgaySinhNV.DataPropertyName = "NgayThangNamSinh";
            this.colNgaySinhNV.HeaderText = "Ngày Sinh";
            this.colNgaySinhNV.Name = "colNgaySinhNV";
            this.colNgaySinhNV.ReadOnly = true;
            // 
            // colSDTNV
            // 
            this.colSDTNV.DataPropertyName = "SoDienThoai";
            this.colSDTNV.HeaderText = "Số Điện Thoại";
            this.colSDTNV.Name = "colSDTNV";
            this.colSDTNV.ReadOnly = true;
            // 
            // colDiaChiNV
            // 
            this.colDiaChiNV.DataPropertyName = "DiaChi";
            this.colDiaChiNV.HeaderText = "Địa Chỉ";
            this.colDiaChiNV.Name = "colDiaChiNV";
            this.colDiaChiNV.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // colLoaiNV
            // 
            this.colLoaiNV.DataPropertyName = "LoaiNV";
            this.colLoaiNV.HeaderText = "Loại NV";
            this.colLoaiNV.Name = "colLoaiNV";
            this.colLoaiNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 47);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nhân Viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNV.DefaultText = "";
            this.txtMaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.FillColor = System.Drawing.Color.Gray;
            this.txtMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.White;
            this.txtMaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.Location = new System.Drawing.Point(285, 20);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PasswordChar = '\0';
            this.txtMaNV.PlaceholderText = "Mã Nhân Viên";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.SelectedText = "";
            this.txtMaNV.Size = new System.Drawing.Size(140, 36);
            this.txtMaNV.TabIndex = 0;
            // 
            // txtHoVaTenDemNV
            // 
            this.txtHoVaTenDemNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoVaTenDemNV.DefaultText = "";
            this.txtHoVaTenDemNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoVaTenDemNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoVaTenDemNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoVaTenDemNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoVaTenDemNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoVaTenDemNV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoVaTenDemNV.ForeColor = System.Drawing.Color.Black;
            this.txtHoVaTenDemNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoVaTenDemNV.Location = new System.Drawing.Point(285, 62);
            this.txtHoVaTenDemNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoVaTenDemNV.Name = "txtHoVaTenDemNV";
            this.txtHoVaTenDemNV.PasswordChar = '\0';
            this.txtHoVaTenDemNV.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoVaTenDemNV.PlaceholderText = "Họ và Tên Đệm";
            this.txtHoVaTenDemNV.SelectedText = "";
            this.txtHoVaTenDemNV.Size = new System.Drawing.Size(346, 36);
            this.txtHoVaTenDemNV.TabIndex = 1;
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiNV.Location = new System.Drawing.Point(285, 230);
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(346, 96);
            this.txtDiaChiNV.TabIndex = 7;
            this.txtDiaChiNV.Text = "";
            // 
            // txtSoDienThoaiNV
            // 
            this.txtSoDienThoaiNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoaiNV.DefaultText = "";
            this.txtSoDienThoaiNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDienThoaiNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDienThoaiNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoaiNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoaiNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoaiNV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoaiNV.ForeColor = System.Drawing.Color.Black;
            this.txtSoDienThoaiNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoaiNV.Location = new System.Drawing.Point(285, 188);
            this.txtSoDienThoaiNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoDienThoaiNV.MaxLength = 10;
            this.txtSoDienThoaiNV.Name = "txtSoDienThoaiNV";
            this.txtSoDienThoaiNV.PasswordChar = '\0';
            this.txtSoDienThoaiNV.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoDienThoaiNV.PlaceholderText = "Số Điện Thoại";
            this.txtSoDienThoaiNV.SelectedText = "";
            this.txtSoDienThoaiNV.Size = new System.Drawing.Size(179, 36);
            this.txtSoDienThoaiNV.TabIndex = 5;
            this.txtSoDienThoaiNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoaiNV_KeyPress);
            // 
            // dtpNgaySinhNV
            // 
            this.dtpNgaySinhNV.Checked = true;
            this.dtpNgaySinhNV.CustomFormat = "dd-MM-yyyy";
            this.dtpNgaySinhNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.dtpNgaySinhNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinhNV.ForeColor = System.Drawing.Color.White;
            this.dtpNgaySinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhNV.Location = new System.Drawing.Point(285, 146);
            this.dtpNgaySinhNV.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinhNV.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinhNV.Name = "dtpNgaySinhNV";
            this.dtpNgaySinhNV.Size = new System.Drawing.Size(179, 36);
            this.dtpNgaySinhNV.TabIndex = 3;
            this.dtpNgaySinhNV.Value = new System.DateTime(2022, 5, 28, 17, 0, 55, 784);
            // 
            // cboGioiTinhNV
            // 
            this.cboGioiTinhNV.BackColor = System.Drawing.Color.Transparent;
            this.cboGioiTinhNV.BorderRadius = 5;
            this.cboGioiTinhNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGioiTinhNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinhNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGioiTinhNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGioiTinhNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGioiTinhNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGioiTinhNV.ItemHeight = 30;
            this.cboGioiTinhNV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinhNV.Location = new System.Drawing.Point(470, 146);
            this.cboGioiTinhNV.Name = "cboGioiTinhNV";
            this.cboGioiTinhNV.Size = new System.Drawing.Size(161, 36);
            this.cboGioiTinhNV.TabIndex = 4;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNV.DefaultText = "";
            this.txtTenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.Black;
            this.txtTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Location = new System.Drawing.Point(285, 104);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PasswordChar = '\0';
            this.txtTenNV.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenNV.PlaceholderText = "Tên";
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.Size = new System.Drawing.Size(179, 36);
            this.txtTenNV.TabIndex = 2;
            // 
            // cboLoaiNV
            // 
            this.cboLoaiNV.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiNV.BorderRadius = 5;
            this.cboLoaiNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoaiNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoaiNV.ItemHeight = 30;
            this.cboLoaiNV.Items.AddRange(new object[] {
            "Nhân Viên",
            "Quản Lý"});
            this.cboLoaiNV.Location = new System.Drawing.Point(470, 188);
            this.cboLoaiNV.Name = "cboLoaiNV";
            this.cboLoaiNV.Size = new System.Drawing.Size(161, 36);
            this.cboLoaiNV.TabIndex = 6;
            // 
            // btnNVSua
            // 
            this.btnNVSua.BorderRadius = 5;
            this.btnNVSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNVSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNVSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNVSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNVSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnNVSua.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVSua.ForeColor = System.Drawing.Color.White;
            this.btnNVSua.Image = global::WindowsFormsApp1.Properties.Resources.icons8_edit_48;
            this.btnNVSua.Location = new System.Drawing.Point(648, 113);
            this.btnNVSua.Name = "btnNVSua";
            this.btnNVSua.Size = new System.Drawing.Size(180, 45);
            this.btnNVSua.TabIndex = 10;
            this.btnNVSua.Text = "Sửa";
            this.btnNVSua.Click += new System.EventHandler(this.btnNVSua_Click);
            // 
            // btnNVXoa
            // 
            this.btnNVXoa.BorderRadius = 5;
            this.btnNVXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNVXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNVXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNVXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNVXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnNVXoa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVXoa.ForeColor = System.Drawing.Color.White;
            this.btnNVXoa.Image = global::WindowsFormsApp1.Properties.Resources.icons8_delete_48;
            this.btnNVXoa.Location = new System.Drawing.Point(648, 164);
            this.btnNVXoa.Name = "btnNVXoa";
            this.btnNVXoa.Size = new System.Drawing.Size(180, 45);
            this.btnNVXoa.TabIndex = 11;
            this.btnNVXoa.Text = "Xóa";
            this.btnNVXoa.Click += new System.EventHandler(this.btnNVXoa_Click);
            // 
            // btnNVThem
            // 
            this.btnNVThem.BorderRadius = 5;
            this.btnNVThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNVThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNVThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNVThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNVThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnNVThem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVThem.ForeColor = System.Drawing.Color.White;
            this.btnNVThem.Image = global::WindowsFormsApp1.Properties.Resources.icons8_plus_math_48;
            this.btnNVThem.Location = new System.Drawing.Point(648, 62);
            this.btnNVThem.Name = "btnNVThem";
            this.btnNVThem.Size = new System.Drawing.Size(180, 45);
            this.btnNVThem.TabIndex = 9;
            this.btnNVThem.Text = "Thêm";
            this.btnNVThem.Click += new System.EventHandler(this.btnNVThem_Click);
            // 
            // txtTimKiemNV
            // 
            this.txtTimKiemNV.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiemNV.BorderRadius = 5;
            this.txtTimKiemNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemNV.DefaultText = "";
            this.txtTimKiemNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiemNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiemNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.txtTimKiemNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiemNV.ForeColor = System.Drawing.Color.White;
            this.txtTimKiemNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemNV.IconRight = global::WindowsFormsApp1.Properties.Resources.icons8_search_48;
            this.txtTimKiemNV.Location = new System.Drawing.Point(81, 291);
            this.txtTimKiemNV.Name = "txtTimKiemNV";
            this.txtTimKiemNV.PasswordChar = '\0';
            this.txtTimKiemNV.PlaceholderText = "Tìm Kiếm";
            this.txtTimKiemNV.SelectedText = "";
            this.txtTimKiemNV.Size = new System.Drawing.Size(198, 36);
            this.txtTimKiemNV.TabIndex = 14;
            this.txtTimKiemNV.TextChanged += new System.EventHandler(this.txtTimKiemNV_TextChanged);
            // 
            // btnInSP
            // 
            this.btnInSP.BorderRadius = 5;
            this.btnInSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnInSP.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInSP.ForeColor = System.Drawing.Color.White;
            this.btnInSP.Image = global::WindowsFormsApp1.Properties.Resources.icons8_downloading_updates_48;
            this.btnInSP.Location = new System.Drawing.Point(20, 62);
            this.btnInSP.Name = "btnInSP";
            this.btnInSP.Size = new System.Drawing.Size(168, 36);
            this.btnInSP.TabIndex = 12;
            this.btnInSP.Text = "In";
            this.btnInSP.Click += new System.EventHandler(this.btnInSP_Click);
            // 
            // btnLuuNV
            // 
            this.btnLuuNV.BorderRadius = 5;
            this.btnLuuNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnLuuNV.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuNV.ForeColor = System.Drawing.Color.White;
            this.btnLuuNV.Image = global::WindowsFormsApp1.Properties.Resources.icons8_save_48__1_;
            this.btnLuuNV.ImageOffset = new System.Drawing.Point(0, 2);
            this.btnLuuNV.Location = new System.Drawing.Point(648, 290);
            this.btnLuuNV.Name = "btnLuuNV";
            this.btnLuuNV.Size = new System.Drawing.Size(180, 36);
            this.btnLuuNV.TabIndex = 8;
            this.btnLuuNV.Text = "Lưu";
            this.btnLuuNV.Click += new System.EventHandler(this.btnLuuNV_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(470, 103);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(161, 36);
            this.txtEmail.TabIndex = 18;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(840, 586);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnLuuNV);
            this.Controls.Add(this.btnInSP);
            this.Controls.Add(this.btnNVSua);
            this.Controls.Add(this.btnNVXoa);
            this.Controls.Add(this.btnNVThem);
            this.Controls.Add(this.cboLoaiNV);
            this.Controls.Add(this.txtDiaChiNV);
            this.Controls.Add(this.txtSoDienThoaiNV);
            this.Controls.Add(this.dtpNgaySinhNV);
            this.Controls.Add(this.cboGioiTinhNV);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtHoVaTenDemNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiemNV);
            this.Controls.Add(this.dgvNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.Click += new System.EventHandler(this.frmNhanVien_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvNV;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemNV;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNV;
        private Guna.UI2.WinForms.Guna2TextBox txtHoVaTenDemNV;
        private System.Windows.Forms.RichTextBox txtDiaChiNV;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDienThoaiNV;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinhNV;
        private Guna.UI2.WinForms.Guna2ComboBox cboGioiTinhNV;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNV;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiNV;
        private Guna.UI2.WinForms.Guna2Button btnNVSua;
        private Guna.UI2.WinForms.Guna2Button btnNVXoa;
        private Guna.UI2.WinForms.Guna2Button btnNVThem;
        private Guna.UI2.WinForms.Guna2Button btnInSP;
        private Guna.UI2.WinForms.Guna2Button btnLuuNV;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoVaTenDemNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinhNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinhNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDTNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiNV;
    }
}