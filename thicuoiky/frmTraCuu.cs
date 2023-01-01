using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thicuoiky
{
    public partial class frmTraCuu : Form
    {
        public frmTraCuu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (radten.Checked)
            {
                using (QLGiayEntities db = new QLGiayEntities())
                {
                    dgvH.DataSource = Luu.CreateDataTable<giay>(db.giays.SqlQuery("select * from giay where tengiay like N'%"
                    + txttim.Text + "%'").ToList());
                }
            }
            if (radloai.Checked)
            {
                using (QLGiayEntities db = new QLGiayEntities())
                {
                    dgvH.DataSource = Luu.CreateDataTable<giay>(db.giays.SqlQuery("select * from giay where maloai like N'%"
                    + txttim.Text+"%'").ToList());
                }
            }
        }
    }
}
