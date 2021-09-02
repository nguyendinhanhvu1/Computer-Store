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
    public partial class frmSanPham : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void sAN_PHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
            try
            {
 this.Validate();
            this.sAN_PHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cSDL_PROJECT_CTMAYTINHDataSet);
            MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            iD_SANPHAMTextBox.Select();
            // TODO: This line of code loads data into the 'cSDL_PROJECT_CTMAYTINHDataSet.NHA_PP' table. You can move, or remove it, as needed.
            this.nHA_PPTableAdapter.Fill(this.cSDL_PROJECT_CTMAYTINHDataSet.NHA_PP);
            // TODO: This line of code loads data into the 'cSDL_PROJECT_CTMAYTINHDataSet.KHO' table. You can move, or remove it, as needed.
            this.kHOTableAdapter.Fill(this.cSDL_PROJECT_CTMAYTINHDataSet.KHO);
            // TODO: This line of code loads data into the 'cSDL_PROJECT_CTMAYTINHDataSet.LOAI_SP' table. You can move, or remove it, as needed.
            this.lOAI_SPTableAdapter.Fill(this.cSDL_PROJECT_CTMAYTINHDataSet.LOAI_SP);
            // TODO: This line of code loads data into the 'cSDL_PROJECT_CTMAYTINHDataSet.SAN_PHAM' table. You can move, or remove it, as needed.
            this.sAN_PHAMTableAdapter.Fill(this.cSDL_PROJECT_CTMAYTINHDataSet.SAN_PHAM);

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
           
            try
            {
 sAN_PHAMBindingSource.Filter = "TEN_SP like '%" + txtTen.Text + "%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
sAN_PHAMBindingSource.RemoveFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
sAN_PHAMBindingSource.Filter = "SOLUONG >=" + txtFrom.Text + "and " + "SOLUONG <=" + txtTo.Text;
        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void btnTimgia_Click(object sender, EventArgs e)
        {
            try
            {
 sAN_PHAMBindingSource.Filter = "GIA >=" + txtMin.Text + "and " + "GIA <=" + txtMax.Text;
       
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
 sAN_PHAMBindingSource.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
            try
            {
sAN_PHAMBindingSource.CancelEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
sAN_PHAMBindingSource.Filter = "ID_LOAI = " + iD_LOAIComboBox.SelectedValue.ToString();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
             try
            {
sAN_PHAMBindingSource.Filter = "ID_NHAPP = " + iD_NHAPPComboBox.SelectedValue.ToString();
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
             try
            {
            sAN_PHAMBindingSource.Filter = "ID_KHO = " + iD_KHOComboBox.SelectedValue.ToString();
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            sAN_PHAMBindingSource.AddNew();
        }
    }
}