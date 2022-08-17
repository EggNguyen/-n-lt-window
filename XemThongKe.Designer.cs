
namespace WindowsFormsApp1
{
    partial class frmXemThongKe
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
            this.crvThongKe = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvThongKe
            // 
            this.crvThongKe.ActiveViewIndex = -1;
            this.crvThongKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvThongKe.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvThongKe.Location = new System.Drawing.Point(0, 0);
            this.crvThongKe.Name = "crvThongKe";
            this.crvThongKe.Size = new System.Drawing.Size(800, 450);
            this.crvThongKe.TabIndex = 0;
            // 
            // frmXemThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvThongKe);
            this.Name = "frmXemThongKe";
            this.Text = "Báo Cáo Doanh Thu";
            this.Load += new System.EventHandler(this.XemThongKe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvThongKe;
    }
}