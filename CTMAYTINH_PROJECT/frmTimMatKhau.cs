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
    public partial class frmTimMatKhau : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmTimMatKhau()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
            string password;
            password = Ultilities.Ultilities.TIMLAIMATKHAU(txtUser.Text, txtPin.Text);
                if(password == "")
                {
                    MessageBox.Show("Nhập sai thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Password của bạn là: " + password +"\nNhớ giữ cẩn thận đừng để mất","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}