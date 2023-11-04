namespace GUI
{
    partial class frmPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyen));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPhanNhom = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gcQuyen = new DevExpress.XtraGrid.GridControl();
            this.gvQuyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.quyen_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quyen_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcNhom = new DevExpress.XtraGrid.GridControl();
            this.gvNhom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nhom_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhom_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcPhanQuyen = new DevExpress.XtraGrid.GridControl();
            this.gvPhanQuyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.phanquyen_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phanquyen_idNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phanquyen_idQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPhanNhom});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1025, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPhanNhom
            // 
            this.btnPhanNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanNhom.Image")));
            this.btnPhanNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPhanNhom.Name = "btnPhanNhom";
            this.btnPhanNhom.Size = new System.Drawing.Size(89, 22);
            this.btnPhanNhom.Text = "Phân nhóm";
            this.btnPhanNhom.Click += new System.EventHandler(this.btnPhanNhom_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 415);
            this.panel1.TabIndex = 2;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(437, 415);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gcQuyen);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 210);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(431, 202);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Thông tin quyền";
            // 
            // gcQuyen
            // 
            this.gcQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcQuyen.Location = new System.Drawing.Point(2, 23);
            this.gcQuyen.MainView = this.gvQuyen;
            this.gcQuyen.Name = "gcQuyen";
            this.gcQuyen.Size = new System.Drawing.Size(427, 177);
            this.gcQuyen.TabIndex = 1;
            this.gcQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvQuyen});
            this.gcQuyen.DoubleClick += new System.EventHandler(this.gcQuyen_DoubleClick);
            // 
            // gvQuyen
            // 
            this.gvQuyen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.quyen_id,
            this.quyen_name});
            this.gvQuyen.GridControl = this.gcQuyen;
            this.gvQuyen.Name = "gvQuyen";
            // 
            // quyen_id
            // 
            this.quyen_id.Caption = "ID";
            this.quyen_id.FieldName = "id";
            this.quyen_id.Name = "quyen_id";
            this.quyen_id.Visible = true;
            this.quyen_id.VisibleIndex = 0;
            // 
            // quyen_name
            // 
            this.quyen_name.Caption = "Tên quyền";
            this.quyen_name.FieldName = "name";
            this.quyen_name.Name = "quyen_name";
            this.quyen_name.Visible = true;
            this.quyen_name.VisibleIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcNhom);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(431, 201);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Thông tin nhóm";
            // 
            // gcNhom
            // 
            this.gcNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNhom.Location = new System.Drawing.Point(2, 23);
            this.gcNhom.MainView = this.gvNhom;
            this.gcNhom.Name = "gcNhom";
            this.gcNhom.Size = new System.Drawing.Size(427, 176);
            this.gcNhom.TabIndex = 0;
            this.gcNhom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhom});
            this.gcNhom.Click += new System.EventHandler(this.gcNhom_Click);
            // 
            // gvNhom
            // 
            this.gvNhom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nhom_id,
            this.nhom_name});
            this.gvNhom.GridControl = this.gcNhom;
            this.gvNhom.Name = "gvNhom";
            // 
            // nhom_id
            // 
            this.nhom_id.Caption = "ID";
            this.nhom_id.FieldName = "id";
            this.nhom_id.Name = "nhom_id";
            this.nhom_id.Visible = true;
            this.nhom_id.VisibleIndex = 0;
            // 
            // nhom_name
            // 
            this.nhom_name.Caption = "Tên nhóm";
            this.nhom_name.FieldName = "name";
            this.nhom_name.Name = "nhom_name";
            this.nhom_name.Visible = true;
            this.nhom_name.VisibleIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcPhanQuyen);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(437, 25);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(588, 415);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Phân quyền";
            // 
            // gcPhanQuyen
            // 
            this.gcPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPhanQuyen.Location = new System.Drawing.Point(2, 23);
            this.gcPhanQuyen.MainView = this.gvPhanQuyen;
            this.gcPhanQuyen.Name = "gcPhanQuyen";
            this.gcPhanQuyen.Size = new System.Drawing.Size(584, 390);
            this.gcPhanQuyen.TabIndex = 1;
            this.gcPhanQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhanQuyen});
            this.gcPhanQuyen.DoubleClick += new System.EventHandler(this.gcPhanQuyen_DoubleClick);
            // 
            // gvPhanQuyen
            // 
            this.gvPhanQuyen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.phanquyen_id,
            this.phanquyen_idNhom,
            this.phanquyen_idQuyen});
            this.gvPhanQuyen.GridControl = this.gcPhanQuyen;
            this.gvPhanQuyen.Name = "gvPhanQuyen";
            // 
            // phanquyen_id
            // 
            this.phanquyen_id.Caption = "ID";
            this.phanquyen_id.FieldName = "id";
            this.phanquyen_id.Name = "phanquyen_id";
            // 
            // phanquyen_idNhom
            // 
            this.phanquyen_idNhom.Caption = "ID Nhóm";
            this.phanquyen_idNhom.FieldName = "idNhom";
            this.phanquyen_idNhom.Name = "phanquyen_idNhom";
            this.phanquyen_idNhom.Visible = true;
            this.phanquyen_idNhom.VisibleIndex = 0;
            // 
            // phanquyen_idQuyen
            // 
            this.phanquyen_idQuyen.Caption = "ID Quyền";
            this.phanquyen_idQuyen.FieldName = "idQuyen";
            this.phanquyen_idQuyen.Name = "phanquyen_idQuyen";
            this.phanquyen_idQuyen.Visible = true;
            this.phanquyen_idQuyen.VisibleIndex = 1;
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 440);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PHÂN QUYỀN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanQuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPhanNhom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gcQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gvQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn quyen_id;
        private DevExpress.XtraGrid.Columns.GridColumn quyen_name;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcNhom;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhom;
        private DevExpress.XtraGrid.Columns.GridColumn nhom_id;
        private DevExpress.XtraGrid.Columns.GridColumn nhom_name;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcPhanQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhanQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn phanquyen_id;
        private DevExpress.XtraGrid.Columns.GridColumn phanquyen_idNhom;
        private DevExpress.XtraGrid.Columns.GridColumn phanquyen_idQuyen;
    }
}