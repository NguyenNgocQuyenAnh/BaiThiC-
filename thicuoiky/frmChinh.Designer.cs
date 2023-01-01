namespace thicuoiky
{
    partial class frmChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHethong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSinhvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTracuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTracuuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTracuuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudoanhthu = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHethong,
            this.mnuDanhmuc,
            this.mnuTracuu,
            this.mnuBaocao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(963, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHethong
            // 
            this.mnuHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangnhap,
            this.mnuDangxuat,
            this.mnuThoat});
            this.mnuHethong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuHethong.Name = "mnuHethong";
            this.mnuHethong.Size = new System.Drawing.Size(133, 36);
            this.mnuHethong.Text = "Hệ thống";
            // 
            // mnuDangnhap
            // 
            this.mnuDangnhap.Name = "mnuDangnhap";
            this.mnuDangnhap.Size = new System.Drawing.Size(227, 36);
            this.mnuDangnhap.Text = "Đăng nhập";
            this.mnuDangnhap.Click += new System.EventHandler(this.mnuDangnhap_Click);
            // 
            // mnuDangxuat
            // 
            this.mnuDangxuat.Name = "mnuDangxuat";
            this.mnuDangxuat.Size = new System.Drawing.Size(227, 36);
            this.mnuDangxuat.Text = "Đăng xuất";
            this.mnuDangxuat.Click += new System.EventHandler(this.mnuDangxuat_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(227, 36);
            this.mnuThoat.Text = "Thoát";
            // 
            // mnuDanhmuc
            // 
            this.mnuDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLop,
            this.mnuSinhvien,
            this.quảnLýNhânViênToolStripMenuItem});
            this.mnuDanhmuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuDanhmuc.Name = "mnuDanhmuc";
            this.mnuDanhmuc.Size = new System.Drawing.Size(143, 36);
            this.mnuDanhmuc.Text = "Danh mục";
            // 
            // mnuLop
            // 
            this.mnuLop.Name = "mnuLop";
            this.mnuLop.Size = new System.Drawing.Size(309, 36);
            this.mnuLop.Text = "Quản lý hàng";
            this.mnuLop.Click += new System.EventHandler(this.mnuLop_Click);
            // 
            // mnuSinhvien
            // 
            this.mnuSinhvien.Name = "mnuSinhvien";
            this.mnuSinhvien.Size = new System.Drawing.Size(309, 36);
            this.mnuSinhvien.Text = "Quản lý loại";
            this.mnuSinhvien.Click += new System.EventHandler(this.mnuSinhvien_Click);
            // 
            // mnuTracuu
            // 
            this.mnuTracuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTracuuLop,
            this.mnuTracuuSinhVien});
            this.mnuTracuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuTracuu.Name = "mnuTracuu";
            this.mnuTracuu.Size = new System.Drawing.Size(112, 36);
            this.mnuTracuu.Text = "Tra cứu";
            // 
            // mnuTracuuLop
            // 
            this.mnuTracuuLop.Name = "mnuTracuuLop";
            this.mnuTracuuLop.Size = new System.Drawing.Size(239, 36);
            this.mnuTracuuLop.Text = "Hàng";
            this.mnuTracuuLop.Click += new System.EventHandler(this.mnuTracuuLop_Click);
            // 
            // mnuTracuuSinhVien
            // 
            this.mnuTracuuSinhVien.Name = "mnuTracuuSinhVien";
            this.mnuTracuuSinhVien.Size = new System.Drawing.Size(239, 36);
            this.mnuTracuuSinhVien.Text = "Khách Hàng";
            // 
            // mnuBaocao
            // 
            this.mnuBaocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnudoanhthu});
            this.mnuBaocao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuBaocao.Name = "mnuBaocao";
            this.mnuBaocao.Size = new System.Drawing.Size(133, 36);
            this.mnuBaocao.Text = "Thống kê";
            // 
            // mnudoanhthu
            // 
            this.mnudoanhthu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnudoanhthu.Name = "mnudoanhthu";
            this.mnudoanhthu.Size = new System.Drawing.Size(227, 36);
            this.mnudoanhthu.Text = "Doanh Thu";
            this.mnudoanhthu.Click += new System.EventHandler(this.mnuBaocaoSinhVien_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(309, 36);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 600);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmChinh";
            this.Text = "mà";
            this.Activated += new System.EventHandler(this.frmChinh_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHethong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangnhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangxuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnuLop;
        private System.Windows.Forms.ToolStripMenuItem mnuSinhvien;
        private System.Windows.Forms.ToolStripMenuItem mnuTracuu;
        private System.Windows.Forms.ToolStripMenuItem mnuTracuuLop;
        private System.Windows.Forms.ToolStripMenuItem mnuTracuuSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuBaocao;
        private System.Windows.Forms.ToolStripMenuItem mnudoanhthu;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
    }
}

