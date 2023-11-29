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
    public partial class frmNhapHang : DevExpress.XtraEditors.XtraForm
    {
        bool _them;
        String _ma;
        PhieuNhapBLL _phieuNhap;
        ChiTietPhieuNhapBLL _chiTietPhieuNhap;
        NhaCungCapBLL _nhaCungCap;
        SanPhamBLL _sanPham;
        SanPhamDTO sp;
        ListView lv;
        List<ChiTietPhieuNhapDTO> listCT;
        String pictureAddress = "../../../img/";
        frmSanPham objSanPham = (frmSanPham)Application.OpenForms["frmSanPham"];
        void _enable(bool t)
        {
            dtpNgayNhap.Enabled = t;
            cboNhaCungCap.Enabled = t;
        }
        void _reset()
        {
            dtpNgayNhap.Value = DateTime.Now;
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
            btnHoanThanh.Visible = t;
        }
        void loadgcDanhSachFull()
        {
            gcDanhSach.DataSource = _phieuNhap.getAll();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void loadgcDanhSachChuaHoanThanh()
        {
            gcDanhSach.DataSource = _phieuNhap.getDataTheoTrangThai(false);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void loadgcDanhSachHoanThanh()
        {
            gcDanhSach.DataSource = _phieuNhap.getDataTheoTrangThai(true);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        public void loadcboNhaCungCap()
        {
            cboNhaCungCap.Properties.DataSource = _nhaCungCap.getAll();
            cboNhaCungCap.Properties.ValueMember = "id";
            cboNhaCungCap.Properties.DisplayMember = "name";
        }
        public void setcboNhaCungCap(String id)
        {
            cboNhaCungCap.EditValue = id;
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
                    listViewItem.Text = item.name + "\n";
                }
                else
                {
                    listViewItem.Text = item.name + "\n";
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
            List<SanPhamDTO> lstData = _sanPham.findDataTheoTrangThai(true, txtTim.Text);
            if (lstData == null)
            {
                return;
            }
            foreach (SanPhamDTO item in lstData)
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
                    listViewItem.Text = item.name + "\n";
                }
                else
                {
                    listViewItem.Text = item.name + "\n";
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
            listCT = _chiTietPhieuNhap.findDataByidPhieuNhap(_ma);
            gcChiTiet.DataSource = listCT;
            //gvChiTiet.OptionsBehavior.Editable = false;
        }
        void tinhlblTongTien()
        {
            int tongTien = 0;
            foreach (ChiTietPhieuNhapDTO item in listCT)
            {
                tongTien += item.SoLuong * item.GiaNhap;
            }
            lblTongtien.Text = double.Parse(tongTien.ToString()).ToString("N0");
        }
        public frmNhapHang()
        {
            InitializeComponent();
        }
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            _phieuNhap = new PhieuNhapBLL();
            _chiTietPhieuNhap = new ChiTietPhieuNhapBLL();
            _nhaCungCap = new NhaCungCapBLL();
            _sanPham = new SanPhamBLL();
            gcDanhSach.ContextMenuStrip = contextMenuStrip1;
            loadcboNhaCungCap();
            loadgcDanhSachChuaHoanThanh();
            showHideControl(true);
            _enable(false);
            txtIDSanPham.Enabled = txtTenSanPham.Enabled = false;
            txtTongSoLuong.Enabled = false;
            txtTongTien.Enabled = false;
            chkTrangThai.Enabled = false;
        }

        private void Lv_Click(object sender, EventArgs e)
        {
            sp = (SanPhamDTO)lv.SelectedItems[0].Tag;
        }

        private void menuTatCa_Click(object sender, EventArgs e)
        {
            loadgcDanhSachFull();
        }

        private void menuChuaHoanThanh_Click(object sender, EventArgs e)
        {
            loadgcDanhSachChuaHoanThanh();
        }

        private void menuHoanThanh_Click(object sender, EventArgs e)
        {
            loadgcDanhSachHoanThanh();
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
            if (!_phieuNhap.ktraTrungKey(_ma))
            {
                MessageBox.Show("Phiếu không tồn tại.");
                return;
            }
            if (chkTrangThai.Checked)
            {
                MessageBox.Show("Bạn không thể chỉnh sửa bất kỳ phiếu nhập nào đã hoàn thành.");
                return;
            }
            _them = false;
            //_enable(true);
            showHideControl(false);
            tabDanhSach.SelectedTabPage = pageChiTiet;
            txtTim.Text = String.Empty;
            listCT = new List<ChiTietPhieuNhapDTO>();
            loadgcChiTiet();
            loadlstData();
            lv.Click += Lv_Click;
            tinhlblTongTien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (chkTrangThai.Checked)
            {
                MessageBox.Show("Bạn không thể xóa bất kỳ phiếu nhập nào đã hoàn thành.");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn xóa phiếu nhập và toàn bộ chi tiết của phiếu nhập " + _ma + " không?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(_phieuNhap.findItem(_ma) == null)
                {
                    MessageBox.Show("Phiếu nhập không tồn tại.");
                    return;
                }
                loadgcChiTiet();
                foreach(ChiTietPhieuNhapDTO item in listCT)
                {
                    _chiTietPhieuNhap.delete(item.id.ToString());
                }
                _phieuNhap.delete(_ma);
            }
            loadgcDanhSachChuaHoanThanh();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboNhaCungCap.EditValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (_them)
            {
                PhieuNhapDTO data = new PhieuNhapDTO();
                data.NgayNhap = DateTime.Parse(dtpNgayNhap.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                data.TongSoLuong = 0;
                data.TongTien = 0;
                data.TrangThai = false;
                data.idNhaCungCap = cboNhaCungCap.EditValue.ToString();
                data.idNhanVien = Login.user.id;
                _phieuNhap.insert(data);
                loadgcDanhSachChuaHoanThanh();
            }
            else
            {
                int tongTien = 0;
                foreach(ChiTietPhieuNhapDTO item in listCT)
                {
                    ChiTietPhieuNhapDTO data = _chiTietPhieuNhap.findDataByCTPhieuNhap_SanPham(item.idSanPham, item.idPhieuNhap.ToString());
                    if (data == null)
                    {
                        _chiTietPhieuNhap.insert(item);
                    }
                    else
                    {
                        data.SoLuong = item.SoLuong;
                        data.GiaNhap = item.GiaNhap;
                        tongTien += data.SoLuong * data.GiaNhap;
                        _chiTietPhieuNhap.update(data);
                    }
                }
                PhieuNhapDTO pn = _phieuNhap.findItem(_ma);
                pn.TongSoLuong = Int32.Parse(gvChiTiet.Columns["SoLuong"].SummaryItem.SummaryValue.ToString());
                pn.TongTien = tongTien;
                _phieuNhap.update(pn);
                loadgcDanhSachChuaHoanThanh();
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
                dtpNgayNhap.Value= DateTime.Parse(gvDanhSach.GetFocusedRowCellValue("NgayNhap").ToString());
                cboNhaCungCap.EditValue= gvDanhSach.GetFocusedRowCellValue("idNhaCungCap").ToString();
                txtTongSoLuong.Text = gvDanhSach.GetFocusedRowCellValue("TongSoLuong").ToString();
                txtTongTien.Text = double.Parse(gvDanhSach.GetFocusedRowCellValue("TongTien").ToString()).ToString("N0");
                chkTrangThai.Checked = gvDanhSach.GetFocusedRowCellValue("TrangThai").ToString() == "True" ? true : false;
            }
        }

        private void gcDanhSach_DoubleClick(object sender, EventArgs e)
        {
            btnSua.PerformClick();
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (!_phieuNhap.ktraTrungKey(_ma))
            {
                MessageBox.Show("ID không tồn tại.");
                return;
            }
            if (chkTrangThai.Checked)
            {
                MessageBox.Show("Phiếu nhập đã hoàn thành.");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn hoàn thành nhập hàng cho phiếu nhập " + _ma + " không?","Xác nhận",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PhieuNhapDTO data = _phieuNhap.findItem(_ma);
                data.TrangThai = true;
                _phieuNhap.update(data);
                loadgcDanhSachChuaHoanThanh();
                foreach(ChiTietPhieuNhapDTO item in _chiTietPhieuNhap.findDataByidPhieuNhap(_ma))
                {
                    sp = _sanPham.findItem(item.idSanPham);
                    sp.SoLuongTon += item.SoLuong;
                    _sanPham.update(sp);
                }
                if (objSanPham != null)
                {
                    objSanPham.loadData();
                }
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
            foreach (ChiTietPhieuNhapDTO item in listCT)
            {
                if(item.idSanPham.Equals(sp.id) && item.idPhieuNhap == Int32.Parse(_ma))
                {
                    item.SoLuong++;
                    gcChiTiet.DataSource = null;
                    gcChiTiet.DataSource = listCT;
                    return;
                }
            }
            ChiTietPhieuNhapDTO a = new ChiTietPhieuNhapDTO();

            a.idSanPham = sp.id;
            a.GiaNhap = 0;
            a.SoLuong = 1;
            a.idPhieuNhap = Int32.Parse(_ma);
            listCT.Add(a);
            gcChiTiet.DataSource = null;
            gcChiTiet.DataSource = listCT;
            tinhlblTongTien();
            //if (a == null)
            //{
            //    a = new ChiTietPhieuNhapDTO();
            //    a.idSanPham = sp.id;
            //    a.GiaNhap = 0;
            //    a.SoLuong = 1;
            //    a.idPhieuNhap = Int32.Parse(_ma);
            //    _chiTietPhieuNhap.insert(a);
            //}
            //else
            //{
            //    a.SoLuong++;
            //    _chiTietPhieuNhap.update(a);
            //}

            ////loaddgvCTHoaDon();
            //txtTongTien.Text = _chiTietPhieuNhap.timTongTien(idHoaDon).ToString("N0");
        }

        private void gcChiTiet_Click(object sender, EventArgs e)
        {
            if(gvChiTiet.RowCount > 0)
            {
                SanPhamDTO a = _sanPham.findItem(gvChiTiet.GetFocusedRowCellValue("idSanPham").ToString());
                if(a == null)
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

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            frm.nhaphang = "nhaphang";
            frm.ShowDialog();
        }
    }
}