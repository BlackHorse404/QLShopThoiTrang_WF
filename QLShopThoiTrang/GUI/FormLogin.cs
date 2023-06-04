using QLShopThoiTrang.DAL;
using QLShopThoiTrang.Ultilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLShopThoiTrang.GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            DBConfig.Username = username;
            DBConfig.Password = password;
            SqlConnection conn = DBConfig.getConnectString();
            try
            {
                conn.Open();
                Notice.successfull("Login state","Thành công !");
                FormDashboard f = new FormDashboard();
                f.Show();
                this.Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Notice.error("Login state", "Đăng nhập thất bại !\nVui lòng kiểm tra lại tài khoản, mật khẩu.");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
