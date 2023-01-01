namespace thicuoiky
{
    partial class frmquanlyhang
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
            this.cmbmaloai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvH = new System.Windows.Forms.DataGridView();
            this.btncancel = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttenh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmah = new System.Windows.Forms.TextBox();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magiay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengiay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtanh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.choose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbmaloai
            // 
            this.cmbmaloai.FormattingEnabled = true;
            this.cmbmaloai.Location = new System.Drawing.Point(743, 13);
            this.cmbmaloai.Name = "cmbmaloai";
            this.cmbmaloai.Size = new System.Drawing.Size(205, 28);
            this.cmbmaloai.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "chọn Mã loại";
            // 
            // dgvH
            // 
            this.dgvH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tt,
            this.magiay,
            this.maloai,
            this.tengiay,
            this.gia,
            this.soluong});
            this.dgvH.Location = new System.Drawing.Point(78, 379);
            this.dgvH.Name = "dgvH";
            this.dgvH.RowTemplate.Height = 28;
            this.dgvH.Size = new System.Drawing.Size(833, 245);
            this.dgvH.TabIndex = 17;
            this.dgvH.Click += new System.EventHandler(this.dgvH_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(546, 291);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(115, 53);
            this.btncancel.TabIndex = 13;
            this.btncancel.Text = "cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(398, 291);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(115, 53);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(249, 291);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(115, 53);
            this.btnupdate.TabIndex = 15;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(78, 291);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(115, 53);
            this.btnadd.TabIndex = 16;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(212, 178);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(367, 26);
            this.txtsl.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lượng";
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(212, 119);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(367, 26);
            this.txtgia.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Giá";
            // 
            // txttenh
            // 
            this.txttenh.Location = new System.Drawing.Point(212, 65);
            this.txttenh.Name = "txttenh";
            this.txttenh.Size = new System.Drawing.Size(367, 26);
            this.txttenh.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã Hàng";
            // 
            // txtmah
            // 
            this.txtmah.Location = new System.Drawing.Point(212, 10);
            this.txtmah.Name = "txtmah";
            this.txtmah.Size = new System.Drawing.Size(367, 26);
            this.txtmah.TabIndex = 12;
            // 
            // tt
            // 
            this.tt.DataPropertyName = "tt";
            this.tt.HeaderText = "TT";
            this.tt.Name = "tt";
            // 
            // magiay
            // 
            this.magiay.DataPropertyName = "magiay";
            this.magiay.HeaderText = "Mã Giày";
            this.magiay.Name = "magiay";
            this.magiay.Visible = false;
            // 
            // maloai
            // 
            this.maloai.DataPropertyName = "maloai";
            this.maloai.HeaderText = "Mã Loại";
            this.maloai.Name = "maloai";
            this.maloai.Visible = false;
            // 
            // tengiay
            // 
            this.tengiay.DataPropertyName = "tengiay";
            this.tengiay.HeaderText = "Tên Giày";
            this.tengiay.Name = "tengiay";
            this.tengiay.Width = 300;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            this.gia.Width = 200;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            this.soluong.Width = 200;
            // 
            // txtanh
            // 
            this.txtanh.Location = new System.Drawing.Point(743, 47);
            this.txtanh.Multiline = true;
            this.txtanh.Name = "txtanh";
            this.txtanh.Size = new System.Drawing.Size(198, 60);
            this.txtanh.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ảnh :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(743, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // choose
            // 
            this.choose.Location = new System.Drawing.Point(659, 55);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(75, 36);
            this.choose.TabIndex = 23;
            this.choose.Text = "choose";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // frmquanlyhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 636);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtanh);
            this.Controls.Add(this.cmbmaloai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvH);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmah);
            this.Controls.Add(this.txttenh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "frmquanlyhang";
            this.Text = "Quản Lý Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbmaloai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvH;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmah;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiay;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengiay;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.TextBox txtanh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button choose;
    }
}