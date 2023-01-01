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
    public partial class frmChinh : Form
    {

        
        public frmChinh()
        {
            InitializeComponent();
            lock_unlock(Luu.KT);
        }
       
        void lock_unlock(bool kt)
        {
            mnuDangnhap.Enabled = mnuThoat.Enabled = kt;
            mnuDangxuat.Enabled = mnuTracuu.Enabled = mnuDanhmuc.Enabled = mnuBaocao.Enabled = !kt;
        }
        private void mnuDangnhap_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.Show();
        }

        private void frmChinh_Activated(object sender, EventArgs e)
        {
            lock_unlock(Luu.KT);
        }

        private void mnuDangxuat_Click(object sender, EventArgs e)
        {
            frmChinh f = new frmChinh();
            f.Show();
        }

        private void mnuSinhvien_Click(object sender, EventArgs e)
        {
            frmLoai f = new frmLoai();
            f.Show();
        }

        private void mnuTracuuLop_Click(object sender, EventArgs e)
        {
            frmTraCuu f = new frmTraCuu();
            f.Show();
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            frmquanlyhang f = new frmquanlyhang();
            f.Show();
        }

        private void mnuBaocaoSinhVien_Click(object sender, EventArgs e)
        {
            frmDoanhthu f = new frmDoanhthu();
            f.Show();
        }

        
    }
}
