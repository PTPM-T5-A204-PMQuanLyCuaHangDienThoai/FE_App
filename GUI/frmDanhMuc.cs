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
    public partial class frmDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        bool _them;
        String _ma;
        DanhMucBLL bll;
        String selectedPath, pictureAddress = "../../../img/";
        frmSanPham objSanPham = (frmSanPham)Application.OpenForms["frmSanPham"];
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
        public frmDanhMuc()
        {
            InitializeComponent();
        }
        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            bll = new DanhMucBLL();
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

            if (String.IsNullOrEmpty(txtid.Text) || String.IsNullOrEmpty(txtTen.Text) || imgAnhDaiDien.Image == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (_them)
            {
                if (bll.findItem(txtid.Text) != null)
                {
                    MessageBox.Show("ID đã tồn tại.");
                    return;
                }
                DanhMucDTO _data = new DanhMucDTO();
                _data.id = txtid.Text;
                _data.name= txtTen.Text;
                bll.insert(_data);
            }
            else
            {
                DanhMucDTO _data = bll.findItem(txtid.Text);
                if (bll.findItem(txtid.Text) == null)
                {
                    MessageBox.Show("ID không tồn tại.");
                    return;
                }
                _data.name = txtTen.Text;
                bll.update(_data);
            }
            _them = false;
            loadData();
            _enable(false);
            showHideControl(true);
            if (objSanPham != null)
            {
                objSanPham.loadsearchDanhMuc();
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