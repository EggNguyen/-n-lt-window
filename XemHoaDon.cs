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
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp1
{
    public partial class frmXemHoaDon : Form
    {
        ChiTietHoaDonBUS cthdbus = new ChiTietHoaDonBUS();
        HoaDonBUS hdbus = new HoaDonBUS();
        public frmXemHoaDon()
        {
            InitializeComponent();
        }

        private void frmXemHoaDon_Load(object sender, EventArgs e)
        {
            cboMaHD.DisplayMember = "mahd";
            cboMaHD.DataSource = hdbus.LayDSHD();
            this.rpvHoaDon.RefreshReport();
        }
        public void HoaDon(HoaDonDTO hd)
        {

            List<ChiTietHoaDonDTO> cthd = cthdbus.LayDSCTHD(hd.mahd);
            this.rpvHoaDon.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.rptHoaDon.rdlc";
            this.rpvHoaDon.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("ChiTietHoaDon", cthd));
            this.rpvHoaDon.LocalReport.SetParameters(new ReportParameter("paNgayLap", hd.ngaylap.ToString()));
            this.rpvHoaDon.LocalReport.SetParameters(new ReportParameter("paNhanVien", frmLogin.mainHoTen.ToString()));
            this.rpvHoaDon.LocalReport.SetParameters(new ReportParameter("paNgayIn", DateTime.Now.ToString()));
            this.rpvHoaDon.LocalReport.SetParameters(new ReportParameter("paTienNhan", hd.khachtra.ToString()));
            this.rpvHoaDon.LocalReport.SetParameters(new ReportParameter("paTraLai", hd.thoilai.ToString()));

            this.rpvHoaDon.RefreshReport();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            HoaDon((HoaDonDTO)cboMaHD.SelectedItem);
        }
    }
}
