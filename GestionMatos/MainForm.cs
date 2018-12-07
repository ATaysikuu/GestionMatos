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
    public partial class MainForm : Form
    {
        private static bool isLogged = false;

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!isLogged)
            {
                LoginForm loginform = new LoginForm();
                loginform.ShowDialog();
            } 
        }



        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void setlogged()
        {
            isLogged = true;
        }
    }
}
