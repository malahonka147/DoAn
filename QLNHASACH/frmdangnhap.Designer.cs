namespace QLNHASACH
{
    partial class frmdangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdangnhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbdn = new System.Windows.Forms.TextBox();
            this.txbmk = new System.Windows.Forms.TextBox();
            this.btndangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu:";
            // 
            // txbdn
            // 
            this.txbdn.Location = new System.Drawing.Point(147, 43);
            this.txbdn.Name = "txbdn";
            this.txbdn.Size = new System.Drawing.Size(136, 20);
            this.txbdn.TabIndex = 2;
            // 
            // txbmk
            // 
            this.txbmk.Location = new System.Drawing.Point(147, 69);
            this.txbmk.Name = "txbmk";
            this.txbmk.PasswordChar = '*';
            this.txbmk.Size = new System.Drawing.Size(136, 20);
            this.txbmk.TabIndex = 3;
            // 
            // btndangnhap
            // 
            this.btndangnhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndangnhap.ImageOptions.Image")));
            this.btndangnhap.Location = new System.Drawing.Point(46, 127);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(104, 39);
            this.btndangnhap.TabIndex = 4;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.ImageOptions.Image")));
            this.btnthoat.Location = new System.Drawing.Point(179, 127);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(104, 39);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frmdangnhap
            // 
            this.AcceptButton = this.btndangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 195);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.txbmk);
            this.Controls.Add(this.txbdn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmdangnhap";
            this.Text = "frmdangnhap";
            this.Load += new System.EventHandler(this.frmdangnhap_Load);
            this.Enter += new System.EventHandler(this.frmdangnhap_Enter);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmdangnhap_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbdn;
        private System.Windows.Forms.TextBox txbmk;
        private DevExpress.XtraEditors.SimpleButton btndangnhap;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
    }
}