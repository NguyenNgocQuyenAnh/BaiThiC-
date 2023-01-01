namespace thicuoiky
{
    partial class frmDoanhthu
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
            this.dgvdoanhthu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttim = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.dtngay = new System.Windows.Forms.DateTimePicker();
            this.radten = new System.Windows.Forms.RadioButton();
            this.radngay = new System.Windows.Forms.RadioButton();
            this.btnclose = new System.Windows.Forms.Button();
            this.dtdenngay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvsum = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoanhthu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsum)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdoanhthu
            // 
            this.dgvdoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdoanhthu.Location = new System.Drawing.Point(38, 234);
            this.dgvdoanhthu.Name = "dgvdoanhthu";
            this.dgvdoanhthu.RowTemplate.Height = 28;
            this.dgvdoanhthu.Size = new System.Drawing.Size(916, 379);
            this.dgvdoanhthu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách hàng đã bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm";
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(245, 38);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(370, 26);
            this.txttim.TabIndex = 4;
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(644, 54);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(99, 29);
            this.btntim.TabIndex = 5;
            this.btntim.Text = "Search";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // dtngay
            // 
            this.dtngay.Location = new System.Drawing.Point(245, 78);
            this.dtngay.Name = "dtngay";
            this.dtngay.Size = new System.Drawing.Size(370, 26);
            this.dtngay.TabIndex = 7;
            this.dtngay.Value = new System.DateTime(2022, 12, 20, 0, 0, 0, 0);
            // 
            // radten
            // 
            this.radten.AutoSize = true;
            this.radten.Location = new System.Drawing.Point(71, 40);
            this.radten.Name = "radten";
            this.radten.Size = new System.Drawing.Size(107, 24);
            this.radten.TabIndex = 8;
            this.radten.TabStop = true;
            this.radten.Text = "Nhập tên :";
            this.radten.UseVisualStyleBackColor = true;
            // 
            // radngay
            // 
            this.radngay.AutoSize = true;
            this.radngay.Location = new System.Drawing.Point(71, 81);
            this.radngay.Name = "radngay";
            this.radngay.Size = new System.Drawing.Size(120, 24);
            this.radngay.TabIndex = 8;
            this.radngay.TabStop = true;
            this.radngay.Text = "Chọn Ngày :";
            this.radngay.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(784, 54);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(88, 28);
            this.btnclose.TabIndex = 9;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dtdenngay
            // 
            this.dtdenngay.Location = new System.Drawing.Point(245, 128);
            this.dtdenngay.Name = "dtdenngay";
            this.dtdenngay.Size = new System.Drawing.Size(370, 26);
            this.dtdenngay.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tổng Doanh Thu :";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvsum
            // 
            this.dgvsum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsum.Location = new System.Drawing.Point(656, 108);
            this.dgvsum.Name = "dgvsum";
            this.dgvsum.RowTemplate.Height = 28;
            this.dgvsum.Size = new System.Drawing.Size(182, 46);
            this.dgvsum.TabIndex = 12;
            this.dgvsum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsum_CellContentClick);
            // 
            // frmDoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 625);
            this.Controls.Add(this.dgvsum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtdenngay);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.radngay);
            this.Controls.Add(this.radten);
            this.Controls.Add(this.dtngay);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdoanhthu);
            this.Name = "frmDoanhthu";
            this.Text = "Thống kê doanh thu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDoanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoanhthu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdoanhthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.DateTimePicker dtngay;
        private System.Windows.Forms.RadioButton radten;
        private System.Windows.Forms.RadioButton radngay;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DateTimePicker dtdenngay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvsum;
    }
}