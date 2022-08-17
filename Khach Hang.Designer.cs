
namespace WindowsFormsApp1
{
    partial class frmKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colHoTenDemKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDTKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinhKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinhKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHoVaTenDemKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboGioiTinhKH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpNgaySinhKH = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSoDienThoaiKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.RichTextBox();
            this.cboLoaiKH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnKHSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnKHXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnKHThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnInKhachHang = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 47);
            this.label1.TabIndex = 10;
            this.label1.Text = "Khách Hàng";
            // 
            // dgvKH
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.dgvKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvKH.ColumnHeadersHeight = 40;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKH,
            this.colLoaiKH,
            this.colHoTenDemKH,
            this.colTenKH,
            this.colSDTKH,
            this.colNgaySinhKH,
            this.colDiaChiKH,
            this.colGioiTinhKH});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKH.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvKH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKH.EnableHeadersVisualStyles = false;
            this.dgvKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKH.Location = new System.Drawing.Point(0, 333);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersVisible = false;
            this.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKH.Size = new System.Drawing.Size(840, 253);
            this.dgvKH.TabIndex = 13;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKH.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.dgvKH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvKH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvKH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvKH.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvKH.ThemeStyle.ReadOnly = false;
            this.dgvKH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvKH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKH.ThemeStyle.RowsStyle.Height = 22;
            this.dgvKH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // colMaKH
            // 
            this.colMaKH.DataPropertyName = "MaKH";
            this.colMaKH.FillWeight = 86.96174F;
            this.colMaKH.HeaderText = "Mã KH";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.ReadOnly = true;
            // 
            // colLoaiKH
            // 
            this.colLoaiKH.DataPropertyName = "LoaiKH";
            this.colLoaiKH.FillWeight = 123.5409F;
            this.colLoaiKH.HeaderText = "Loại KH";
            this.colLoaiKH.Name = "colLoaiKH";
            this.colLoaiKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLoaiKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colHoTenDemKH
            // 
            this.colHoTenDemKH.DataPropertyName = "HoTenDemKH";
            this.colHoTenDemKH.FillWeight = 123.5409F;
            this.colHoTenDemKH.HeaderText = "Họ và Tên Đệm";
            this.colHoTenDemKH.Name = "colHoTenDemKH";
            this.colHoTenDemKH.ReadOnly = true;
            // 
            // colTenKH
            // 
            this.colTenKH.DataPropertyName = "TenKH";
            this.colTenKH.FillWeight = 60.91373F;
            this.colTenKH.HeaderText = "Tên";
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.ReadOnly = true;
            // 
            // colSDTKH
            // 
            this.colSDTKH.DataPropertyName = "SdtKH";
            this.colSDTKH.FillWeight = 94.2586F;
            this.colSDTKH.HeaderText = "SĐT";
            this.colSDTKH.Name = "colSDTKH";
            this.colSDTKH.ReadOnly = true;
            // 
            // colNgaySinhKH
            // 
            this.colNgaySinhKH.DataPropertyName = "NgaySinhKH";
            this.colNgaySinhKH.FillWeight = 123.5409F;
            this.colNgaySinhKH.HeaderText = "Ngày Sinh";
            this.colNgaySinhKH.Name = "colNgaySinhKH";
            this.colNgaySinhKH.ReadOnly = true;
            // 
            // colDiaChiKH
            // 
            this.colDiaChiKH.DataPropertyName = "DiaChiKH";
            this.colDiaChiKH.FillWeight = 123.5409F;
            this.colDiaChiKH.HeaderText = "Địa Chỉ";
            this.colDiaChiKH.Name = "colDiaChiKH";
            this.colDiaChiKH.ReadOnly = true;
            // 
            // colGioiTinhKH
            // 
            this.colGioiTinhKH.DataPropertyName = "GioiTinhKH";
            this.colGioiTinhKH.FillWeight = 63.70262F;
            this.colGioiTinhKH.HeaderText = "Giới Tính";
            this.colGioiTinhKH.Name = "colGioiTinhKH";
            this.colGioiTinhKH.ReadOnly = true;
            // 
            // txtHoVaTenDemKH
            // 
            this.txtHoVaTenDemKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoVaTenDemKH.DefaultText = "";
            this.txtHoVaTenDemKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoVaTenDemKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoVaTenDemKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoVaTenDemKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoVaTenDemKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoVaTenDemKH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoVaTenDemKH.ForeColor = System.Drawing.Color.Black;
            this.txtHoVaTenDemKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoVaTenDemKH.Location = new System.Drawing.Point(290, 62);
            this.txtHoVaTenDemKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoVaTenDemKH.Name = "txtHoVaTenDemKH";
            this.txtHoVaTenDemKH.PasswordChar = '\0';
            this.txtHoVaTenDemKH.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoVaTenDemKH.PlaceholderText = "Họ và Tên Đệm";
            this.txtHoVaTenDemKH.SelectedText = "";
            this.txtHoVaTenDemKH.Size = new System.Drawing.Size(346, 36);
            this.txtHoVaTenDemKH.TabIndex = 1;
            this.txtHoVaTenDemKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoVaTenDemKH_KeyPress);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKH.DefaultText = "";
            this.txtTenKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.ForeColor = System.Drawing.Color.Black;
            this.txtTenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.Location = new System.Drawing.Point(290, 104);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenKH.PlaceholderText = "Tên";
            this.txtTenKH.SelectedText = "";
            this.txtTenKH.Size = new System.Drawing.Size(346, 36);
            this.txtTenKH.TabIndex = 2;
            this.txtTenKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKH_KeyPress);
            // 
            // cboGioiTinhKH
            // 
            this.cboGioiTinhKH.BackColor = System.Drawing.Color.Transparent;
            this.cboGioiTinhKH.BorderRadius = 5;
            this.cboGioiTinhKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGioiTinhKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinhKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGioiTinhKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGioiTinhKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGioiTinhKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGioiTinhKH.ItemHeight = 30;
            this.cboGioiTinhKH.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinhKH.Location = new System.Drawing.Point(290, 147);
            this.cboGioiTinhKH.Name = "cboGioiTinhKH";
            this.cboGioiTinhKH.Size = new System.Drawing.Size(168, 36);
            this.cboGioiTinhKH.TabIndex = 3;
            // 
            // dtpNgaySinhKH
            // 
            this.dtpNgaySinhKH.Checked = true;
            this.dtpNgaySinhKH.CustomFormat = "dd-MM-yyyy";
            this.dtpNgaySinhKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.dtpNgaySinhKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinhKH.ForeColor = System.Drawing.Color.White;
            this.dtpNgaySinhKH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhKH.Location = new System.Drawing.Point(464, 189);
            this.dtpNgaySinhKH.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinhKH.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinhKH.Name = "dtpNgaySinhKH";
            this.dtpNgaySinhKH.Size = new System.Drawing.Size(172, 36);
            this.dtpNgaySinhKH.TabIndex = 6;
            this.dtpNgaySinhKH.Value = new System.DateTime(2022, 5, 28, 0, 0, 0, 0);
            // 
            // txtSoDienThoaiKH
            // 
            this.txtSoDienThoaiKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoaiKH.DefaultText = "";
            this.txtSoDienThoaiKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDienThoaiKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDienThoaiKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoaiKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoaiKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoaiKH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoaiKH.ForeColor = System.Drawing.Color.Black;
            this.txtSoDienThoaiKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoaiKH.Location = new System.Drawing.Point(290, 188);
            this.txtSoDienThoaiKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoDienThoaiKH.MaxLength = 10;
            this.txtSoDienThoaiKH.Name = "txtSoDienThoaiKH";
            this.txtSoDienThoaiKH.PasswordChar = '\0';
            this.txtSoDienThoaiKH.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoDienThoaiKH.PlaceholderText = "Số Điện Thoại";
            this.txtSoDienThoaiKH.SelectedText = "";
            this.txtSoDienThoaiKH.Size = new System.Drawing.Size(168, 36);
            this.txtSoDienThoaiKH.TabIndex = 5;
            this.txtSoDienThoaiKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoaiKH_KeyPress);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH.DefaultText = "";
            this.txtMaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.FillColor = System.Drawing.Color.Gray;
            this.txtMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.ForeColor = System.Drawing.Color.White;
            this.txtMaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Location = new System.Drawing.Point(290, 20);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PasswordChar = '\0';
            this.txtMaKH.PlaceholderText = "Mã Khách Hàng";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.Size = new System.Drawing.Size(140, 36);
            this.txtMaKH.TabIndex = 20;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiKH.Location = new System.Drawing.Point(290, 230);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(346, 96);
            this.txtDiaChiKH.TabIndex = 7;
            this.txtDiaChiKH.Text = "";
            // 
            // cboLoaiKH
            // 
            this.cboLoaiKH.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiKH.BorderRadius = 5;
            this.cboLoaiKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoaiKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoaiKH.ItemHeight = 30;
            this.cboLoaiKH.Location = new System.Drawing.Point(464, 147);
            this.cboLoaiKH.Name = "cboLoaiKH";
            this.cboLoaiKH.Size = new System.Drawing.Size(172, 36);
            this.cboLoaiKH.TabIndex = 4;
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = global::WindowsFormsApp1.Properties.Resources.icons8_save_48__1_;
            this.btnLuu.ImageOffset = new System.Drawing.Point(0, 2);
            this.btnLuu.Location = new System.Drawing.Point(648, 281);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(180, 45);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnKHSua
            // 
            this.btnKHSua.BorderRadius = 5;
            this.btnKHSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKHSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKHSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKHSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKHSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnKHSua.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKHSua.ForeColor = System.Drawing.Color.White;
            this.btnKHSua.Image = global::WindowsFormsApp1.Properties.Resources.icons8_edit_48;
            this.btnKHSua.Location = new System.Drawing.Point(648, 113);
            this.btnKHSua.Name = "btnKHSua";
            this.btnKHSua.Size = new System.Drawing.Size(180, 45);
            this.btnKHSua.TabIndex = 10;
            this.btnKHSua.Text = "Sửa";
            this.btnKHSua.Click += new System.EventHandler(this.btnKHSua_Click);
            // 
            // btnKHXoa
            // 
            this.btnKHXoa.BorderRadius = 5;
            this.btnKHXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKHXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKHXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKHXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKHXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnKHXoa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKHXoa.ForeColor = System.Drawing.Color.White;
            this.btnKHXoa.Image = global::WindowsFormsApp1.Properties.Resources.icons8_delete_48;
            this.btnKHXoa.Location = new System.Drawing.Point(648, 164);
            this.btnKHXoa.Name = "btnKHXoa";
            this.btnKHXoa.Size = new System.Drawing.Size(180, 45);
            this.btnKHXoa.TabIndex = 11;
            this.btnKHXoa.Text = "Xóa";
            this.btnKHXoa.Click += new System.EventHandler(this.btnKHXoa_Click);
            // 
            // btnKHThem
            // 
            this.btnKHThem.BorderRadius = 5;
            this.btnKHThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKHThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKHThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKHThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKHThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnKHThem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKHThem.ForeColor = System.Drawing.Color.White;
            this.btnKHThem.Image = global::WindowsFormsApp1.Properties.Resources.icons8_plus_math_48;
            this.btnKHThem.Location = new System.Drawing.Point(648, 62);
            this.btnKHThem.Name = "btnKHThem";
            this.btnKHThem.Size = new System.Drawing.Size(180, 45);
            this.btnKHThem.TabIndex = 9;
            this.btnKHThem.Text = "Thêm";
            this.btnKHThem.Click += new System.EventHandler(this.btnKHThem_Click);
            // 
            // txtTimKH
            // 
            this.txtTimKH.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKH.BorderRadius = 5;
            this.txtTimKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKH.DefaultText = "";
            this.txtTimKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.txtTimKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKH.ForeColor = System.Drawing.Color.White;
            this.txtTimKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKH.IconRight = global::WindowsFormsApp1.Properties.Resources.icons8_search_48;
            this.txtTimKH.Location = new System.Drawing.Point(55, 290);
            this.txtTimKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.PasswordChar = '\0';
            this.txtTimKH.PlaceholderText = "Tìm Kiếm";
            this.txtTimKH.SelectedText = "";
            this.txtTimKH.Size = new System.Drawing.Size(229, 36);
            this.txtTimKH.TabIndex = 14;
            this.txtTimKH.TextChanged += new System.EventHandler(this.txtTimKH_TextChanged);
            // 
            // btnInKhachHang
            // 
            this.btnInKhachHang.BorderRadius = 5;
            this.btnInKhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInKhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInKhachHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnInKhachHang.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnInKhachHang.Image = global::WindowsFormsApp1.Properties.Resources.icons8_downloading_updates_48;
            this.btnInKhachHang.Location = new System.Drawing.Point(43, 62);
            this.btnInKhachHang.Name = "btnInKhachHang";
            this.btnInKhachHang.Size = new System.Drawing.Size(168, 36);
            this.btnInKhachHang.TabIndex = 12;
            this.btnInKhachHang.Text = "In";
            this.btnInKhachHang.Click += new System.EventHandler(this.btnInKhachHang_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(840, 586);
            this.Controls.Add(this.btnInKhachHang);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cboLoaiKH);
            this.Controls.Add(this.btnKHSua);
            this.Controls.Add(this.txtDiaChiKH);
            this.Controls.Add(this.btnKHXoa);
            this.Controls.Add(this.btnKHThem);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtSoDienThoaiKH);
            this.Controls.Add(this.dtpNgaySinhKH);
            this.Controls.Add(this.cboGioiTinhKH);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtHoVaTenDemKH);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.txtTimKH);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhachHang";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.Click += new System.EventHandler(this.frmKhachHang_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKH;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKH;
        private Guna.UI2.WinForms.Guna2TextBox txtHoVaTenDemKH;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKH;
        private Guna.UI2.WinForms.Guna2ComboBox cboGioiTinhKH;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinhKH;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDienThoaiKH;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKH;
        private Guna.UI2.WinForms.Guna2Button btnKHThem;
        private System.Windows.Forms.RichTextBox txtDiaChiKH;
        private Guna.UI2.WinForms.Guna2Button btnKHSua;
        public Guna.UI2.WinForms.Guna2Button btnKHXoa;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTenDemKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDTKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinhKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinhKH;
        public Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnInKhachHang;
    }
}