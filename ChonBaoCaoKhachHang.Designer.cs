
namespace WindowsFormsApp1
{
    partial class frmChonBaoCaoKhachHang
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
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.radTheoLoai = new System.Windows.Forms.RadioButton();
            this.btnXemBaoCaoKhachHang = new System.Windows.Forms.Button();
            this.cboLoaiKhachHang = new System.Windows.Forms.ComboBox();
            this.radNhomTheoLoai = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTatCa.Location = new System.Drawing.Point(12, 12);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(166, 24);
            this.radTatCa.TabIndex = 0;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất Cả Khách Hàng";
            this.radTatCa.UseVisualStyleBackColor = true;
            // 
            // radTheoLoai
            // 
            this.radTheoLoai.AutoSize = true;
            this.radTheoLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTheoLoai.Location = new System.Drawing.Point(12, 46);
            this.radTheoLoai.Name = "radTheoLoai";
            this.radTheoLoai.Size = new System.Drawing.Size(97, 24);
            this.radTheoLoai.TabIndex = 1;
            this.radTheoLoai.TabStop = true;
            this.radTheoLoai.Text = "Theo Loại";
            this.radTheoLoai.UseVisualStyleBackColor = true;
            // 
            // btnXemBaoCaoKhachHang
            // 
            this.btnXemBaoCaoKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBaoCaoKhachHang.Location = new System.Drawing.Point(77, 106);
            this.btnXemBaoCaoKhachHang.Name = "btnXemBaoCaoKhachHang";
            this.btnXemBaoCaoKhachHang.Size = new System.Drawing.Size(120, 58);
            this.btnXemBaoCaoKhachHang.TabIndex = 2;
            this.btnXemBaoCaoKhachHang.Text = "Xem Báo Cáo";
            this.btnXemBaoCaoKhachHang.UseVisualStyleBackColor = true;
            this.btnXemBaoCaoKhachHang.Click += new System.EventHandler(this.btnXemBaoCaoKhachHang_Click);
            // 
            // cboLoaiKhachHang
            // 
            this.cboLoaiKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboLoaiKhachHang.FormattingEnabled = true;
            this.cboLoaiKhachHang.Items.AddRange(new object[] {
            "Thành Viên",
            "Đặt Hàng"});
            this.cboLoaiKhachHang.Location = new System.Drawing.Point(115, 49);
            this.cboLoaiKhachHang.Name = "cboLoaiKhachHang";
            this.cboLoaiKhachHang.Size = new System.Drawing.Size(121, 21);
            this.cboLoaiKhachHang.TabIndex = 3;
            // 
            // radNhomTheoLoai
            // 
            this.radNhomTheoLoai.AutoSize = true;
            this.radNhomTheoLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNhomTheoLoai.Location = new System.Drawing.Point(12, 76);
            this.radNhomTheoLoai.Name = "radNhomTheoLoai";
            this.radNhomTheoLoai.Size = new System.Drawing.Size(143, 24);
            this.radNhomTheoLoai.TabIndex = 4;
            this.radNhomTheoLoai.TabStop = true;
            this.radNhomTheoLoai.Text = "Nhóm Theo Loại";
            this.radNhomTheoLoai.UseVisualStyleBackColor = true;
            // 
            // frmChonBaoCaoKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 172);
            this.Controls.Add(this.radNhomTheoLoai);
            this.Controls.Add(this.cboLoaiKhachHang);
            this.Controls.Add(this.btnXemBaoCaoKhachHang);
            this.Controls.Add(this.radTheoLoai);
            this.Controls.Add(this.radTatCa);
            this.Name = "frmChonBaoCaoKhachHang";
            this.Text = "Chọn Loại Báo Cáo";
            this.Load += new System.EventHandler(this.frmChonBaoCaoKhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.RadioButton radTheoLoai;
        private System.Windows.Forms.Button btnXemBaoCaoKhachHang;
        private System.Windows.Forms.ComboBox cboLoaiKhachHang;
        private System.Windows.Forms.RadioButton radNhomTheoLoai;
    }
}