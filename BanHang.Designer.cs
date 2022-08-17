
namespace WindowsFormsApp1
{
    partial class frmBanHang
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
            this.lblBanHang = new System.Windows.Forms.Label();
            this.lblTraLai = new System.Windows.Forms.Label();
            this.lblTienNhan = new System.Windows.Forms.Label();
            this.txtTraLaiBH = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTongThanhTien = new System.Windows.Forms.Label();
            this.txtTongThanhTienBH = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBHXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnBHThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.btnBHThem = new Guna.UI2.WinForms.Guna2Button();
            this.numSanPham = new System.Windows.Forms.NumericUpDown();
            this.dgvBH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBHTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBHSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBHThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTenSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTienNhan = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBanHang
            // 
            this.lblBanHang.AutoSize = true;
            this.lblBanHang.BackColor = System.Drawing.Color.Transparent;
            this.lblBanHang.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanHang.ForeColor = System.Drawing.Color.White;
            this.lblBanHang.Location = new System.Drawing.Point(12, 9);
            this.lblBanHang.Name = "lblBanHang";
            this.lblBanHang.Size = new System.Drawing.Size(181, 47);
            this.lblBanHang.TabIndex = 2;
            this.lblBanHang.Text = "Bán Hàng";
            // 
            // lblTraLai
            // 
            this.lblTraLai.AutoSize = true;
            this.lblTraLai.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraLai.ForeColor = System.Drawing.Color.White;
            this.lblTraLai.Location = new System.Drawing.Point(448, 116);
            this.lblTraLai.Name = "lblTraLai";
            this.lblTraLai.Size = new System.Drawing.Size(76, 30);
            this.lblTraLai.TabIndex = 28;
            this.lblTraLai.Text = "Trả Lại";
            // 
            // lblTienNhan
            // 
            this.lblTienNhan.AutoSize = true;
            this.lblTienNhan.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienNhan.ForeColor = System.Drawing.Color.White;
            this.lblTienNhan.Location = new System.Drawing.Point(409, 160);
            this.lblTienNhan.Name = "lblTienNhan";
            this.lblTienNhan.Size = new System.Drawing.Size(115, 30);
            this.lblTienNhan.TabIndex = 27;
            this.lblTienNhan.Text = "Tiền Nhận";
            // 
            // txtTraLaiBH
            // 
            this.txtTraLaiBH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTraLaiBH.DefaultText = "";
            this.txtTraLaiBH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTraLaiBH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTraLaiBH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraLaiBH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraLaiBH.FillColor = System.Drawing.Color.Gray;
            this.txtTraLaiBH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraLaiBH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraLaiBH.ForeColor = System.Drawing.Color.Black;
            this.txtTraLaiBH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraLaiBH.Location = new System.Drawing.Point(533, 110);
            this.txtTraLaiBH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTraLaiBH.Name = "txtTraLaiBH";
            this.txtTraLaiBH.PasswordChar = '\0';
            this.txtTraLaiBH.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTraLaiBH.PlaceholderText = "";
            this.txtTraLaiBH.ReadOnly = true;
            this.txtTraLaiBH.SelectedText = "";
            this.txtTraLaiBH.Size = new System.Drawing.Size(295, 36);
            this.txtTraLaiBH.TabIndex = 26;
            // 
            // lblTongThanhTien
            // 
            this.lblTongThanhTien.AutoSize = true;
            this.lblTongThanhTien.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongThanhTien.ForeColor = System.Drawing.Color.White;
            this.lblTongThanhTien.Location = new System.Drawing.Point(348, 65);
            this.lblTongThanhTien.Name = "lblTongThanhTien";
            this.lblTongThanhTien.Size = new System.Drawing.Size(180, 30);
            this.lblTongThanhTien.TabIndex = 24;
            this.lblTongThanhTien.Text = "Tổng Thành Tiền";
            // 
            // txtTongThanhTienBH
            // 
            this.txtTongThanhTienBH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongThanhTienBH.DefaultText = "";
            this.txtTongThanhTienBH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongThanhTienBH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongThanhTienBH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongThanhTienBH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongThanhTienBH.FillColor = System.Drawing.Color.Gray;
            this.txtTongThanhTienBH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongThanhTienBH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongThanhTienBH.ForeColor = System.Drawing.Color.Black;
            this.txtTongThanhTienBH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongThanhTienBH.Location = new System.Drawing.Point(533, 59);
            this.txtTongThanhTienBH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongThanhTienBH.Name = "txtTongThanhTienBH";
            this.txtTongThanhTienBH.PasswordChar = '\0';
            this.txtTongThanhTienBH.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTongThanhTienBH.PlaceholderText = "";
            this.txtTongThanhTienBH.ReadOnly = true;
            this.txtTongThanhTienBH.SelectedText = "";
            this.txtTongThanhTienBH.Size = new System.Drawing.Size(295, 36);
            this.txtTongThanhTienBH.TabIndex = 23;
            this.txtTongThanhTienBH.TextChanged += new System.EventHandler(this.txtTongThanhTienBH_TextChanged);
            // 
            // btnBHXoa
            // 
            this.btnBHXoa.BorderRadius = 5;
            this.btnBHXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBHXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBHXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBHXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBHXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnBHXoa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBHXoa.ForeColor = System.Drawing.Color.White;
            this.btnBHXoa.Image = global::WindowsFormsApp1.Properties.Resources.icons8_delete_48;
            this.btnBHXoa.Location = new System.Drawing.Point(20, 237);
            this.btnBHXoa.Name = "btnBHXoa";
            this.btnBHXoa.Size = new System.Drawing.Size(200, 55);
            this.btnBHXoa.TabIndex = 5;
            this.btnBHXoa.Text = "Xóa";
            this.btnBHXoa.Click += new System.EventHandler(this.btnBHXoa_Click);
            // 
            // btnBHThanhToan
            // 
            this.btnBHThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.btnBHThanhToan.BorderRadius = 5;
            this.btnBHThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBHThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBHThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBHThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBHThanhToan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBHThanhToan.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBHThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnBHThanhToan.Image = global::WindowsFormsApp1.Properties.Resources.icons8_cash_euro_48;
            this.btnBHThanhToan.Location = new System.Drawing.Point(648, 208);
            this.btnBHThanhToan.Name = "btnBHThanhToan";
            this.btnBHThanhToan.Size = new System.Drawing.Size(180, 45);
            this.btnBHThanhToan.TabIndex = 7;
            this.btnBHThanhToan.Text = "Thanh Toán";
            this.btnBHThanhToan.Click += new System.EventHandler(this.btnBHThanhToan_Click);
            // 
            // btnBHThem
            // 
            this.btnBHThem.BorderRadius = 5;
            this.btnBHThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBHThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBHThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBHThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBHThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnBHThem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBHThem.ForeColor = System.Drawing.Color.White;
            this.btnBHThem.Image = global::WindowsFormsApp1.Properties.Resources.icons8_plus_math_48;
            this.btnBHThem.Location = new System.Drawing.Point(231, 237);
            this.btnBHThem.Name = "btnBHThem";
            this.btnBHThem.Size = new System.Drawing.Size(164, 55);
            this.btnBHThem.TabIndex = 4;
            this.btnBHThem.Text = "Thêm";
            this.btnBHThem.Click += new System.EventHandler(this.btnBHThem_Click);
            // 
            // numSanPham
            // 
            this.numSanPham.Location = new System.Drawing.Point(231, 178);
            this.numSanPham.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSanPham.Name = "numSanPham";
            this.numSanPham.Size = new System.Drawing.Size(57, 20);
            this.numSanPham.TabIndex = 2;
            this.numSanPham.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvBH
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.dgvBH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBH.ColumnHeadersHeight = 21;
            this.dgvBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colBHTenSP,
            this.colBHSoLuong,
            this.colDonGia,
            this.colBHThanhTien});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBH.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBH.EnableHeadersVisualStyles = false;
            this.dgvBH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBH.Location = new System.Drawing.Point(0, 298);
            this.dgvBH.Name = "dgvBH";
            this.dgvBH.RowHeadersVisible = false;
            this.dgvBH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBH.Size = new System.Drawing.Size(840, 288);
            this.dgvBH.TabIndex = 3;
            this.dgvBH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBH.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.dgvBH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBH.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvBH.ThemeStyle.ReadOnly = false;
            this.dgvBH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBH.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBH_CellClick);
            this.dgvBH.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvBH_RowsAdded);
            // 
            // colMaSP
            // 
            this.colMaSP.HeaderText = "Mã Sản Phẩm";
            this.colMaSP.Name = "colMaSP";
            // 
            // colBHTenSP
            // 
            this.colBHTenSP.HeaderText = "Tên Sản Phẩm";
            this.colBHTenSP.Name = "colBHTenSP";
            this.colBHTenSP.ReadOnly = true;
            // 
            // colBHSoLuong
            // 
            this.colBHSoLuong.HeaderText = "Số Lượng";
            this.colBHSoLuong.Name = "colBHSoLuong";
            this.colBHSoLuong.ReadOnly = true;
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "money";
            dataGridViewCellStyle3.Format = "#,####";
            this.colDonGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDonGia.HeaderText = "Đơn Giá";
            this.colDonGia.Name = "colDonGia";
            // 
            // colBHThanhTien
            // 
            dataGridViewCellStyle4.Format = "#,####";
            this.colBHThanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            this.colBHThanhTien.HeaderText = "Thành Tiền";
            this.colBHThanhTien.Name = "colBHThanhTien";
            this.colBHThanhTien.ReadOnly = true;
            // 
            // cboTenSP
            // 
            this.cboTenSP.BackColor = System.Drawing.Color.Transparent;
            this.cboTenSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTenSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTenSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTenSP.ItemHeight = 30;
            this.cboTenSP.Location = new System.Drawing.Point(28, 173);
            this.cboTenSP.Name = "cboTenSP";
            this.cboTenSP.Size = new System.Drawing.Size(192, 36);
            this.cboTenSP.TabIndex = 1;
            // 
            // txtTienNhan
            // 
            this.txtTienNhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienNhan.DefaultText = "";
            this.txtTienNhan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTienNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTienNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienNhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienNhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienNhan.ForeColor = System.Drawing.Color.Black;
            this.txtTienNhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienNhan.Location = new System.Drawing.Point(533, 160);
            this.txtTienNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTienNhan.MaxLength = 10;
            this.txtTienNhan.Name = "txtTienNhan";
            this.txtTienNhan.PasswordChar = '\0';
            this.txtTienNhan.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTienNhan.PlaceholderText = "";
            this.txtTienNhan.SelectedText = "";
            this.txtTienNhan.Size = new System.Drawing.Size(295, 38);
            this.txtTienNhan.TabIndex = 33;
            this.txtTienNhan.TextChanged += new System.EventHandler(this.txtTienNhan_TextChanged);
            this.txtTienNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienNhan_KeyPress);
            // 
            // frmBanHang
            // 
            this.AcceptButton = this.btnBHThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(840, 586);
            this.Controls.Add(this.txtTienNhan);
            this.Controls.Add(this.cboTenSP);
            this.Controls.Add(this.numSanPham);
            this.Controls.Add(this.btnBHXoa);
            this.Controls.Add(this.btnBHThanhToan);
            this.Controls.Add(this.lblTraLai);
            this.Controls.Add(this.lblTienNhan);
            this.Controls.Add(this.txtTraLaiBH);
            this.Controls.Add(this.lblTongThanhTien);
            this.Controls.Add(this.txtTongThanhTienBH);
            this.Controls.Add(this.btnBHThem);
            this.Controls.Add(this.dgvBH);
            this.Controls.Add(this.lblBanHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBanHang";
            this.Text = "BanHang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.Click += new System.EventHandler(this.frmBanHang_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2Button btnBHThem;
        public Guna.UI2.WinForms.Guna2Button btnBHThanhToan;
        public System.Windows.Forms.Label lblTraLai;
        public System.Windows.Forms.Label lblTienNhan;
        public Guna.UI2.WinForms.Guna2TextBox txtTraLaiBH;
        public System.Windows.Forms.Label lblTongThanhTien;
        public Guna.UI2.WinForms.Guna2TextBox txtTongThanhTienBH;
        public Guna.UI2.WinForms.Guna2Button btnBHXoa;
        public System.Windows.Forms.Label lblBanHang;
        private System.Windows.Forms.NumericUpDown numSanPham;
        public Guna.UI2.WinForms.Guna2DataGridView dgvBH;
        private Guna.UI2.WinForms.Guna2ComboBox cboTenSP;
        public Guna.UI2.WinForms.Guna2TextBox txtTienNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBHTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBHSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBHThanhTien;
    }
}