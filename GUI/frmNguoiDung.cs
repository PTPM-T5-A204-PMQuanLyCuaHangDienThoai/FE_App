using BLL;
using DevExpress.XtraEditors;
using DTO;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        bool _them;
        String _ma;
        NguoiDungBLL bll;
        ChucVuBLL chucVuBLL;
        String selectedPath, pictureAddress = "../../../img/";
        //frmDonHang objDonHang = (frmDonHang)Application.OpenForms["frmDonHang"];
        //public String donHangNguoiDung;
        public string OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các thiết lập cho hộp thoại mở tập tin
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy tên tập tin từ đường dẫn đầy đủ
                string fileName = Path.GetFileName(openFileDialog.FileName);

                return fileName;
            }

            return null; // Trả về null nếu không có tập tin nào được chọn
        }
        void _enable(bool t)
        {
            txtTenDangNhap.Enabled = t;
            txtTen.Enabled = t;
            txtDiaChi.Enabled = t;
            txtSDT.Enabled = t;
            txtEmail.Enabled = t;
            dtpNgaySinh.Enabled = t;
            rdbNam.Enabled = t;
            rdbNu.Enabled = t;
            chkBiKhoa.Enabled = t;
            btnChonAnh.Enabled = t;
            cboChucVu.Enabled = t;
        }
        void _reset()
        {
            txtTenDangNhap.Text = String.Empty;
            txtTen.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtSDT.Text = String.Empty;
            txtEmail.Text = String.Empty;
            dtpNgaySinh.Value = DateTime.Now;
            chkBiKhoa.Checked = true;
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
        public void loadChucVu()
        {
            cboChucVu.Properties.DataSource = chucVuBLL.getAll();
            cboChucVu.Properties.ValueMember = "id";
            cboChucVu.Properties.DisplayMember = "name";
        }
        public void setChucVu(String data)
        {
            cboChucVu.EditValue = data;
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
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            bll = new NguoiDungBLL();
            chucVuBLL = new ChucVuBLL();
            loadData();
            showHideControl(true);
            _enable(false);
            loadChucVu();
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
            if (String.IsNullOrEmpty(txtTen.Text) ||
                String.IsNullOrEmpty(txtTenDangNhap.Text) ||
                String.IsNullOrEmpty(txtDiaChi.Text) ||
                String.IsNullOrEmpty(selectedPath) ||
                dtpNgaySinh.Value == null ||
                cboChucVu.EditValue.ToString() == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
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
                if (bll.ktraTenDangNhap(txtTenDangNhap.Text) != null)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại.");
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
                NguoiDungDTO a = new NguoiDungDTO();
                //a.id = 4;
                a.name = txtTen.Text;
                a.TenDangNhap = txtTenDangNhap.Text;
                a.MatKhau = txtTenDangNhap.Text;
                a.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                a.SDT = txtSDT.Text;
                a.DiaChi = txtDiaChi.Text;
                a.Email = txtEmail.Text;
                a.NgayTao = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                a.NgayThayDoi = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                a.HoatDong = chkBiKhoa.Checked;
                a.idChucVu = cboChucVu.EditValue.ToString();
                a.GioiTinh = rdbNam.Checked == true ? "Nam" : "Nữ";
                a.Anh = selectedPath;
                a.MatKhau_confirmation = a.MatKhau;
                if (!bll.insert(a))
                {
                    MessageBox.Show("Thêm thất bại.");
                    return;
                }
            }
            else
            {
                NguoiDungDTO a = bll.findItem(_ma);
                if (bll.ktraTenDangNhap(txtTenDangNhap.Text) != null && a.TenDangNhap != txtTenDangNhap.Text)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại.");
                    return;
                }
                if (bll.ktraSDT(txtSDT.Text) != null && a.SDT != txtSDT.Text)
                {
                    MessageBox.Show("Số điện thoại đã được sử dụng.");
                    return;
                }
                if (bll.ktraEmail(txtEmail.Text) != null && a.Email != txtEmail.Text)
                {
                    MessageBox.Show("Email đã được sử dụng.");
                    return;
                }
                a.name = txtTen.Text;
                a.TenDangNhap = txtTenDangNhap.Text;
                a.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                a.SDT = txtSDT.Text;
                a.DiaChi = txtDiaChi.Text;
                a.Email = txtEmail.Text;
                a.Anh = selectedPath;
                a.HoatDong = chkBiKhoa.Checked;
                a.idChucVu = cboChucVu.EditValue.ToString();
                a.GioiTinh = rdbNam.Checked == true ? "Nam" : "Nữ";
                a.Anh = selectedPath;
                a.MatKhau_confirmation = a.MatKhau;
                bll.update(a);
            }
            _them = false;
            loadData();
            _enable(false);
            showHideControl(true);
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
                _ma = gvDanhSach.GetFocusedRowCellValue("id").ToString();
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("name").ToString();
                txtTenDangNhap.Text = gvDanhSach.GetFocusedRowCellValue("TenDangNhap").ToString();
                dtpNgaySinh.Value = DateTime.Parse(gvDanhSach.GetFocusedRowCellValue("NgaySinh").ToString());
                txtSDT.Text = gvDanhSach.GetFocusedRowCellValue("SDT").ToString();
                txtDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DiaChi").ToString();
                txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("Email").ToString();
                chkBiKhoa.Checked = Boolean.Parse(gvDanhSach.GetFocusedRowCellValue("HoatDong").ToString());
                cboChucVu.EditValue = gvDanhSach.GetFocusedRowCellValue("idChucVu").ToString();
                String t = gvDanhSach.GetFocusedRowCellValue("GioiTinh").ToString();
                if (t.Equals("Nam"))
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
                selectedPath = gvDanhSach.GetFocusedRowCellValue("Anh").ToString();
                if (File.Exists(pictureAddress + selectedPath))
                {
                    imgAnhDaiDien.Image = Image.FromFile(pictureAddress + selectedPath);
                }
                else
                {
                    imgAnhDaiDien.Image = Image.FromFile("../../../img/error.png");
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            selectedPath = OpenFile();
            if (!String.IsNullOrEmpty(pictureAddress + selectedPath) && File.Exists(pictureAddress + selectedPath))
            {
                imgAnhDaiDien.Image = Image.FromFile(pictureAddress + selectedPath);
            }
            else
            {
                imgAnhDaiDien.Image = Image.FromFile(pictureAddress + "error.png");
            }

        }

        private void btnThemChucVu_Click(object sender, EventArgs e)
        {
            frmChucVu frm = new frmChucVu();
            frm.ShowDialog();
        }

        private void btnResetMatKhau_Click(object sender, EventArgs e)
        {
            NguoiDungDTO a = bll.findItem(_ma);
            if (a == null)
            {
                MessageBox.Show("Vui lòng chọn người dùng cần đổi mật khẩu.");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn khôi phục mật khẩu mặc định của tài khoản: " + txtTenDangNhap.Text, "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                a.MatKhau = a.MatKhau_confirmation = txtTenDangNhap.Text;
                bll.resetMatKhau(a);
                loadData();
                MessageBox.Show("Khôi phục mật khẩu thành công.\nMật khẩu mới là tên đăng nhập.");
            }
        }
    }
}