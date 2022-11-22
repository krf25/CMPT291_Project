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
using Microsoft.VisualBasic.ApplicationServices;

namespace CMPT291_Group3_Project
{
    public partial class Registration_Screen : Form
    {
        public Registration_Screen()
        {
            InitializeComponent();
        }
        // connection to database
        SqlConnection db = new SqlConnection(@"Data Source=(local);Initial Catalog=Cmpt291_GroupProject;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_button_Click(object sender, EventArgs e)
        {   // check for empty text boxes
            if (password.Text != String.Empty || password_confirm.Text != String.Empty || username.Text != String.Empty)
            {
                // if password != password_confirm, clear the textboxes then focus tab back to password txtbox
                if (password.Text != password_confirm.Text)
                {
                    MessageBox.Show("Password wasn't confirmed correctly.", "Confirm password failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    password.Clear();
                    password_confirm.Clear();
                    password.Focus();
                }
                else
                {
                    db.Open();
                    // grab max(LID) from login, increment by 1 to create new LID for current registration
                    int max_id;
                    string LID_query = "Select max(LID) FROM login";
                    SqlCommand cmd = new SqlCommand(LID_query, db);
                    max_id = (int)cmd.ExecuteScalar();
                    max_id++;

                    // registration insertion
                    string email_text = email.Text;
                    string password_text = password.Text;
                    string password_confirm_text = password_confirm.Text;
                    string username_text = username.Text;

                    string registration = "Insert into Login values(" + max_id + ", '" + email_text + "', '" + username_text + "', '" + password_text + "')";
                    SqlCommand insertion = new SqlCommand(registration, db);
                    insertion.ExecuteNonQuery();
                    MessageBox.Show("Account Registered.", "Registration Complete", MessageBoxButtons.OK);
                    this.Hide();
                    db.Close();

                }
            
            }
            else
            {
                MessageBox.Show("Registration error, please fill in the required fields correctly.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void username_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_redirect_button_Click(object sender, EventArgs e)
        {
            // Check Login form is still open, close registration form
            // DO NOT close login form before/after registration form opens
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

        private void bkround_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registration_Screen_Load(object sender, EventArgs e)
        {
            //email.Focus();
            // form opens to username being focused instead of email despite email being at the top, unsure of how to fix; email.Focus(); in bkround_panel_Paint breaks;causes indefinite focus to the email textbox.
        }
    }
}
