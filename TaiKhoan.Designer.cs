
namespace WindowsFormsApp1
{
    partial class frmTaiKhoan
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
            this.dgvTK = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colTenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTaoTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiTK = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNVTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboLoaiTaiKhoanTK = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnTKSua = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.txtGhiChuTK = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTK
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.dgvTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTK.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTK.ColumnHeadersHeight = 21;
            this.dgvTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenTK,
            this.colNgayTaoTK,
            this.colLoaiTK,
            this.colGhiChu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTK.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTK.EnableHeadersVisualStyles = false;
            this.dgvTK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTK.Location = new System.Drawing.Point(0, 182);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.RowHeadersVisible = false;
            this.dgvTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTK.Size = new System.Drawing.Size(840, 404);
            this.dgvTK.TabIndex = 13;
            this.dgvTK.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTK.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTK.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTK.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTK.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTK.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.dgvTK.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTK.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTK.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTK.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTK.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTK.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTK.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvTK.ThemeStyle.ReadOnly = false;
            this.dgvTK.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTK.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTK.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTK.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTK.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTK.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTK.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTK_CellClick);
            // 
            // colTenTK
            // 
            this.colTenTK.DataPropertyName = "tk_manv";
            this.colTenTK.HeaderText = "Tài Khoản (Mã Nhân Viên)";
            this.colTenTK.Name = "colTenTK";
            this.colTenTK.ReadOnly = true;
            // 
            // colNgayTaoTK
            // 
            this.colNgayTaoTK.DataPropertyName = "tk_ngaytao";
            this.colNgayTaoTK.HeaderText = "Ngày Tạo";
            this.colNgayTaoTK.Name = "colNgayTaoTK";
            this.colNgayTaoTK.ReadOnly = true;
            // 
            // colLoaiTK
            // 
            this.colLoaiTK.DataPropertyName = "tk_maloai";
            this.colLoaiTK.HeaderText = "Loại Tài Khoản";
            this.colLoaiTK.Name = "colLoaiTK";
            this.colLoaiTK.ReadOnly = true;
            this.colLoaiTK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLoaiTK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colGhiChu
            // 
            this.colGhiChu.DataPropertyName = "tk_ghichu";
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.Name = "colGhiChu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 47);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tài Khoản";
            // 
            // txtMaNVTK
            // 
            this.txtMaNVTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNVTK.DefaultText = "";
            this.txtMaNVTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNVTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNVTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNVTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNVTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNVTK.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNVTK.ForeColor = System.Drawing.Color.Black;
            this.txtMaNVTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNVTK.Location = new System.Drawing.Point(218, 20);
            this.txtMaNVTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNVTK.Name = "txtMaNVTK";
            this.txtMaNVTK.PasswordChar = '\0';
            this.txtMaNVTK.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaNVTK.PlaceholderText = "Mã Nhân Viên";
            this.txtMaNVTK.SelectedText = "";
            this.txtMaNVTK.Size = new System.Drawing.Size(203, 36);
            this.txtMaNVTK.TabIndex = 1;
            // 
            // cboLoaiTaiKhoanTK
            // 
            this.cboLoaiTaiKhoanTK.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiTaiKhoanTK.BorderRadius = 5;
            this.cboLoaiTaiKhoanTK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiTaiKhoanTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiTaiKhoanTK.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiTaiKhoanTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiTaiKhoanTK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoaiTaiKhoanTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoaiTaiKhoanTK.ItemHeight = 30;
            this.cboLoaiTaiKhoanTK.Items.AddRange(new object[] {
            "Nhân Viên",
            "Admin"});
            this.cboLoaiTaiKhoanTK.Location = new System.Drawing.Point(427, 20);
            this.cboLoaiTaiKhoanTK.Name = "cboLoaiTaiKhoanTK";
            this.cboLoaiTaiKhoanTK.Size = new System.Drawing.Size(204, 36);
            this.cboLoaiTaiKhoanTK.TabIndex = 3;
            // 
            // btnTKSua
            // 
            this.btnTKSua.BorderRadius = 5;
            this.btnTKSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTKSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTKSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTKSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTKSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnTKSua.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKSua.ForeColor = System.Drawing.Color.White;
            this.btnTKSua.Image = global::WindowsFormsApp1.Properties.Resources.icons8_edit_48;
            this.btnTKSua.Location = new System.Drawing.Point(637, 20);
            this.btnTKSua.Name = "btnTKSua";
            this.btnTKSua.Size = new System.Drawing.Size(191, 45);
            this.btnTKSua.TabIndex = 8;
            this.btnTKSua.Text = "Sửa";
            this.btnTKSua.Click += new System.EventHandler(this.btnTKSua_Click);
            // 
            // txtTimTK
            // 
            this.txtTimTK.BackColor = System.Drawing.Color.Transparent;
            this.txtTimTK.BorderRadius = 5;
            this.txtTimTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimTK.DefaultText = "";
            this.txtTimTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimTK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.txtTimTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimTK.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTK.ForeColor = System.Drawing.Color.White;
            this.txtTimTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimTK.IconRight = global::WindowsFormsApp1.Properties.Resources.icons8_search_48;
            this.txtTimTK.Location = new System.Drawing.Point(12, 139);
            this.txtTimTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimTK.Name = "txtTimTK";
            this.txtTimTK.PasswordChar = '\0';
            this.txtTimTK.PlaceholderText = "Tìm Kiếm";
            this.txtTimTK.SelectedText = "";
            this.txtTimTK.Size = new System.Drawing.Size(200, 36);
            this.txtTimTK.TabIndex = 12;
            this.txtTimTK.TextChanged += new System.EventHandler(this.txtTimTK_TextChanged);
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
            this.btnLuu.Location = new System.Drawing.Point(637, 130);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(191, 45);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtGhiChuTK
            // 
            this.txtGhiChuTK.Location = new System.Drawing.Point(218, 62);
            this.txtGhiChuTK.Multiline = true;
            this.txtGhiChuTK.Name = "txtGhiChuTK";
            this.txtGhiChuTK.Size = new System.Drawing.Size(413, 113);
            this.txtGhiChuTK.TabIndex = 20;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(840, 586);
            this.Controls.Add(this.txtGhiChuTK);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTKSua);
            this.Controls.Add(this.cboLoaiTaiKhoanTK);
            this.Controls.Add(this.txtMaNVTK);
            this.Controls.Add(this.txtTimTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTaiKhoan";
            this.Text = "Tài Khoản";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            this.Click += new System.EventHandler(this.frmTaiKhoan_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimTK;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNVTK;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiTaiKhoanTK;
        private Guna.UI2.WinForms.Guna2Button btnTKSua;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTaoTK;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLoaiTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        public Guna.UI2.WinForms.Guna2DataGridView dgvTK;
        private System.Windows.Forms.TextBox txtGhiChuTK;
    }
}