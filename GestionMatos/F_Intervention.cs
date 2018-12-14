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
    public partial class F_Intervention : Form
    {
        public F_Intervention()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //sqlcmd_insertIntervention.Parameters.Add()
        }

        private void F_Intervention_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtset_techos.Technician' table. You can move, or remove it, as needed.
            this.technicianTableAdapter.Fill(this.dtset_techos.Technician);
            // TODO: This line of code loads data into the 'dtset_Materiel.Materiel' table. You can move, or remove it, as needed.
            this.materielTableAdapter.Fill(this.dtset_Materiel.Materiel);
            // TODO: This line of code loads data into the 'gestionMatosDataSet3.afficher_sites' table. You can move, or remove it, as needed.
            this.afficher_sitesTableAdapter1.Fill(this.gestionMatosDataSet3.afficher_sites);
            // TODO: This line of code loads data into the 'gestionMatosDataSet2.afficher_sites' table. You can move, or remove it, as needed.
            this.afficher_sitesTableAdapter.Fill(this.gestionMatosDataSet2.afficher_sites);
            // TODO: This line of code loads data into the 'gestionMatosDataSet1.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.gestionMatosDataSet1.Clients);

        }
    }
}
