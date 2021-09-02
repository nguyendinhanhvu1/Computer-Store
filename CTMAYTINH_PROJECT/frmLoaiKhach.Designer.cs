namespace CTMAYTINH_PROJECT
{
    partial class frmLoaiKhach
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
            System.Windows.Forms.Label iD_LOAIKHACHLabel;
            System.Windows.Forms.Label lOAI_KHACHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiKhach));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lOAI_KHACHGridControl = new DevExpress.XtraGrid.GridControl();
            this.lOAI_KHACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSDL_PROJECT_CTMAYTINHDataSet = new CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_LOAIKHACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAI_KHACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.iD_LOAIKHACHTextBox = new System.Windows.Forms.TextBox();
            this.lOAI_KHACHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnBoqua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.lOAI_KHACHTableAdapter = new CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.LOAI_KHACHTableAdapter();
            this.tableAdapterManager = new CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.TableAdapterManager();
            this.lOAI_KHACHBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lOAI_KHACHBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            iD_LOAIKHACHLabel = new System.Windows.Forms.Label();
            lOAI_KHACHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_KHACHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_KHACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSDL_PROJECT_CTMAYTINHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_KHACHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_KHACHBindingNavigator)).BeginInit();
            this.lOAI_KHACHBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_LOAIKHACHLabel
            // 
            iD_LOAIKHACHLabel.AutoSize = true;
            iD_LOAIKHACHLabel.Location = new System.Drawing.Point(19, 58);
            iD_LOAIKHACHLabel.Name = "iD_LOAIKHACHLabel";
            iD_LOAIKHACHLabel.Size = new System.Drawing.Size(44, 13);
            iD_LOAIKHACHLabel.TabIndex = 2;
            iD_LOAIKHACHLabel.Text = "Mã loại:";
            // 
            // lOAI_KHACHLabel
            // 
            lOAI_KHACHLabel.AutoSize = true;
            lOAI_KHACHLabel.Location = new System.Drawing.Point(19, 82);
            lOAI_KHACHLabel.Name = "lOAI_KHACHLabel";
            lOAI_KHACHLabel.Size = new System.Drawing.Size(61, 13);
            lOAI_KHACHLabel.TabIndex = 4;
            lOAI_KHACHLabel.Text = "Loại khách:";
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
            this.ribbon.Size = new System.Drawing.Size(568, 49);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(568, 31);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lOAI_KHACHGridControl);
            this.groupControl1.Location = new System.Drawing.Point(12, 91);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(310, 285);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Danh sách";
            // 
            // lOAI_KHACHGridControl
            // 
            this.lOAI_KHACHGridControl.DataSource = this.lOAI_KHACHBindingSource;
            this.lOAI_KHACHGridControl.Location = new System.Drawing.Point(5, 24);
            this.lOAI_KHACHGridControl.MainView = this.gridView1;
            this.lOAI_KHACHGridControl.MenuManager = this.ribbon;
            this.lOAI_KHACHGridControl.Name = "lOAI_KHACHGridControl";
            this.lOAI_KHACHGridControl.Size = new System.Drawing.Size(300, 220);
            this.lOAI_KHACHGridControl.TabIndex = 0;
            this.lOAI_KHACHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // lOAI_KHACHBindingSource
            // 
            this.lOAI_KHACHBindingSource.DataMember = "LOAI_KHACH";
            this.lOAI_KHACHBindingSource.DataSource = this.cSDL_PROJECT_CTMAYTINHDataSet;
            // 
            // cSDL_PROJECT_CTMAYTINHDataSet
            // 
            this.cSDL_PROJECT_CTMAYTINHDataSet.DataSetName = "CSDL_PROJECT_CTMAYTINHDataSet";
            this.cSDL_PROJECT_CTMAYTINHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_LOAIKHACH,
            this.colLOAI_KHACH});
            this.gridView1.GridControl = this.lOAI_KHACHGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID_LOAIKHACH
            // 
            this.colID_LOAIKHACH.Caption = "Mã loại";
            this.colID_LOAIKHACH.FieldName = "ID_LOAIKHACH";
            this.colID_LOAIKHACH.Name = "colID_LOAIKHACH";
            this.colID_LOAIKHACH.OptionsColumn.ReadOnly = true;
            this.colID_LOAIKHACH.Visible = true;
            this.colID_LOAIKHACH.VisibleIndex = 0;
            // 
            // colLOAI_KHACH
            // 
            this.colLOAI_KHACH.Caption = "Loại khách";
            this.colLOAI_KHACH.FieldName = "LOAI_KHACH";
            this.colLOAI_KHACH.Name = "colLOAI_KHACH";
            this.colLOAI_KHACH.Visible = true;
            this.colLOAI_KHACH.VisibleIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(iD_LOAIKHACHLabel);
            this.groupControl2.Controls.Add(this.iD_LOAIKHACHTextBox);
            this.groupControl2.Controls.Add(lOAI_KHACHLabel);
            this.groupControl2.Controls.Add(this.lOAI_KHACHTextEdit);
            this.groupControl2.Controls.Add(this.btnBoqua);
            this.groupControl2.Controls.Add(this.btnLuu);
            this.groupControl2.Location = new System.Drawing.Point(328, 91);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(228, 204);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Chi tiết";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::CTMAYTINH_PROJECT.Properties.Resources.add_icon;
            this.simpleButton1.Location = new System.Drawing.Point(5, 119);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(58, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Thêm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // iD_LOAIKHACHTextBox
            // 
            this.iD_LOAIKHACHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAI_KHACHBindingSource, "ID_LOAIKHACH", true));
            this.iD_LOAIKHACHTextBox.Location = new System.Drawing.Point(108, 55);
            this.iD_LOAIKHACHTextBox.Name = "iD_LOAIKHACHTextBox";
            this.iD_LOAIKHACHTextBox.Size = new System.Drawing.Size(100, 21);
            this.iD_LOAIKHACHTextBox.TabIndex = 3;
            // 
            // lOAI_KHACHTextEdit
            // 
            this.lOAI_KHACHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOAI_KHACHBindingSource, "LOAI_KHACH", true));
            this.lOAI_KHACHTextEdit.Location = new System.Drawing.Point(108, 79);
            this.lOAI_KHACHTextEdit.MenuManager = this.ribbon;
            this.lOAI_KHACHTextEdit.Name = "lOAI_KHACHTextEdit";
            this.lOAI_KHACHTextEdit.Size = new System.Drawing.Size(100, 20);
            this.lOAI_KHACHTextEdit.TabIndex = 5;
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(148, 119);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 1;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::CTMAYTINH_PROJECT.Properties.Resources.Save_icon;
            this.btnLuu.Location = new System.Drawing.Point(67, 119);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lOAI_KHACHTableAdapter
            // 
            this.lOAI_KHACHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHI_TIET_PHIEUTableAdapter = null;
            this.tableAdapterManager.HOA_DONTableAdapter = null;
            this.tableAdapterManager.KHACH_HANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAI_KHACHTableAdapter = this.lOAI_KHACHTableAdapter;
            this.tableAdapterManager.LOAI_SPTableAdapter = null;
            this.tableAdapterManager.NHA_PPTableAdapter = null;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHIEU_HANGTableAdapter = null;
            this.tableAdapterManager.SAN_PHAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VAI_TROTableAdapter = null;
            // 
            // lOAI_KHACHBindingNavigator
            // 
            this.lOAI_KHACHBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lOAI_KHACHBindingNavigator.BindingSource = this.lOAI_KHACHBindingSource;
            this.lOAI_KHACHBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lOAI_KHACHBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lOAI_KHACHBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lOAI_KHACHBindingNavigatorSaveItem});
            this.lOAI_KHACHBindingNavigator.Location = new System.Drawing.Point(0, 49);
            this.lOAI_KHACHBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lOAI_KHACHBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lOAI_KHACHBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lOAI_KHACHBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lOAI_KHACHBindingNavigator.Name = "lOAI_KHACHBindingNavigator";
            this.lOAI_KHACHBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lOAI_KHACHBindingNavigator.Size = new System.Drawing.Size(568, 25);
            this.lOAI_KHACHBindingNavigator.TabIndex = 6;
            this.lOAI_KHACHBindingNavigator.Text = "bindingNavigator1";
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
            // lOAI_KHACHBindingNavigatorSaveItem
            // 
            this.lOAI_KHACHBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lOAI_KHACHBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lOAI_KHACHBindingNavigatorSaveItem.Image")));
            this.lOAI_KHACHBindingNavigatorSaveItem.Name = "lOAI_KHACHBindingNavigatorSaveItem";
            this.lOAI_KHACHBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.lOAI_KHACHBindingNavigatorSaveItem.Text = "Save Data";
            this.lOAI_KHACHBindingNavigatorSaveItem.Click += new System.EventHandler(this.lOAI_KHACHBindingNavigatorSaveItem_Click);
            // 
            // frmLoaiKhach
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 449);
            this.Controls.Add(this.lOAI_KHACHBindingNavigator);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLoaiKhach";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Phân loại khách hàng";
            this.Load += new System.EventHandler(this.frmLoaiKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_KHACHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_KHACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSDL_PROJECT_CTMAYTINHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_KHACHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_KHACHBindingNavigator)).EndInit();
            this.lOAI_KHACHBindingNavigator.ResumeLayout(false);
            this.lOAI_KHACHBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnBoqua;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private CSDL_PROJECT_CTMAYTINHDataSet cSDL_PROJECT_CTMAYTINHDataSet;
        private System.Windows.Forms.BindingSource lOAI_KHACHBindingSource;
        private CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.LOAI_KHACHTableAdapter lOAI_KHACHTableAdapter;
        private CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lOAI_KHACHBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lOAI_KHACHBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl lOAI_KHACHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_LOAIKHACH;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAI_KHACH;
        private System.Windows.Forms.TextBox iD_LOAIKHACHTextBox;
        private DevExpress.XtraEditors.TextEdit lOAI_KHACHTextEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}