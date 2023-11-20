using BLL;
using DevExpress.Xpo.DB;
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

namespace GUI
{
    public partial class frmBaoHanh : DevExpress.XtraEditors.XtraForm
    {
        PhieuXuatBLL _phieuXuat;
        ChiTietPhieuXuatBLL _chiTietPhieuXuat;
        BaoHanhBLL _baoHanh;
        SanPhamBLL _sanPham;
        NguoiDungBLL _nguoiDung;
        String _ma;
        SanPhamDTO sp;
        int _idPhieuXuat = 0, _idChiTietPhieuXuat = 0;
        bool _them;
        String pictureAddress = "../../../img/";
        void _enable(bool t)
        {
            dtpNgayTraHang.Enabled = t;
            cboKhachHang.Enabled = t;
            txtChiPhi.Enabled = t;
            txtLyDo.Enabled = t;
            chkTrangThai.Enabled = t;
        }
        void _reset()
        {
            dtpNgayTraHang.Value = DateTime.Now;
            txtChiPhi.Text = "0";
            txtLyDo.Text = String.Empty;
            chkTrangThai.Checked = false;
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
        public void loadcboKhachHang()
        {
            cboKhachHang.Properties.DataSource = _nguoiDung.getAll();
            cboKhachHang.Properties.ValueMember = "id";
            cboKhachHang.Properties.DisplayMember = "name";
        }
        void loadgcDanhSach()
        {
            gcDanhSach.DataSource = _phieuXuat.getDataTheoTinhTrang_TrangThai(2, true);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void loadgcChiTiet()
        {
            gcChiTiet.DataSource = _chiTietPhieuXuat.findDataByidPhieuXuat(_idPhieuXuat.ToString());
            gvChiTiet.OptionsBehavior.Editable = false;
        }
        void loadgcBaoHanh()
        {
            gcBaoHanh.DataSource = _baoHanh.getDataByidPhieuXuat(_idPhieuXuat.ToString());
            gvBaoHanh.OptionsBehavior.Editable = false;
        }
        public void setcboKhachHang(int id)
        {
            cboKhachHang.EditValue = id;
        }
        public frmBaoHanh()
        {
            InitializeComponent();
        }

        private void frmBaoHanh_Load(object sender, EventArgs e)
        {
            _phieuXuat = new PhieuXuatBLL();
            _chiTietPhieuXuat = new ChiTietPhieuXuatBLL();
            _baoHanh = new BaoHanhBLL();
            _sanPham = new SanPhamBLL();
            _nguoiDung = new NguoiDungBLL();
            loadcboKhachHang();
            loadgcDanhSach();
            showHideControl(true);
            _enable(false);
            txtSanPham.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideControl(false);
            _enable(true);
            _reset();
            chkTrangThai.Checked = false;
            chkTrangThai.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            _enable(true);
            showHideControl(false);
            chkTrangThai.Checked = false;
            chkTrangThai.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (chkTrangThai.Checked)
            {
                MessageBox.Show("Bạn không thể xóa bảo hành đã xác nhận trả cho khách hàng.");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _baoHanh.delete(_ma);
            }
            loadgcBaoHanh();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(_idPhieuXuat == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất.");
                return;
            }
            if(_idChiTietPhieuXuat == 0)
            {
                MessageBox.Show("Vui lòng chọn chi tiết phiếu xuất.");
                return;
            }
            ChiTietPhieuXuatDTO a = _chiTietPhieuXuat.findItem(_idChiTietPhieuXuat.ToString());
            if(a.idPhieuXuat != _idPhieuXuat)
            {
                MessageBox.Show("Vui lòng chọn chi tiết phiếu xuất.");
                return;
            }
            if (cboKhachHang.EditValue == null || String.IsNullOrEmpty(txtChiPhi.Text) || String.IsNullOrEmpty(txtLyDo.Text))
            {
                MessageBox.Show("Vui lòng nhập chi phí và chọn khách hàng.");
                return;
            }

            if (_them)
            {
                if (_baoHanh.ktraTrungKey(_ma))
                {
                    MessageBox.Show("ID đã tồn tại.");
                    return;
                }
                BaoHanhDTO data = new BaoHanhDTO();
                data.idChiTietPhieuXuat = _idChiTietPhieuXuat;
                data.LyDo = txtLyDo.Text;
                data.NgayBaoHanh = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                data.NgayTraHang = DateTime.Parse(dtpNgayTraHang.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                data.idNhanVien = Login.user.id;
                data.idKhachHang = (int)cboKhachHang.EditValue;
                data.ChiPhi = Int32.Parse(txtChiPhi.Text);
                data.TrangThai = false;
                data.idPhieuXuat = _idPhieuXuat;
                _baoHanh.insert(data);
            }
            else
            {
                if (!_baoHanh.ktraTrungKey(_ma))
                {
                    MessageBox.Show("ID không tồn tại.");
                    return;
                }
                BaoHanhDTO data = _baoHanh.findItem(_ma);
                data.LyDo = txtLyDo.Text;
                data.NgayTraHang = DateTime.Parse(dtpNgayTraHang.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                data.idNhanVien = Login.user.id;
                data.idKhachHang = (int)cboKhachHang.EditValue;
                data.ChiPhi = Int32.Parse(txtChiPhi.Text);
                _baoHanh.update(data);
            }
            _them = false;
            loadgcBaoHanh();
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

        private void gcChiTiet_Click(object sender, EventArgs e)
        {
            if(gvChiTiet.RowCount > 0)
            {
                _idChiTietPhieuXuat = (int)gvChiTiet.GetFocusedRowCellValue("id");
                sp = _sanPham.findItem(gvChiTiet.GetFocusedRowCellValue("idSanPham").ToString());
                if(sp != null)
                {
                    txtSanPham.Text = sp.name;
                    if (File.Exists(pictureAddress + sp.Anh))
                    {
                        imgAnhDaiDien.Image = Image.FromFile(pictureAddress + sp.Anh);
                    }
                    else
                    {
                        imgAnhDaiDien.Image = Image.FromFile("../../../img/error.png");
                    }
                }
            }
        }

        private void gcBaoHanh_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvChiTiet.RowCount > 0)
                {
                    ChiTietPhieuXuatDTO temp = _chiTietPhieuXuat.findItem(gvBaoHanh.GetFocusedRowCellValue("idChiTietPhieuXuat").ToString());
                    sp = _sanPham.findItem(temp.idSanPham);
                    if (sp != null)
                    {
                        txtSanPham.Text = sp.name;
                        if (File.Exists(pictureAddress + sp.Anh))
                        {
                            imgAnhDaiDien.Image = Image.FromFile(pictureAddress + sp.Anh);
                        }
                        else
                        {
                            imgAnhDaiDien.Image = Image.FromFile("../../../img/error.png");
                        }
                    }
                    cboKhachHang.EditValue = (int)gvBaoHanh.GetFocusedRowCellValue("idKhachHang");
                    dtpNgayTraHang.Value = DateTime.Parse(gvBaoHanh.GetFocusedRowCellValue("NgayTraHang").ToString());
                    txtChiPhi.Text = gvBaoHanh.GetFocusedRowCellValue("ChiPhi").ToString();
                    txtLyDo.Text = gvBaoHanh.GetFocusedRowCellValue("LyDo").ToString();
                    chkTrangThai.Checked = gvBaoHanh.GetFocusedRowCellValue("TrangThai").ToString() == "True" ? true : false;
                    _idPhieuXuat = (int)gvBaoHanh.GetFocusedRowCellValue("idPhieuXuat");
                    _idChiTietPhieuXuat = (int)gvBaoHanh.GetFocusedRowCellValue("idChiTietPhieuXuat");
                    _ma = gvBaoHanh.GetFocusedRowCellValue("id").ToString();
                }
            }
            catch
            {

            }
        }

        private void btnTrangThai_Click(object sender, EventArgs e)
        {
            BaoHanhDTO data = _baoHanh.findItem(_ma);
            if(data == null)
            {
                MessageBox.Show("Vui lòng chọn bảo hành cần cập nhật trạng thái.");
                return;
            }
            if(data.TrangThai)
            {
                MessageBox.Show("Bảo hành vốn đã trả cho khách hàng.");
                return;
            }
            data.TrangThai = true;
            data.idNhanVien = Login.user.id;
            _baoHanh.update(data);
            loadgcBaoHanh();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmNguoiDung frm = new frmNguoiDung();
            frm.xuathang = "baohanh";
            frm.ShowDialog();
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.RowCount > 0)
            {
                _idPhieuXuat = (int)gvDanhSach.GetFocusedRowCellValue("id");
                loadgcChiTiet();
                loadgcBaoHanh();
                cboKhachHang.EditValue = Int32.Parse(gvDanhSach.GetFocusedRowCellValue("idKhachHang").ToString());
            }
        }
    }
}