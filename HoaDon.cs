using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace WindowsFormsApp1
{
    public partial class frmHoaDon : Form
    {
        HoaDonBUS hdbus = new HoaDonBUS();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.AutoGenerateColumns = false;
            dgvCTHoaDon.AutoGenerateColumns = false;
            
            
            dgvHoaDon.DataSource = hdbus.LayDSHD();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string constr = @"Data Source=DESKTOP-MVNUEV2\SQLEXPRESS;Initial Catalog=QuanLyCuaHangTraSua;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";

            //SqlConnection conn = new SqlConnection(constr);

            //conn.Open();
            //SqlCommand cmd = new SqlCommand();

            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "SP_HienThiChiTietHoaDon";
            //cmd.Parameters.AddWithValue("@mahoadon", dgvHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString());
            //cmd.Connection = conn;

            //object kq = cmd.ExecuteNonQuery();
            dgvCTHoaDon.DataSource = hdbus.LayDSCTHD(dgvHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            frmXemHoaDon fxemhoadon = new frmXemHoaDon();
            fxemhoadon.ShowDialog();
        }
    }
}
