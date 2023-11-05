using BLL;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI
{
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        bool _them;
        String _ma;
        SanPhamBLL _sanPham;
        DanhMucBLL _danhMuc;
        NhaCungCapBLL _nhaCungCap;
        String selectedPath, pictureAddress = "../../../img/";
        void _enable(bool t)
        {
            txtid.Enabled = t;
            txtTen.Enabled = t;
            txtSoLuongTon.Enabled = t;
            txtGiaGoc.Enabled = t;
            txtGiaKhuyenMai.Enabled = t;
            txtMoTa.Enabled = t;
            txtManHinh.Enabled = t;
            txtDoPhanGiai.Enabled = t;
            txtTanSoQuet.Enabled = t;
            txtCameraSau.Enabled = t;
            txtCameraTruoc.Enabled = t;
            txtCPU.Enabled = t;
            txtGPU.Enabled = t;
            txtRam.Enabled = t;
            txtRom.Enabled = t;
            chkFlash.Enabled = t;
            txtPin.Enabled = t;
            txtSim.Enabled = t;
            txtHeDieuHanh.Enabled = t;
            txtHoTroMang.Enabled = t;
            chkKhangNuoc.Enabled = t;
            dtpThoiDiemRaMat.Enabled = t;
            chkTrangThai.Enabled = t;
            txtThoiGianBaoHanh.Enabled = t;
            txtThoiGianDoiTra.Enabled = t;
            cboDanhMuc.Enabled = t;
            cboNhaCungCap.Enabled = t;
            btnChonAnh.Enabled = t;
        }

        void _reset()
        {
            txtid.Text = String.Empty;
            txtTen.Text = String.Empty;
            txtSoLuongTon.Text = String.Empty;
            txtGiaGoc.Text = String.Empty;
            txtGiaKhuyenMai.Text = String.Empty;
            txtMoTa.Text = String.Empty;
            txtManHinh.Text = String.Empty;
            txtDoPhanGiai.Text = String.Empty;
            txtTanSoQuet.Text = String.Empty;
            txtCameraSau.Text = String.Empty;
            txtCameraTruoc.Text = String.Empty;
            txtCPU.Text = String.Empty;
            txtGPU.Text = String.Empty;
            txtRam.Text = String.Empty;
            txtRom.Text = String.Empty;
            chkFlash.Checked = true;
            txtPin.Text = String.Empty;
            txtSim.Text = String.Empty;
            txtHeDieuHanh.Text = String.Empty;
            txtHoTroMang.Text = String.Empty;
            chkKhangNuoc.Checked = true;
            dtpThoiDiemRaMat.Text = String.Empty;
            chkTrangThai.Checked = true;
            txtThoiGianBaoHanh.Text = String.Empty;
            txtThoiGianDoiTra.Text = String.Empty;
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
            gcDanhSach.DataSource = _sanPham.getAll();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void loadsearchDanhMuc()
        {
            cboDanhMuc.Properties.DataSource = _danhMuc.getAll();
            cboDanhMuc.Properties.ValueMember = "id";
            cboDanhMuc.Properties.DisplayMember = "name";
        }
        void loadsearchNhaCungCap()
        {
            cboNhaCungCap.Properties.DataSource = _nhaCungCap.getAll();
            cboNhaCungCap.Properties.ValueMember = "id";
            cboNhaCungCap.Properties.DisplayMember = "name";
        }

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
        public frmSanPham()
        {
            InitializeComponent();
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            _sanPham = new SanPhamBLL();
            _danhMuc = new DanhMucBLL();
            _nhaCungCap = new NhaCungCapBLL();
            loadsearchDanhMuc();
            loadsearchNhaCungCap();
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
                _sanPham.delete(_ma);
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtid.Text) ||
                String.IsNullOrEmpty(txtTen.Text) ||
                String.IsNullOrEmpty(txtSoLuongTon.Text) ||
                String.IsNullOrEmpty(txtGiaGoc.Text) ||
                String.IsNullOrEmpty(txtGiaKhuyenMai.Text) ||
                String.IsNullOrEmpty(txtMoTa.Text) ||
                String.IsNullOrEmpty(txtManHinh.Text) ||
                String.IsNullOrEmpty(txtDoPhanGiai.Text) ||
                String.IsNullOrEmpty(txtTanSoQuet.Text) ||
                String.IsNullOrEmpty(txtCameraSau.Text) ||
                String.IsNullOrEmpty(txtCameraTruoc.Text) ||
                String.IsNullOrEmpty(txtCPU.Text) ||
                String.IsNullOrEmpty(txtGPU.Text) ||
                String.IsNullOrEmpty(txtRam.Text) ||
                String.IsNullOrEmpty(txtRom.Text) ||
                String.IsNullOrEmpty(txtPin.Text) ||
                String.IsNullOrEmpty(txtSim.Text) ||
                String.IsNullOrEmpty(txtHeDieuHanh.Text) ||
                String.IsNullOrEmpty(txtHoTroMang.Text) ||
                String.IsNullOrEmpty(txtThoiGianBaoHanh.Text) ||
                String.IsNullOrEmpty(txtThoiGianDoiTra.Text) ||
                cboDanhMuc.EditValue == null ||
                cboNhaCungCap.EditValue == null ||
                imgAnhDaiDien.Image == null
                )
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (_them)
            {
                if (_sanPham.ktraTrungKey(txtid.Text))
                {
                    MessageBox.Show("ID đã tồn tại.");
                    return;
                }
                SanPhamDTO _data = new SanPhamDTO();
                _data.id = txtid.Text;
                _data.name = txtTen.Text;
                _data.SoLuongTon = Int32.Parse(txtSoLuongTon.Text);
                _data.GiaGoc = Int32.Parse(txtGiaGoc.Text);
                _data.GiaKhuyenMai = Int32.Parse(txtGiaKhuyenMai.Text);
                _data.MoTa = txtMoTa.Text;
                double soThuc;
                if(!double.TryParse(txtManHinh.Text, out soThuc))
                {
                    MessageBox.Show("Vui lòng nhập số thực");
                    return;
                }
                _data.ManHinh = float.Parse(txtManHinh.Text);
                _data.DoPhanGiai = txtDoPhanGiai.Text;
                _data.TanSoQuet = Int32.Parse(txtTanSoQuet.Text);
                _data.CameraSau = txtCameraSau.Text;
                _data.CameraTruoc = txtCameraTruoc.Text;
                _data.CPU = txtCPU.Text;
                _data.GPU = txtGPU.Text;
                _data.RAM = txtRam.Text;
                _data.ROM = txtRom.Text;
                _data.Flash = chkFlash.Checked;
                _data.Pin = Int32.Parse(txtPin.Text);
                _data.Sim = txtSim.Text;
                _data.HeDieuHanh = txtHeDieuHanh.Text;
                _data.HoTroMang = Int32.Parse(txtHoTroMang.Text);
                _data.KhangNuoc = chkKhangNuoc.Checked;
                _data.ThoiDiemRaMat = DateTime.Parse(dtpThoiDiemRaMat.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                _data.TrangThai = chkTrangThai.Checked;
                _data.ThoiGianBaoHanh = Int32.Parse(txtThoiGianBaoHanh.Text);
                _data.ThoiGianDoiTra = Int32.Parse(txtThoiGianDoiTra.Text);
                _data.idDanhMuc = cboDanhMuc.EditValue.ToString();
                _data.idNhaCungCap = cboNhaCungCap.EditValue.ToString();
                _data.Anh = selectedPath;
                _sanPham.insert(_data);
            }
            else
            {
                if (!_sanPham.ktraTrungKey(txtid.Text))
                {
                    MessageBox.Show("ID chưa tồn tại.");
                    return;
                }
                SanPhamDTO _data = _sanPham.findItem(txtid.Text);
                _data.name = txtTen.Text;
                _data.SoLuongTon = Int32.Parse(txtSoLuongTon.Text);
                _data.GiaGoc = Int32.Parse(txtGiaGoc.Text);
                _data.GiaKhuyenMai = Int32.Parse(txtGiaKhuyenMai.Text);
                _data.MoTa = txtMoTa.Text;
                double soThuc;
                if (!double.TryParse(txtManHinh.Text, out soThuc))
                {
                    MessageBox.Show("Vui lòng nhập số thực");
                    return;
                }
                _data.ManHinh = float.Parse(txtManHinh.Text);
                _data.DoPhanGiai = txtDoPhanGiai.Text;
                _data.TanSoQuet = Int32.Parse(txtTanSoQuet.Text);
                _data.CameraSau = txtCameraSau.Text;
                _data.CameraTruoc = txtCameraTruoc.Text;
                _data.CPU = txtCPU.Text;
                _data.GPU = txtGPU.Text;
                _data.RAM = txtRam.Text;
                _data.ROM = txtRom.Text;
                _data.Flash = chkFlash.Checked;
                _data.Pin = Int32.Parse(txtPin.Text);
                _data.Sim = txtSim.Text;
                _data.HeDieuHanh = txtHeDieuHanh.Text;
                _data.HoTroMang = Int32.Parse(txtHoTroMang.Text);
                _data.KhangNuoc = chkKhangNuoc.Checked;
                _data.ThoiDiemRaMat = DateTime.Parse(dtpThoiDiemRaMat.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                _data.TrangThai = chkTrangThai.Checked;
                _data.ThoiGianBaoHanh = Int32.Parse(txtThoiGianBaoHanh.Text);
                _data.ThoiGianDoiTra = Int32.Parse(txtThoiGianDoiTra.Text);
                _data.idDanhMuc = cboDanhMuc.EditValue.ToString();
                _data.idNhaCungCap = cboNhaCungCap.EditValue.ToString();
                _data.Anh = selectedPath;
                _sanPham.update(_data);
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
                _ma = txtid.Text = gvDanhSach.GetFocusedRowCellValue("id").ToString();
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("name").ToString();
                txtSoLuongTon.Text = gvDanhSach.GetFocusedRowCellValue("SoLuongTon").ToString();
                txtGiaGoc.Text = gvDanhSach.GetFocusedRowCellValue("GiaGoc").ToString();
                txtGiaKhuyenMai.Text = gvDanhSach.GetFocusedRowCellValue("GiaKhuyenMai").ToString();
                txtMoTa.Text = gvDanhSach.GetFocusedRowCellValue("MoTa").ToString();
                txtManHinh.Text = gvDanhSach.GetFocusedRowCellValue("ManHinh").ToString();
                txtDoPhanGiai.Text = gvDanhSach.GetFocusedRowCellValue("DoPhanGiai").ToString();
                txtTanSoQuet.Text = gvDanhSach.GetFocusedRowCellValue("TanSoQuet").ToString();
                txtCameraSau.Text = gvDanhSach.GetFocusedRowCellValue("CameraSau").ToString();
                txtCameraTruoc.Text = gvDanhSach.GetFocusedRowCellValue("CameraTruoc").ToString();
                txtCPU.Text = gvDanhSach.GetFocusedRowCellValue("CPU").ToString();
                txtGPU.Text = gvDanhSach.GetFocusedRowCellValue("GPU").ToString();
                txtRam.Text = gvDanhSach.GetFocusedRowCellValue("RAM").ToString();
                txtRom.Text = gvDanhSach.GetFocusedRowCellValue("ROM").ToString();
                chkFlash.Checked = gvDanhSach.GetFocusedRowCellValue("Flash").ToString() == "True" ? true : false;
                txtPin.Text = gvDanhSach.GetFocusedRowCellValue("Pin").ToString();
                txtSim.Text = gvDanhSach.GetFocusedRowCellValue("Sim").ToString();
                txtHeDieuHanh.Text = gvDanhSach.GetFocusedRowCellValue("HeDieuHanh").ToString();
                txtHoTroMang.Text = gvDanhSach.GetFocusedRowCellValue("HoTroMang").ToString();
                chkKhangNuoc.Checked = gvDanhSach.GetFocusedRowCellValue("KhangNuoc").ToString() == "True" ? true : false;
                dtpThoiDiemRaMat.Value = DateTime.Parse(gvDanhSach.GetFocusedRowCellValue("ThoiDiemRaMat").ToString());
                chkTrangThai.Checked = gvDanhSach.GetFocusedRowCellValue("TrangThai").ToString() == "True" ? true : false;
                txtThoiGianBaoHanh.Text = gvDanhSach.GetFocusedRowCellValue("ThoiGianBaoHanh").ToString();
                txtThoiGianDoiTra.Text = gvDanhSach.GetFocusedRowCellValue("ThoiGianDoiTra").ToString();
                cboDanhMuc.EditValue = gvDanhSach.GetFocusedRowCellValue("idDanhMuc").ToString();
                cboNhaCungCap.EditValue = gvDanhSach.GetFocusedRowCellValue("idNhaCungCap").ToString();
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
    }
}