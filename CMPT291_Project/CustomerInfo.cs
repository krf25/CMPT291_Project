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
            string MaxCID = "";
            int CID, TID;
            myCommand.CommandText = "select max(CID) as CID from dbo.Customer";
            try
            {
                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    MaxCID += (myReader["CID"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");

            }
            if (MaxCID == "") CID = 1;
            else CID = Convert.ToInt32(MaxCID) + 1;
            if (LimitedAdd.Checked) TID = 1;
            else if (BasicAdd.Checked) TID = 2;
            else if (StandardAdd.Checked) TID = 3;
            else TID = 4;
            try
            {
                myCommand.CommandText = "insert into dbo.Customer values (" + CID.ToString() + ",'" +
                    LName_add_box.Text + "','" + FName_add_box.Text + "','" + Address_add_box.Text + "','" +
                    City_add_box.Text + "','" + State_add_box.Text + "','" + ZIP_add_box.Text + "','" + phone_add_box.Text + "','" +
                    Email_add_box.Text + "','" + Password_add_box.Text + "','" + Credit_add_box.Text + "',0," + TID.ToString() + ",'" + StartDatePicker.Text + "','" + EndDatePicker.Text + "')";
                MessageBox.Show(myCommand.CommandText);

                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "delete from dbo.Customer where CID = " + CID_DELETE_BOX.Text;
            MessageBox.Show(myCommand.CommandText);
            myCommand.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool valid = false;
            myCommand.CommandText = "select * from dbo.Customer";
            if (SearchAll.Checked) valid = true;
            else if (SearchBy.Text == "")
                MessageBox.Show("please type in search box");
            else
            {
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
            if (valid == true)
            {
                try
                {
                    MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();

                    CustomerDisplay.Rows.Clear();
                    while (myReader.Read())
                    {
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
    }
}
