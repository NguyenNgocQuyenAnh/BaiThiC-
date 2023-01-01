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
    public partial class frmLoai : Form
    {
        loai model = new loai();
        public frmLoai()
        {
            InitializeComponent();
            loadDataToGrv();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
        void loadDataToGrv()
        {
            dgvloai.AutoGenerateColumns = false;
            using (QLGiayEntities db = new QLGiayEntities())
            {
                dgvloai.DataSource = Luu.CreateDataTable<loai>(db.loais.ToList<loai>());
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            model.maloai = txtmaloai.Text;
            model.tenloai = txtloai.Text;
            using (QLGiayEntities db = new QLGiayEntities())
            {
                db.loais.Add(model);
                db.SaveChanges();
                MessageBox.Show("thêm thành công", "thông báo");
                txtmaloai.Text = "";
                txtloai.Text = "";
                loadDataToGrv();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            model.maloai = txtmaloai.Text;
            model.tenloai = txtloai.Text;
            using (QLGiayEntities db = new QLGiayEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("update thành công", "thông báo");
                txtloai.Text = "";
                btndelete.Enabled = btnupdate.Enabled = false;
                btnadd.Enabled = true;
                loadDataToGrv();
            }
        }

        private void dgvloai_Click(object sender, EventArgs e)
        {

            int i = dgvloai.CurrentRow.Index;
            txtmaloai.Text = dgvloai[1, i].Value.ToString();
            txtloai.Text = dgvloai[2, i].Value.ToString();
            btndelete.Enabled = btnupdate.Enabled = true;
            btnadd.Enabled = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            model.maloai = txtmaloai.Text;
            model.tenloai = txtloai.Text;
            using (QLGiayEntities db = new QLGiayEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                MessageBox.Show("delete thành công", "thông báo");
                txtloai.Text = "";
                btndelete.Enabled = btnupdate.Enabled = false;
                btnadd.Enabled = true;
                loadDataToGrv();
            }
        }
    }
}
