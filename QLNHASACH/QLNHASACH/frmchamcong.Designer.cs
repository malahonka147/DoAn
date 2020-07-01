namespace QLNHASACH
{
    partial class frmchamcong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmchamcong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listnhanvien = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btntinhluong = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.numSoGio = new System.Windows.Forms.NumericUpDown();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCTChamCong = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChamCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoGio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listnhanvien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btntinhluong);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.numSoGio);
            this.groupBox1.Controls.Add(this.dtNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chấm công";
            // 
            // listnhanvien
            // 
            this.listnhanvien.FormattingEnabled = true;
            this.listnhanvien.Location = new System.Drawing.Point(355, 59);
            this.listnhanvien.Name = "listnhanvien";
            this.listnhanvien.Size = new System.Drawing.Size(173, 69);
            this.listnhanvien.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Danh sách nhân viên:";
            // 
            // btntinhluong
            // 
            this.btntinhluong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntinhluong.ImageOptions.Image")));
            this.btntinhluong.Location = new System.Drawing.Point(194, 113);
            this.btntinhluong.Name = "btntinhluong";
            this.btntinhluong.Size = new System.Drawing.Size(109, 45);
            this.btntinhluong.TabIndex = 5;
            this.btntinhluong.Text = "Tính Lương";
            this.btntinhluong.Click += new System.EventHandler(this.btntinhluong_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(53, 113);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(109, 45);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // numSoGio
            // 
            this.numSoGio.Location = new System.Drawing.Point(163, 66);
            this.numSoGio.Name = "numSoGio";
            this.numSoGio.Size = new System.Drawing.Size(140, 20);
            this.numSoGio.TabIndex = 3;
            // 
            // dtNgay
            // 
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(161, 25);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(142, 20);
            this.dtNgay.TabIndex = 2;
            this.dtNgay.ValueChanged += new System.EventHandler(this.dtNgay_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số giờ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày Chấm Công:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chi Tiết Chấm Công";
            // 
            // dgvCTChamCong
            // 
            this.dgvCTChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenNV,
            this.NgayChamCong,
            this.SoGio,
            this.Sua,
            this.Xoa});
            this.dgvCTChamCong.Location = new System.Drawing.Point(36, 270);
            this.dgvCTChamCong.Name = "dgvCTChamCong";
            this.dgvCTChamCong.Size = new System.Drawing.Size(645, 120);
            this.dgvCTChamCong.TabIndex = 3;
            this.dgvCTChamCong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTChamCong_CellContentClick);
            this.dgvCTChamCong.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCTChamCong_DataBindingComplete);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 150;
            // 
            // NgayChamCong
            // 
            this.NgayChamCong.DataPropertyName = "Ngay";
            this.NgayChamCong.HeaderText = "Ngày Chấm Công";
            this.NgayChamCong.Name = "NgayChamCong";
            this.NgayChamCong.ReadOnly = true;
            // 
            // SoGio
            // 
            this.SoGio.DataPropertyName = "SoGio";
            this.SoGio.HeaderText = "Số Giờ";
            this.SoGio.Name = "SoGio";
            this.SoGio.ReadOnly = true;
            // 
            // Sua
            // 
            this.Sua.DataPropertyName = "Sua";
            this.Sua.HeaderText = "Sửa";
            this.Sua.Name = "Sua";
            this.Sua.ReadOnly = true;
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "Xoa";
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            // 
            // frmchamcong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.dgvCTChamCong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmchamcong";
            this.Text = "frmchamcong";
            this.Load += new System.EventHandler(this.frmchamcong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoGio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listnhanvien;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btntinhluong;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.NumericUpDown numSoGio;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCTChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xoa;
    }
}