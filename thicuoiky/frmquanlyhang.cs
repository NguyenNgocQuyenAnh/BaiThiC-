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
    public partial class frmquanlyhang : Form
    {
        giay model = new giay();
        public frmquanlyhang()
        {
            InitializeComponent();
            loadDataToGrv();
            loadDataToCmb();
        }
        void loadDataToGrv()
        {
            dgvH.AutoGenerateColumns = false;
            using (QLGiayEntities db = new QLGiayEntities())
            {
                
                    dgvH.DataSource = Luu.CreateDataTable<giay>(db.giays.ToList<giay>());
      
            }
        }
        void loadDataToCmb()
        {
            using (QLGiayEntities db = new QLGiayEntities())
            {
                var list = db.loais.ToList();
                foreach (var item in list)
                {
                    cmbmaloai.Items.Add(item.maloai);
                }
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            model.magiay = txtmah.Text;
            model.maloai = cmbmaloai.SelectedItem.ToString();
            model.tengiay = txttenh.Text;
            model.gia = long.Parse(txtgia.Text);
            model.soluong = long.Parse(txtsl.Text);
            model.anh = txtanh.Text;
            using (QLGiayEntities db = new QLGiayEntities())
            {
                db.giays.Add(model);
                db.SaveChanges();
                MessageBox.Show("thêm thành công", "thông báo");
                txtmah.Text = txttenh.Text= txtgia.Text = txtsl.Text = "";
                cmbmaloai.Text = "*";
                pictureBox1.Image = null;
                loadDataToGrv();
            }
        }

        private void choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlgOpen.FileName);
                txtanh.Text = dlgOpen.FileName;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            model.magiay = txtmah.Text;
            model.maloai = cmbmaloai.SelectedItem.ToString();
            model.tengiay = txttenh.Text;
            model.gia = long.Parse(txtgia.Text);
            model.soluong = long.Parse(txtsl.Text);
            model.anh = txtanh.Text;
            using (QLGiayEntities db = new QLGiayEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("update thành công", "thông báo");
                txtmah.Text = txttenh.Text = txtgia.Text = txtsl.Text = "";
                cmbmaloai.Text = "*";
                pictureBox1.Image = null;
                btnadd.Enabled = false;
                btndelete.Enabled = btnupdate.Enabled = false;
                loadDataToGrv();
            }
        }

        private void dgvH_Click(object sender, EventArgs e)
        {
            int i = dgvH.CurrentRow.Index;
            txtmah.Text = dgvH[1, i].Value.ToString();
            cmbmaloai.Text = dgvH[2, i].Value.ToString();
            txttenh.Text = dgvH[3, i].Value.ToString();
            txtgia.Text = dgvH[4, i].Value.ToString();
            txtsl.Text = dgvH[5, i].Value.ToString();
            
            btnadd.Enabled = false;
            btndelete.Enabled = btnupdate.Enabled = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            model.magiay = txtmah.Text;
            model.maloai = cmbmaloai.SelectedItem.ToString();
            model.tengiay = txttenh.Text;
            model.gia = long.Parse(txtgia.Text);
            model.soluong = long.Parse(txtsl.Text);
            model.anh = txtanh.Text;
            using (QLGiayEntities db = new QLGiayEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                MessageBox.Show("delete thành công", "thông báo");
                txtmah.Text = txttenh.Text = txtgia.Text = txtsl.Text = "";
                cmbmaloai.Text = "*";
                pictureBox1.Image = null;
                btnadd.Enabled = false;
                loadDataToGrv();
            }
        }
    }
}
