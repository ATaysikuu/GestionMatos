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
    public partial class F_Intervention : Form
    {
        static DateTime dt_dateinter;
        static int i_idtech, i_idInter;
        static String s_clientName, s_siteName, s_materielName;

        public F_Intervention()
        {
            InitializeComponent();
        }

        public F_Intervention(int id_inter)
        {
            i_idInter = id_inter;
            InitializeComponent();
            sqls_intervention.Open();
            sqlcmd_getIntervention.Parameters.Add("@id_intervention", SqlDbType.Int).Value = id_inter;
            SqlDataReader dataReader = sqlcmd_getIntervention.ExecuteReader();
            if (dataReader.Read())
            {
                dtpicker_dateinter.Value =(DateTime)dataReader["date_Intervention"];
                rtb_commIntervention.Text = dataReader["commentaire_Intervention"].ToString();
                cmb_listeClients.SelectedIndex = cmb_listeClients.FindStringExact(dataReader["name_Client"].ToString());
                cmb_IDTechnicien.SelectedIndex = cmb_IDTechnicien.FindStringExact(dataReader["id_Technicien"].ToString());
                cmb_listeMateriel.SelectedIndex = cmb_listeMateriel.FindStringExact(dataReader["name_Materiel"].ToString());
                cmb_listeSites.SelectedIndex = cmb_listeSites.FindStringExact(dataReader["name_Site"].ToString());
            }
            sqls_intervention.Close();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            dt_dateinter = dtpicker_dateinter.Value;
            i_idtech = 2;
            s_clientName = cmb_listeClients.SelectedText;
            s_siteName = cmb_listeSites.SelectedText;
            s_materielName = cmb_listeMateriel.SelectedText;

            sqlcmd_updateIntervention.Parameters.Add("@id_intervention", SqlDbType.Int).Value = i_idInter;
            sqlcmd_updateIntervention.Parameters.Add("@date_inter", SqlDbType.DateTime).Value = dt_dateinter;
            sqlcmd_updateIntervention.Parameters.Add("@id_tech", SqlDbType.Int).Value = i_idtech;
            sqlcmd_updateIntervention.Parameters.Add("@id_materiel", SqlDbType.VarChar).Value = 5;
            sqlcmd_updateIntervention.Parameters.Add("@comm_inter", SqlDbType.VarChar).Value = rtb_commIntervention.Text;


            sqls_intervention.Open();
            sqlcmd_updateIntervention.ExecuteNonQuery();
            sqls_intervention.Close();
            MessageBox.Show("Intervention updated!", "Mission Passed!");
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            dt_dateinter = dtpicker_dateinter.Value;
            i_idtech = 2;
            s_clientName = cmb_listeClients.SelectedText;
            s_siteName = cmb_listeSites.SelectedText;
            s_materielName = cmb_listeMateriel.SelectedText;

            sqlcmd_insertIntervention.Parameters.Add("@date_intervention",SqlDbType.DateTime).Value = dt_dateinter;
            sqlcmd_insertIntervention.Parameters.Add("@id_technicien",SqlDbType.Int).Value = i_idtech;
            sqlcmd_insertIntervention.Parameters.Add("@id_materiel",SqlDbType.VarChar).Value = 5;
            
            sqls_intervention.Open();
            sqlcmd_insertIntervention.ExecuteNonQuery();
            sqls_intervention.Close();
            MessageBox.Show("Intervention planned!", "Mission Passed!");
            this.Close();
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
            this.clientsTableAdapter.Fill(this.dtset_Clients.Clients);

        }
    }
}
