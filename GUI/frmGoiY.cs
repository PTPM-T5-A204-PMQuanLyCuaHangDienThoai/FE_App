using BLL;
using DevExpress.Xpo.DB;
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
    public partial class frmGoiY : Form
    {
        AIBLL ai;
        List<AIDTO> list;
        DataTable table;
        ThuatToan tt;
        SanPhamBLL _sanPham;
        String pictureAddress = "../../../img/";
        void loadcboHieuSuat()
        {
            cboHieuSuat.DataSource = ai.getHieuSuat();
        }
        void loadcboPin()
        {
            cboPin.DataSource = ai.getPin();
        }
        void loadcboCamera()
        {
            cboCamera.DataSource = ai.getCamera();
        }
        void loadcboTanSo()
        {
            cboTanSo.DataSource = ai.getTanSo();
        }
        void loadList()
        {
            list = ai.get1000Data();
        }
        void loaddt()
        {
            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                table.Columns.Add(column.Name);
            }

            // Adding rows to the DataTable based on the rows in the DataGridView
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                DataRow dataRow = table.NewRow();

                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Check for DBNull before attempting the conversion
                    dataRow[cell.OwningColumn.Name] = (cell.Value != DBNull.Value) ? cell.Value : null;
                }

                table.Rows.Add(dataRow);
            }
        }
        void loaddgvData()
        {
            dgvData.DataSource = list;
            dgvData.ReadOnly = true;
        }
        public frmGoiY()
        {
            InitializeComponent();
        }

        private void frmGoiY_Load(object sender, EventArgs e)
        {
            ai = new AIBLL();
            list = new List<AIDTO>();
            table = new DataTable();
            tt = new ThuatToan();
            _sanPham = new SanPhamBLL();
            txtTenSanPham.Enabled = false;
            loadList();
            loaddgvData();
            loadcboHieuSuat();
            loadcboCamera();
            loadcboPin();
            loadcboTanSo();
            loaddt();
            tt.readDecisionTree(table, cboHieuSuat.Items.Count, cboCamera.Items.Count, cboPin.Items.Count, cboTanSo.Items.Count);
        }

        private void cboThuongHieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnGoiY_Click(object sender, EventArgs e)
        {
            if(
                cboHieuSuat.SelectedValue == null ||
                cboCamera.SelectedValue == null ||
                cboPin.SelectedValue == null ||
                cboTanSo.SelectedValue == null
                )
            {
                MessageBox.Show("Chọn đầy đủ thông tin.");
                return;
            }
            AIDTO a = new AIDTO();
            a.HieuSuat = cboHieuSuat.SelectedItem.ToString();
            a.Camera = cboCamera.SelectedItem.ToString();
            a.Pin = cboPin.SelectedItem.ToString();
            a.TanSo = cboTanSo.SelectedItem.ToString();
            String id = tt.goiY(a);
            SanPhamDTO b = _sanPham.findItem(id);
            if (b != null) 
            {
                txtTenSanPham.Text = b.name;
                if (File.Exists(pictureAddress + b.Anh))
                {
                    imgAnh.Image = Image.FromFile(pictureAddress + b.Anh);
                }
                else
                {
                    imgAnh.Image = Image.FromFile("../../../img/error.png");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm phù hợp với nhu cầu.");
            }
        }
    }
}
