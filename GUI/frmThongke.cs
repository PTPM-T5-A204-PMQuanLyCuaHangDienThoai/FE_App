using BLL;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frmThongke : DevExpress.XtraEditors.XtraForm
    {
        PhieuXuatBLL data;
        NguoiDungBLL ngd;
        public void loadData()
        {
            List<PhieuXuatDTO> list = data.getAll();
            dgvData.DataSource = list;
            dgvData.ReadOnly = true;
        }
        public frmThongke()
        {
            InitializeComponent();
        }

        private void frmThongke_Load(object sender, EventArgs e)
        {
            data = new PhieuXuatBLL();
            ngd = new NguoiDungBLL();
            loadData();
            loadNhanVien();
            load_ThongKeMatDinh();
            cbo_nv.SelectedIndex = -1;
            load_doanhthuNgay(dtpbd.Value,dtpkt.Value);
        }
        void loadNhanVien()
        {
            cbo_nv.DataSource = ngd.getNhanVien();
            cbo_nv.DisplayMember = "name";
            cbo_nv.ValueMember = "id";
        }
        void load_ThongKeMatDinh()
        {
            dtpbd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpkt.Value = dtpbd.Value.AddMonths(1).AddDays(-1);
        }
        void load_theonv(int ma)
        {
            dgvData.Controls.Clear();
            dgvData.DataSource = data.GetPhieuXuatsNhanVien(ma);
            int sc = dgvData.Rows.Count;
            double thanhtien = 0;
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (!row.IsNewRow) // Kiểm tra không phải hàng mới
                {
                    object cellValue = row.Cells["TongTien"].Value;

                    if (cellValue != null && double.TryParse(cellValue.ToString(), out double tongTien))
                    {
                        thanhtien += tongTien;
                    }


                }
            }
            string s = "Tổng Doanh Thu  : ";
            label4.Text = s + thanhtien.ToString()+ "VNĐ";
        }
        void load_doanhthuNgay(DateTime bd,DateTime kt)
        {
            dgvData.Controls.Clear();
            dgvData.DataSource = data.getDataTheoNgay(bd,kt);
            int sc = dgvData.Rows.Count;
            double thanhtien = 0;
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (!row.IsNewRow) // Kiểm tra không phải hàng mới
                {
                    object cellValue = row.Cells["TongTien"].Value;

                    if (cellValue != null && double.TryParse(cellValue.ToString(), out double tongTien))
                    {
                        thanhtien += tongTien;
                    }
               
                    
                }
            }
            string s = "Tổng Doanh Thu  : ";
            label4.Text = s+thanhtien.ToString()+"VNĐ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_doanhthuNgay(dtpbd.Value, dtpkt.Value);
          
            if (cbo_nv.SelectedIndex != -1)
            {
                load_theonv((int)cbo_nv.SelectedValue);
                cbo_nv.SelectedIndex = -1;
            }

        }
    }
}