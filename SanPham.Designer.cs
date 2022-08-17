
namespace WindowsFormsApp1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvQLSP = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colSPMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSPTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSPGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhapSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSPMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGiaSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMASP = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuuSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaSP = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboMoTaSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpNgayNhapSP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQLSP
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvQLSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLSP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.dgvQLSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLSP.ColumnHeadersHeight = 21;
            this.dgvQLSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSPMaSP,
            this.colSPTenSP,
            this.colSPGia,
            this.colNgayNhapSP,
            this.colSPMoTa});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLSP.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvQLSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvQLSP.EnableHeadersVisualStyles = false;
            this.dgvQLSP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLSP.Location = new System.Drawing.Point(0, 257);
            this.dgvQLSP.Name = "dgvQLSP";
            this.dgvQLSP.RowHeadersVisible = false;
            this.dgvQLSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLSP.Size = new System.Drawing.Size(840, 329);
            this.dgvQLSP.TabIndex = 10;
            this.dgvQLSP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLSP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQLSP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQLSP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQLSP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQLSP.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.dgvQLSP.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLSP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQLSP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQLSP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLSP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQLSP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvQLSP.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvQLSP.ThemeStyle.ReadOnly = false;
            this.dgvQLSP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLSP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLSP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLSP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLSP.ThemeStyle.RowsStyle.Height = 22;
            this.dgvQLSP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLSP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLSP_CellClick);
            // 
            // colSPMaSP
            // 
            this.colSPMaSP.DataPropertyName = "TRASUA_MATS";
            this.colSPMaSP.FillWeight = 67.19145F;
            this.colSPMaSP.HeaderText = "Mã Sản Phẩm";
            this.colSPMaSP.Name = "colSPMaSP";
            this.colSPMaSP.ReadOnly = true;
            // 
            // colSPTenSP
            // 
            this.colSPTenSP.DataPropertyName = "TRASUA_TEN";
            this.colSPTenSP.FillWeight = 152.2843F;
            this.colSPTenSP.HeaderText = "Tên Sản Phẩm";
            this.colSPTenSP.Name = "colSPTenSP";
            this.colSPTenSP.ReadOnly = true;
            // 
            // colSPGia
            // 
            this.colSPGia.DataPropertyName = "TRASUA_GIA";
            dataGridViewCellStyle3.Format = "#,###";
            dataGridViewCellStyle3.NullValue = "0";
            this.colSPGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSPGia.FillWeight = 93.5081F;
            this.colSPGia.HeaderText = "Giá";
            this.colSPGia.Name = "colSPGia";
            this.colSPGia.ReadOnly = true;
            // 
            // colNgayNhapSP
            // 
            this.colNgayNhapSP.DataPropertyName = "TRASUA_NGAYTAO";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.colNgayNhapSP.DefaultCellStyle = dataGridViewCellStyle4;
            this.colNgayNhapSP.FillWeight = 93.5081F;
            this.colNgayNhapSP.HeaderText = "Ngày Tạo";
            this.colNgayNhapSP.Name = "colNgayNhapSP";
            this.colNgayNhapSP.ReadOnly = true;
            // 
            // colSPMoTa
            // 
            this.colSPMoTa.DataPropertyName = "TRASUA_MOTA";
            this.colSPMoTa.FillWeight = 93.5081F;
            this.colSPMoTa.HeaderText = "Mô Tả";
            this.colSPMoTa.Name = "colSPMoTa";
            this.colSPMoTa.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sản Phẩm";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.DefaultText = "";
            this.txtTenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.ForeColor = System.Drawing.Color.Black;
            this.txtTenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.Location = new System.Drawing.Point(369, 54);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.PasswordChar = '\0';
            this.txtTenSP.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenSP.PlaceholderText = "Tên Sản Phẩm";
            this.txtTenSP.SelectedText = "";
            this.txtTenSP.Size = new System.Drawing.Size(268, 36);
            this.txtTenSP.TabIndex = 2;
            this.txtTenSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenSP_KeyPress);
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaSP.DefaultText = "";
            this.txtGiaSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaSP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaSP.ForeColor = System.Drawing.Color.Black;
            this.txtGiaSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaSP.Location = new System.Drawing.Point(251, 95);
            this.txtGiaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.PasswordChar = '\0';
            this.txtGiaSP.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGiaSP.PlaceholderText = "Giá";
            this.txtGiaSP.SelectedText = "";
            this.txtGiaSP.Size = new System.Drawing.Size(112, 36);
            this.txtGiaSP.TabIndex = 3;
            this.txtGiaSP.TextChanged += new System.EventHandler(this.txtGiaSP_TextChanged);
            this.txtGiaSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaSP_KeyPress);
            // 
            // txtMASP
            // 
            this.txtMASP.BackColor = System.Drawing.Color.Gray;
            this.txtMASP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMASP.DefaultText = "";
            this.txtMASP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMASP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMASP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMASP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMASP.FillColor = System.Drawing.Color.Gray;
            this.txtMASP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMASP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMASP.ForeColor = System.Drawing.Color.Black;
            this.txtMASP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMASP.Location = new System.Drawing.Point(251, 54);
            this.txtMASP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMASP.Name = "txtMASP";
            this.txtMASP.PasswordChar = '\0';
            this.txtMASP.PlaceholderText = "";
            this.txtMASP.ReadOnly = true;
            this.txtMASP.SelectedText = "";
            this.txtMASP.Size = new System.Drawing.Size(112, 36);
            this.txtMASP.TabIndex = 1;
            // 
            // btnLuuSP
            // 
            this.btnLuuSP.BorderRadius = 5;
            this.btnLuuSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnLuuSP.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuSP.ForeColor = System.Drawing.Color.White;
            this.btnLuuSP.Image = global::WindowsFormsApp1.Properties.Resources.icons8_save_48__1_;
            this.btnLuuSP.ImageOffset = new System.Drawing.Point(0, 2);
            this.btnLuuSP.Location = new System.Drawing.Point(660, 214);
            this.btnLuuSP.Name = "btnLuuSP";
            this.btnLuuSP.Size = new System.Drawing.Size(168, 36);
            this.btnLuuSP.TabIndex = 9;
            this.btnLuuSP.Text = "Lưu";
            this.btnLuuSP.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BorderRadius = 5;
            this.btnThemSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Image = global::WindowsFormsApp1.Properties.Resources.icons8_plus_math_48;
            this.btnThemSP.Location = new System.Drawing.Point(660, 54);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(168, 36);
            this.btnThemSP.TabIndex = 6;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BorderRadius = 5;
            this.btnXoaSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnXoaSP.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.ForeColor = System.Drawing.Color.White;
            this.btnXoaSP.Image = global::WindowsFormsApp1.Properties.Resources.icons8_delete_48;
            this.btnXoaSP.Location = new System.Drawing.Point(660, 137);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(168, 36);
            this.btnXoaSP.TabIndex = 8;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.BorderRadius = 5;
            this.btnSuaSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnSuaSP.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSP.ForeColor = System.Drawing.Color.White;
            this.btnSuaSP.Image = global::WindowsFormsApp1.Properties.Resources.icons8_edit_48;
            this.btnSuaSP.Location = new System.Drawing.Point(660, 96);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(168, 35);
            this.btnSuaSP.TabIndex = 7;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // txtTimSP
            // 
            this.txtTimSP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTimSP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTimSP.BackColor = System.Drawing.Color.Transparent;
            this.txtTimSP.BorderRadius = 5;
            this.txtTimSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimSP.DefaultText = "";
            this.txtTimSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.txtTimSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimSP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimSP.ForeColor = System.Drawing.Color.White;
            this.txtTimSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimSP.IconRight = global::WindowsFormsApp1.Properties.Resources.icons8_search_48;
            this.txtTimSP.Location = new System.Drawing.Point(20, 214);
            this.txtTimSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimSP.Name = "txtTimSP";
            this.txtTimSP.PasswordChar = '\0';
            this.txtTimSP.PlaceholderText = "Tìm Kiếm";
            this.txtTimSP.SelectedText = "";
            this.txtTimSP.Size = new System.Drawing.Size(200, 36);
            this.txtTimSP.TabIndex = 11;
            this.txtTimSP.TextChanged += new System.EventHandler(this.txtTimSP_TextChanged);
            // 
            // cboMoTaSP
            // 
            this.cboMoTaSP.BackColor = System.Drawing.Color.Transparent;
            this.cboMoTaSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMoTaSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoTaSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMoTaSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMoTaSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMoTaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboMoTaSP.ItemHeight = 30;
            this.cboMoTaSP.Items.AddRange(new object[] {
            "Top Sale",
            "Ngon",
            "Ít Người Mua"});
            this.cboMoTaSP.Location = new System.Drawing.Point(495, 95);
            this.cboMoTaSP.Name = "cboMoTaSP";
            this.cboMoTaSP.Size = new System.Drawing.Size(142, 36);
            this.cboMoTaSP.TabIndex = 5;
            // 
            // dtpNgayNhapSP
            // 
            this.dtpNgayNhapSP.Checked = true;
            this.dtpNgayNhapSP.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayNhapSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.dtpNgayNhapSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayNhapSP.ForeColor = System.Drawing.Color.White;
            this.dtpNgayNhapSP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhapSP.Location = new System.Drawing.Point(369, 95);
            this.dtpNgayNhapSP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayNhapSP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayNhapSP.Name = "dtpNgayNhapSP";
            this.dtpNgayNhapSP.Size = new System.Drawing.Size(120, 36);
            this.dtpNgayNhapSP.TabIndex = 4;
            this.dtpNgayNhapSP.Value = new System.DateTime(2022, 6, 25, 0, 0, 0, 0);
            // 
            // frmSanPham
            // 
            this.AcceptButton = this.btnLuuSP;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(840, 586);
            this.Controls.Add(this.cboMoTaSP);
            this.Controls.Add(this.btnLuuSP);
            this.Controls.Add(this.txtMASP);
            this.Controls.Add(this.dtpNgayNhapSP);
            this.Controls.Add(this.txtGiaSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnSuaSP);
            this.Controls.Add(this.txtTimSP);
            this.Controls.Add(this.dgvQLSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSanPham";
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.Click += new System.EventHandler(this.frmSanPham_Click);
            this.DoubleClick += new System.EventHandler(this.frmSanPham_DoubleClick_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtTimSP;
        private Guna.UI2.WinForms.Guna2Button btnSuaSP;
        private Guna.UI2.WinForms.Guna2Button btnXoaSP;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2Button btnThemSP;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSP;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaSP;
        private Guna.UI2.WinForms.Guna2TextBox txtMASP;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLSP;
        private Guna.UI2.WinForms.Guna2Button btnLuuSP;
        private Guna.UI2.WinForms.Guna2ComboBox cboMoTaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSPMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSPTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSPGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhapSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSPMoTa;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayNhapSP;
    }
}