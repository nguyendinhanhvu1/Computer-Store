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
    public partial class frmLoaiKhach : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmLoaiKhach()
        {
            InitializeComponent();
        }

        private void lOAI_KHACHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
            try
            {
 this.Validate();
            this.lOAI_KHACHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cSDL_PROJECT_CTMAYTINHDataSet);
            MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLoaiKhach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSDL_PROJECT_CTMAYTINHDataSet.LOAI_KHACH' table. You can move, or remove it, as needed.
            this.lOAI_KHACHTableAdapter.Fill(this.cSDL_PROJECT_CTMAYTINHDataSet.LOAI_KHACH);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            try
            {
 lOAI_KHACHBindingSource.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            
            try
            {
lOAI_KHACHBindingSource.CancelEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            lOAI_KHACHBindingSource.AddNew();
        }
    }
}