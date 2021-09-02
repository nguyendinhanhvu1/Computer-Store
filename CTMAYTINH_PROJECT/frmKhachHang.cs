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
    public partial class frmKhachHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void kHACH_HANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
     this.Validate();
            this.kHACH_HANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cSDL_PROJECT_CTMAYTINHDataSet);
            MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            iD_KHACHHANGTextBox.Select();
            // TODO: This line of code loads data into the 'cSDL_PROJECT_CTMAYTINHDataSet.LOAI_KHACH' table. You can move, or remove it, as needed.
            this.lOAI_KHACHTableAdapter.Fill(this.cSDL_PROJECT_CTMAYTINHDataSet.LOAI_KHACH);
            // TODO: This line of code loads data into the 'cSDL_PROJECT_CTMAYTINHDataSet.KHACH_HANG' table. You can move, or remove it, as needed.
            this.kHACH_HANGTableAdapter.Fill(this.cSDL_PROJECT_CTMAYTINHDataSet.KHACH_HANG);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
kHACH_HANGBindingSource.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            try
            {
 kHACH_HANGBindingSource.CancelEdit();
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
               case "Mã khách hàng":
                   kHACH_HANGBindingSource.Filter = "ID_KHACHHANG ='" +txtGiatri.Text+ "'";
                   break;
               case "Tên":
                   kHACH_HANGBindingSource.Filter = "TEN like'%" +txtGiatri.Text+ "%'";
               break;
               case "Số điện thoại":
               kHACH_HANGBindingSource.Filter = "SDT ='" + txtGiatri.Text + "'";
               break;
               case "Địa chỉ":
               kHACH_HANGBindingSource.Filter = "DIACHI like'%" + txtGiatri.Text + "%'";
                   break;
               case "Thành phố":
                   kHACH_HANGBindingSource.Filter = "THANHPHO like'%" + txtGiatri.Text + "%'";
                   break;
               case "Mã loại khách hàng":
                   kHACH_HANGBindingSource.Filter = "ID_LOAIKHACH ='" + txtGiatri.Text + "'";
                   break;
               default:
               MessageBox.Show("Bạn chưa chọn kiểu tìm");             
               break;
           }
        }

        private void btnBotim_Click(object sender, EventArgs e)
        {
            try
            {
  kHACH_HANGBindingSource.RemoveFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            kHACH_HANGBindingSource.AddNew();
        }
    }
}