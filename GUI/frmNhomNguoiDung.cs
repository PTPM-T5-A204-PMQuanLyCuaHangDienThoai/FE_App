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
    public partial class frmNhomNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        NhomBLL _nhom;
        NguoiDungBLL _nguoiDung;
        NhomNguoiDungBLL _nhomNguoiDung;
        String idNhom = "-1";
        public frmNhomNguoiDung()
        {
            InitializeComponent();
        }
        public void loaddgvNhom()
        {
            gcNhom.DataSource = _nhom.getAll();
            gvNhom.OptionsBehavior.Editable = false;
        }
        void loaddgvNguoiDung()
        {
            gcNguoiDung.DataSource = _nguoiDung.getDataIsNotAddByGroup(idNhom);
            gvNguoiDung.OptionsBehavior.Editable = false;
        }
        void loaddgvData()
        {
            gcNhomNguoiDung.DataSource = _nhomNguoiDung.getDataByidNhom(idNhom);
            gvNhomNguoiDung.OptionsBehavior.Editable = false;
        }

        private void frmNhomNguoiDung_Load(object sender, EventArgs e)
        {
            _nhom = new NhomBLL();
            _nguoiDung = new NguoiDungBLL();
            _nhomNguoiDung = new NhomNguoiDungBLL();
            loaddgvNhom();
            loaddgvNguoiDung();
            loaddgvData();
        }

        private void gcNhom_Click(object sender, EventArgs e)
        {
            if (gvNhom.RowCount > 0)
            {
                idNhom = gvNhom.GetFocusedRowCellValue("id").ToString();
                loaddgvNguoiDung();
                loaddgvData();
            }
        }

        private void gcNguoiDung_DoubleClick(object sender, EventArgs e)
        {
            if (idNhom.Equals("-1"))
            {
                MessageBox.Show("Vui lòng chọn nhóm cần thêm quyền vào.");
                return;
            }
            if (gvNguoiDung.RowCount > 0)
            {
                int idNguoiDung = Int32.Parse(gvNguoiDung.GetFocusedRowCellValue("id").ToString());
                if (MessageBox.Show("Thêm người dùng " + idNguoiDung + " vào nhóm " + idNhom + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    NhomNguoiDungDTO a = new NhomNguoiDungDTO();
                    a.idNhom = idNhom;
                    a.idNguoiDung = idNguoiDung;
                    _nhomNguoiDung.insert(a);
                    loaddgvNguoiDung();
                    loaddgvData();
                }
            }
        }

        private void gcNhomNguoiDung_DoubleClick(object sender, EventArgs e)
        {
            if (gvNhomNguoiDung.RowCount > 0)
            {
                String idNguoiDung = gvNhomNguoiDung.GetFocusedRowCellValue("idNguoiDung").ToString();
                idNhom = gvNhomNguoiDung.GetFocusedRowCellValue("idNhom").ToString();
                if (MessageBox.Show("Xóa người dùng " + idNguoiDung + " khỏi nhóm " + idNhom + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _nhomNguoiDung.delete(gvNhomNguoiDung.GetFocusedRowCellValue("id").ToString());
                    loaddgvNguoiDung();
                    loaddgvData();
                }
            }
        }

        private void btnNhom_Click(object sender, EventArgs e)
        {
            frmNhom frm = new frmNhom();
            frm.ShowDialog();
        }
    }
}