using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace WindowsFormsApp1
{
    public partial class frmXemBaoCaoNhanVien : Form
    {
        NhanVienBUS nvbus = new NhanVienBUS();
        public frmXemBaoCaoNhanVien()
        {
            InitializeComponent();
        }

        private void XemBaoCaoNhanVien_Load(object sender, EventArgs e)
        {

            this.rpvbaocao.RefreshReport();
        }

        public void NhanVienConLam()
        {
            List<NhanVienDTO> nvdto = nvbus.LayDSNV();
            this.rpvbaocao.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.rptNhanVienConLam.rdlc";
            this.rpvbaocao.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSNhanVienConLam", nvdto));
            
            this.rpvbaocao.RefreshReport();
        }
        public void NhanVienNghiLam()
        {
            List<NhanVienDTO> nvnghilam = nvbus.LayDSNVDANGHI();
            this.rpvbaocao.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.rptNhanVienNghiLam.rdlc";
            this.rpvbaocao.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSNhanVienNghiLam", nvnghilam));

            this.rpvbaocao.RefreshReport();
        }
    }
}
