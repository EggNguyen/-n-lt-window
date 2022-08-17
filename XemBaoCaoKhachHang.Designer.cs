
namespace WindowsFormsApp1
{
    partial class frmXemBaoCaoKhachHang
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
            this.rpvXemBaoCaoKhachHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvXemBaoCaoKhachHang
            // 
            this.rpvXemBaoCaoKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvXemBaoCaoKhachHang.Location = new System.Drawing.Point(0, 0);
            this.rpvXemBaoCaoKhachHang.Name = "rpvXemBaoCaoKhachHang";
            this.rpvXemBaoCaoKhachHang.ServerReport.BearerToken = null;
            this.rpvXemBaoCaoKhachHang.Size = new System.Drawing.Size(800, 450);
            this.rpvXemBaoCaoKhachHang.TabIndex = 0;
            // 
            // frmXemBaoCaoKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvXemBaoCaoKhachHang);
            this.Name = "frmXemBaoCaoKhachHang";
            this.Text = "Xem Báo Cáo Khách Hàng";
            this.Load += new System.EventHandler(this.XemBaoCaoKhachHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvXemBaoCaoKhachHang;
    }
}