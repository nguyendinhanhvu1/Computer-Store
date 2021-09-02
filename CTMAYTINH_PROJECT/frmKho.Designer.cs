namespace CTMAYTINH_PROJECT
{
    partial class frmKho
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
            System.Windows.Forms.Label iD_KHOLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKho));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.kHOGridControl = new DevExpress.XtraGrid.GridControl();
            this.kHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSDL_PROJECT_CTMAYTINHDataSet = new CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_KHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnBoqua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.iD_KHOTextBox = new System.Windows.Forms.TextBox();
            this.tENKHOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.kHOTableAdapter = new CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.KHOTableAdapter();
            this.tableAdapterManager = new CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.TableAdapterManager();
            this.kHOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.kHOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            iD_KHOLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSDL_PROJECT_CTMAYTINHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tENKHOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOBindingNavigator)).BeginInit();
            this.kHOBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_KHOLabel
            // 
            iD_KHOLabel.AutoSize = true;
            iD_KHOLabel.Location = new System.Drawing.Point(28, 33);
            iD_KHOLabel.Name = "iD_KHOLabel";
            iD_KHOLabel.Size = new System.Drawing.Size(45, 13);
            iD_KHOLabel.TabIndex = 0;
            iD_KHOLabel.Text = "Mã kho:";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Location = new System.Drawing.Point(28, 57);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(49, 13);
            tENKHOLabel.TabIndex = 2;
            tENKHOLabel.Text = "Tên kho:";
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
            this.ribbon.Size = new System.Drawing.Size(582, 49);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(582, 31);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.kHOGridControl);
            this.groupControl1.Location = new System.Drawing.Point(12, 93);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(341, 273);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Danh sách:";
            // 
            // kHOGridControl
            // 
            this.kHOGridControl.DataSource = this.kHOBindingSource;
            this.kHOGridControl.Location = new System.Drawing.Point(21, 33);
            this.kHOGridControl.MainView = this.gridView1;
            this.kHOGridControl.MenuManager = this.ribbon;
            this.kHOGridControl.Name = "kHOGridControl";
            this.kHOGridControl.Size = new System.Drawing.Size(300, 220);
            this.kHOGridControl.TabIndex = 0;
            this.kHOGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // kHOBindingSource
            // 
            this.kHOBindingSource.DataMember = "KHO";
            this.kHOBindingSource.DataSource = this.cSDL_PROJECT_CTMAYTINHDataSet;
            // 
            // cSDL_PROJECT_CTMAYTINHDataSet
            // 
            this.cSDL_PROJECT_CTMAYTINHDataSet.DataSetName = "CSDL_PROJECT_CTMAYTINHDataSet";
            this.cSDL_PROJECT_CTMAYTINHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_KHO,
            this.colTENKHO});
            this.gridView1.GridControl = this.kHOGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID_KHO
            // 
            this.colID_KHO.Caption = "Mã kho";
            this.colID_KHO.FieldName = "ID_KHO";
            this.colID_KHO.Name = "colID_KHO";
            this.colID_KHO.OptionsColumn.ReadOnly = true;
            this.colID_KHO.Visible = true;
            this.colID_KHO.VisibleIndex = 0;
            // 
            // colTENKHO
            // 
            this.colTENKHO.Caption = "Tên kho";
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnBoqua);
            this.groupControl2.Controls.Add(this.btnLuu);
            this.groupControl2.Controls.Add(iD_KHOLabel);
            this.groupControl2.Controls.Add(this.iD_KHOTextBox);
            this.groupControl2.Controls.Add(tENKHOLabel);
            this.groupControl2.Controls.Add(this.tENKHOTextEdit);
            this.groupControl2.Location = new System.Drawing.Point(359, 93);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(213, 134);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Chi tiết";
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(112, 83);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 5;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::CTMAYTINH_PROJECT.Properties.Resources.Save_icon;
            this.btnLuu.Location = new System.Drawing.Point(31, 83);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // iD_KHOTextBox
            // 
            this.iD_KHOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHOBindingSource, "ID_KHO", true));
            this.iD_KHOTextBox.Location = new System.Drawing.Point(85, 30);
            this.iD_KHOTextBox.Name = "iD_KHOTextBox";
            this.iD_KHOTextBox.ReadOnly = true;
            this.iD_KHOTextBox.Size = new System.Drawing.Size(100, 21);
            this.iD_KHOTextBox.TabIndex = 1;
            // 
            // tENKHOTextEdit
            // 
            this.tENKHOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHOBindingSource, "TENKHO", true));
            this.tENKHOTextEdit.Location = new System.Drawing.Point(85, 54);
            this.tENKHOTextEdit.MenuManager = this.ribbon;
            this.tENKHOTextEdit.Name = "tENKHOTextEdit";
            this.tENKHOTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tENKHOTextEdit.TabIndex = 3;
            // 
            // kHOTableAdapter
            // 
            this.kHOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHI_TIET_PHIEUTableAdapter = null;
            this.tableAdapterManager.HOA_DONTableAdapter = null;
            this.tableAdapterManager.KHACH_HANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = this.kHOTableAdapter;
            this.tableAdapterManager.LOAI_KHACHTableAdapter = null;
            this.tableAdapterManager.LOAI_SPTableAdapter = null;
            this.tableAdapterManager.NHA_PPTableAdapter = null;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHIEU_HANGTableAdapter = null;
            this.tableAdapterManager.SAN_PHAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VAI_TROTableAdapter = null;
            // 
            // kHOBindingNavigator
            // 
            this.kHOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kHOBindingNavigator.BindingSource = this.kHOBindingSource;
            this.kHOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kHOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kHOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.kHOBindingNavigatorSaveItem});
            this.kHOBindingNavigator.Location = new System.Drawing.Point(0, 49);
            this.kHOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kHOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kHOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kHOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kHOBindingNavigator.Name = "kHOBindingNavigator";
            this.kHOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kHOBindingNavigator.Size = new System.Drawing.Size(582, 25);
            this.kHOBindingNavigator.TabIndex = 3;
            this.kHOBindingNavigator.Text = "bindingNavigator1";
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
            // kHOBindingNavigatorSaveItem
            // 
            this.kHOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kHOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kHOBindingNavigatorSaveItem.Image")));
            this.kHOBindingNavigatorSaveItem.Name = "kHOBindingNavigatorSaveItem";
            this.kHOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kHOBindingNavigatorSaveItem.Text = "Save Data";
            this.kHOBindingNavigatorSaveItem.Click += new System.EventHandler(this.kHOBindingNavigatorSaveItem_Click);
            // 
            // frmKho
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 449);
            this.Controls.Add(this.kHOBindingNavigator);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmKho";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý kho";
            this.Load += new System.EventHandler(this.frmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kHOGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSDL_PROJECT_CTMAYTINHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tENKHOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOBindingNavigator)).EndInit();
            this.kHOBindingNavigator.ResumeLayout(false);
            this.kHOBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private CSDL_PROJECT_CTMAYTINHDataSet cSDL_PROJECT_CTMAYTINHDataSet;
        private System.Windows.Forms.BindingSource kHOBindingSource;
        private CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.KHOTableAdapter kHOTableAdapter;
        private CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kHOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton kHOBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl kHOGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_KHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraEditors.SimpleButton btnBoqua;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.TextBox iD_KHOTextBox;
        private DevExpress.XtraEditors.TextEdit tENKHOTextEdit;
    }
}