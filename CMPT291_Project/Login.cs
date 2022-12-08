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
            // DataTable == represents a table obj
            // SqlDataAdapter == Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database. 
            string user, pass;
            user = username.Text;
            pass = password.Text;

            // query the database with SqlDataAdapter, add query response to table
            string query = "Select * FROM Employees WHERE Email ='" + user + "' AND password = '" + pass + "'";
            SqlDataAdapter adapter = new(query, db);
            DataTable emp_emails = new DataTable();
            adapter.Fill(emp_emails);

            // one row returned from the employee query assumes correct login
            if (emp_emails.Rows.Count > 0)
            {
                //get EID
                db.Open();
                string LID_query = "Select EID FROM Employees WHERE Email ='" + user + "' AND password = '" + pass + "'";
                SqlCommand cmd = new SqlCommand(LID_query, db);
                int EID;
                EID = (int)cmd.ExecuteScalar(); // executescalar returns first col/row item from queried table
                IDtracker.EmployeeID = EID.ToString();
                db.Close();
                //open employee screen
                landingpage lp = new landingpage();
                this.Hide();
                db.Close();
                lp.Show();
            }
            // no rows returned from employee query, check customer table for login info
            else if (emp_emails.Rows.Count == 0)
            {
                // query the customer table for email/pass match
                string c_query = "Select * FROM Customer WHERE Email ='" + user + "' AND password = '" + pass + "'";
                SqlDataAdapter c_adapter = new(c_query, db);
                DataTable c_emails = new DataTable();
                c_adapter.Fill(c_emails);

                // one row returned from the employee query assumes correct login
                if (c_emails.Rows.Count > 0)
                {
                    //get CID
                    db.Open();
                    string LID_query = "Select CID FROM Customer WHERE Email ='" + user + "' AND password = '" + pass + "'";
                    SqlCommand cmd = new SqlCommand(LID_query, db);
                    int CID;
                    CID = (int)cmd.ExecuteScalar(); // executescalar returns first col/row item from queried table
                    IDtracker.CustomerID = CID.ToString();
                    db.Close();
                    //open customer screen
                    CustomerScreen c = new CustomerScreen();
                    this.Hide();
                    db.Close();
                    c.Show();
                }
                // no returned info from either employee/customer tables, invalid email/passsword messsage then clear the fields.
                else
                {
                        username.Clear();
                        password.Clear();
                        MessageBox.Show("Invalid email or password.", "Invalid email or password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        username.Focus();
                    }
                }
            // if no info was entered and user still clicks login
            else
            {
                username.Clear();
                password.Clear();
                MessageBox.Show("Invalid email or password.", "Invalid email or password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
    }