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
        {
            // TODO: This line of code loads data into the 'dtset_InterventionsMain1.afficher_interventions' table. You can move, or remove it, as needed.
            this.afficher_interventionsTableAdapter.Fill(this.dtset_InterventionsMain1.afficher_interventions);
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
            this.afficher_interventionsTableAdapter.Fill(this.dtset_InterventionsMain1.afficher_interventions);
        }

        private void btn_editInter_Click(object sender, EventArgs e)
        {
            F_Intervention inter = new F_Intervention((int)dgv_ListeInterMain.SelectedRows[0].Cells[0].Value);
            inter.ShowDialog();
            this.afficher_interventionsTableAdapter.Fill(this.dtset_InterventionsMain1.afficher_interventions);
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

        private void cmb_sites_SelectedValueChanged(object sender, EventArgs e)
        {
            //(dgv_listeinter.DataSource as DataTable).DefaultView.RowFilter = string.Format("Site = '{0}'", cmb_sites.Text);
        }
    }
    
}
