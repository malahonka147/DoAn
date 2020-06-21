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
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }
        private void frmmain_Load(object sender, EventArgs e)
        {
            enableControl(-1);
            frmdangnhap f = new frmdangnhap();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            f.WindowState = FormWindowState.Normal;

        }
        public string maNV;
        frmdoimatkhau fdoimatkhau;
        public void enableControl (int MaLTK)
        {
            switch(MaLTK)
            {

                case 1:// admin
                    {
                        btnDangXuat.Enabled = true;
                        btnDoiMK.Enabled = true;
                        btnChamCong.Enabled = true;
                        btnDonHang.Enabled = true;
                        btnKhachHang.Enabled = true;
                        btnLoaiSanPham.Enabled = true;
                        btnNhanVien.Enabled = true;
                        btnSanPham.Enabled = true;
                        btnTaoHoaDon.Enabled = true;
                        btnThongKe.Enabled = true;
                        break;
                    }
                case 2:// nhanvien ban hang
                    {
                        btnDangXuat.Enabled = true;
                        btnDoiMK.Enabled = true;
                        btnChamCong.Enabled = false;
                        btnDonHang.Enabled = false;
                        btnKhachHang.Enabled = true;
                        btnLoaiSanPham.Enabled = false;
                        btnNhanVien.Enabled = false;
                        btnSanPham.Enabled = false;
                        btnTaoHoaDon.Enabled = true;
                        btnThongKe.Enabled = false;
                        break;
                    }
                case 3:// nhanvien quanly kho
                    {
                        btnDangXuat.Enabled = true;
                        btnDoiMK.Enabled = true;
                        btnChamCong.Enabled = false;
                        btnDonHang.Enabled = false;
                        btnKhachHang.Enabled = false;
                        btnLoaiSanPham.Enabled = true;
                        btnNhanVien.Enabled = false;
                        btnSanPham.Enabled = true;
                        btnTaoHoaDon.Enabled = false;
                        btnThongKe.Enabled = false;
                        break;
                    }
                default:
                    {
                        btnDangXuat.Enabled = false;
                        btnDoiMK.Enabled = false;
                        btnChamCong.Enabled = false;
                        btnDonHang.Enabled = false;
                        btnKhachHang.Enabled = false;
                        btnLoaiSanPham.Enabled = false;
                        btnNhanVien.Enabled = false;
                        btnSanPham.Enabled = true;
                        btnTaoHoaDon.Enabled = false;
                        btnThongKe.Enabled = false;
                        break;
                    }
                    
            }
            


        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach(Form f in MdiChildren)
            {
                f.Close();

            }
            frmmain_Load(sender, e);

        }

        private void btnDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fdoimatkhau==null)
            {
                fdoimatkhau = new frmdoimatkhau();
                fdoimatkhau.MdiParent = this;
                fdoimatkhau.WindowState = FormWindowState.Maximized;
                fdoimatkhau.Show();
            }
            else
            {
                fdoimatkhau.Activate();
                fdoimatkhau.Show();
            }
            
        }
    }
}
