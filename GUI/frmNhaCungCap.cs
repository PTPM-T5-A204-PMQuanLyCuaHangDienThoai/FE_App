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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        bool _them;
        String _ma;
        NhaCungCapBLL bll;
        frmSanPham objSanPham = (frmSanPham)Application.OpenForms["frmSanPham"];
        public String nhaphang = String.Empty;
        frmNhapHang objNhapHang = (frmNhapHang)Application.OpenForms["frmNhapHang"];
        void _enable(bool t)
        {
            txtid.Enabled = t;
            txtTen.Enabled = t;
            txtDiaChi.Enabled = t;
            txtSDT.Enabled = t;
            txtEmail.Enabled = t;
            chkHoatDong.Enabled = t;
        }
        void _reset()
        {
            txtid.Text = String.Empty;
            txtTen.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtSDT.Text = String.Empty;
            txtEmail.Text = String.Empty;
            chkHoatDong.Checked = true;
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
        private bool IsEmailValid(string email)
        {
            string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Regex.IsMatch(email, emailPattern);
        }
        public bool IsPhoneNumberValid(string phoneNumber)
        {
            // Sử dụng biểu thức chính quy để kiểm tra định dạng số điện thoại
            string pattern = @"^\d{10}$"; // Chuỗi chính quy kiểm tra số điện thoại 10 chữ số

            // Tạo một instance của lớp Regex để thực hiện kiểm tra
            Regex regex = new Regex(pattern);

            // Kiểm tra chuỗi nhập vào với biểu thức chính quy
            return regex.IsMatch(phoneNumber);
        }
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            bll = new NhaCungCapBLL();
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
            if (String.IsNullOrEmpty(txtid.Text) ||
                String.IsNullOrEmpty(txtTen.Text) ||
                String.IsNullOrEmpty(txtDiaChi.Text) ||
                String.IsNullOrEmpty(txtSDT.Text) ||
                String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (!IsPhoneNumberValid(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại bắt buộc phải có 10 chữ số và chỉ được nhập từ 0-9.");
                return;
            }


            if (!IsEmailValid(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạnh email.");
                return;
            }

            if (_them)
            {
                if (bll.findItem(txtid.Text) != null)
                {
                    MessageBox.Show("ID đã tồn tại.");
                    return;
                }
                if (bll.ktraSDT(txtSDT.Text) != null)
                {
                    MessageBox.Show("Số điện thoại đã được sử dụng.");
                    return;
                }
                if (bll.ktraEmail(txtEmail.Text) != null)
                {
                    MessageBox.Show("Email đã được sử dụng.");
                    return;
                }
                NhaCungCapDTO _data = new NhaCungCapDTO();
                _data.id = txtid.Text;
                _data.name = txtTen.Text;
                _data.DiaChi = txtDiaChi.Text;
                _data.SDT = txtSDT.Text;
                _data.Email = txtEmail.Text;
                _data.HoatDong = chkHoatDong.Checked;
                bll.insert(_data);
            }
            else
            {
                NhaCungCapDTO _data = bll.findItem(txtid.Text);
                if (bll.findItem(txtid.Text) == null)
                {
                    MessageBox.Show("ID không tồn tại.");
                    return;
                }
                if (bll.ktraSDT(txtSDT.Text) != null && _data.SDT != txtSDT.Text)
                {
                    MessageBox.Show("Số điện thoại đã được sử dụng.");
                    return;
                }
                if (bll.ktraEmail(txtEmail.Text) != null && _data.Email != txtEmail.Text)
                {
                    MessageBox.Show("Email đã được sử dụng.");
                    return;
                }
                _data.name = txtTen.Text;
                _data.DiaChi = txtDiaChi.Text;
                _data.SDT = txtSDT.Text;
                _data.Email = txtEmail.Text;
                _data.HoatDong= chkHoatDong.Checked;
                bll.update(_data);
            }
            _them = false;
            loadData();
            _enable(false);
            showHideControl(true);
            if (objSanPham != null)
            {
                objSanPham.loadsearchNhaCungCap();
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
                txtDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DiaChi").ToString();
                txtSDT.Text = gvDanhSach.GetFocusedRowCellValue("SDT").ToString();
                txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("Email").ToString();
                chkHoatDong.Checked = gvDanhSach.GetFocusedRowCellValue("HoatDong").ToString() == "True" ? true : false;
            }
        }

        private void gcDanhSach_DoubleClick(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0 && !String.IsNullOrEmpty(nhaphang) && objNhapHang != null)
            {
                objNhapHang.loadcboNhaCungCap();
                objNhapHang.setcboNhaCungCap(txtid.Text);
                this.Close();
            }
        }
    }
}