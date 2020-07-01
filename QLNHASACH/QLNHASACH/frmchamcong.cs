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
using System.Data.SqlClient;
namespace QLNHASACH
{
    public partial class frmchamcong : Form
    {
        public frmchamcong()
        {
            InitializeComponent();
        }
        XLNHANVIEN tblNhanVien;
        XLCHAMCONG tblChamCong;

        private void frmchamcong_Load(object sender, EventArgs e)
        {
            tblNhanVien = new XLNHANVIEN(); tblChamCong = new XLCHAMCONG();
            loadCTChamCong();
            loadNhanVien();
            dtNgay.Value = DateTime.Now;

        }
        private void loadNhanVien()
        {
            listnhanvien.DataSource = tblNhanVien;
            listnhanvien.ValueMember = "MaNV";
            listnhanvien.DisplayMember = "TenNV";
        }

   

        private void loadCTChamCong()
        {
            
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblNhanVien, tblChamCong });
            DataRelation qh = new DataRelation("FRK_NHANVIEN_CHAMCONG", tblNhanVien.Columns["MaNV"], tblChamCong.Columns["MaNV"]);
            ds.Relations.Add(qh);
           
            DataColumn cTenNV = new DataColumn("TenNV", Type.GetType("System.String"), "Parent(FRK_NHANVIEN_CHAMCONG).TenNV");
            tblChamCong.Columns.Add(cTenNV);
            
            dgvCTChamCong.AutoGenerateColumns = false;
            dgvCTChamCong.DataSource = tblChamCong;

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DataRow r = tblChamCong.NewRow();
            r["MaNV"] = listnhanvien.SelectedValue;
            r["Ngay"] = dtNgay.Value.ToShortDateString();
            r["SoGio"] = numSoGio.Value;
            tblChamCong.Rows.Add(r);
           
            tblChamCong.ghi();

        }

        private void dtNgay_ValueChanged(object sender, EventArgs e)
        {
            tblChamCong.locDuLieu("Ngay='" + dtNgay.Value.ToShortDateString() + "'");
        }

        private void dgvCTChamCong_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvCTChamCong.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void dgvCTChamCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 4 || e.ColumnIndex == 5))
            {
                

                if (e.ColumnIndex == 5) tblChamCong.Rows[e.RowIndex].Delete();
                
                tblChamCong.ghi();

            }

        }

        private void btntinhluong_Click(object sender, EventArgs e)
        {

        }
    }
}
