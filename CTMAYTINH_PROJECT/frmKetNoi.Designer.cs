namespace CTMAYTINH_PROJECT
{
    partial class frmKetNoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetNoi));
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.labelpass = new DevExpress.XtraEditors.LabelControl();
            this.textpass = new DevExpress.XtraEditors.TextEdit();
            this.labeluser = new DevExpress.XtraEditors.LabelControl();
            this.textuser = new DevExpress.XtraEditors.TextEdit();
            this.labeldata = new DevExpress.XtraEditors.LabelControl();
            this.textdata = new DevExpress.XtraEditors.TextEdit();
            this.labelhodt = new DevExpress.XtraEditors.LabelControl();
            this.texthost = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textuser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textdata.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texthost.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 280);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar.Size = new System.Drawing.Size(333, 31);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationIcon = global::CTMAYTINH_PROJECT.Properties.Resources.iconedit;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(333, 49);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // labelpass
            // 
            this.labelpass.Location = new System.Drawing.Point(55, 176);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(50, 13);
            this.labelpass.TabIndex = 11;
            this.labelpass.Text = "Password:";
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(124, 173);
            this.textpass.Name = "textpass";
            this.textpass.Properties.PasswordChar = '*';
            this.textpass.Size = new System.Drawing.Size(144, 20);
            this.textpass.TabIndex = 9;
            // 
            // labeluser
            // 
            this.labeluser.Location = new System.Drawing.Point(55, 145);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(52, 13);
            this.labeluser.TabIndex = 12;
            this.labeluser.Text = "Username:";
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(124, 142);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(144, 20);
            this.textuser.TabIndex = 10;
            // 
            // labeldata
            // 
            this.labeldata.Location = new System.Drawing.Point(55, 114);
            this.labeldata.Name = "labeldata";
            this.labeldata.Size = new System.Drawing.Size(50, 13);
            this.labeldata.TabIndex = 13;
            this.labeldata.Text = "Database:";
            // 
            // textdata
            // 
            this.textdata.Location = new System.Drawing.Point(124, 111);
            this.textdata.Name = "textdata";
            this.textdata.Size = new System.Drawing.Size(144, 20);
            this.textdata.TabIndex = 8;
            // 
            // labelhodt
            // 
            this.labelhodt.Location = new System.Drawing.Point(55, 84);
            this.labelhodt.Name = "labelhodt";
            this.labelhodt.Size = new System.Drawing.Size(26, 13);
            this.labelhodt.TabIndex = 14;
            this.labelhodt.Text = "Host:";
            // 
            // texthost
            // 
            this.texthost.Location = new System.Drawing.Point(124, 81);
            this.texthost.Name = "texthost";
            this.texthost.Size = new System.Drawing.Size(144, 20);
            this.texthost.TabIndex = 7;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::CTMAYTINH_PROJECT.Properties.Resources.Actions_window_close_icon;
            this.simpleButton2.Location = new System.Drawing.Point(193, 209);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Exit";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::CTMAYTINH_PROJECT.Properties.Resources.Save_icon;
            this.simpleButton1.Location = new System.Drawing.Point(55, 209);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmKetNoi
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 311);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.labelpass);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.labeldata);
            this.Controls.Add(this.textdata);
            this.Controls.Add(this.labelhodt);
            this.Controls.Add(this.texthost);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.ribbonStatusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmKetNoi";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Kết nối";
            this.Load += new System.EventHandler(this.frmKetNoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textuser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textdata.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texthost.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.LabelControl labelpass;
        private DevExpress.XtraEditors.TextEdit textpass;
        private DevExpress.XtraEditors.LabelControl labeluser;
        private DevExpress.XtraEditors.TextEdit textuser;
        private DevExpress.XtraEditors.LabelControl labeldata;
        private DevExpress.XtraEditors.TextEdit textdata;
        private DevExpress.XtraEditors.LabelControl labelhodt;
        private DevExpress.XtraEditors.TextEdit texthost;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    }
}