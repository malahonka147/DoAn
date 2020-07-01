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
    public partial class frmdoimatkhau : Form
    {
        public frmdoimatkhau()
        {
            InitializeComponent();
        }

        private void frmdoimatkhau_Load(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
            
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txbmkmoi, "");
            errorProvider1.SetError(txbnhaplaimk, "");

            if(txbmkmoi.Text.Length<8||!txbmkmoi.Text.Any(char.IsDigit)||!txbmkmoi.Text.Any(char.IsLower)||!txbmkmoi.Text.Any(char.IsUpper))
            {
                errorProvider1.SetError(txbmkmoi, "Mật khẩu mới tối thiểu 8 ký tự, gồm chữ số,in hoa và chữ thường.");
                return;
            }
            if(txbmkmoi.Text != txbnhaplaimk.Text)
            {
                errorProvider1.SetError(txbnhaplaimk, "Mật khẩu nhập lại không trùng!!!");
                return;
            }

            frmmain f = (frmmain)this.MdiParent;
            int count = XLBANG.Thuc_hien_lenh("Update NHANVIEN set password ='" + txbmkmoi.Text + "' where MaNV ='" + f.maNV + "'");
            if (count > 0)
            {
                MessageBox.Show("Cập nhật thành công!!!");

            }
            else MessageBox.Show("Mật Khẩu không hợp lệ!!!");
        }
    }
}
