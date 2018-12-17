using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMatos
{
    public partial class LoginForm : Form
    {
        static String s_connstring = @"Data Source=.\DESKTOP-L5O173O;AttachDbFilename=.mdf;Integrated Security=True;User Instance=True";
        SqlConnection sql_con = new SqlConnection(s_connstring);
        static byte[] bytes;

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
                s_upass = Hash(s_upass);
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

        //HASH
        private static String Hash(String raw)
        {
            using (SHA256 sha256hash = SHA256.Create())
            {
                bytes = sha256hash.ComputeHash(Encoding.UTF8.GetBytes(raw));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void connect()
        {

        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            
                if (!File.Exists("logged.txt"))
                {
                    File.CreateText("logged.txt");
                }
                else
                {
                    File.Delete("logged.txt");
                }
        }
    }
}