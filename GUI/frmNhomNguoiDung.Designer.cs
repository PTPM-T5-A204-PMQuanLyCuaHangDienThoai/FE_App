namespace GUI
{
    partial class frmNhomNguoiDung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhomNguoiDung));
            this.nhomnguoidung_idNguoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhomnguoidung_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvNhomNguoiDung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nhomnguoidung_idNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNhomNguoiDung = new DevExpress.XtraGrid.GridControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.nhom_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhom_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvNhom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcNhom = new DevExpress.XtraGrid.GridControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNhom = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.gcNguoiDung = new DevExpress.XtraGrid.GridControl();
            this.gvNguoiDung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nguoidung_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nguoidung_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nguoidung_TenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nguoidung_MatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nguoidung_NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nguoidung_SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nguoidung_DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nguoidung_Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nguoidung_NgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nguoidung_NgayThayDoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nguoidung_HoatDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nguoidung_idChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nguoidung_GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nguoidung_Anh = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhomNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // nhomnguoidung_idNguoiDung
            // 
            this.nhomnguoidung_idNguoiDung.Caption = "ID Người dùng";
            this.nhomnguoidung_idNguoiDung.FieldName = "idNguoiDung";
            this.nhomnguoidung_idNguoiDung.Name = "nhomnguoidung_idNguoiDung";
            this.nhomnguoidung_idNguoiDung.Visible = true;
            this.nhomnguoidung_idNguoiDung.VisibleIndex = 1;
            // 
            // nhomnguoidung_id
            // 
            this.nhomnguoidung_id.Caption = "ID";
            this.nhomnguoidung_id.FieldName = "id";
            this.nhomnguoidung_id.Name = "nhomnguoidung_id";
            // 
            // gvNhomNguoiDung
            // 
            this.gvNhomNguoiDung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nhomnguoidung_id,
            this.nhomnguoidung_idNhom,
            this.nhomnguoidung_idNguoiDung});
            this.gvNhomNguoiDung.GridControl = this.gcNhomNguoiDung;
            this.gvNhomNguoiDung.Name = "gvNhomNguoiDung";
            // 
            // nhomnguoidung_idNhom
            // 
            this.nhomnguoidung_idNhom.Caption = "ID Nhóm";
            this.nhomnguoidung_idNhom.FieldName = "idNhom";
            this.nhomnguoidung_idNhom.Name = "nhomnguoidung_idNhom";
            this.nhomnguoidung_idNhom.Visible = true;
            this.nhomnguoidung_idNhom.VisibleIndex = 0;
            // 
            // gcNhomNguoiDung
            // 
            this.gcNhomNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNhomNguoiDung.Location = new System.Drawing.Point(2, 23);
            this.gcNhomNguoiDung.MainView = this.gvNhomNguoiDung;
            this.gcNhomNguoiDung.Name = "gcNhomNguoiDung";
            this.gcNhomNguoiDung.Size = new System.Drawing.Size(373, 347);
            this.gcNhomNguoiDung.TabIndex = 1;
            this.gcNhomNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhomNguoiDung});
            this.gcNhomNguoiDung.DoubleClick += new System.EventHandler(this.gcNhomNguoiDung_DoubleClick);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gcNguoiDung);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 189);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(431, 180);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Thông tin người dùng";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcNhomNguoiDung);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(437, 25);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(377, 372);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Phân nhóm";
            // 
            // nhom_name
            // 
            this.nhom_name.Caption = "Tên nhóm";
            this.nhom_name.FieldName = "name";
            this.nhom_name.Name = "nhom_name";
            this.nhom_name.Visible = true;
            this.nhom_name.VisibleIndex = 1;
            // 
            // nhom_id
            // 
            this.nhom_id.Caption = "ID";
            this.nhom_id.FieldName = "id";
            this.nhom_id.Name = "nhom_id";
            this.nhom_id.Visible = true;
            this.nhom_id.VisibleIndex = 0;
            // 
            // gvNhom
            // 
            this.gvNhom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nhom_id,
            this.nhom_name});
            this.gvNhom.GridControl = this.gcNhom;
            this.gvNhom.Name = "gvNhom";
            // 
            // gcNhom
            // 
            this.gcNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNhom.Location = new System.Drawing.Point(2, 23);
            this.gcNhom.MainView = this.gvNhom;
            this.gcNhom.Name = "gcNhom";
            this.gcNhom.Size = new System.Drawing.Size(427, 155);
            this.gcNhom.TabIndex = 0;
            this.gcNhom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhom});
            this.gcNhom.Click += new System.EventHandler(this.gcNhom_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcNhom);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(431, 180);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Thông tin nhóm";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(437, 372);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 372);
            this.panel1.TabIndex = 5;
            // 
            // btnNhom
            // 
            this.btnNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnNhom.Image")));
            this.btnNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNhom.Name = "btnNhom";
            this.btnNhom.Size = new System.Drawing.Size(61, 22);
            this.btnNhom.Text = "Nhóm";
            this.btnNhom.Click += new System.EventHandler(this.btnNhom_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNhom});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(814, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // gcNguoiDung
            // 
            this.gcNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNguoiDung.Location = new System.Drawing.Point(2, 23);
            this.gcNguoiDung.MainView = this.gvNguoiDung;
            this.gcNguoiDung.Name = "gcNguoiDung";
            this.gcNguoiDung.Size = new System.Drawing.Size(427, 155);
            this.gcNguoiDung.TabIndex = 5;
            this.gcNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNguoiDung});
            this.gcNguoiDung.DoubleClick += new System.EventHandler(this.gcNguoiDung_DoubleClick);
            // 
            // gvNguoiDung
            // 
            this.gvNguoiDung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nguoidung_id,
            this.nguoidung_name,
            this.nguoidung_TenDangNhap,
            this.nguoidung_MatKhau,
            this.nguoidung_NgaySinh,
            this.nguoidung_SDT,
            this.nguoidung_DiaChi,
            this.nguoidung_Email,
            this.nguoidung_NgayTao,
            this.nguoidung_NgayThayDoi,
            this.nguoidung_HoatDong,
            this.nguoidung_idChucVu,
            this.nguoidung_GioiTinh,
            this.nguoidung_Anh});
            this.gvNguoiDung.GridControl = this.gcNguoiDung;
            this.gvNguoiDung.Name = "gvNguoiDung";
            // 
            // nguoidung_id
            // 
            this.nguoidung_id.Caption = "ID";
            this.nguoidung_id.FieldName = "id";
            this.nguoidung_id.Name = "nguoidung_id";
            this.nguoidung_id.Visible = true;
            this.nguoidung_id.VisibleIndex = 0;
            // 
            // nguoidung_name
            // 
            this.nguoidung_name.Caption = "Họ tên";
            this.nguoidung_name.FieldName = "name";
            this.nguoidung_name.Name = "nguoidung_name";
            this.nguoidung_name.Visible = true;
            this.nguoidung_name.VisibleIndex = 1;
            // 
            // nguoidung_TenDangNhap
            // 
            this.nguoidung_TenDangNhap.Caption = "Tên đăng nhập";
            this.nguoidung_TenDangNhap.FieldName = "TenDangNhap";
            this.nguoidung_TenDangNhap.Name = "nguoidung_TenDangNhap";
            this.nguoidung_TenDangNhap.Visible = true;
            this.nguoidung_TenDangNhap.VisibleIndex = 2;
            // 
            // nguoidung_MatKhau
            // 
            this.nguoidung_MatKhau.Caption = "Mật khẩu";
            this.nguoidung_MatKhau.FieldName = "MatKhau";
            this.nguoidung_MatKhau.Name = "nguoidung_MatKhau";
            // 
            // nguoidung_NgaySinh
            // 
            this.nguoidung_NgaySinh.Caption = "Ngày sinh";
            this.nguoidung_NgaySinh.FieldName = "NgaySinh";
            this.nguoidung_NgaySinh.Name = "nguoidung_NgaySinh";
            // 
            // nguoidung_SDT
            // 
            this.nguoidung_SDT.Caption = "Số điện thoại";
            this.nguoidung_SDT.FieldName = "SDT";
            this.nguoidung_SDT.Name = "nguoidung_SDT";
            this.nguoidung_SDT.Visible = true;
            this.nguoidung_SDT.VisibleIndex = 3;
            // 
            // nguoidung_DiaChi
            // 
            this.nguoidung_DiaChi.Caption = "Địa chỉ";
            this.nguoidung_DiaChi.FieldName = "DiaChi";
            this.nguoidung_DiaChi.Name = "nguoidung_DiaChi";
            // 
            // nguoidung_Email
            // 
            this.nguoidung_Email.Caption = "Email";
            this.nguoidung_Email.FieldName = "Email";
            this.nguoidung_Email.Name = "nguoidung_Email";
            // 
            // nguoidung_NgayTao
            // 
            this.nguoidung_NgayTao.Caption = "Ngày tạo";
            this.nguoidung_NgayTao.FieldName = "NgayTao";
            this.nguoidung_NgayTao.Name = "nguoidung_NgayTao";
            // 
            // nguoidung_NgayThayDoi
            // 
            this.nguoidung_NgayThayDoi.Caption = "Ngày thay đổi";
            this.nguoidung_NgayThayDoi.FieldName = "NgayThayDoi";
            this.nguoidung_NgayThayDoi.Name = "nguoidung_NgayThayDoi";
            // 
            // nguoidung_HoatDong
            // 
            this.nguoidung_HoatDong.Caption = "Hoạt động";
            this.nguoidung_HoatDong.FieldName = "HoatDong";
            this.nguoidung_HoatDong.Name = "nguoidung_HoatDong";
            // 
            // nguoidung_idChucVu
            // 
            this.nguoidung_idChucVu.Caption = "Chức vụ";
            this.nguoidung_idChucVu.FieldName = "idChucVu";
            this.nguoidung_idChucVu.Name = "nguoidung_idChucVu";
            this.nguoidung_idChucVu.Visible = true;
            this.nguoidung_idChucVu.VisibleIndex = 4;
            // 
            // nguoidung_GioiTinh
            // 
            this.nguoidung_GioiTinh.Caption = "Giới tính";
            this.nguoidung_GioiTinh.FieldName = "GioiTinh";
            this.nguoidung_GioiTinh.Name = "nguoidung_GioiTinh";
            // 
            // nguoidung_Anh
            // 
            this.nguoidung_Anh.Caption = "Ảnh đại diện";
            this.nguoidung_Anh.FieldName = "Anh";
            this.nguoidung_Anh.Name = "nguoidung_Anh";
            // 
            // frmNhomNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 397);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhomNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHÓM NGƯỜI DÙNG";
            this.Load += new System.EventHandler(this.frmNhomNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhomNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn nhomnguoidung_idNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn nhomnguoidung_id;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhomNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn nhomnguoidung_idNhom;
        private DevExpress.XtraGrid.GridControl gcNhomNguoiDung;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn nhom_name;
        private DevExpress.XtraGrid.Columns.GridColumn nhom_id;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhom;
        private DevExpress.XtraGrid.GridControl gcNhom;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btnNhom;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.GridControl gcNguoiDung;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn nguoidung_id;
        private DevExpress.XtraGrid.Columns.GridColumn nguoidung_name;
        private DevExpress.XtraGrid.Columns.GridColumn nguoidung_TenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn nguoidung_MatKhau;
        private DevExpress.XtraGrid.Columns.GridColumn nguoidung_NgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn nguoidung_SDT;
        private DevExpress.XtraGrid.Columns.GridColumn nguoidung_DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn nguoidung_Email;
        private DevExpress.XtraGrid.Columns.GridColumn nguoidung_NgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn nguoidung_NgayThayDoi;
        private DevExpress.XtraGrid.Columns.GridColumn nguoidung_HoatDong;
        private DevExpress.XtraGrid.Columns.GridColumn nguoidung_idChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn nguoidung_GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn nguoidung_Anh;
    }
}