namespace CTMAYTINH_PROJECT
{
    partial class frmNhaPP
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
            System.Windows.Forms.Label iD_NHAPPLabel;
            System.Windows.Forms.Label nHAPHANPHOILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaPP));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.nHA_PPGridControl = new DevExpress.XtraGrid.GridControl();
            this.nHA_PPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSDL_PROJECT_CTMAYTINHDataSet = new CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_NHAPP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHAPHANPHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnBoqua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.iD_NHAPPTextBox = new System.Windows.Forms.TextBox();
            this.nHAPHANPHOITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nHA_PPTableAdapter = new CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.NHA_PPTableAdapter();
            this.tableAdapterManager = new CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.TableAdapterManager();
            this.nHA_PPBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nHA_PPBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.txtGiatri = new DevExpress.XtraEditors.TextEdit();
            this.cbxTim = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            iD_NHAPPLabel = new System.Windows.Forms.Label();
            nHAPHANPHOILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHA_PPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHA_PPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSDL_PROJECT_CTMAYTINHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHAPHANPHOITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHA_PPBindingNavigator)).BeginInit();
            this.nHA_PPBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiatri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTim.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_NHAPPLabel
            // 
            iD_NHAPPLabel.AutoSize = true;
            iD_NHAPPLabel.Location = new System.Drawing.Point(5, 34);
            iD_NHAPPLabel.Name = "iD_NHAPPLabel";
            iD_NHAPPLabel.Size = new System.Drawing.Size(61, 13);
            iD_NHAPPLabel.TabIndex = 0;
            iD_NHAPPLabel.Text = "Mã nhà PP:";
            // 
            // nHAPHANPHOILabel
            // 
            nHAPHANPHOILabel.AutoSize = true;
            nHAPHANPHOILabel.Location = new System.Drawing.Point(5, 58);
            nHAPHANPHOILabel.Name = "nHAPHANPHOILabel";
            nHAPHANPHOILabel.Size = new System.Drawing.Size(65, 13);
            nHAPHANPHOILabel.TabIndex = 2;
            nHAPHANPHOILabel.Text = "Tên nhà PP:";
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
            this.ribbon.Size = new System.Drawing.Size(599, 49);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 387);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(599, 31);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.nHA_PPGridControl);
            this.groupControl1.Location = new System.Drawing.Point(12, 87);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(313, 276);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Danh sách";
            // 
            // nHA_PPGridControl
            // 
            this.nHA_PPGridControl.DataSource = this.nHA_PPBindingSource;
            this.nHA_PPGridControl.Location = new System.Drawing.Point(5, 24);
            this.nHA_PPGridControl.MainView = this.gridView1;
            this.nHA_PPGridControl.MenuManager = this.ribbon;
            this.nHA_PPGridControl.Name = "nHA_PPGridControl";
            this.nHA_PPGridControl.Size = new System.Drawing.Size(300, 220);
            this.nHA_PPGridControl.TabIndex = 0;
            this.nHA_PPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nHA_PPBindingSource
            // 
            this.nHA_PPBindingSource.DataMember = "NHA_PP";
            this.nHA_PPBindingSource.DataSource = this.cSDL_PROJECT_CTMAYTINHDataSet;
            // 
            // cSDL_PROJECT_CTMAYTINHDataSet
            // 
            this.cSDL_PROJECT_CTMAYTINHDataSet.DataSetName = "CSDL_PROJECT_CTMAYTINHDataSet";
            this.cSDL_PROJECT_CTMAYTINHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_NHAPP,
            this.colNHAPHANPHOI});
            this.gridView1.GridControl = this.nHA_PPGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID_NHAPP
            // 
            this.colID_NHAPP.Caption = "Mã nhà PP";
            this.colID_NHAPP.FieldName = "ID_NHAPP";
            this.colID_NHAPP.Name = "colID_NHAPP";
            this.colID_NHAPP.OptionsColumn.ReadOnly = true;
            this.colID_NHAPP.Visible = true;
            this.colID_NHAPP.VisibleIndex = 0;
            // 
            // colNHAPHANPHOI
            // 
            this.colNHAPHANPHOI.Caption = "Nhà phân phối";
            this.colNHAPHANPHOI.FieldName = "NHAPHANPHOI";
            this.colNHAPHANPHOI.Name = "colNHAPHANPHOI";
            this.colNHAPHANPHOI.Visible = true;
            this.colNHAPHANPHOI.VisibleIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.btnBoqua);
            this.groupControl2.Controls.Add(this.btnLuu);
            this.groupControl2.Controls.Add(iD_NHAPPLabel);
            this.groupControl2.Controls.Add(this.iD_NHAPPTextBox);
            this.groupControl2.Controls.Add(nHAPHANPHOILabel);
            this.groupControl2.Controls.Add(this.nHAPHANPHOITextEdit);
            this.groupControl2.Location = new System.Drawing.Point(341, 199);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(246, 132);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Chi tiết";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::CTMAYTINH_PROJECT.Properties.Resources.add_icon;
            this.simpleButton1.Location = new System.Drawing.Point(5, 85);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Thêm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(166, 85);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 5;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::CTMAYTINH_PROJECT.Properties.Resources.Save_icon;
            this.btnLuu.Location = new System.Drawing.Point(85, 85);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // iD_NHAPPTextBox
            // 
            this.iD_NHAPPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHA_PPBindingSource, "ID_NHAPP", true));
            this.iD_NHAPPTextBox.Location = new System.Drawing.Point(95, 31);
            this.iD_NHAPPTextBox.Name = "iD_NHAPPTextBox";
            this.iD_NHAPPTextBox.ReadOnly = true;
            this.iD_NHAPPTextBox.Size = new System.Drawing.Size(100, 21);
            this.iD_NHAPPTextBox.TabIndex = 1;
            // 
            // nHAPHANPHOITextEdit
            // 
            this.nHAPHANPHOITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHA_PPBindingSource, "NHAPHANPHOI", true));
            this.nHAPHANPHOITextEdit.Location = new System.Drawing.Point(95, 55);
            this.nHAPHANPHOITextEdit.MenuManager = this.ribbon;
            this.nHAPHANPHOITextEdit.Name = "nHAPHANPHOITextEdit";
            this.nHAPHANPHOITextEdit.Size = new System.Drawing.Size(100, 20);
            this.nHAPHANPHOITextEdit.TabIndex = 3;
            // 
            // nHA_PPTableAdapter
            // 
            this.nHA_PPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHI_TIET_PHIEUTableAdapter = null;
            this.tableAdapterManager.HOA_DONTableAdapter = null;
            this.tableAdapterManager.KHACH_HANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAI_KHACHTableAdapter = null;
            this.tableAdapterManager.LOAI_SPTableAdapter = null;
            this.tableAdapterManager.NHA_PPTableAdapter = this.nHA_PPTableAdapter;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHIEU_HANGTableAdapter = null;
            this.tableAdapterManager.SAN_PHAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VAI_TROTableAdapter = null;
            // 
            // nHA_PPBindingNavigator
            // 
            this.nHA_PPBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nHA_PPBindingNavigator.BindingSource = this.nHA_PPBindingSource;
            this.nHA_PPBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nHA_PPBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nHA_PPBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.nHA_PPBindingNavigatorSaveItem});
            this.nHA_PPBindingNavigator.Location = new System.Drawing.Point(0, 49);
            this.nHA_PPBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nHA_PPBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nHA_PPBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nHA_PPBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nHA_PPBindingNavigator.Name = "nHA_PPBindingNavigator";
            this.nHA_PPBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nHA_PPBindingNavigator.Size = new System.Drawing.Size(599, 25);
            this.nHA_PPBindingNavigator.TabIndex = 4;
            this.nHA_PPBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // nHA_PPBindingNavigatorSaveItem
            // 
            this.nHA_PPBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nHA_PPBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nHA_PPBindingNavigatorSaveItem.Image")));
            this.nHA_PPBindingNavigatorSaveItem.Name = "nHA_PPBindingNavigatorSaveItem";
            this.nHA_PPBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.nHA_PPBindingNavigatorSaveItem.Text = "Save Data";
            this.nHA_PPBindingNavigatorSaveItem.Click += new System.EventHandler(this.nHA_PPBindingNavigatorSaveItem_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnHuy);
            this.groupControl3.Controls.Add(this.btnTim);
            this.groupControl3.Controls.Add(this.txtGiatri);
            this.groupControl3.Controls.Add(this.cbxTim);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Location = new System.Drawing.Point(341, 87);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(246, 100);
            this.groupControl3.TabIndex = 7;
            this.groupControl3.Text = "Tìm kiếm";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(174, 63);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(67, 23);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTim
            // 
            this.btnTim.Image = global::CTMAYTINH_PROJECT.Properties.Resources.Document_Preview_icon;
            this.btnTim.Location = new System.Drawing.Point(174, 34);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(67, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtGiatri
            // 
            this.txtGiatri.Location = new System.Drawing.Point(68, 65);
            this.txtGiatri.MenuManager = this.ribbon;
            this.txtGiatri.Name = "txtGiatri";
            this.txtGiatri.Size = new System.Drawing.Size(100, 20);
            this.txtGiatri.TabIndex = 2;
            // 
            // cbxTim
            // 
            this.cbxTim.Location = new System.Drawing.Point(68, 37);
            this.cbxTim.MenuManager = this.ribbon;
            this.cbxTim.Name = "cbxTim";
            this.cbxTim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxTim.Properties.Items.AddRange(new object[] {
            "Mã",
            "Tên"});
            this.cbxTim.Size = new System.Drawing.Size(100, 20);
            this.cbxTim.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Giá trị:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tìm theo:";
            // 
            // frmNhaPP
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 418);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.nHA_PPBindingNavigator);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNhaPP";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý nhà phân phối";
            this.Load += new System.EventHandler(this.frmNhaPP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nHA_PPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHA_PPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSDL_PROJECT_CTMAYTINHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHAPHANPHOITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHA_PPBindingNavigator)).EndInit();
            this.nHA_PPBindingNavigator.ResumeLayout(false);
            this.nHA_PPBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiatri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTim.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private CSDL_PROJECT_CTMAYTINHDataSet cSDL_PROJECT_CTMAYTINHDataSet;
        private System.Windows.Forms.BindingSource nHA_PPBindingSource;
        private CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.NHA_PPTableAdapter nHA_PPTableAdapter;
        private CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nHA_PPBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton nHA_PPBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl nHA_PPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_NHAPP;
        private DevExpress.XtraGrid.Columns.GridColumn colNHAPHANPHOI;
        private System.Windows.Forms.TextBox iD_NHAPPTextBox;
        private DevExpress.XtraEditors.TextEdit nHAPHANPHOITextEdit;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.TextEdit txtGiatri;
        private DevExpress.XtraEditors.ComboBoxEdit cbxTim;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnBoqua;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}