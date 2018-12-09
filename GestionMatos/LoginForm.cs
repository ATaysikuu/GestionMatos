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

namespace GestionMatos
{
    public partial class LoginForm : Form
    {
        static String s_connstring = @"Data Source=.\DESKTOP-L5O173O;AttachDbFilename=.mdf;Integrated Security=True;User Instance=True";
        SqlConnection sql_con = new SqlConnection(s_connstring);

        public LoginForm()
        {
            InitializeComponent();
        }
        public void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                sql_loginconnstring.Open();
            }
            catch (Exception)
            {
                Console.WriteLine("e");
            }
        }

        private void btn_connectlogin_Click(object sender, EventArgs e)
        {
            String s_uid = tb_idlogin.Text;
            String s_upass = tb_passlogin.Text;
            //sqlcmd_login.Parameters.Add("@")
        }

        private void connect()
        {

        }
    }
}