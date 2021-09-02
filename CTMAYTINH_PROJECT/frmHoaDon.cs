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
    public partial class frmHoaDon : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        NHANVIEN nguoidung = new NHANVIEN();
        public frmHoaDon(NHANVIEN nhanvien)
        {
            nguoidung = nhanvien;
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Ultilities.Ultilities.TAOHOADON(nguoidung.ID_NHANVIEN, Convert.ToInt32(txtPhieuHang.Text), Convert.ToInt32(txtNguoiDung.Text));
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }
    }
}