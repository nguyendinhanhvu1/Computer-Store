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
    public partial class frmVaiTro : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmVaiTro()
        {
            InitializeComponent();
        }

        private void vAI_TROBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
      try
            {
                this.Validate();
            this.vAI_TROBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cSDL_PROJECT_CTMAYTINHDataSet);
            MessageBox.Show("Done","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void frmVaiTro_Load(object sender, EventArgs e)
        {
            iD_VAITROTextBox.Select();
            // TODO: This line of code loads data into the 'cSDL_PROJECT_CTMAYTINHDataSet.VAI_TRO' table. You can move, or remove it, as needed.
            this.vAI_TROTableAdapter.Fill(this.cSDL_PROJECT_CTMAYTINHDataSet.VAI_TRO);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {vAI_TROBindingSource.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            try
            {vAI_TROBindingSource.CancelEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(iD_VAITROTextBox.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Nếu xóa một vai trò thì tất cả nhân viên có vai trò đó đều bị xóa\nBạn có chắc chắn muốn xóa ?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Ultilities.Ultilities.DELVAITRO(Convert.ToInt32(iD_VAITROTextBox.Text));
                vAI_TROBindingSource.RemoveCurrent();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            vAI_TROBindingSource.AddNew();
        }

      

   
    }
}