namespace thicuoiky
{
    partial class frmTraCuu
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
            this.dgvH = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radten = new System.Windows.Forms.RadioButton();
            this.radloai = new System.Windows.Forms.RadioButton();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magiay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengiay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvH
            // 
            this.dgvH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tt,
            this.magiay,
            this.maloai,
            this.tengiay,
            this.gia});
            this.dgvH.Location = new System.Drawing.Point(93, 257);
            this.dgvH.Name = "dgvH";
            this.dgvH.RowTemplate.Height = 28;
            this.dgvH.Size = new System.Drawing.Size(781, 270);
            this.dgvH.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(368, 180);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(91, 51);
            this.btnsearch.TabIndex = 10;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(363, 113);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(333, 26);
            this.txttim.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập thông tin cần tìm";
            // 
            // radten
            // 
            this.radten.AutoSize = true;
            this.radten.Checked = true;
            this.radten.Location = new System.Drawing.Point(136, 72);
            this.radten.Name = "radten";
            this.radten.Size = new System.Drawing.Size(150, 24);
            this.radten.TabIndex = 5;
            this.radten.TabStop = true;
            this.radten.Text = "Tra cứu theo tên";
            this.radten.UseVisualStyleBackColor = true;
            // 
            // radloai
            // 
            this.radloai.AutoSize = true;
            this.radloai.Location = new System.Drawing.Point(136, 119);
            this.radloai.Name = "radloai";
            this.radloai.Size = new System.Drawing.Size(177, 24);
            this.radloai.TabIndex = 6;
            this.radloai.Text = "Tra cứu theo mã loại";
            this.radloai.UseVisualStyleBackColor = true;
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
            this.magiay.HeaderText = "Mã Hàng";
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
            this.gia.Width = 300;
            // 
            // frmTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 599);
            this.Controls.Add(this.dgvH);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radten);
            this.Controls.Add(this.radloai);
            this.Name = "frmTraCuu";
            this.Text = "Tra Cứu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radten;
        private System.Windows.Forms.RadioButton radloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiay;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengiay;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
    }
}