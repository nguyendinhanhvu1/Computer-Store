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
    public partial class frmNhaPP : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmNhaPP()
        {
            InitializeComponent();
        }

        private void nHA_PPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
 this.Validate();
            this.nHA_PPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cSDL_PROJECT_CTMAYTINHDataSet);
            MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void frmNhaPP_Load(object sender, EventArgs e)
        {
            iD_NHAPPTextBox.Select();
            // TODO: This line of code loads data into the 'cSDL_PROJECT_CTMAYTINHDataSet.NHA_PP' table. You can move, or remove it, as needed.
            this.nHA_PPTableAdapter.Fill(this.cSDL_PROJECT_CTMAYTINHDataSet.NHA_PP);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
nHA_PPBindingSource.EndEdit();
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
                nHA_PPBindingSource.CancelEdit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            switch (cbxTim.Text)
            {
                case "Mã":
                    nHA_PPBindingSource.Filter = "ID_NHAPP = '" +txtGiatri.Text+"'";
                    break;
                case "Tên":
                    nHA_PPBindingSource.Filter = "NHAPHANPHOI like '%" + txtGiatri.Text + "%'";
                    break;
                default:
                    break;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
nHA_PPBindingSource.RemoveFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            nHA_PPBindingSource.AddNew();
        }

       

     
    }
}