using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ConnectDB;
using System.Data.SqlClient;
using Objects;
namespace Ultilities
{
    public class Ultilities
    {
        public static void SAVECONNECTINFO(string server, string data, string username, string password)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "config.txt";
            File.WriteAllText(path, server + "|" + data + "|" + username + "|" + password);
        }
        public static void TAOHOADON(int ID_NHANVIEN, int ID_PHIEUHANG, int ID_KHACHHANG)
        {
            ConnectDB.ConnectDB.TAOHOADON(ID_NHANVIEN,ID_PHIEUHANG,ID_KHACHHANG);
        }
        public static string GETCONNECTINFO()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "config.txt";
            return File.ReadAllText(path);
        }
        public static NHANVIEN CHECKLOGIN(string user, string pass)
        {
            NHANVIEN nhanvien = new NHANVIEN();
            nhanvien = ConnectDB.ConnectDB.CHECKLOGIN(user,pass);
            return nhanvien;
        }
        public static string TIMLAIMATKHAU(string user, string pin)
        {
            string password = null;
            password = ConnectDB.ConnectDB.TIMLAIMATKHAU(user, pin);
            return password;
        }
        public static void DELVAITRO(int ID_VAITRO)
        {
            ConnectDB.ConnectDB.DELVAITRO(ID_VAITRO);
        }
        public static int LAYIDPHIEUHANG()
        {
            int ID_PHIEUHANG = ConnectDB.ConnectDB.LAYIDPHIEUHANG();
            return ID_PHIEUHANG;
        }
        public static VAITRO LAYVAITRO(int ID_VAITRO)
        {
            VAITRO vaitro = ConnectDB.ConnectDB.LAYVAITRO(ID_VAITRO);
            return vaitro;
        }
        public static void THEMPHIEUHANG(PHIEUHANG phieuhang)
        {
            ConnectDB.ConnectDB.THEMPHIEUHANG(phieuhang);
        }
    }
}
