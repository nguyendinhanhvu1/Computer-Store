using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Objects;
namespace CTMAYTINH_PROJECT
{
    public partial class frmLogin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        NHANVIEN nhanvien = new NHANVIEN();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKetNoi formketnoi = new frmKetNoi();
            formketnoi.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {       
            try
            {
                NHANVIEN nhanvien = new NHANVIEN();
                nhanvien = Ultilities.Ultilities.CHECKLOGIN(txtUser.Text, txtPass.Text);
                if (nhanvien.TENDANGNHAP == null)
                {
                    MessageBox.Show("Sai user hoặc password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    VAITRO vaitro = Ultilities.Ultilities.LAYVAITRO(nhanvien.ID_VAITRO);
                    frmMain main = new frmMain(vaitro,nhanvien);
                    this.Visible = false;
                    main.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTimMatKhau timmk = new frmTimMatKhau();
            timmk.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmInfo info = new frmInfo();
            info.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                NHANVIEN nhanvien = new NHANVIEN();
                nhanvien = Ultilities.Ultilities.CHECKLOGIN(txtUser.Text, txtPass.Text);
                if (nhanvien.TENDANGNHAP == "")
                {
                    MessageBox.Show("Sai user hoặc password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(3000);
        }

   
    }
}