
namespace WindowsFormsApp1
{
    partial class frmNhaCungCap
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvNCC = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtTenNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoDienThoaiNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChiNCC = new System.Windows.Forms.RichTextBox();
            this.btnNCCSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnNCCXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnNCCThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnNCCLuu = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatHangNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.colMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDTNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(257, 47);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nhà Cung Cấp";
            // 
            // txtTimKiemNCC
            // 
            this.txtTimKiemNCC.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiemNCC.BorderRadius = 5;
            this.txtTimKiemNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemNCC.DefaultText = "";
            this.txtTimKiemNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiemNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiemNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemNCC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.txtTimKiemNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemNCC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNCC.ForeColor = System.Drawing.Color.White;
            this.txtTimKiemNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemNCC.IconRight = global::WindowsFormsApp1.Properties.Resources.icons8_search_48;
            this.txtTimKiemNCC.Location = new System.Drawing.Point(12, 249);
            this.txtTimKiemNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemNCC.Name = "txtTimKiemNCC";
            this.txtTimKiemNCC.PasswordChar = '\0';
            this.txtTimKiemNCC.PlaceholderText = "Tìm Kiếm";
            this.txtTimKiemNCC.SelectedText = "";
            this.txtTimKiemNCC.Size = new System.Drawing.Size(200, 36);
            this.txtTimKiemNCC.TabIndex = 11;
            this.txtTimKiemNCC.TextChanged += new System.EventHandler(this.txtTimKiemNCC_TextChanged);
            // 
            // dgvNCC
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvNCC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNCC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.dgvNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNCC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNCC.ColumnHeadersHeight = 21;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNCC,
            this.colTenNhaCungCap,
            this.colSDTNCC,
            this.colDiaChiNCC,
            this.colMatHang,
            this.colMaNhanVien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNCC.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNCC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNCC.EnableHeadersVisualStyles = false;
            this.dgvNCC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNCC.Location = new System.Drawing.Point(0, 300);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersVisible = false;
            this.dgvNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNCC.Size = new System.Drawing.Size(840, 286);
            this.dgvNCC.TabIndex = 23;
            this.dgvNCC.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNCC.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNCC.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNCC.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNCC.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNCC.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.dgvNCC.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNCC.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNCC.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNCC.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvNCC.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNCC.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNCC.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvNCC.ThemeStyle.ReadOnly = false;
            this.dgvNCC.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNCC.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNCC.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvNCC.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNCC.ThemeStyle.RowsStyle.Height = 22;
            this.dgvNCC.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNCC.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNCC.DefaultText = "";
            this.txtTenNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNCC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.ForeColor = System.Drawing.Color.Black;
            this.txtTenNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNCC.Location = new System.Drawing.Point(282, 62);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.PasswordChar = '\0';
            this.txtTenNCC.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenNCC.PlaceholderText = "Tên NCC";
            this.txtTenNCC.SelectedText = "";
            this.txtTenNCC.Size = new System.Drawing.Size(346, 36);
            this.txtTenNCC.TabIndex = 1;
            // 
            // txtSoDienThoaiNCC
            // 
            this.txtSoDienThoaiNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoaiNCC.DefaultText = "";
            this.txtSoDienThoaiNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDienThoaiNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDienThoaiNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoaiNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoaiNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoaiNCC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoaiNCC.ForeColor = System.Drawing.Color.Black;
            this.txtSoDienThoaiNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoaiNCC.Location = new System.Drawing.Point(282, 104);
            this.txtSoDienThoaiNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoDienThoaiNCC.MaxLength = 10;
            this.txtSoDienThoaiNCC.Name = "txtSoDienThoaiNCC";
            this.txtSoDienThoaiNCC.PasswordChar = '\0';
            this.txtSoDienThoaiNCC.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoDienThoaiNCC.PlaceholderText = "Số Điện Thoại";
            this.txtSoDienThoaiNCC.SelectedText = "";
            this.txtSoDienThoaiNCC.Size = new System.Drawing.Size(346, 36);
            this.txtSoDienThoaiNCC.TabIndex = 2;
            this.txtSoDienThoaiNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoaiNCC_KeyPress);
            // 
            // txtDiaChiNCC
            // 
            this.txtDiaChiNCC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiNCC.Location = new System.Drawing.Point(282, 146);
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.Size = new System.Drawing.Size(346, 96);
            this.txtDiaChiNCC.TabIndex = 3;
            this.txtDiaChiNCC.Text = "";
            // 
            // btnNCCSua
            // 
            this.btnNCCSua.BorderRadius = 5;
            this.btnNCCSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNCCSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNCCSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNCCSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNCCSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnNCCSua.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCCSua.ForeColor = System.Drawing.Color.White;
            this.btnNCCSua.Image = global::WindowsFormsApp1.Properties.Resources.icons8_edit_48;
            this.btnNCCSua.Location = new System.Drawing.Point(648, 113);
            this.btnNCCSua.Name = "btnNCCSua";
            this.btnNCCSua.Size = new System.Drawing.Size(180, 45);
            this.btnNCCSua.TabIndex = 7;
            this.btnNCCSua.Text = "Sửa";
            this.btnNCCSua.Click += new System.EventHandler(this.btnNCCSua_Click);
            // 
            // btnNCCXoa
            // 
            this.btnNCCXoa.BorderRadius = 5;
            this.btnNCCXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNCCXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNCCXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNCCXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNCCXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnNCCXoa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCCXoa.ForeColor = System.Drawing.Color.White;
            this.btnNCCXoa.Image = global::WindowsFormsApp1.Properties.Resources.icons8_delete_48;
            this.btnNCCXoa.Location = new System.Drawing.Point(648, 164);
            this.btnNCCXoa.Name = "btnNCCXoa";
            this.btnNCCXoa.Size = new System.Drawing.Size(180, 45);
            this.btnNCCXoa.TabIndex = 8;
            this.btnNCCXoa.Text = "Xóa";
            this.btnNCCXoa.Click += new System.EventHandler(this.btnNCCXoa_Click);
            // 
            // btnNCCThem
            // 
            this.btnNCCThem.BorderRadius = 5;
            this.btnNCCThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNCCThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNCCThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNCCThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNCCThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnNCCThem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCCThem.ForeColor = System.Drawing.Color.White;
            this.btnNCCThem.Image = global::WindowsFormsApp1.Properties.Resources.icons8_plus_math_48;
            this.btnNCCThem.Location = new System.Drawing.Point(648, 62);
            this.btnNCCThem.Name = "btnNCCThem";
            this.btnNCCThem.Size = new System.Drawing.Size(180, 45);
            this.btnNCCThem.TabIndex = 6;
            this.btnNCCThem.Text = "Thêm";
            this.btnNCCThem.Click += new System.EventHandler(this.btnNCCThem_Click);
            // 
            // btnNCCLuu
            // 
            this.btnNCCLuu.BorderRadius = 5;
            this.btnNCCLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNCCLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNCCLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNCCLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNCCLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnNCCLuu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCCLuu.ForeColor = System.Drawing.Color.White;
            this.btnNCCLuu.Image = global::WindowsFormsApp1.Properties.Resources.icons8_save_48__1_;
            this.btnNCCLuu.ImageOffset = new System.Drawing.Point(0, 2);
            this.btnNCCLuu.Location = new System.Drawing.Point(648, 249);
            this.btnNCCLuu.Name = "btnNCCLuu";
            this.btnNCCLuu.Size = new System.Drawing.Size(180, 36);
            this.btnNCCLuu.TabIndex = 5;
            this.btnNCCLuu.Text = "Lưu";
            this.btnNCCLuu.Click += new System.EventHandler(this.btnNCCLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(168, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 37);
            this.label2.TabIndex = 27;
            this.label2.Text = "Địa Chỉ";
            // 
            // txtMatHangNCC
            // 
            this.txtMatHangNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatHangNCC.DefaultText = "";
            this.txtMatHangNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatHangNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatHangNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatHangNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatHangNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatHangNCC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatHangNCC.ForeColor = System.Drawing.Color.Black;
            this.txtMatHangNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatHangNCC.Location = new System.Drawing.Point(282, 249);
            this.txtMatHangNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatHangNCC.Name = "txtMatHangNCC";
            this.txtMatHangNCC.PasswordChar = '\0';
            this.txtMatHangNCC.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMatHangNCC.PlaceholderText = "Mặt Hàng";
            this.txtMatHangNCC.SelectedText = "";
            this.txtMatHangNCC.Size = new System.Drawing.Size(346, 36);
            this.txtMatHangNCC.TabIndex = 29;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNCC.DefaultText = "";
            this.txtMaNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNCC.FillColor = System.Drawing.Color.Gray;
            this.txtMaNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.ForeColor = System.Drawing.Color.Black;
            this.txtMaNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNCC.Location = new System.Drawing.Point(282, 20);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.PasswordChar = '\0';
            this.txtMaNCC.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMaNCC.PlaceholderText = "Mã NCC";
            this.txtMaNCC.ReadOnly = true;
            this.txtMaNCC.SelectedText = "";
            this.txtMaNCC.Size = new System.Drawing.Size(140, 36);
            this.txtMaNCC.TabIndex = 26;
            // 
            // colMaNCC
            // 
            this.colMaNCC.DataPropertyName = "ma";
            this.colMaNCC.HeaderText = "Mã NCC";
            this.colMaNCC.Name = "colMaNCC";
            // 
            // colTenNhaCungCap
            // 
            this.colTenNhaCungCap.DataPropertyName = "ten";
            this.colTenNhaCungCap.HeaderText = "Tên NCC";
            this.colTenNhaCungCap.Name = "colTenNhaCungCap";
            this.colTenNhaCungCap.ReadOnly = true;
            // 
            // colSDTNCC
            // 
            this.colSDTNCC.DataPropertyName = "sodienthoai";
            this.colSDTNCC.HeaderText = "Số Điện Thoại";
            this.colSDTNCC.Name = "colSDTNCC";
            this.colSDTNCC.ReadOnly = true;
            // 
            // colDiaChiNCC
            // 
            this.colDiaChiNCC.DataPropertyName = "diachi";
            this.colDiaChiNCC.HeaderText = "Địa Chỉ";
            this.colDiaChiNCC.Name = "colDiaChiNCC";
            this.colDiaChiNCC.ReadOnly = true;
            // 
            // colMatHang
            // 
            this.colMatHang.DataPropertyName = "mathang";
            this.colMatHang.HeaderText = "Mặt Hàng";
            this.colMatHang.Name = "colMatHang";
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.DataPropertyName = "manv";
            this.colMaNhanVien.HeaderText = "Mã Người Nhập";
            this.colMaNhanVien.Name = "colMaNhanVien";
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(840, 586);
            this.Controls.Add(this.txtMatHangNCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNCCLuu);
            this.Controls.Add(this.btnNCCSua);
            this.Controls.Add(this.btnNCCXoa);
            this.Controls.Add(this.btnNCCThem);
            this.Controls.Add(this.txtDiaChiNCC);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.txtSoDienThoaiNCC);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.dgvNCC);
            this.Controls.Add(this.txtTimKiemNCC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhaCungCap";
            this.Text = "Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            this.Click += new System.EventHandler(this.frmNhaCungCap_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemNCC;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNCC;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNCC;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDienThoaiNCC;
        private System.Windows.Forms.RichTextBox txtDiaChiNCC;
        private Guna.UI2.WinForms.Guna2Button btnNCCSua;
        private Guna.UI2.WinForms.Guna2Button btnNCCXoa;
        private Guna.UI2.WinForms.Guna2Button btnNCCThem;
        private Guna.UI2.WinForms.Guna2Button btnNCCLuu;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMatHangNCC;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDTNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhanVien;
    }
}