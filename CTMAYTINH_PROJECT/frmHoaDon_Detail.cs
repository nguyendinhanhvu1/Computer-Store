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
    public partial class frmHoaDon_Detail : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmHoaDon_Detail()
        {
            InitializeComponent();
        }

        private void hOA_DONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOA_DONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cSDL_PROJECT_CTMAYTINHDataSet);
            MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmHoaDon_Detail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSDL_PROJECT_CTMAYTINHDataSet.HOA_DON' table. You can move, or remove it, as needed.
            this.hOA_DONTableAdapter.Fill(this.cSDL_PROJECT_CTMAYTINHDataSet.HOA_DON);

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            hOA_DONBindingSource.RemoveFilter();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            hOA_DONBindingSource.EndEdit();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            hOA_DONBindingSource.CancelEdit();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            hOA_DONBindingSource.Filter = "ID_HOADON =" + textEdit1.Text;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            hOA_DONBindingSource.Filter = "ID_NHANVIEN =" + textEdit1.Text;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            hOA_DONBindingSource.Filter = "ID_PHIEUHANG =" + textEdit1.Text;
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            hOA_DONBindingSource.Filter = "ID_KHACHHANG =" + textEdit1.Text;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            HOADON_REPORT chitiet = new HOADON_REPORT();
            chitiet.parameter1.Value = iD_HOADONTextBox.Text;
            chitiet.parameter1.Visible = false;
            //chitiet.ShowPreview();
        }
    }
}