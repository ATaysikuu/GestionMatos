using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMatos
{

    public partial class F_Client : Form
    {
        static String s_nameclient, s_adresseclient, s_telephone, s_email, s_ville;

        private void lb_adresse_Click(object sender, EventArgs e)
        {

        }

        private void lb_code_postal_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        static int i_zip;

        public F_Client()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            s_nameclient = tb_nom.Text;
            s_adresseclient = tb_adresse.Text;
            s_telephone = tb_tel.Text;
            s_email = tb_email.Text;
            s_ville = tb_ville.Text;
            i_zip = Convert.ToInt32(tb_code_postal.Text);

            //adding parameters to the SQLCommand. 
            sqlcmd_addClient.Parameters.Add("@nomClient", SqlDbType.VarChar).Value = s_nameclient;
            sqlcmd_addClient.Parameters.Add("@adresse", SqlDbType.VarChar).Value = s_adresseclient;
            sqlcmd_addClient.Parameters.Add("@telephone", SqlDbType.VarChar).Value = s_telephone;
            sqlcmd_addClient.Parameters.Add("@codePostal", SqlDbType.Int).Value = i_zip;
            sqlcmd_addClient.Parameters.Add("@email", SqlDbType.VarChar).Value = s_email;
            sqlcmd_addClient.Parameters.Add("@ville", SqlDbType.VarChar).Value = s_ville;

            //Open the connection
            sqls_client.Open();
            //Execute the command
            sqlcmd_addClient.ExecuteNonQuery();
            //Close the connection
            sqls_client.Close();
            MessageBox.Show("Intervention planned!", "Mission Passed!");
            //Close the dialog
            this.Close();
        }
    }
}
