
namespace WindowsFormsApp1
{
    partial class frmChonBaoCaoNhanVien
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
            this.radConLam = new System.Windows.Forms.RadioButton();
            this.radNghiLam = new System.Windows.Forms.RadioButton();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radConLam
            // 
            this.radConLam.AutoSize = true;
            this.radConLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radConLam.Location = new System.Drawing.Point(3, 12);
            this.radConLam.Name = "radConLam";
            this.radConLam.Size = new System.Drawing.Size(204, 24);
            this.radConLam.TabIndex = 0;
            this.radConLam.TabStop = true;
            this.radConLam.Text = "Nhân Viên Còn Làm Việc";
            this.radConLam.UseVisualStyleBackColor = true;
            // 
            // radNghiLam
            // 
            this.radNghiLam.AutoSize = true;
            this.radNghiLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNghiLam.Location = new System.Drawing.Point(3, 47);
            this.radNghiLam.Name = "radNghiLam";
            this.radNghiLam.Size = new System.Drawing.Size(197, 24);
            this.radNghiLam.TabIndex = 1;
            this.radNghiLam.TabStop = true;
            this.radNghiLam.Text = "Nhân Viên Đã Nghỉ Việc";
            this.radNghiLam.UseVisualStyleBackColor = true;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Location = new System.Drawing.Point(51, 92);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(98, 58);
            this.btnXemBaoCao.TabIndex = 2;
            this.btnXemBaoCao.Text = "Xem Báo Cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // frmChonBaoCaoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 162);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.radNghiLam);
            this.Controls.Add(this.radConLam);
            this.Name = "frmChonBaoCaoNhanVien";
            this.Text = "Chọn báo Cáo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radConLam;
        private System.Windows.Forms.RadioButton radNghiLam;
        private System.Windows.Forms.Button btnXemBaoCao;
    }
}