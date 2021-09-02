using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Objects;
using DevExpress.XtraBars.Helpers;
namespace CTMAYTINH_PROJECT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        VAITRO setform = new VAITRO();
        NHANVIEN nguoidung = new NHANVIEN();
        public frmMain(VAITRO vaitro,NHANVIEN nhanvien)
        {
            
            setform = vaitro;
            nguoidung = nhanvien;
            InitializeComponent();
            SKIN();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {         
            frmKho kho = new frmKho();
            kho.MdiParent = this;
            kho.Show();
        }
        public void SKIN()
        {
            SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (setform.QL_KHO == false)
            {
                ribbonPage1.Visible = false;
            }
            if (setform.QL_SANPHAM == false)
            {
                ribbonPage2.Visible = false;
            }
            if (setform.QL_NHANVIEN == false)
            {
                ribbonPage3.Visible = false;
            }
            if (setform.QL_NHAPP == false)
            {
                ribbonPage4.Visible = false;
            }

            if (setform.QL_HOADON == false)
            {
                ribbonPage6.Visible = false;
            }
            if (setform.QL_PHIEUHANG == false)
            {
                ribbonPage7.Visible = false;
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPhieuHang phieu = new frmPhieuHang(nguoidung);
            phieu.MdiParent = this;
            phieu.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHoaDon hoadon = new frmHoaDon(nguoidung);
            hoadon.MdiParent = this;
            hoadon.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSanPham sanpham = new frmSanPham();
            sanpham.MdiParent = this;
            sanpham.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhanVien nhanvien = new frmNhanVien();
            nhanvien.MdiParent = this;
            nhanvien.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhaPP nhapp = new frmNhaPP();
            nhapp.MdiParent = this;
            nhapp.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHoaDon_Detail detail = new frmHoaDon_Detail();
            detail.MdiParent = this;
            detail.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPhieuHang_Detail phieudetail = new frmPhieuHang_Detail();
            phieudetail.MdiParent = this;
            phieudetail.Show();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmInfo info = new frmInfo();
            info.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKhachHang khack = new frmKhachHang();
            khack.MdiParent = this;
            khack.Show();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmVaiTro vaitro = new frmVaiTro();
            vaitro.MdiParent = this;
            vaitro.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLoaiSP loai = new frmLoaiSP();
            loai.MdiParent = this;
            loai.Show();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLoaiKhach loaikhach = new frmLoaiKhach();
            loaikhach.MdiParent = this;
            loaikhach.Show();
        }
    }
}