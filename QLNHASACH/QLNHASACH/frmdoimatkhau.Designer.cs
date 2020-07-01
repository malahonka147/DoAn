namespace QLNHASACH
{
    partial class frmdoimatkhau
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdoimatkhau));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbmkmoi = new System.Windows.Forms.TextBox();
            this.txbnhaplaimk = new System.Windows.Forms.TextBox();
            this.btncapnhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập lại mật khẩu:";
            // 
            // txbmkmoi
            // 
            this.txbmkmoi.Location = new System.Drawing.Point(182, 41);
            this.txbmkmoi.Name = "txbmkmoi";
            this.txbmkmoi.Size = new System.Drawing.Size(138, 20);
            this.txbmkmoi.TabIndex = 2;
            // 
            // txbnhaplaimk
            // 
            this.txbnhaplaimk.Location = new System.Drawing.Point(182, 79);
            this.txbnhaplaimk.Name = "txbnhaplaimk";
            this.txbnhaplaimk.Size = new System.Drawing.Size(138, 20);
            this.txbnhaplaimk.TabIndex = 3;
            // 
            // btncapnhat
            // 
            this.btncapnhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btncapnhat.Location = new System.Drawing.Point(65, 120);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(90, 40);
            this.btncapnhat.TabIndex = 4;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(191, 120);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(91, 40);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Không";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmdoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 201);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.txbnhaplaimk);
            this.Controls.Add(this.txbmkmoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmdoimatkhau";
            this.Text = "frmdoimatkhau1";
            this.Load += new System.EventHandler(this.frmdoimatkhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbmkmoi;
        private System.Windows.Forms.TextBox txbnhaplaimk;
        private DevExpress.XtraEditors.SimpleButton btncapnhat;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}