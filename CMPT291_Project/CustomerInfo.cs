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
using System.Diagnostics;

namespace CMPT291_Project
{
    public partial class CustomerInfo : Form
    {
        // starts the sql connection
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public CustomerInfo()
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            // finds avalible CID by finding highest CID
            string MaxCID = "";
            int CID, TID;
            myCommand.CommandText = "select max(CID) as CID from dbo.Customer";
            try
            {
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    // returns highest CID
                    MaxCID += (myReader["CID"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");

            }
            // gets the avalible CID
            if (MaxCID == "") CID = 1;
            else CID = Convert.ToInt32(MaxCID) + 1;
            // gets the selected account type
            if (LimitedAdd.Checked) TID = 1;
            else if (BasicAdd.Checked) TID = 2;
            else if (StandardAdd.Checked) TID = 3;
            else TID = 4;
            try
            {
                //make the sql to add the typed in data to customer table
                myCommand.CommandText = "insert into dbo.Customer values (" + CID.ToString() + ",'" +
                    LName_add_box.Text + "','" + FName_add_box.Text + "','" + Address_add_box.Text + "','" +
                    City_add_box.Text + "','" + State_add_box.Text + "','" + ZIP_add_box.Text + "','" + phone_add_box.Text + "','" +
                    Email_add_box.Text + "','" + Password_add_box.Text + "','" + Credit_add_box.Text + "',0," + TID.ToString() + ",'" + StartDatePicker.Text + "','" + EndDatePicker.Text + "')";
                MessageBox.Show(myCommand.CommandText);
                // executes the sql command
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // command to delete base on CID from the box
            myCommand.CommandText = "delete from dbo.Customer where CID = " + CID_DELETE_BOX.Text;
            MessageBox.Show(myCommand.CommandText);
            myCommand.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // value to check if box is empty
            bool valid = false;
            myCommand.CommandText = "select * from dbo.Customer";
            // if search all box is not nessary to be filled
            if (SearchAll.Checked) valid = true;
            // if box is empty then put up error
            else if (SearchBy.Text == "")
                MessageBox.Show("please type in search box");
            else
            {
                // makes the sort sql command base on radio button
                valid = true;
                if (SearchEmail.Checked)
                    myCommand.CommandText += " where Email = " + "'" + SearchBy.Text + "'";
                else if (SearchLastName.Checked)
                    myCommand.CommandText += " where LName = " + "'" + SearchBy.Text + "'";
                else if (SearchPhone.Checked)
                    myCommand.CommandText += " where PhoneNum = " + "'" + SearchBy.Text + "'";
                else
                    myCommand.CommandText += " where Address = " + "'" + SearchBy.Text + "'";
            }
            // runs if box is filled or search all
            if (valid == true)
            {
                try
                {
                    // shows the command
                    MessageBox.Show(myCommand.CommandText);
                    // runs command
                    myReader = myCommand.ExecuteReader();

                    CustomerDisplay.Rows.Clear();
                    while (myReader.Read())
                    {
                        // fills in the box with the sql return
                        CustomerDisplay.Rows.Add(myReader["CID"].ToString(), myReader["LName"].ToString(), myReader["FName"].ToString(), myReader["Address"].ToString(), myReader["City"].ToString(), myReader["State"].ToString(), myReader["ZIP"].ToString(), myReader["Phone"].ToString(), myReader["Email"].ToString(), myReader["password"].ToString(), myReader["CreditCardNum"].ToString(), myReader["Rating"].ToString(), myReader["TID"].ToString(), myReader["START_Date"].ToString(), myReader["END_Date"].ToString());
                    }

                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
