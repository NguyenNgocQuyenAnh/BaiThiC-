namespace thicuoiky
{
    partial class frmLoai
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtloai = new System.Windows.Forms.TextBox();
            this.dgvloai = new System.Windows.Forms.DataGridView();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Loại :";
            // 
            // txtloai
            // 
            this.txtloai.Location = new System.Drawing.Point(294, 90);
            this.txtloai.Name = "txtloai";
            this.txtloai.Size = new System.Drawing.Size(249, 26);
            this.txtloai.TabIndex = 1;
            // 
            // dgvloai
            // 
            this.dgvloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tt,
            this.maloai,
            this.tenloai});
            this.dgvloai.Location = new System.Drawing.Point(12, 254);
            this.dgvloai.Name = "dgvloai";
            this.dgvloai.RowTemplate.Height = 28;
            this.dgvloai.Size = new System.Drawing.Size(889, 357);
            this.dgvloai.TabIndex = 2;
            this.dgvloai.Click += new System.EventHandler(this.dgvloai_Click);
            // 
            // tt
            // 
            this.tt.DataPropertyName = "tt";
            this.tt.HeaderText = "TT";
            this.tt.Name = "tt";
            this.tt.Width = 150;
            // 
            // maloai
            // 
            this.maloai.DataPropertyName = "maloai";
            this.maloai.HeaderText = "Mã Loại";
            this.maloai.Name = "maloai";
            this.maloai.Width = 200;
            // 
            // tenloai
            // 
            this.tenloai.DataPropertyName = "tenloai";
            this.tenloai.HeaderText = "Tên Loại";
            this.tenloai.Name = "tenloai";
            this.tenloai.Width = 200;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(143, 148);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(101, 38);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(294, 148);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(101, 38);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(447, 148);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(101, 38);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(611, 148);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(101, 38);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Loại :";
            // 
            // txtmaloai
            // 
            this.txtmaloai.Location = new System.Drawing.Point(294, 45);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(249, 26);
            this.txtmaloai.TabIndex = 1;
            // 
            // frmLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 623);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvloai);
            this.Controls.Add(this.txtmaloai);
            this.Controls.Add(this.txtloai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLoai";
            this.Text = "Quản Lý Loại";
            ((System.ComponentModel.ISupportInitialize)(this.dgvloai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtloai;
        private System.Windows.Forms.DataGridView dgvloai;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaloai;
    }
}