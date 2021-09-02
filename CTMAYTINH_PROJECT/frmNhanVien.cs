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
    public partial class frmNhanVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void nHAN_VIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHAN_VIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cSDL_PROJECT_CTMAYTINHDataSet);
            MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            iD_NHANVIENTextBox.Select();
            // TODO: This line of code loads data into the 'cSDL_PROJECT_CTMAYTINHDataSet.VAI_TRO' table. You can move, or remove it, as needed.
            this.vAI_TROTableAdapter.Fill(this.cSDL_PROJECT_CTMAYTINHDataSet.VAI_TRO);
            // TODO: This line of code loads data into the 'cSDL_PROJECT_CTMAYTINHDataSet.NHAN_VIEN' table. You can move, or remove it, as needed.
            this.nHAN_VIENTableAdapter.Fill(this.cSDL_PROJECT_CTMAYTINHDataSet.NHAN_VIEN);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            nHAN_VIENBindingSource.EndEdit();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            nHAN_VIENBindingSource.CancelEdit();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            nHAN_VIENBindingSource.RemoveFilter();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            nHAN_VIENBindingSource.Filter = "TENNHANVIEN like '%" + txtTen.Text + "%'";

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            nHAN_VIENBindingSource.Filter = "ID_VAITRO = " + iD_VAITROComboBox1.SelectedValue.ToString();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            nHAN_VIENBindingSource.AddNew();
        }
    }
}