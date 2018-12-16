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
    public partial class F_Site : Form
    {
        public F_Site()
        {
            InitializeComponent();
        }

        private void F_Site_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtset_Clients.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dtset_Clients.Clients);

        }
    }
}
