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

namespace thicuoiky
{
    public partial class frmDoanhthu : Form
    {
        string chuoiketnoi = "Server =LAPTOP-MB50MFR1 ; Initial Catalog = QLGiay; User ID = sa;" + "Password = Ron25251325";
        SqlConnection con = new SqlConnection();
        public frmDoanhthu()
        {
            InitializeComponent();
           // loadDataToGrv();
        }
        private void ketnoicsdl()
        {
            try
            {
                con = new SqlConnection(chuoiketnoi);
                con.Open();
                // MessageBox.Show("Kết nối thành công");
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại");
            }
        }

        private void loaddulieu()
        {
            string sql = "select * from lichsu";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvdoanhthu.DataSource = dt;
        }
        private DataTable loadtongtien()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select SUM(Doanhthu) from doanhthu", con);
            da.Fill(dt);
            return dt;
        }

        private void frmDoanhthu_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            loaddulieu();
            loadtongtien();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (radten.Checked)
            {
                string sql = "select * from lichsu where tengiay like N'%" + txttim.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvdoanhthu.DataSource = dt;
            }
            else if (radngay.Checked)
            { 
                try
                {
                    int nam = dtngay.Value.Year;
                    int thang = dtngay.Value.Month;
                    int ngay = dtdenngay.Value.Day;
                    int dnam = dtdenngay.Value.Year;
                    int dthang = dtdenngay.Value.Month;
                    int dngay = dtngay.Value.Day;
                  //  MessageBox.Show("" + ngay+ " " + thang+ " " + nam + "///" + dngay + " " + dthang + " " + dnam);
                    // MessageBox.Show("Ngày:" + nam + "/" + thang + "/" + ngay);
                    string sql = "select * from lichsu where NgayMua between'"
                     + dthang + '/' + dngay + '/' + dnam + "' and'" + thang + '/' + ngay + '/' + nam +"'";

                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvdoanhthu.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Lỗi !");
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void lbsum_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvsum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
