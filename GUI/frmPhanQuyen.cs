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

namespace GUI
{
    public partial class frmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        NhomBLL _nhom;
        QuyenBLL _quyen;
        PhanQuyenBLL _phanQuyen;
        String idNhom = "-1";
        public void loaddgvNhom()
        {
            gcNhom.DataSource = _nhom.getAll();
            gvNhom.OptionsBehavior.Editable = false;
        }
        void loaddgvQuyen()
        {
            gcQuyen.DataSource = _quyen.getDataIsNotAddByGroup(idNhom);
            gvQuyen.OptionsBehavior.Editable = false;
        }
        void loaddgvData()
        {
            gcPhanQuyen.DataSource = _phanQuyen.getDataByidNhom(idNhom);
            gvPhanQuyen.OptionsBehavior.Editable = false;
        }
        public frmPhanQuyen()
        {
            InitializeComponent();
        }
        private void btnPhanNhom_Click(object sender, EventArgs e)
        {
            frmNhomNguoiDung frm = new frmNhomNguoiDung();
            frm.ShowDialog();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            _nhom = new NhomBLL();
            _quyen = new QuyenBLL();
            _phanQuyen = new PhanQuyenBLL();
            loaddgvNhom();
            loaddgvQuyen();
            loaddgvData();
        }

        private void gcNhom_Click(object sender, EventArgs e)
        {
            if (gvNhom.RowCount > 0)
            {
                idNhom = gvNhom.GetFocusedRowCellValue("id").ToString();
                loaddgvQuyen();
                loaddgvData();
            }
        }

        private void gcQuyen_DoubleClick(object sender, EventArgs e)
        {
            if (idNhom.Equals("-1"))
            {
                MessageBox.Show("Vui lòng chọn nhóm cần thêm quyền vào.");
                return;
            }
            if (gvQuyen.RowCount > 0)
            {
                String idQuyen = gvQuyen.GetFocusedRowCellValue("id").ToString();
                if (MessageBox.Show("Thêm quyền " + idQuyen + " vào nhóm " + idNhom + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PhanQuyenDTO a = new PhanQuyenDTO();
                    a.idNhom = idNhom;
                    a.idQuyen = idQuyen;
                    _phanQuyen.insert(a);
                    loaddgvQuyen();
                    loaddgvData();
                }
            }
        }

        private void gcPhanQuyen_DoubleClick(object sender, EventArgs e)
        {
            if (gvPhanQuyen.RowCount > 0)
            {
                String idQuyen = gvPhanQuyen.GetFocusedRowCellValue("idQuyen").ToString();
                idNhom = gvPhanQuyen.GetFocusedRowCellValue("idNhom").ToString();
                if (MessageBox.Show("Xóa quyền " + idQuyen + " khỏi nhóm " + idNhom + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _phanQuyen.delete(gvPhanQuyen.GetFocusedRowCellValue("id").ToString());
                    loaddgvQuyen();
                    loaddgvData();
                }
            }
        }
    }
}