using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPT291_Group3_Project
{
    public partial class Registration_Screen : Form
    {
        public Registration_Screen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            //if (password_box.Text != String.Empty || password_box_confirm.Text != String.Empty || username_box.Text != String.Empty)
            //{ }
        }

        private void username_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_redirect_button_Click(object sender, EventArgs e)
        {
            // Check Login form is still open, close registration form
            // DO NOT close login form before/after registration form operations
            FormCollection forms = Application.OpenForms;
            foreach (Form f in forms)
            {
                if (f.Name == "Login")
                {
                    this.Close();
                    return;
                }
            }
        }
    }
}
