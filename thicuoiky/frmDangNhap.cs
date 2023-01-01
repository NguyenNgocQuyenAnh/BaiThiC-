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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDn_Click(object sender, EventArgs e)
        {
            using (QLGiayEntities db = new QLGiayEntities())
            {
                string s = "select * from DangNhap where MatKhau='" +
                    txtmk.Text + "' and TenDangNhap='" + txttk.Text + "'";
                var list = db.DangNhaps.SqlQuery(s).ToList();
                if (list.Count > 0)
                {
                    MessageBox.Show("đăng nhập thành công", "thông báo");
                    Luu.KT = !Luu.KT;
                    Close();
                }
                else
                {
                    MessageBox.Show("Username hoặc password không đúng", "thông báo");
                }
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
