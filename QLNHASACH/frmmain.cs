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
            frmdangnhap f = new frmdangnhap(this);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();

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
                        btnChamCong.Enabled = true;
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
                        btnChamCong.Enabled = false;
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
                        btnChamCong.Enabled = false;
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
                        btnChamCong.Enabled = false; 
                        break;
                    }
                    
            }
            


        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                f.Close();
            }
            frmmain_Load(sender, e);

        }

        private void btnDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlMain.TabPages.IndexOfKey("tabPageDoiMatKhau");
            if(index >=0)
            {
                tabControlMain.SelectedIndex = index;
                
            }
            else
            {
                frmdoimatkhau f = new frmdoimatkhau();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageDoiMatKhau";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                f.Show();
            }
            
        }

        private void btnChamCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmchamcong f = new frmchamcong();
            TabPage p = new TabPage(f.Text);
            p.Name = "tabChamCong";
            f.TopLevel = false;
            p.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            tabControlMain.TabPages.Add(p);
            f.Show();
        }
    }
}
