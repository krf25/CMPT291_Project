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

namespace CMPT291_Project
{
    public partial class Return : Form
    {
        // starts the sql connection
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public Return()
        {
            InitializeComponent();
            SqlConnection myConnection = new SqlConnection(@"Data Source=(local);Initial Catalog=Cmpt291_GroupProject;Integrated Security=True");
            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from dbo.\"Order\" as o, dbo.Movies as m where o.MID = m.MID and Returned = 'N' and CID = " + IDtracker.CustomerID;
            try
            {
                // shows the command
                MessageBox.Show(myCommand.CommandText);
                // runs command
                myReader = myCommand.ExecuteReader();

                OrderGrid.Rows.Clear();
                while (myReader.Read())
                {
                    // fills in the box with the sql return
                    OrderGrid.Rows.Add(myReader["OID"].ToString(), myReader["CPID"].ToString(), myReader["MID"].ToString(), myReader["mName"].ToString(), myReader["CheckOutDate"].ToString(), myReader["ReturnDate"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (OrderIDReturnBox.Text != "")
            {
                int year = DateTime.Now.Year;
                int month = DateTime.Now.Month;
                int day = DateTime.Now.Day;
                string CPID;
                string ReturnDate = year.ToString() + "-" + month.ToString() + "-" + day.ToString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
                // get CPID
                myCommand.CommandText = "select * from dbo.\"Order\" where OID = " + OrderIDReturnBox.Text;
                myReader = myCommand.ExecuteReader();
                myReader.Read();
                CPID = myReader["CPID"].ToString();
                myReader.Close();
                //return copy
                myCommand.CommandText = "update dbo.\"Order\" set Returned = 'Y', ReturnDate = '"+ ReturnDate + "' where OID = " + OrderIDReturnBox.Text;
                myCommand.ExecuteNonQuery();
                myCommand.CommandText = "update dbo.Copies set Availability = 'Y', ReturnDate = '' where CPID = " + CPID;
                myCommand.ExecuteNonQuery();
                MessageBox.Show("copy returned");
                OrderGrid.Rows.Clear();
            }
        }
    }
}
