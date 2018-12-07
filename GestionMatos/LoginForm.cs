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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_connectlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainform.setlogged();
            Program.mainform.Show();
        }
    }
}
