using BLL;
using DTO;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        NavBarGroup navGroup;
        frmNguoiDung objNguoiDung;
        frmDanhMuc objDanhMuc;
        frmNhaCungCap objNhaCungCap;
        frmCuaHang objCuaHang;
        frmSanPham objSanPham;
        frmNhapHang objNhapHang;
        frmDoiMatKhau objDoiMatKhau;
        frmPhanQuyen objPhanQuyen;
        frmXuatHang objXuatHang;
        frmBaoHanh objBaoHanh;

        PhanQuyenBLL _phanQuyen;
        QuyenBLL _quyen;
        void addnavItem(String tag, String name)
        {
            NavBarItem navItem = new NavBarItem(name);
            navItem.Tag = tag;
            navItem.ImageOptions.SmallImageIndex = 0;
            navGroup.ItemLinks.Add(navItem);
        }
        void leftMenu()
        {
            int i = 0;
            navGroup = new NavBarGroup("ADMIN");
            navGroup.Tag = "ADMIN";
            navGroup.ImageOptions.LargeImageIndex = 0;
            navMain.Groups.Add(navGroup);

            //addnavItem("NguoiDung", "Người dùng");
            //addnavItem("DanhMuc", "Danh mục");
            //addnavItem("NhaCungCap", "Nhà cung cấp");
            //addnavItem("CuaHang", "Cửa hàng");
            //addnavItem("SanPham", "Sản phẩm");
            //addnavItem("DonHang", "Đơn hàng");
            //addnavItem("NhapHang", "Nhập hàng");

            //addnavItem("DoiMatKhau", "Đổi mật khẩu");

            //addnavItem("PhanQuyen", "Phân Quyền");

            foreach (QuyenDTO item in _quyen.getAll())
            {
                addnavItem(item.id, item.name);
            }


            navMain.Groups[navGroup.Name].Expanded = true;

        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _phanQuyen = new PhanQuyenBLL();
            _quyen = new QuyenBLL();
            leftMenu();
        }

        private void navMain_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            switch (e.Link.Item.Tag.ToString())
            {
                case "NguoiDung":
                    {
                        if (!_phanQuyen.ktraQuyen(e.Link.Item.Tag.ToString()))
                        {
                            MessageBox.Show("Bạn không có quyền truy cập chức năng này");
                            return;
                        }
                        if (objNguoiDung == null || objNguoiDung.IsDisposed)
                        {
                            objNguoiDung = new frmNguoiDung();
                            objNguoiDung.MdiParent = this;
                            objNguoiDung.Show();
                        }
                        else
                        {
                            objNguoiDung.Activate();
                        }
                        break;
                    }
                case "DanhMuc":
                    {
                        if (!_phanQuyen.ktraQuyen(e.Link.Item.Tag.ToString()))
                        {
                            MessageBox.Show("Bạn không có quyền truy cập chức năng này");
                            return;
                        }
                        if (objDanhMuc == null || objDanhMuc.IsDisposed)
                        {
                            objDanhMuc = new frmDanhMuc();
                            objDanhMuc.MdiParent = this;
                            objDanhMuc.Show();
                        }
                        else
                        {
                            objDanhMuc.Activate();
                        }
                        break;
                    }
                case "NhaCungCap":
                    {
                        if (!_phanQuyen.ktraQuyen(e.Link.Item.Tag.ToString()))
                        {
                            MessageBox.Show("Bạn không có quyền truy cập chức năng này");
                            return;
                        }
                        if (objNhaCungCap == null || objNhaCungCap.IsDisposed)
                        {
                            objNhaCungCap = new frmNhaCungCap();
                            objNhaCungCap.MdiParent = this;
                            objNhaCungCap.Show();
                        }
                        else
                        {
                            objNhaCungCap.Activate();
                        }
                        break;
                    }
                case "CuaHang":
                    {
                        if (!_phanQuyen.ktraQuyen(e.Link.Item.Tag.ToString()))
                        {
                            MessageBox.Show("Bạn không có quyền truy cập chức năng này");
                            return;
                        }
                        if (objCuaHang == null || objCuaHang.IsDisposed)
                        {
                            objCuaHang = new frmCuaHang();
                            objCuaHang.MdiParent = this;
                            objCuaHang.Show();
                        }
                        else
                        {
                            objCuaHang.Activate();
                        }
                        break;
                    }
                case "SanPham":
                    {
                        if (!_phanQuyen.ktraQuyen(e.Link.Item.Tag.ToString()))
                        {
                            MessageBox.Show("Bạn không có quyền truy cập chức năng này");
                            return;
                        }
                        if (objSanPham == null || objSanPham.IsDisposed)
                        {
                            objSanPham = new frmSanPham();
                            objSanPham.MdiParent = this;
                            objSanPham.Show();
                        }
                        else
                        {
                            objSanPham.Activate();
                        }
                        break;
                    }
                case "NhapHang":
                    {
                        if (!_phanQuyen.ktraQuyen(e.Link.Item.Tag.ToString()))
                        {
                            MessageBox.Show("Bạn không có quyền truy cập chức năng này");
                            return;
                        }
                        if (objNhapHang == null || objNhapHang.IsDisposed)
                        {
                            objNhapHang = new frmNhapHang();
                            objNhapHang.MdiParent = this;
                            objNhapHang.Show();
                        }
                        else
                        {
                            objNhapHang.Activate();
                        }
                        break;
                    }
                case "XuatHang":
                    {
                        if (!_phanQuyen.ktraQuyen(e.Link.Item.Tag.ToString()))
                        {
                            MessageBox.Show("Bạn không có quyền truy cập chức năng này");
                            return;
                        }
                        if (objXuatHang == null || objXuatHang.IsDisposed)
                        {
                            objXuatHang = new frmXuatHang();
                            objXuatHang.MdiParent = this;
                            objXuatHang.Show();
                        }
                        else
                        {
                            objXuatHang.Activate();
                        }
                        break;
                    }
                case "BaoHanh":
                    {
                        if (!_phanQuyen.ktraQuyen(e.Link.Item.Tag.ToString()))
                        {
                            MessageBox.Show("Bạn không có quyền truy cập chức năng này");
                            return;
                        }
                        if (objBaoHanh == null || objBaoHanh.IsDisposed)
                        {
                            objBaoHanh = new frmBaoHanh();
                            objBaoHanh.MdiParent = this;
                            objBaoHanh.Show();
                        }
                        else
                        {
                            objBaoHanh.Activate();
                        }
                        break;
                    }
                case "DoiMatKhau":
                    {
                        //if (!_phanQuyen.ktraQuyen(e.Link.Item.Tag.ToString()))
                        //{
                        //    MessageBox.Show("Bạn không có quyền truy cập chức năng này");
                        //    return;
                        //}
                        //if (objDoiMatKhau == null || objDoiMatKhau.IsDisposed)
                        //{
                        //    objDoiMatKhau = new frmDoiMatKhau();
                        //    objDoiMatKhau.MdiParent = this;
                        //    objDoiMatKhau.Show();
                        //}
                        //else
                        //{
                        //    objDoiMatKhau.Activate();
                        //}
                        objDoiMatKhau = new frmDoiMatKhau();
                        objDoiMatKhau.ShowDialog();
                        break;
                    }
                case "PhanQuyen":
                    {
                        if (!_phanQuyen.ktraQuyen(e.Link.Item.Tag.ToString()))
                        {
                            MessageBox.Show("Bạn không có quyền truy cập chức năng này");
                            return;
                        }
                        if (objPhanQuyen == null || objPhanQuyen.IsDisposed)
                        {
                            objPhanQuyen = new frmPhanQuyen();
                            objPhanQuyen.MdiParent = this;
                            objPhanQuyen.Show();
                        }
                        else
                        {
                            objPhanQuyen.Activate();
                        }
                        break;
                    }
            }
        }
    }
}