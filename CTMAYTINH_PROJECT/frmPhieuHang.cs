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
    public partial class frmPhieuHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        PHIEUHANG phieuhang = new PHIEUHANG();
        NHANVIEN nguoidung = new NHANVIEN();
        public frmPhieuHang(NHANVIEN nhanvien)
        {
            nguoidung = nhanvien;
            InitializeComponent();
        }

        private void lOAI_SPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOAI_SPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cSDL_PROJECT_CTMAYTINHDataSet);

        }

        private void frmPhieuHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSDL_PROJECT_CTMAYTINHDataSet.SAN_PHAM' table. You can move, or remove it, as needed.
            this.sAN_PHAMTableAdapter.Fill(this.cSDL_PROJECT_CTMAYTINHDataSet.SAN_PHAM);
            // TODO: This line of code loads data into the 'cSDL_PROJECT_CTMAYTINHDataSet.LOAI_SP' table. You can move, or remove it, as needed.
            this.lOAI_SPTableAdapter.Fill(this.cSDL_PROJECT_CTMAYTINHDataSet.LOAI_SP);
            
            dataGridView1.DataSource = phieuhang.LISTSP;
            dataGridView1.Columns[0].HeaderText = "Mã sản phẩm";
            dataGridView1.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            txtNguoiLap.Text = nguoidung.TENDANGNHAP;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SANPHAM sp = new SANPHAM();
            sp.ID_SANPHAM = (int)sAN_PHAMDataGridView.SelectedRows[0].Cells[0].Value;
            sp.SOLUONG = 1;
            sp.TENSANPHAM = sAN_PHAMDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            phieuhang.LISTSP.Add(sp);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try { phieuhang.LISTSP.RemoveAt(dataGridView1.SelectedRows[0].Index); }
            catch (Exception ex)
            {
                MessageBox.Show("Không có sản phẩm nào để xóa","Error");
            }
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sAN_PHAMBindingSource.RemoveFilter();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Phiếu hàng chống rỗng. Xin chọn ít nhất 1 mặt hàng","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                phieuhang.ID_NHANVIEN = nguoidung.ID_NHANVIEN;
                phieuhang.NGAYLAP = dateTimePicker1.Value;
                txtMa.Text = Convert.ToString(Ultilities.Ultilities.LAYIDPHIEUHANG());
                phieuhang.ID_PHIEUHANG = Ultilities.Ultilities.LAYIDPHIEUHANG();
                Ultilities.Ultilities.THEMPHIEUHANG(phieuhang);
                MessageBox.Show("Đã tạo phiếu hàng mã số: " + phieuhang.ID_PHIEUHANG,"Congratulation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            phieuhang = new PHIEUHANG();
            frmPhieuHang_Load(null,null);
        }

  

        
    }
}