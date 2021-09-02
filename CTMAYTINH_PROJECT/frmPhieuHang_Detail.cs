using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace CTMAYTINH_PROJECT
{
    public partial class frmPhieuHang_Detail : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmPhieuHang_Detail()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            PHIEU_HANG_CHITIET_REPORT chitiet = new PHIEU_HANG_CHITIET_REPORT();
            chitiet.parameter1.Value = txtMaPhieu.Text;
            chitiet.parameter1.Visible = false;
            //chitiet.ShowPreview();
            

        }
    }
}