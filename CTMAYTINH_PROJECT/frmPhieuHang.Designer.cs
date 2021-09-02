namespace CTMAYTINH_PROJECT
{
    partial class frmPhieuHang
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_LOAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuHang));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnPhieuKhac = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnTimgia = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMax = new DevExpress.XtraEditors.TextEdit();
            this.txtMin = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnTao = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNguoiLap = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sAN_PHAMDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAN_PHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAI_SPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSDL_PROJECT_CTMAYTINHDataSet = new CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.iD_LOAIListBox = new System.Windows.Forms.ListBox();
            this.lOAI_SPTableAdapter = new CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.LOAI_SPTableAdapter();
            this.tableAdapterManager = new CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.TableAdapterManager();
            this.sAN_PHAMTableAdapter = new CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.SAN_PHAMTableAdapter();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtFrom = new DevExpress.XtraEditors.TextEdit();
            this.txtTo = new DevExpress.XtraEditors.TextEdit();
            iD_LOAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAN_PHAMDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAN_PHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_SPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSDL_PROJECT_CTMAYTINHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_LOAILabel
            // 
            iD_LOAILabel.AutoSize = true;
            iD_LOAILabel.Location = new System.Drawing.Point(9, 63);
            iD_LOAILabel.Name = "iD_LOAILabel";
            iD_LOAILabel.Size = new System.Drawing.Size(107, 13);
            iD_LOAILabel.TabIndex = 2;
            iD_LOAILabel.Text = "Danh mục sản phẩm:";
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = global::CTMAYTINH_PROJECT.Properties.Resources.iconedit;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(880, 49);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 536);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(880, 31);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnPhieuKhac);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.btnTao);
            this.groupControl1.Controls.Add(this.btnDel);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtNguoiLap);
            this.groupControl1.Controls.Add(this.txtMa);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.sAN_PHAMDataGridView);
            this.groupControl1.Controls.Add(this.dataGridView1);
            this.groupControl1.Controls.Add(this.dateTimePicker1);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(iD_LOAILabel);
            this.groupControl1.Controls.Add(this.iD_LOAIListBox);
            this.groupControl1.Location = new System.Drawing.Point(12, 55);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(856, 479);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Chi tiết phiếu";
            // 
            // btnPhieuKhac
            // 
            this.btnPhieuKhac.Image = global::CTMAYTINH_PROJECT.Properties.Resources.add_icon;
            this.btnPhieuKhac.Location = new System.Drawing.Point(738, 30);
            this.btnPhieuKhac.Name = "btnPhieuKhac";
            this.btnPhieuKhac.Size = new System.Drawing.Size(103, 23);
            this.btnPhieuKhac.TabIndex = 17;
            this.btnPhieuKhac.Text = "Tạo phiếu mới";
            this.btnPhieuKhac.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.xtraTabControl1);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Location = new System.Drawing.Point(579, 79);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(272, 176);
            this.groupControl2.TabIndex = 16;
            this.groupControl2.Text = "Tìm kiếm và lọc sản phẩm";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 24);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(262, 116);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnTim);
            this.xtraTabPage1.Controls.Add(this.txtTen);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(256, 88);
            this.xtraTabPage1.Text = "Tên";
            // 
            // btnTim
            // 
            this.btnTim.Image = global::CTMAYTINH_PROJECT.Properties.Resources.Document_Preview_icon;
            this.btnTim.Location = new System.Drawing.Point(169, 30);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(13, 33);
            this.txtTen.MenuManager = this.ribbon;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(150, 20);
            this.txtTen.TabIndex = 1;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.labelControl5);
            this.xtraTabPage4.Controls.Add(this.btnTimgia);
            this.xtraTabPage4.Controls.Add(this.labelControl6);
            this.xtraTabPage4.Controls.Add(this.txtMax);
            this.xtraTabPage4.Controls.Add(this.txtMin);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(256, 88);
            this.xtraTabPage4.Text = "Khoảng giá";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(117, 21);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(20, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Max";
            // 
            // btnTimgia
            // 
            this.btnTimgia.Location = new System.Drawing.Point(92, 44);
            this.btnTimgia.Name = "btnTimgia";
            this.btnTimgia.Size = new System.Drawing.Size(75, 23);
            this.btnTimgia.TabIndex = 3;
            this.btnTimgia.Text = "Tìm";
            this.btnTimgia.Click += new System.EventHandler(this.btnTimgia_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 21);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(16, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Min";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(143, 18);
            this.txtMax.MenuManager = this.ribbon;
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 20);
            this.txtMax.TabIndex = 1;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(29, 18);
            this.txtMin.MenuManager = this.ribbon;
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(82, 20);
            this.txtMin.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(105, 146);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Bỏ tìm kiếm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnTao
            // 
            this.btnTao.Image = global::CTMAYTINH_PROJECT.Properties.Resources.order_history_icon;
            this.btnTao.Location = new System.Drawing.Point(650, 357);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(158, 62);
            this.btnTao.TabIndex = 15;
            this.btnTao.Text = "Tạo phiếu hàng";
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = global::CTMAYTINH_PROJECT.Properties.Resources.Actions_window_close_icon;
            this.btnDel.Location = new System.Drawing.Point(357, 261);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::CTMAYTINH_PROJECT.Properties.Resources.add_icon;
            this.btnAdd.Location = new System.Drawing.Point(250, 261);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ngày lập:";
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Location = new System.Drawing.Point(582, 30);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.ReadOnly = true;
            this.txtNguoiLap.Size = new System.Drawing.Size(100, 21);
            this.txtNguoiLap.TabIndex = 11;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(81, 30);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(100, 21);
            this.txtMa.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(513, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Người lập:";
            // 
            // sAN_PHAMDataGridView
            // 
            this.sAN_PHAMDataGridView.AutoGenerateColumns = false;
            this.sAN_PHAMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sAN_PHAMDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            this.sAN_PHAMDataGridView.DataSource = this.sAN_PHAMBindingSource;
            this.sAN_PHAMDataGridView.Location = new System.Drawing.Point(131, 79);
            this.sAN_PHAMDataGridView.Name = "sAN_PHAMDataGridView";
            this.sAN_PHAMDataGridView.ReadOnly = true;
            this.sAN_PHAMDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sAN_PHAMDataGridView.Size = new System.Drawing.Size(445, 176);
            this.sAN_PHAMDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_SANPHAM";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TEN_SP";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tên sản phẩm";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MOTA";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mô tả";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "GIA";
            this.dataGridViewTextBoxColumn8.HeaderText = "Giá";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // sAN_PHAMBindingSource
            // 
            this.sAN_PHAMBindingSource.DataMember = "FK_SAN_PHAM_LOAI_SP";
            this.sAN_PHAMBindingSource.DataSource = this.lOAI_SPBindingSource;
            // 
            // lOAI_SPBindingSource
            // 
            this.lOAI_SPBindingSource.DataMember = "LOAI_SP";
            this.lOAI_SPBindingSource.DataSource = this.cSDL_PROJECT_CTMAYTINHDataSet;
            // 
            // cSDL_PROJECT_CTMAYTINHDataSet
            // 
            this.cSDL_PROJECT_CTMAYTINHDataSet.DataSetName = "CSDL_PROJECT_CTMAYTINHDataSet";
            this.cSDL_PROJECT_CTMAYTINHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(131, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(445, 178);
            this.dataGridView1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(263, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Mã phiếu:";
            // 
            // iD_LOAIListBox
            // 
            this.iD_LOAIListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lOAI_SPBindingSource, "ID_LOAI", true));
            this.iD_LOAIListBox.DataSource = this.lOAI_SPBindingSource;
            this.iD_LOAIListBox.DisplayMember = "LOAI_SP";
            this.iD_LOAIListBox.FormattingEnabled = true;
            this.iD_LOAIListBox.Location = new System.Drawing.Point(5, 79);
            this.iD_LOAIListBox.Name = "iD_LOAIListBox";
            this.iD_LOAIListBox.Size = new System.Drawing.Size(120, 173);
            this.iD_LOAIListBox.TabIndex = 3;
            this.iD_LOAIListBox.ValueMember = "ID_LOAI";
            // 
            // lOAI_SPTableAdapter
            // 
            this.lOAI_SPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHI_TIET_PHIEUTableAdapter = null;
            this.tableAdapterManager.HOA_DONTableAdapter = null;
            this.tableAdapterManager.KHACH_HANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAI_KHACHTableAdapter = null;
            this.tableAdapterManager.LOAI_SPTableAdapter = this.lOAI_SPTableAdapter;
            this.tableAdapterManager.NHA_PPTableAdapter = null;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHIEU_HANGTableAdapter = null;
            this.tableAdapterManager.SAN_PHAMTableAdapter = this.sAN_PHAMTableAdapter;
            this.tableAdapterManager.UpdateOrder = CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VAI_TROTableAdapter = null;
            // 
            // sAN_PHAMTableAdapter
            // 
            this.sAN_PHAMTableAdapter.ClearBeforeFill = true;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(256, 88);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(34, 21);
            this.txtFrom.MenuManager = this.ribbon;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(76, 20);
            this.txtFrom.TabIndex = 0;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(161, 21);
            this.txtTo.MenuManager = this.ribbon;
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(81, 20);
            this.txtTo.TabIndex = 1;
            // 
            // frmPhieuHang
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 567);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPhieuHang";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Phiếu hàng";
            this.Load += new System.EventHandler(this.frmPhieuHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAN_PHAMDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAN_PHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_SPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSDL_PROJECT_CTMAYTINHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private CSDL_PROJECT_CTMAYTINHDataSet cSDL_PROJECT_CTMAYTINHDataSet;
        private System.Windows.Forms.BindingSource lOAI_SPBindingSource;
        private CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.LOAI_SPTableAdapter lOAI_SPTableAdapter;
        private CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.SAN_PHAMTableAdapter sAN_PHAMTableAdapter;
        private System.Windows.Forms.BindingSource sAN_PHAMBindingSource;
        private System.Windows.Forms.ListBox iD_LOAIListBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView sAN_PHAMDataGridView;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNguoiLap;
        private System.Windows.Forms.TextBox txtMa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnTao;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.TextEdit txtFrom;
        private DevExpress.XtraEditors.TextEdit txtTo;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnTimgia;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtMax;
        private DevExpress.XtraEditors.TextEdit txtMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DevExpress.XtraEditors.SimpleButton btnPhieuKhac;
    }
}