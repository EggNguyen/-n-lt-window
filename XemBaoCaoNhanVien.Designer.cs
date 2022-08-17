
namespace WindowsFormsApp1
{
    partial class frmXemBaoCaoNhanVien
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
            this.rpvbaocao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvbaocao
            // 
            this.rpvbaocao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvbaocao.Location = new System.Drawing.Point(0, 0);
            this.rpvbaocao.Name = "rpvbaocao";
            this.rpvbaocao.ServerReport.BearerToken = null;
            this.rpvbaocao.Size = new System.Drawing.Size(800, 450);
            this.rpvbaocao.TabIndex = 0;
            // 
            // frmXemBaoCaoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvbaocao);
            this.Name = "frmXemBaoCaoNhanVien";
            this.Text = "XemBaoCaoNhanVien";
            this.Load += new System.EventHandler(this.XemBaoCaoNhanVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvbaocao;
    }
}