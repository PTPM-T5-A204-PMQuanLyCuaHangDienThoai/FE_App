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
    public partial class frmNhom : DevExpress.XtraEditors.XtraForm
    {
        bool _them;
        String _ma;
        NhomBLL bll;
        frmNhomNguoiDung objNhomNguoiDung = (frmNhomNguoiDung)Application.OpenForms["frmNhomNguoiDung"];
        frmPhanQuyen objPhanQuyen = (frmPhanQuyen)Application.OpenForms["frmPhanQuyen"];
        void _enable(bool t)
        {
            txtid.Enabled = t;
            txtTen.Enabled = t;
        }
        void _reset()
        {
            txtid.Text = String.Empty;
            txtTen.Text = String.Empty;
        }
        void showHideControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;
        }

        void loadData()
        {
            gcDanhSach.DataSource = bll.getAll();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        public frmNhom()
        {
            InitializeComponent();
        }
        private void frmNhom_Load(object sender, EventArgs e)
        {
            bll = new NhomBLL();
            loadData();
            showHideControl(true);
            _enable(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideControl(false);
            _enable(true);
            _reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            _enable(true);
            showHideControl(false);
            txtid.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bll.delete(_ma);
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtid.Text) || String.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (_them)
            {
                if (bll.ktraTrungKey(txtid.Text))
                {
                    MessageBox.Show("ID đã tồn tại.");
                    return;
                }
                NhomDTO data = new NhomDTO();
                data.id = txtid.Text;
                data.name = txtTen.Text;
                bll.insert(data);
            }
            else
            {
                if (!bll.ktraTrungKey(txtid.Text))
                {
                    MessageBox.Show("ID không tồn tại.");
                    return;
                }
                NhomDTO data = bll.findItem(txtid.Text);
                data.name = txtTen.Text;
                bll.update(data);
            }
            _them = false;
            loadData();
            _enable(false);
            showHideControl(true);
            if (objNhomNguoiDung != null)
            {
                objNhomNguoiDung.loaddgvNhom();
            }
            if (objPhanQuyen != null)
            {
                objPhanQuyen.loaddgvNhom();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);
            _enable(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _ma = txtid.Text = gvDanhSach.GetFocusedRowCellValue("id").ToString();
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("name").ToString();
            }
        }
    }
}