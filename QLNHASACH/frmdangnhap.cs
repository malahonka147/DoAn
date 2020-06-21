using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNHASACH.Modules;
namespace QLNHASACH
{
    public partial class frmdangnhap : Form
    {

        XLNHANVIEN tblNhanVien;
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            tblNhanVien = new XLNHANVIEN();
            var r = tblNhanVien.Select("Username='" + txbdn.Text + "' and Password='" + txbmk.Text + "'");
            if(r.Count()>0)
            {
                frmmain f = (frmmain)this.Parent;
                f.Text = "Quản Lý Nhà Sách - Chào" + r[0]["TenNV"].ToString();
                f.maNV = r[0]["MaNV"].ToString();
                f.enableControl((int)r[0]["MaLTK"]);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!!!");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmdangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(int)Keys.Enter)
            {
                btndangnhap_Click(sender, e);

            }

        }

        private void frmdangnhap_Enter(object sender, EventArgs e)
        {
            btndangnhap_Click(sender, e);
        }
    }
}
