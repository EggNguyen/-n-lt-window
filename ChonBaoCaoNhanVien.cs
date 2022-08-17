using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmChonBaoCaoNhanVien : Form
    {
        public frmChonBaoCaoNhanVien()
        {
            InitializeComponent();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            frmXemBaoCaoNhanVien fxembaocaonhanvien = new frmXemBaoCaoNhanVien();

            if (radConLam.Checked)
            {
                fxembaocaonhanvien.NhanVienConLam();
                fxembaocaonhanvien.ShowDialog();
            }
            if (radNghiLam.Checked)
            {
                fxembaocaonhanvien.NhanVienNghiLam();
                fxembaocaonhanvien.ShowDialog();
            }
        }
    }
}
