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
            /*try
            {
                sql_loginconnstring.Open();
            }
            catch (Exception)
            {
                Console.WriteLine("e");
            }*/
        }

        private void btn_connectlogin_Click(object sender, EventArgs e)
        {
            String s_uid = tb_idlogin.Text;
            String s_upass = tb_passlogin.Text;

            try
            {
                sql_loginconnstring.Open();
                sqlcmd_login.Parameters.Add("@identifiant", SqlDbType.VarChar).Value = s_uid;
                sqlcmd_login.Parameters.Add("@password", SqlDbType.VarChar).Value = s_upass;
                //sqlcmd_login.ExecuteNonQuery();
                SqlDataAdapter sqlda_login = new SqlDataAdapter("SELECT COUNT(*) FROM Users WHERE id_User='" + s_uid + "' AND password_User='" + s_upass + "'", sql_loginconnstring);
                DataTable dt_login = new DataTable();
                sqlda_login.Fill(dt_login);
                if (dt_login.Rows[0][0].ToString() == "1")
                {
                    this.Close();
                    Program.F_mainform.setlogged();
                    //new MainForm().Show();
                }
                else
                {
                    MessageBox.Show("Invalid IDs","Failed");
                }
                sql_loginconnstring.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void connect()
        {

        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}