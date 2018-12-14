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
    public partial class MainForm : Form
    {
        //private static bool isLogged = false;

        internal List<Intervention> listeInter = new List<Intervention>();

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {// TODO: This line of code loads data into the 'gestionMatosDataSet.afficher_interventions' table. You can move, or remove it, as needed.
            this.afficher_interventionsTableAdapter.Fill(this.gestionMatosDataSet.afficher_interventions);
            // TODO: This line of code loads data into the 'gestionMatosDataSet.Intervention' table. You can move, or remove it, as needed.
            this.interventionTableAdapter.Fill(this.gestionMatosDataSet.Intervention);
            //this.get_ListeInter();
            /*
                        if (!isLogged)
                        {
                            LoginForm loginform = new LoginForm();
                            loginform.ShowDialog();
                        } */
        }



        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void setlogged()
        {
            //isLogged = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_addInter_Click(object sender, EventArgs e)
        {
            F_Intervention inter = new F_Intervention();
            inter.ShowDialog();
        }

        private void btn_editInter_Click(object sender, EventArgs e)
        {

        }

        private void get_ListeInter()
        {
            try
            {
                sqls_main.Open();
                using (SqlDataReader oReader = sqlcmd_listeinter.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        listeInter.Add(new Intervention((int)oReader["id_Intervention"], oReader["date_Intervention"].ToString(), oReader["commentaire_Intervention"].ToString(), (int)oReader["id_Materiel"], (int)oReader["id_Technicien"]));
                        foreach (var i in listeInter)
                        {

                        }
                    }

                    sqls_main.Close();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void cmb_MTBF_SelectedIndexChanged(object sender, EventArgs e)
        {

            //(dgv_listeinter.DataSource as DataTable).DefaultView.RowFilter = string.Format("date_Intervention = '{0}'", cmb_MTBF.SelectedText);
        }
    }
    
}
