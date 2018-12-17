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
        private static bool isLogged = false;

        internal List<Intervention> listeInter = new List<Intervention>();

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!isLogged)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
            // TODO: This line of code loads data into the 'dtset_Materiels.Materiel' table. You can move, or remove it, as needed.
            this.materielTableAdapter.Fill(this.dtset_Materiels.Materiel);
            // TODO: This line of code loads data into the 'dtset_Clients.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dtset_Clients.Clients);
            // TODO: This line of code loads data into the 'dtset_InterventionsMain1.afficher_interventions' table. You can move, or remove it, as needed.
            this.afficher_interventionsTableAdapter.Fill(this.dtset_InterventionsMain1.afficher_interventions);
        }



        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void setlogged()
        {
            isLogged = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        //Interventions
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
        //Clients
        private void btn_addClient_Click(object sender, EventArgs e)
        {
            F_Client client = new F_Client();
            client.ShowDialog();
            this.clientsTableAdapter.Fill(this.dtset_Clients.Clients);
        }
        private void btn_editClient_Click(object sender, EventArgs e)
        {

        }
        //Materiels
        private void btn_addMateriel_Click(object sender, EventArgs e)
        {
            Materiel matos = new Materiel();
            matos.ShowDialog();
            this.materielTableAdapter.Fill(this.dtset_Materiels.Materiel);
        }

        private void cmb_MTBF_SelectedIndexChanged(object sender, EventArgs e)
        {

            //(dgv_listeinter.DataSource as DataTable).DefaultView.RowFilter = string.Format("date_Intervention = '{0}'", cmb_MTBF.SelectedText);
        }

        private void cmb_sites_SelectedValueChanged(object sender, EventArgs e)
        {
            //(dgv_listeinter.DataSource as DataTable).DefaultView.RowFilter = string.Format("Site = '{0}'", cmb_sites.Text);
        }

       

        private void btn_delInter_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxNom3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_MTBF_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
