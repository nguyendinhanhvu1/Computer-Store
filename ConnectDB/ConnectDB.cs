using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Objects;
namespace ConnectDB
{
    public class ConnectDB
    {
        public static SqlConnection connectme()
        {    
            string host, data, user, pass;
            string path = AppDomain.CurrentDomain.BaseDirectory + "config.txt";
            string connectinfo = System.IO.File.ReadAllText(path);
            string[] infosplit = connectinfo.Split(Convert.ToChar("|"));
            host = infosplit[0];
            data = infosplit[1];
            user = infosplit[2];
            pass = infosplit[3];
            SqlConnection sc;
            string connectstring = "Data Source=" + host + ";Initial Catalog=" + data + ";User ID=" + user + ";Password=" + pass;
            sc = new SqlConnection(connectstring);
            sc.Open();
            return sc;
        }
        public static int LAYIDPHIEUHANG()
        {
            int ID_PHIEUHANG;
            SqlConnection sc = connectme();
            SqlCommand com = new SqlCommand("Select case when MAX(ID_PHIEUHANG) is null then 1 when MAX(ID_PHIEUHANG) is not null then MAX(ID_PHIEUHANG) +1 end From PHIEU_HANG", sc);
            ID_PHIEUHANG = (int)com.ExecuteScalar();
            sc.Close();
            return ID_PHIEUHANG;
        }
        public static void THEMPHIEUHANG(PHIEUHANG phieuhang)
        {
            SqlConnection sc = connectme();
         
            SqlCommand com2 = new SqlCommand("Insert into CHI_TIET_PHIEU(ID_PHIEUHANG,NGAYLAP,ID_NHANVIEN) values (@ID_PHIEUHANG,@NGAYLAP,@ID_NHANVIEN)",sc);
            com2.Parameters.AddWithValue("@ID_PHIEUHANG", phieuhang.ID_PHIEUHANG);
            com2.Parameters.AddWithValue("@NGAYLAP", phieuhang.NGAYLAP);
            com2.Parameters.AddWithValue("@ID_NHANVIEN", phieuhang.ID_NHANVIEN);
            com2.ExecuteNonQuery();
            foreach (SANPHAM sanpham in phieuhang.LISTSP)
            {
                SqlCommand com1 = new SqlCommand("INSERT INTO PHIEU_HANG(ID_PHIEUHANG,ID_SANPHAM,SOLUONG) Values (@ID_PHIEUHANG,@ID_SANPHAM,@SOLUONG)", sc);
                com1.Parameters.AddWithValue("@ID_PHIEUHANG", phieuhang.ID_PHIEUHANG);
                com1.Parameters.AddWithValue("@ID_SANPHAM", sanpham.ID_SANPHAM);
                com1.Parameters.AddWithValue("@SOLUONG", sanpham.SOLUONG);
                com1.ExecuteNonQuery();
            }
            sc.Close();
        }
        public static VAITRO LAYVAITRO(int ID_VAITRO)
        {
            VAITRO vaitro = new VAITRO();
            SqlConnection sc = connectme();
            SqlCommand com = new SqlCommand("Select * from VAI_TRO where ID_VAITRO = @ID_VAITRO",sc);
            com.Parameters.AddWithValue("@ID_VAITRO",ID_VAITRO);
            SqlDataReader sdr = com.ExecuteReader();
            sdr.Read();
            if (sdr.HasRows == true)
            {
                vaitro.ID_VAITRO = Convert.ToInt32(sdr[0].ToString());
                vaitro.TENVAITRO = sdr[1].ToString();
                vaitro.QL_KHO = Convert.ToBoolean(sdr[2].ToString());
                vaitro.QL_SANPHAM = Convert.ToBoolean(sdr[3].ToString());
                vaitro.QL_NHANVIEN = Convert.ToBoolean(sdr[4].ToString());
                vaitro.QL_NHAPP = Convert.ToBoolean(sdr[5].ToString());
                vaitro.QL_HOADON = Convert.ToBoolean(sdr[6].ToString());
                vaitro.QL_PHIEUHANG = Convert.ToBoolean(sdr[7].ToString());
            }
            sdr.Close();
            sc.Close();
            return vaitro;

        }
        public static NHANVIEN CHECKLOGIN(string user, string pass)
        {
            NHANVIEN nhanvien = new NHANVIEN();
            SqlConnection sc = connectme();
            SqlCommand command = new SqlCommand("Select * from NHAN_VIEN Where TENDANGNHAP = @user and MATKHAU = @pass", sc);
            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pass", pass);
            SqlDataReader sdr = command.ExecuteReader();
            sdr.Read();
            if (sdr.HasRows == true)
            {
                nhanvien.ID_NHANVIEN = Convert.ToInt32(sdr[0].ToString());
                nhanvien.TENDANGNHAP = sdr[1].ToString();
                nhanvien.MATKHAU = sdr[2].ToString();
                nhanvien.TENNHANVIEN = sdr[3].ToString();
                nhanvien.SECRET_PIN = sdr[4].ToString();
                nhanvien.ID_VAITRO = Convert.ToInt32(sdr[5].ToString());
                sdr.Close();
                sc.Close();
                return nhanvien;
            }
            else
            {
                sdr.Close();
                sc.Close();
                return nhanvien;
            }
        }
        public static void TAOHOADON(int ID_NHANVIEN, int ID_PHIEUHANG, int ID_KHACHHANG)
        {
            SqlConnection sc = connectme();
            SqlCommand com = new SqlCommand("Insert into HOA_DON values (@ID_NHANVIEN,@ID_PHIEUHANG,@ID_KHACHHANG)",sc);
            com.Parameters.AddWithValue("@ID_NHANVIEN",ID_NHANVIEN);
            com.Parameters.AddWithValue("@ID_PHIEUHANG",ID_PHIEUHANG);
            com.Parameters.AddWithValue("@ID_KHACHHANG",ID_KHACHHANG);
            com.ExecuteNonQuery();
            sc.Close();
        }
        public static void DELVAITRO(int ID_VAITRO)
        {
            SqlConnection sc = connectme();
            SqlCommand command = new SqlCommand("DELETE  from NHAN_VIEN Where ID_VAITRO = @ID_VAITRO", sc);
            command.Parameters.AddWithValue("@ID_VAITRO",ID_VAITRO);
            command.ExecuteNonQuery();
            sc.Close();
        }
        public static string TIMLAIMATKHAU(string user, string pin)
        {
            string password = null;
            SqlConnection sc = connectme();
            SqlCommand command = new SqlCommand("Select MATKHAU from NHAN_VIEN Where TENDANGNHAP = @user and SECRET_PIN = @pin", sc);
            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pin", pin);
            SqlDataReader sdr = command.ExecuteReader();
            sdr.Read();
                if (sdr.HasRows == true)
                {
                    password = sdr[0].ToString();
                    sdr.Close();
                    sc.Close();
                    return password;
                }
            else
                {
                    password = "";
                    sdr.Close();
                    sc.Close();
                    return password;
                }
        }

    }
}

