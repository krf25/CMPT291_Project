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
using CMPT291_Project;

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
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            string Today = year.ToString() + "-" + month.ToString() + "-" + day.ToString();

            // check for empty text boxes
            if (password.Text != String.Empty || password_confirm.Text != String.Empty || email.Text != String.Empty)
            {   // wrong confirm password
                if (password.Text != password_confirm.Text)
                {
                    MessageBox.Show("Password wasn't confirmed correctly.", "Confirm password failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    password.Clear();
                    password_confirm.Clear();
                    password.Focus();
                    return;
                }
                // query the database with SqlDataAdapter, add query response to table obj
                string query = "Select * FROM customer WHERE Email ='" + email.Text + "'";// AND password = '" + password.Text + "'";
                SqlDataAdapter adapter = new(query, db);
                DataTable emp_emails = new DataTable();
                adapter.Fill(emp_emails);
                
                if (emp_emails.Rows.Count > 0)
                {
                    MessageBox.Show("Account already exists.", "Account already exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    password.Clear();
                    password_confirm.Clear();
                    email.Focus();
                    return;
                }


                else if (emp_emails.Rows.Count == 0 && password.Text == password_confirm.Text)
                {
                    // generate unique id -> get max ID from table, convert to int, increment by one then convert back to string
                    db.Open();
                    int max_value = 0;
                    string LID_query = "Select max(CID) FROM Customer";
                    SqlCommand cmd = new SqlCommand(LID_query, db);
                    max_value = (int)cmd.ExecuteScalar(); // executescalar returns first col/row item from queried table
                    max_value++;

                    // inserting the registration into the customer table
                    // TID 0 - no plan; (1-4) limited, basic, standard, premium
                    string email_text = email.Text;
                    string password_text = password.Text;
                    string r = "Insert into Customer values('" + max_value + "'" +
                        ", '', '', '', '', '', '', '', '" + email_text + "'," +
                        "'" + password_text + "', '', 0, 0, '"+ Today + "', '"+ Today + "')";

                    // executeNonQuery - "Executes a Transact-SQL statement against the connection and returns the number of rows affected."
                    SqlCommand insertion = new SqlCommand(r, db);
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
            // form opens to username being focused instead of email despite email being at the top; email.Focus()
        }
    }
}
