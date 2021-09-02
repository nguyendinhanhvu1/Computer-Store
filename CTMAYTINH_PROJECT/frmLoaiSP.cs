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
    public partial class frmLoaiSP : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmLoaiSP()
        {
            InitializeComponent();
        }

        private void lOAI_SPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
 this.Validate();
            this.lOAI_SPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cSDL_PROJECT_CTMAYTINHDataSet);
            MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void frmLoaiSP_Load(object sender, EventArgs e)
        {
            iD_LOAITextBox.Select();
            // TODO: This line of code loads data into the 'cSDL_PROJECT_CTMAYTINHDataSet.LOAI_SP' table. You can move, or remove it, as needed.
            this.lOAI_SPTableAdapter.Fill(this.cSDL_PROJECT_CTMAYTINHDataSet.LOAI_SP);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
            try
            {
  lOAI_SPBindingSource.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
lOAI_SPBindingSource.CancelEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            lOAI_SPBindingSource.AddNew();
        }
    }
}