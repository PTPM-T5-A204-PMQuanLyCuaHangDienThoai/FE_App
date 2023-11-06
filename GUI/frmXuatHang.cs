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

namespace GUI
{
    public partial class frmXuatHang : DevExpress.XtraEditors.XtraForm
    {
        bool _them;
        String _ma;
        PhieuXuatBLL _phieuXuat;
        ChiTietPhieuXuatBLL _chiTietPhieuXuat;
        NguoiDungBLL _khachHang;
        SanPhamBLL _sanPham;
        SanPhamDTO sp;
        ListView lv;
        List<ChiTietPhieuXuatDTO> listCT;
        String pictureAddress = "../../../img/";
        frmSanPham objSanPham = (frmSanPham)Application.OpenForms["frmSanPham"];
        void _enable(bool t)
        {
            dtpNgayXuat.Enabled = t;
            cboKhachHang.Enabled = t;
        }
        void _reset()
        {
            dtpNgayXuat.Value = DateTime.Now;
            txtTongSoLuong.Text = String.Empty;
            txtTongTien.Text = String.Empty;
        }
        void showHideControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;
            btnTrangThai.Visible = t;
            btnXacNhan.Visible = t;
        }
        void loadgcDanhSachFull()
        {
            gcDanhSach.DataSource = _phieuXuat.getAll();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void loadgcDanhSachChuaThanhToan()
        {
            gcDanhSach.DataSource = _phieuXuat.getDataTheoTrangThai(false);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void loadgcDanhSachThanhToan()
        {
            gcDanhSach.DataSource = _phieuXuat.getDataTheoTrangThai(true);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void loadgcDanhSachChuaXacNhan()
        {
            gcDanhSach.DataSource = _phieuXuat.getDataTheoTinhTrang(false);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void loadgcDanhSachXacNhan()
        {
            gcDanhSach.DataSource = _phieuXuat.getDataTheoTinhTrang(true);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void loadgcDanhSachChuaThanhToan_XacNhan()
        {
            gcDanhSach.DataSource = _phieuXuat.getDataTheoTinhTrang_TrangThai(false, false);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void loadgcDanhSachThanhToan_XacNhan()
        {
            gcDanhSach.DataSource = _phieuXuat.getDataTheoTinhTrang_TrangThai(true, true);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        public void loadcboKhachHang()
        {
            cboKhachHang.Properties.DataSource = _khachHang.getAll();
            cboKhachHang.Properties.ValueMember = "id";
            cboKhachHang.Properties.DisplayMember = "name";
        }
        public void setcboKhachHang(int id)
        {
            cboKhachHang.EditValue = id;
        }
        public void loadlstData()
        {
            pnSanPham.Controls.Clear();
            lv = new ListView();
            ImageList img = new ImageList();
            img.ImageSize = new Size(200, 200);
            lv.LargeImageList = img;
            lv.Dock = DockStyle.Fill;
            lv.ForeColor = Color.White;

            foreach (SanPhamDTO item in _sanPham.getDataTheoTrangThai(true))
            {
                if (File.Exists(pictureAddress + item.Anh))
                {
                    img.Images.Add(item.Anh.GetHashCode().ToString(), Image.FromFile(pictureAddress + item.Anh));
                }
                else
                {
                    img.Images.Add(item.Anh.GetHashCode().ToString(), Image.FromFile("../../../img/error.png"));
                }
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.ImageKey = item.Anh.GetHashCode().ToString();
                listViewItem.Font = new Font(listViewItem.Font.FontFamily, 16);
                listViewItem.ForeColor = Color.Black;
                listViewItem.Font = new Font(listViewItem.Font.FontFamily, listViewItem.Font.Size, FontStyle.Bold);
                listViewItem.Tag = item;
                if (item.GiaKhuyenMai == item.GiaGoc)
                {
                    listViewItem.Text = item.name + "\n" + "Giá: " + item.GiaKhuyenMai + " đ\n\n\n";
                }
                else
                {
                    listViewItem.Text = item.name + "\n" + "Giá gốc: " + item.GiaGoc + " đ\n" + "Giá khuyến mãi: " + item.GiaKhuyenMai + " đ\n\n\n";
                }
                listViewItem.SubItems.Add(item.GiaGoc.ToString());
                listViewItem.SubItems.Add(item.GiaKhuyenMai.ToString());
                lv.Items.Add(listViewItem);
            }
            lv.ContextMenuStrip = contextMenuStrip2;
            pnSanPham.Controls.Add(lv);
        }
        public void findlstData()
        {
            pnSanPham.Controls.Clear();
            lv = new ListView();
            ImageList img = new ImageList();
            img.ImageSize = new Size(200, 200);
            lv.LargeImageList = img;
            lv.Dock = DockStyle.Fill;
            lv.ForeColor = Color.White;

            foreach (SanPhamDTO item in _sanPham.findDataTheoTrangThai(true, txtTim.Text))
            {
                if (File.Exists(pictureAddress + item.Anh))
                {
                    img.Images.Add(item.Anh.GetHashCode().ToString(), Image.FromFile(item.Anh));
                }
                else
                {
                    img.Images.Add(item.Anh.GetHashCode().ToString(), Image.FromFile("../../../img/error.png"));
                }
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.ImageKey = item.Anh.GetHashCode().ToString();
                listViewItem.Font = new Font(listViewItem.Font.FontFamily, 16);
                listViewItem.Font = new Font(listViewItem.Font.FontFamily, listViewItem.Font.Size, FontStyle.Bold);
                listViewItem.Tag = item;
                if (item.GiaKhuyenMai == item.GiaGoc)
                {
                    listViewItem.Text = item.name + "\n" + "Giá: " + item.GiaKhuyenMai + " đ\n\n\n";
                }
                else
                {
                    listViewItem.Text = item.name + "\n" + "Giá gốc: " + item.GiaGoc + " đ\n" + "Giá khuyến mãi: " + item.GiaKhuyenMai + " đ\n\n\n";
                }
                listViewItem.SubItems.Add(item.GiaGoc.ToString());
                listViewItem.SubItems.Add(item.GiaKhuyenMai.ToString());
                lv.Items.Add(listViewItem);
            }
            lv.ContextMenuStrip = contextMenuStrip2;
            pnSanPham.Controls.Add(lv);
        }
        void loadgcChiTiet()
        {
            listCT = _chiTietPhieuXuat.findDataByidPhieuXuat(_ma);
            gcChiTiet.DataSource = listCT;
            //gvChiTiet.OptionsBehavior.Editable = false;
        }
        void tinhlblTongTien()
        {
            int tongTien = 0;
            foreach (ChiTietPhieuXuatDTO item in listCT)
            {
                tongTien += item.SoLuong * item.GiaNhap;
            }
            lblTongtien.Text = double.Parse(tongTien.ToString()).ToString("N0");
        }
        public frmXuatHang()
        {
            InitializeComponent();
        }
        private void frmXuatHang_Load(object sender, EventArgs e)
        {
            _phieuXuat = new PhieuXuatBLL();
            _chiTietPhieuXuat = new ChiTietPhieuXuatBLL();
            _khachHang = new NguoiDungBLL();
            _sanPham = new SanPhamBLL();
            gcDanhSach.ContextMenuStrip = contextMenuStrip1;
            loadcboKhachHang();
            loadgcDanhSachChuaThanhToan();
            showHideControl(true);
            _enable(false);
            txtIDSanPham.Enabled = txtTenSanPham.Enabled = false;
            txtTongSoLuong.Enabled = false;
            txtTongTien.Enabled = false;
            chkTrangThai.Enabled = chkTinhTrang.Enabled = false;
        }

        private void Lv_Click(object sender, EventArgs e)
        {
            sp = (SanPhamDTO)lv.SelectedItems[0].Tag;
        }

        private void menuTatCa_Click(object sender, EventArgs e)
        {
            loadgcDanhSachFull();
        }

        private void menuChuaThanhToan_Click(object sender, EventArgs e)
        {
            loadgcDanhSachChuaThanhToan();
        }

        private void menuThanhToan_Click(object sender, EventArgs e)
        {
            loadgcDanhSachThanhToan();
        }
        private void menuChuaXacNhan_Click(object sender, EventArgs e)
        {
            loadgcDanhSachChuaXacNhan();
        }
        private void menuXacNhan_Click(object sender, EventArgs e)
        {
            loadgcDanhSachXacNhan();
        }
        private void menuChuaThanhToan_XacNhan_Click(object sender, EventArgs e)
        {
            loadgcDanhSachChuaThanhToan_XacNhan();
        }
        private void menuThanhToan_XacNhan_Click(object sender, EventArgs e)
        {
            loadgcDanhSachThanhToan_XacNhan();
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
            if (!_phieuXuat.ktraTrungKey(_ma))
            {
                MessageBox.Show("Phiếu không tồn tại.");
                return;
            }
            if (chkTrangThai.Checked || chkTinhTrang.Checked)
            {
                MessageBox.Show("Bạn không thể chỉnh sửa bất kỳ phiếu xuất nào đã xác nhận hoặc thanh toán.");
                return;
            }
            _them = false;
            //_enable(true);
            showHideControl(false);
            tabDanhSach.SelectedTabPage = pageChiTiet;
            txtTim.Text = String.Empty;
            listCT = new List<ChiTietPhieuXuatDTO>();
            loadgcChiTiet();
            loadlstData();
            lv.Click += Lv_Click;
            tinhlblTongTien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (chkTrangThai.Checked)
            {
                MessageBox.Show("Bạn không thể xóa bất kỳ phiếu xuất nào đã thanh toán.");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn xóa phiếu xuất và toàn bộ chi tiết của phiếu xuất " + _ma + " không?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_phieuXuat.findItem(_ma) == null)
                {
                    MessageBox.Show("Phiếu xuất không tồn tại.");
                    return;
                }
                loadgcChiTiet();
                foreach (ChiTietPhieuXuatDTO item in listCT)
                {
                    _chiTietPhieuXuat.delete(item.id.ToString());
                }
                _phieuXuat.delete(_ma);
            }
            loadgcDanhSachChuaThanhToan();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboKhachHang.EditValue == null)
            {
                MessageBox.Show("Vui lòng xuất đầy đủ thông tin.");
                return;
            }

            if (_them)
            {
                PhieuXuatDTO data = new PhieuXuatDTO();
                data.NgayXuat = DateTime.Parse(dtpNgayXuat.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                data.TongSoLuong = 0;
                data.TongTien = 0;
                data.TinhTrang = false;
                data.TrangThai = false;
                data.idKhachHang = cboKhachHang.EditValue.ToString();
                data.idNhanVien = Login.user.id;
                _phieuXuat.insert(data);
                loadgcDanhSachChuaThanhToan();
            }
            else
            {
                int tongTien = 0;
                foreach (ChiTietPhieuXuatDTO item in listCT)
                {
                    ChiTietPhieuXuatDTO data = _chiTietPhieuXuat.findDataByCTPhieuXuat_SanPham(item.idSanPham, item.idPhieuXuat.ToString());
                    if (data == null)
                    {
                        _chiTietPhieuXuat.insert(item);
                    }
                    else
                    {
                        data.SoLuong = item.SoLuong;
                        data.GiaNhap = item.GiaNhap;
                        tongTien += data.SoLuong * data.GiaNhap;
                        _chiTietPhieuXuat.update(data);
                    }
                }
                PhieuXuatDTO pn = _phieuXuat.findItem(_ma);
                pn.TongSoLuong = Int32.Parse(gvChiTiet.Columns["SoLuong"].SummaryItem.SummaryValue.ToString());
                pn.TongTien = tongTien;
                _phieuXuat.update(pn);
                loadgcDanhSachChuaThanhToan();
                tabDanhSach.SelectedTabPage = pageDanhSach;
            }
            _them = false;
            _enable(false);
            showHideControl(true);
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);
            _enable(false);
            tabDanhSach.SelectedTabPage = pageDanhSach;
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
                dtpNgayXuat.Value = DateTime.Parse(gvDanhSach.GetFocusedRowCellValue("NgayXuat").ToString());
                cboKhachHang.EditValue = Int32.Parse(gvDanhSach.GetFocusedRowCellValue("idKhachHang").ToString());
                txtTongSoLuong.Text = gvDanhSach.GetFocusedRowCellValue("TongSoLuong").ToString();
                txtTongTien.Text = double.Parse(gvDanhSach.GetFocusedRowCellValue("TongTien").ToString()).ToString("N0");
                chkTrangThai.Checked = gvDanhSach.GetFocusedRowCellValue("TrangThai").ToString() == "True" ? true : false;
                chkTinhTrang.Checked = gvDanhSach.GetFocusedRowCellValue("TinhTrang").ToString() == "True" ? true : false;
            }
        }

        private void gcDanhSach_DoubleClick(object sender, EventArgs e)
        {
            btnSua.PerformClick();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!_phieuXuat.ktraTrungKey(_ma))
            {
                MessageBox.Show("ID không tồn tại.");
                return;
            }
            if (!chkTinhTrang.Checked)
            {
                MessageBox.Show("Vui lòng xác nhận phiếu xuất trước khi thanh toán.");
                return;
            }
            if (chkTrangThai.Checked)
            {
                MessageBox.Show("Phiếu xuất đã thanh toán.");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn thanh toán xuất hàng cho phiếu xuất " + _ma + " không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PhieuXuatDTO data = _phieuXuat.findItem(_ma);
                data.TrangThai = true;
                _phieuXuat.update(data);
                loadgcDanhSachChuaThanhToan();
                foreach (ChiTietPhieuXuatDTO item in _chiTietPhieuXuat.findDataByidPhieuXuat(_ma))
                {
                    sp = _sanPham.findItem(item.idSanPham);
                    sp.SoLuongTon -= item.SoLuong;
                    _sanPham.update(sp);
                }
                if (objSanPham != null)
                {
                    objSanPham.loadData();
                }
            }
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!_phieuXuat.ktraTrungKey(_ma))
            {
                MessageBox.Show("ID không tồn tại.");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xác nhận xuất hàng cho phiếu xuất " + _ma + " không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PhieuXuatDTO data = _phieuXuat.findItem(_ma);
                data.TinhTrang = true;
                _phieuXuat.update(data);
                loadgcDanhSachChuaThanhToan();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            findlstData();
            lv.Click += Lv_Click;
        }

        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTim.PerformClick();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            if (sp == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm.");
                return;
            }
            foreach (ChiTietPhieuXuatDTO item in listCT)
            {
                if (item.idSanPham.Equals(sp.id) && item.idPhieuXuat == Int32.Parse(_ma))
                {
                    item.SoLuong++;
                    gcChiTiet.DataSource = null;
                    gcChiTiet.DataSource = listCT;
                    tinhlblTongTien();
                    return;
                }
            }
            ChiTietPhieuXuatDTO a = new ChiTietPhieuXuatDTO();

            a.idSanPham = sp.id;
            a.GiaNhap = sp.GiaKhuyenMai;
            a.SoLuong = 1;
            a.idPhieuXuat = Int32.Parse(_ma);
            listCT.Add(a);
            gcChiTiet.DataSource = null;
            gcChiTiet.DataSource = listCT;
            tinhlblTongTien();
        }

        private void gcChiTiet_Click(object sender, EventArgs e)
        {
            if (gvChiTiet.RowCount > 0)
            {
                SanPhamDTO a = _sanPham.findItem(gvChiTiet.GetFocusedRowCellValue("idSanPham").ToString());
                if (a == null)
                {
                    MessageBox.Show("Lỗi sản phẩm không tồn tại.");
                    return;
                }
                txtIDSanPham.Text = a.id;
                txtTenSanPham.Text = a.name;
                if (File.Exists(pictureAddress + a.Anh))
                {
                    imgAnhDaiDien.Image = Image.FromFile(pictureAddress + a.Anh);
                }
                else
                {
                    imgAnhDaiDien.Image = Image.FromFile("../../../img/error.png");
                }
            }
        }

        private void gvChiTiet_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gvChiTiet.UpdateTotalSummary();
            tinhlblTongTien();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmNguoiDung frm = new frmNguoiDung();
            frm.xuathang = "nhaphang";
            frm.ShowDialog();
        }
    }
}