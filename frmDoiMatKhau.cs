using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab4.Modules;
namespace Lab4
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPassNew, "");
            errorProvider1.SetError(txtConfirmPass, "");
            if(txtPassNew.Text.Length<8||!txtPassNew.Text.Any(char.IsDigit)||!txtPassNew.Text.Any(char.IsLower)|| !txtPassNew.Text.Any(char.IsUpper))
            {
                errorProvider1.SetError(txtPassNew,"Mật khẩu mới gồm 8 kí tự,gồm chữ số" + "in hoa,in thường.");
                return;
            }
            frmMain f = (frmMain)this.MdiParent;
            int count = XLBANG.Thuc_hien_lenh("Update NHANVIEN set Password ='" + txtPassNew.Text + "' where MaNV ='" + f.maNV + "'");
            if(count>0)
            {
                MessageBox.Show("Cập Nhật Thành Công.");
            }    
            else
            {
                MessageBox.Show("Mật khẩu không hợp lệ!!!");
            }    



        }


    }
}
