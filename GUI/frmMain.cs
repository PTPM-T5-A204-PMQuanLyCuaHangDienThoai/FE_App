﻿using DevExpress.XtraEditors;
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
        frmCuaHang objCuaHang;
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

            addnavItem("NguoiDung", "Người dùng");
            addnavItem("DanhMuc", "Danh mục");
            addnavItem("CuaHang", "Cửa hàng");
            addnavItem("TinTuc", "Tin tức");
            addnavItem("SanPham", "Sản phẩm");
            addnavItem("DonHang", "Đơn hàng");
            addnavItem("NhapHang", "Nhập hàng");

            addnavItem("DoiMatKhau", "Đổi mật khẩu");



            navMain.Groups[navGroup.Name].Expanded = true;

        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            leftMenu();
        }

        private void navMain_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            switch (e.Link.Item.Tag.ToString())
            {
                case "NguoiDung":
                    {
                        //if (!_phanQuyen.ktraQuyen(pnBanHang.Tag.ToString()))
                        //{
                        //    MessageBox.Show("Bạn không có quyền truy cập chức năng này");
                        //    return;
                        //}
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
                        //if (!_phanQuyen.ktraQuyen(pnBanHang.Tag.ToString()))
                        //{
                        //    MessageBox.Show("Bạn không có quyền truy cập chức năng này");
                        //    return;
                        //}
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
                case "CuaHang":
                    {
                        //if (!_phanQuyen.ktraQuyen(pnBanHang.Tag.ToString()))
                        //{
                        //    MessageBox.Show("Bạn không có quyền truy cập chức năng này");
                        //    return;
                        //}
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
            }
        }
    }
}