namespace CTMAYTINH_PROJECT
{
    partial class frmLoaiSP
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
            System.Windows.Forms.Label lOAI_SPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiSP));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lOAI_SPGridControl = new DevExpress.XtraGrid.GridControl();
            this.lOAI_SPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSDL_PROJECT_CTMAYTINHDataSet = new CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_LOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAI_SP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.iD_LOAITextBox = new System.Windows.Forms.TextBox();
            this.lOAI_SPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lOAI_SPTableAdapter = new CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.LOAI_SPTableAdapter();
            this.tableAdapterManager = new CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.TableAdapterManager();
            this.lOAI_SPBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lOAI_SPBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            iD_LOAILabel = new System.Windows.Forms.Label();
            lOAI_SPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_SPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_SPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSDL_PROJECT_CTMAYTINHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_SPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_SPBindingNavigator)).BeginInit();
            this.lOAI_SPBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_LOAILabel
            // 
            iD_LOAILabel.AutoSize = true;
            iD_LOAILabel.Location = new System.Drawing.Point(33, 36);
            iD_LOAILabel.Name = "iD_LOAILabel";
            iD_LOAILabel.Size = new System.Drawing.Size(44, 13);
            iD_LOAILabel.TabIndex = 0;
            iD_LOAILabel.Text = "Mã loại:";
            // 
            // lOAI_SPLabel
            // 
            lOAI_SPLabel.AutoSize = true;
            lOAI_SPLabel.Location = new System.Drawing.Point(33, 60);
            lOAI_SPLabel.Name = "lOAI_SPLabel";
            lOAI_SPLabel.Size = new System.Drawing.Size(45, 13);
            lOAI_SPLabel.TabIndex = 2;
            lOAI_SPLabel.Text = "Loại SP:";
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
            this.ribbon.Size = new System.Drawing.Size(567, 49);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 395);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(567, 31);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lOAI_SPGridControl);
            this.groupControl1.Location = new System.Drawing.Point(12, 90);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(311, 276);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Danh sách";
            // 
            // lOAI_SPGridControl
            // 
            this.lOAI_SPGridControl.DataSource = this.lOAI_SPBindingSource;
            this.lOAI_SPGridControl.Location = new System.Drawing.Point(5, 24);
            this.lOAI_SPGridControl.MainView = this.gridView1;
            this.lOAI_SPGridControl.MenuManager = this.ribbon;
            this.lOAI_SPGridControl.Name = "lOAI_SPGridControl";
            this.lOAI_SPGridControl.Size = new System.Drawing.Size(300, 220);
            this.lOAI_SPGridControl.TabIndex = 0;
            this.lOAI_SPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_LOAI,
            this.colLOAI_SP});
            this.gridView1.GridControl = this.lOAI_SPGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID_LOAI
            // 
            this.colID_LOAI.Caption = "Mã loại";
            this.colID_LOAI.FieldName = "ID_LOAI";
            this.colID_LOAI.Name = "colID_LOAI";
            this.colID_LOAI.OptionsColumn.ReadOnly = true;
            this.colID_LOAI.Visible = true;
            this.colID_LOAI.VisibleIndex = 0;
            // 
            // colLOAI_SP
            // 
            this.colLOAI_SP.Caption = "Loại sản phẩm";
            this.colLOAI_SP.FieldName = "LOAI_SP";
            this.colLOAI_SP.Name = "colLOAI_SP";
            this.colLOAI_SP.Visible = true;
            this.colLOAI_SP.VisibleIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.simpleButton3);
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(iD_LOAILabel);
            this.groupControl2.Controls.Add(this.iD_LOAITextBox);
            this.groupControl2.Controls.Add(lOAI_SPLabel);
            this.groupControl2.Controls.Add(this.lOAI_SPTextEdit);
            this.groupControl2.Location = new System.Drawing.Point(329, 90);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(226, 133);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Chi tiết";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::CTMAYTINH_PROJECT.Properties.Resources.add_icon;
            this.simpleButton3.Location = new System.Drawing.Point(5, 92);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(57, 23);
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "Thêm";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(149, 92);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(72, 23);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Bỏ qua";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::CTMAYTINH_PROJECT.Properties.Resources.Save_icon;
            this.simpleButton1.Location = new System.Drawing.Point(68, 92);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Lưu";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // iD_LOAITextBox
            // 
            this.iD_LOAITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAI_SPBindingSource, "ID_LOAI", true));
            this.iD_LOAITextBox.Location = new System.Drawing.Point(89, 33);
            this.iD_LOAITextBox.Name = "iD_LOAITextBox";
            this.iD_LOAITextBox.ReadOnly = true;
            this.iD_LOAITextBox.Size = new System.Drawing.Size(100, 21);
            this.iD_LOAITextBox.TabIndex = 1;
            // 
            // lOAI_SPTextEdit
            // 
            this.lOAI_SPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOAI_SPBindingSource, "LOAI_SP", true));
            this.lOAI_SPTextEdit.Location = new System.Drawing.Point(89, 57);
            this.lOAI_SPTextEdit.MenuManager = this.ribbon;
            this.lOAI_SPTextEdit.Name = "lOAI_SPTextEdit";
            this.lOAI_SPTextEdit.Size = new System.Drawing.Size(100, 20);
            this.lOAI_SPTextEdit.TabIndex = 3;
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
            this.tableAdapterManager.SAN_PHAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CTMAYTINH_PROJECT.CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VAI_TROTableAdapter = null;
            // 
            // lOAI_SPBindingNavigator
            // 
            this.lOAI_SPBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lOAI_SPBindingNavigator.BindingSource = this.lOAI_SPBindingSource;
            this.lOAI_SPBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lOAI_SPBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lOAI_SPBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lOAI_SPBindingNavigatorSaveItem});
            this.lOAI_SPBindingNavigator.Location = new System.Drawing.Point(0, 49);
            this.lOAI_SPBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lOAI_SPBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lOAI_SPBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lOAI_SPBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lOAI_SPBindingNavigator.Name = "lOAI_SPBindingNavigator";
            this.lOAI_SPBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lOAI_SPBindingNavigator.Size = new System.Drawing.Size(567, 25);
            this.lOAI_SPBindingNavigator.TabIndex = 3;
            this.lOAI_SPBindingNavigator.Text = "bindingNavigator1";
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
            // lOAI_SPBindingNavigatorSaveItem
            // 
            this.lOAI_SPBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lOAI_SPBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lOAI_SPBindingNavigatorSaveItem.Image")));
            this.lOAI_SPBindingNavigatorSaveItem.Name = "lOAI_SPBindingNavigatorSaveItem";
            this.lOAI_SPBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.lOAI_SPBindingNavigatorSaveItem.Text = "Save Data";
            this.lOAI_SPBindingNavigatorSaveItem.Click += new System.EventHandler(this.lOAI_SPBindingNavigatorSaveItem_Click);
            // 
            // frmLoaiSP
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 426);
            this.Controls.Add(this.lOAI_SPBindingNavigator);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLoaiSP";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Loại sản phẩm";
            this.Load += new System.EventHandler(this.frmLoaiSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_SPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_SPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSDL_PROJECT_CTMAYTINHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_SPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_SPBindingNavigator)).EndInit();
            this.lOAI_SPBindingNavigator.ResumeLayout(false);
            this.lOAI_SPBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private CSDL_PROJECT_CTMAYTINHDataSet cSDL_PROJECT_CTMAYTINHDataSet;
        private System.Windows.Forms.BindingSource lOAI_SPBindingSource;
        private CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.LOAI_SPTableAdapter lOAI_SPTableAdapter;
        private CSDL_PROJECT_CTMAYTINHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lOAI_SPBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lOAI_SPBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl lOAI_SPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_LOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAI_SP;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox iD_LOAITextBox;
        private DevExpress.XtraEditors.TextEdit lOAI_SPTextEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}