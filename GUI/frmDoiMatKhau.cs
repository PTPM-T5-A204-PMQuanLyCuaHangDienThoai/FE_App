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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        NguoiDungBLL _nguoiDung;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            _nguoiDung = new NguoiDungBLL();
            txtMatKhauCu.Focus();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            NguoiDungDTO _nd = new NguoiDungDTO();
            _nd.id = Login.user.id;
            _nd.TenDangNhap = Login.user.TenDangNhap;
            _nd.MatKhau = txtMatKhauCu.Text;
            if (_nguoiDung.checkLogin(_nd))
            {
                if (txtMatKhauMoi.Text.Equals(txtNhapLaiMatKhau.Text))
                {
                    Login.user.MatKhau = Login.user.MatKhau_confirmation = txtMatKhauMoi.Text;
                    if (_nguoiDung.resetMatKhau(Login.user))
                        MessageBox.Show("Đổi mật khẩu thành công.");
                    else
                        MessageBox.Show("Đổi mật khẩu thất bại.");
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không trùng khớp.");
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu cũ.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}