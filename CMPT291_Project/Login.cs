using CMPT291_Group3_Project;
using System.Data;
using System.Data.SqlClient;

namespace CMPT291_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        // connection to database
        SqlConnection db = new SqlConnection(@"Data Source=(local);Initial Catalog=Cmpt291_GroupProject;Integrated Security=True");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration_Screen r = new Registration_Screen();
            r.Show();

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = username.Text;
            pass = password.Text;

            try
            {   // query the database with SqlDataAdapter, create DataTable obj to contain the query_res
                string query = "Select * FROM Login WHERE username ='" + user + "' AND password = '" + pass + "'";
                SqlDataAdapter adapter = new(query, db);
                DataTable query_result = new DataTable();
                adapter.Fill(query_result);

                // one row returned from the query assumes correct login
                if (query_result.Rows.Count > 0)
                {
                    CustomerScreen c = new CustomerScreen();
                    this.Hide();
                    c.Show();
                }
                else
                {
                    // clears the textboxes, show "Invalid username or password" error, user is tabbed back to user textbox after clicking OK on error msg.
                    username.Clear();
                    password.Clear();
                    MessageBox.Show("Invalid username or password.", "Invalid username or password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("some error placeholder?");
            }
            finally
            {
                db.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}