using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Ultilities;
using System.Configuration;
namespace CTMAYTINH_PROJECT
{
    public partial class frmKetNoi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmKetNoi()
        {
            InitializeComponent();
        }

        private void frmKetNoi_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "config.txt";
            if (System.IO.File.Exists(path) == false)
            {
                System.IO.File.WriteAllText(path, "localhost|CSDL_PROJECT_CTMAYTINH|admin|123456");
            }
            string connectinfo = Ultilities.Ultilities.GETCONNECTINFO();
            string[] info = connectinfo.Split(Convert.ToChar("|"));
            texthost.Text = info[0];
            textdata.Text = info[1];
            textuser.Text = info[2];
            textpass.Text = info[3];
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
 Ultilities.Ultilities.SAVECONNECTINFO(texthost.Text, textdata.Text, textuser.Text, textpass.Text);
            //Snipet - Edit file app.config at run time
            //----------------------------------------------------------------------------------
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["CTMAYTINH_PROJECT.Properties.Settings.CSDL_PROJECT_CTMAYTINHConnectionString"].ConnectionString = "Data Source="+texthost.Text+";Initial Catalog="+textdata.Text+";User ID="+textuser.Text+";Password="+textpass.Text;
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
            //----------------------------------------------------------------------------------
            MessageBox.Show("Success!", "Result", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}