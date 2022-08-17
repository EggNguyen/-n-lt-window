
namespace WindowsFormsApp1
{
    partial class frmNguyenLieu
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
            this.dgvNL = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNL = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNL = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoLuongTonNL = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpHanSuDungNL = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtMoTaNL = new System.Windows.Forms.RichTextBox();
            this.btnNLSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnNLXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnNLThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimNL = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNLLuu = new Guna.UI2.WinForms.Guna2Button();
            this.cboTenNCC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colMaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTonNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHanSuDungNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhaCungCapNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNL)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNL
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvNL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNL.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.dgvNL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNL.ColumnHeadersHeight = 21;
            this.dgvNL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNL,
            this.colTenNL,
            this.colNgayNhap,
            this.colSoLuongTonNL,
            this.colHanSuDungNL,
            this.colTenNhaCungCapNL,
            this.colMoTaNL});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNL.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNL.EnableHeadersVisualStyles = false;
            this.dgvNL.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNL.Location = new System.Drawing.Point(0, 273);
            this.dgvNL.Name = "dgvNL";
            this.dgvNL.RowHeadersVisible = false;
            this.dgvNL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNL.Size = new System.Drawing.Size(840, 313);
            this.dgvNL.TabIndex = 0;
            this.dgvNL.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNL.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNL.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNL.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNL.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNL.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.dgvNL.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNL.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNL.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNL.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvNL.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNL.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNL.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvNL.ThemeStyle.ReadOnly = false;
            this.dgvNL.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNL.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNL.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvNL.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNL.ThemeStyle.RowsStyle.Height = 22;
            this.dgvNL.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNL.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNL_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 47);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nguyên Liệu";
            // 
            // txtMaNL
            // 
            this.txtMaNL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNL.DefaultText = "";
            this.txtMaNL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNL.FillColor = System.Drawing.Color.Gray;
            this.txtMaNL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNL.ForeColor = System.Drawing.Color.Black;
            this.txtMaNL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNL.Location = new System.Drawing.Point(286, 35);
            this.txtMaNL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.PasswordChar = '\0';
            this.txtMaNL.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMaNL.PlaceholderText = "Mã Nguyên Liệu";
            this.txtMaNL.ReadOnly = true;
            this.txtMaNL.SelectedText = "";
            this.txtMaNL.Size = new System.Drawing.Size(140, 36);
            this.txtMaNL.TabIndex = 21;
            // 
            // txtTenNL
            // 
            this.txtTenNL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNL.DefaultText = "";
            this.txtTenNL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNL.ForeColor = System.Drawing.Color.Black;
            this.txtTenNL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNL.Location = new System.Drawing.Point(433, 78);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.PasswordChar = '\0';
            this.txtTenNL.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenNL.PlaceholderText = "Tên Nguyên Liệu";
            this.txtTenNL.SelectedText = "";
            this.txtTenNL.Size = new System.Drawing.Size(200, 36);
            this.txtTenNL.TabIndex = 1;
            this.txtTenNL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenNL_KeyPress);
            // 
            // txtSoLuongTonNL
            // 
            this.txtSoLuongTonNL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuongTonNL.DefaultText = "";
            this.txtSoLuongTonNL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuongTonNL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuongTonNL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongTonNL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongTonNL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongTonNL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTonNL.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuongTonNL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongTonNL.Location = new System.Drawing.Point(286, 119);
            this.txtSoLuongTonNL.Name = "txtSoLuongTonNL";
            this.txtSoLuongTonNL.PasswordChar = '\0';
            this.txtSoLuongTonNL.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoLuongTonNL.PlaceholderText = "Số Lượng Tồn";
            this.txtSoLuongTonNL.SelectedText = "";
            this.txtSoLuongTonNL.Size = new System.Drawing.Size(141, 33);
            this.txtSoLuongTonNL.TabIndex = 2;
            this.txtSoLuongTonNL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongTonNL_KeyPress);
            // 
            // dtpHanSuDungNL
            // 
            this.dtpHanSuDungNL.Checked = true;
            this.dtpHanSuDungNL.CustomFormat = "dd-MM-yyyy";
            this.dtpHanSuDungNL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.dtpHanSuDungNL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpHanSuDungNL.ForeColor = System.Drawing.Color.White;
            this.dtpHanSuDungNL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHanSuDungNL.Location = new System.Drawing.Point(432, 119);
            this.dtpHanSuDungNL.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHanSuDungNL.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHanSuDungNL.Name = "dtpHanSuDungNL";
            this.dtpHanSuDungNL.Size = new System.Drawing.Size(200, 33);
            this.dtpHanSuDungNL.TabIndex = 3;
            this.dtpHanSuDungNL.Value = new System.DateTime(2022, 5, 28, 17, 0, 55, 784);
            // 
            // txtMoTaNL
            // 
            this.txtMoTaNL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTaNL.Location = new System.Drawing.Point(287, 158);
            this.txtMoTaNL.Name = "txtMoTaNL";
            this.txtMoTaNL.Size = new System.Drawing.Size(346, 108);
            this.txtMoTaNL.TabIndex = 5;
            this.txtMoTaNL.Text = "";
            // 
            // btnNLSua
            // 
            this.btnNLSua.BorderRadius = 5;
            this.btnNLSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNLSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNLSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNLSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNLSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnNLSua.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNLSua.ForeColor = System.Drawing.Color.White;
            this.btnNLSua.Image = global::WindowsFormsApp1.Properties.Resources.icons8_edit_48;
            this.btnNLSua.Location = new System.Drawing.Point(648, 86);
            this.btnNLSua.Name = "btnNLSua";
            this.btnNLSua.Size = new System.Drawing.Size(180, 45);
            this.btnNLSua.TabIndex = 8;
            this.btnNLSua.Text = "Sửa";
            this.btnNLSua.Click += new System.EventHandler(this.btnNLSua_Click);
            // 
            // btnNLXoa
            // 
            this.btnNLXoa.BorderRadius = 5;
            this.btnNLXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNLXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNLXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNLXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNLXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnNLXoa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNLXoa.ForeColor = System.Drawing.Color.White;
            this.btnNLXoa.Image = global::WindowsFormsApp1.Properties.Resources.icons8_delete_48;
            this.btnNLXoa.Location = new System.Drawing.Point(648, 137);
            this.btnNLXoa.Name = "btnNLXoa";
            this.btnNLXoa.Size = new System.Drawing.Size(180, 45);
            this.btnNLXoa.TabIndex = 9;
            this.btnNLXoa.Text = "Xóa";
            this.btnNLXoa.Click += new System.EventHandler(this.btnNLXoa_Click);
            // 
            // btnNLThem
            // 
            this.btnNLThem.BorderRadius = 5;
            this.btnNLThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNLThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNLThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNLThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNLThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnNLThem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNLThem.ForeColor = System.Drawing.Color.White;
            this.btnNLThem.Image = global::WindowsFormsApp1.Properties.Resources.icons8_plus_math_48;
            this.btnNLThem.Location = new System.Drawing.Point(648, 35);
            this.btnNLThem.Name = "btnNLThem";
            this.btnNLThem.Size = new System.Drawing.Size(180, 45);
            this.btnNLThem.TabIndex = 7;
            this.btnNLThem.Text = "Thêm";
            this.btnNLThem.Click += new System.EventHandler(this.btnNLThem_Click);
            // 
            // txtTimNL
            // 
            this.txtTimNL.BackColor = System.Drawing.Color.Transparent;
            this.txtTimNL.BorderRadius = 5;
            this.txtTimNL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimNL.DefaultText = "";
            this.txtTimNL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimNL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimNL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimNL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimNL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.txtTimNL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimNL.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtTimNL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimNL.IconRight = global::WindowsFormsApp1.Properties.Resources.icons8_search_48;
            this.txtTimNL.Location = new System.Drawing.Point(81, 230);
            this.txtTimNL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimNL.Name = "txtTimNL";
            this.txtTimNL.PasswordChar = '\0';
            this.txtTimNL.PlaceholderText = "Tìm Kiếm";
            this.txtTimNL.SelectedText = "";
            this.txtTimNL.Size = new System.Drawing.Size(200, 36);
            this.txtTimNL.TabIndex = 11;
            this.txtTimNL.TextChanged += new System.EventHandler(this.txtTimNL_TextChanged);
            // 
            // btnNLLuu
            // 
            this.btnNLLuu.BorderRadius = 5;
            this.btnNLLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNLLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNLLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNLLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNLLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnNLLuu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNLLuu.ForeColor = System.Drawing.Color.White;
            this.btnNLLuu.Image = global::WindowsFormsApp1.Properties.Resources.icons8_save_48__1_;
            this.btnNLLuu.ImageOffset = new System.Drawing.Point(0, 2);
            this.btnNLLuu.Location = new System.Drawing.Point(648, 230);
            this.btnNLLuu.Name = "btnNLLuu";
            this.btnNLLuu.Size = new System.Drawing.Size(180, 36);
            this.btnNLLuu.TabIndex = 6;
            this.btnNLLuu.Text = "Lưu";
            this.btnNLLuu.Click += new System.EventHandler(this.btnNLLuu_Click);
            // 
            // cboTenNCC
            // 
            this.cboTenNCC.BackColor = System.Drawing.Color.Transparent;
            this.cboTenNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTenNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenNCC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTenNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTenNCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTenNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTenNCC.ItemHeight = 30;
            this.cboTenNCC.Location = new System.Drawing.Point(287, 78);
            this.cboTenNCC.Name = "cboTenNCC";
            this.cboTenNCC.Size = new System.Drawing.Size(140, 36);
            this.cboTenNCC.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên Nhà Cung Cấp";
            // 
            // colMaNL
            // 
            this.colMaNL.DataPropertyName = "ma";
            this.colMaNL.HeaderText = "Mã Nguyên Liệu";
            this.colMaNL.Name = "colMaNL";
            this.colMaNL.ReadOnly = true;
            // 
            // colTenNL
            // 
            this.colTenNL.DataPropertyName = "ten";
            this.colTenNL.HeaderText = "Tên";
            this.colTenNL.Name = "colTenNL";
            this.colTenNL.ReadOnly = true;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.DataPropertyName = "ngaynhap";
            this.colNgayNhap.HeaderText = "Ngày Nhập";
            this.colNgayNhap.Name = "colNgayNhap";
            // 
            // colSoLuongTonNL
            // 
            this.colSoLuongTonNL.DataPropertyName = "soluong";
            this.colSoLuongTonNL.HeaderText = "Số Lượng Tồn";
            this.colSoLuongTonNL.Name = "colSoLuongTonNL";
            this.colSoLuongTonNL.ReadOnly = true;
            // 
            // colHanSuDungNL
            // 
            this.colHanSuDungNL.DataPropertyName = "hansudung";
            this.colHanSuDungNL.HeaderText = "Hạn Sử Dụng";
            this.colHanSuDungNL.Name = "colHanSuDungNL";
            this.colHanSuDungNL.ReadOnly = true;
            // 
            // colTenNhaCungCapNL
            // 
            this.colTenNhaCungCapNL.DataPropertyName = "tenncc";
            this.colTenNhaCungCapNL.HeaderText = "Nhà Cung Cấp";
            this.colTenNhaCungCapNL.Name = "colTenNhaCungCapNL";
            this.colTenNhaCungCapNL.ReadOnly = true;
            // 
            // colMoTaNL
            // 
            this.colMoTaNL.DataPropertyName = "mota";
            this.colMoTaNL.HeaderText = "Mô Tả";
            this.colMoTaNL.Name = "colMoTaNL";
            this.colMoTaNL.ReadOnly = true;
            // 
            // frmNguyenLieu
            // 
            this.AcceptButton = this.btnNLLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(840, 586);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTenNCC);
            this.Controls.Add(this.btnNLLuu);
            this.Controls.Add(this.btnNLSua);
            this.Controls.Add(this.btnNLXoa);
            this.Controls.Add(this.btnNLThem);
            this.Controls.Add(this.txtMoTaNL);
            this.Controls.Add(this.dtpHanSuDungNL);
            this.Controls.Add(this.txtSoLuongTonNL);
            this.Controls.Add(this.txtTenNL);
            this.Controls.Add(this.txtMaNL);
            this.Controls.Add(this.txtTimNL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNguyenLieu";
            this.Text = "Nguyên Liệu";
            this.Load += new System.EventHandler(this.frmNguyenLieu_Load);
            this.Click += new System.EventHandler(this.frmNguyenLieu_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvNL;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimNL;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNL;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuongTonNL;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHanSuDungNL;
        private System.Windows.Forms.RichTextBox txtMoTaNL;
        private Guna.UI2.WinForms.Guna2Button btnNLSua;
        private Guna.UI2.WinForms.Guna2Button btnNLXoa;
        private Guna.UI2.WinForms.Guna2Button btnNLThem;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNL;
        private Guna.UI2.WinForms.Guna2Button btnNLLuu;
        private Guna.UI2.WinForms.Guna2ComboBox cboTenNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTonNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanSuDungNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhaCungCapNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTaNL;
    }
}