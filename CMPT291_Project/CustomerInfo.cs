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
            //checks if importent boxes are empty
            if (LName_add_box.Text != "" && FName_add_box.Text != "" && Email_add_box.Text != "" && Credit_add_box.Text != "" && Password_add_box.Text != "")
            {
                // check if repeat email
                myCommand.CommandText = "select count(*) as repeat from dbo.Customer where Email = '" + Email_add_box.Text+"'";
                myReader = myCommand.ExecuteReader();
                myReader.Read();
                if (myReader["repeat"].ToString() == "0") { 
                myReader.Close();
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
                // gets date
                int StartDay = StartDatePicker.Value.Day;
                int StartMonth = StartDatePicker.Value.Month;
                int StartYear = StartDatePicker.Value.Year;
                int EndDay = EndDatePicker.Value.Day;
                int EndMonth = EndDatePicker.Value.Month;
                int EndYear = EndDatePicker.Value.Year;
                try
                {
                    //make the sql to add the typed in data to customer table
                    myCommand.CommandText = "insert into dbo.Customer values (" + CID.ToString() + ",'" +
                        LName_add_box.Text + "','" + FName_add_box.Text + "','" + Address_add_box.Text + "','" +
                        City_add_box.Text + "','" + State_add_box.Text + "','" + ZIP_add_box.Text + "','" + phone_add_box.Text + "','" +
                        Email_add_box.Text + "','" + Password_add_box.Text + "','" + Credit_add_box.Text + "',0," + TID.ToString() + ",'" + StartYear.ToString() + "-" + StartMonth.ToString() + "-" + StartDay.ToString() + "','" + EndYear.ToString() + "-" + EndMonth.ToString() + "-" + EndDay.ToString() + "')";
                    MessageBox.Show(myCommand.CommandText);
                    // executes the sql command
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e2)
                {
                    MessageBox.Show("please make sure all boxes are filled in the right format EX: phone: numbers");
                }
                }else
                {
                    myReader.Close();
                    MessageBox.Show("Email is already registored");
                }
            }
            else MessageBox.Show("Please fill in all boxes with asteries");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            // command to change customer to not active account
            myCommand.CommandText = "update dbo.Customer set TID = 0, END_Date = '" + year.ToString() + "-" + month.ToString() + "-" + day.ToString() + "' where CID = " + CID_DELETE_BOX.Text;
            MessageBox.Show("Account deactived");
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
                    myCommand.CommandText += " where PhoneNum = " + SearchBy.Text;
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
            // values to use in command
            string FName = FName_edit_box.Text, LName = LName_edit_box.Text, Address = Address_edit_box.Text, City = City_edit_box.Text, State = State_edit_box.Text, Zip = ZIP_edit_box.Text, Phone = Phone_edit_box.Text, Email = Email_edit_box.Text, Password = Password_edit_box.Text, CreditCardNum = Credit_edit_box.Text;
            int TID;
            int StartDay = startDate_edit_box.Value.Day;
            int StartMonth = startDate_edit_box.Value.Month;
            int StartYear = startDate_edit_box.Value.Year;
            int EndDay = endDate_edit_box.Value.Day;
            int EndMonth = endDate_edit_box.Value.Month;
            int EndYear = endDate_edit_box.Value.Year;
            // check if value was changed(empty box)
            if (LimitedEdit.Checked) TID = 1;
            else if (BasicEdit.Checked) TID = 2;
            else if (StandardEdit.Checked) TID = 3;
            else if (PremiumEdit.Checked) TID = 4;
            else TID = 0;
            
            if (LName_edit_box.Text != "" && FName_edit_box.Text != "" && Email_edit_box.Text != "" && Credit_edit_box.Text != "" && Password_edit_box.Text != "")
            {
                myCommand.CommandText = "select count(*) as repeat from dbo.Customer where Email = '" + Email_add_box.Text + "' and CID != "+CID_edit_box.Text;
                myReader = myCommand.ExecuteReader();
                myReader.Read();
                if (myReader["repeat"].ToString() == "0")
                {
                    myReader.Close();
                    try
                    {
                        // makes the command for change
                        myCommand.CommandText = "update dbo.Customer set LName = '" + LName + "', FName = '" + FName +
                           "', Address = '" + Address + "', City = '" + City + "', State = '" + State + "' , ZIP = '" +
                           Zip + "', Phone = " + Phone + ", Email = '" + Email + "', password = '" +
                            Password + "', CreditCardNum = " + CreditCardNum + ", TID = " + TID + ", START_Date = '" + StartYear.ToString() + "-" + StartMonth.ToString() + "-" + StartDay.ToString() + "', END_Date = '" + EndYear.ToString() + "-" + EndMonth.ToString() + "-" + EndDay.ToString() + "' where CID = " + CID_edit_box.Text;
                        // runs command
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(myCommand.CommandText);

                    }
                    catch
                    {
                        MessageBox.Show("please make sure all boxes are filled in the right format Ex: phone: numbers");
                    }
                }
                else
                {
                    myReader.Close();
                    MessageBox.Show("Email is already registored");
                }
                }
            else
            MessageBox.Show("Please fill in all boxes with asteries");
        }

        private void EditWithCID_Click(object sender, EventArgs e)
        {
            // gets current values from employee from EID
            myCommand.CommandText = "select * from dbo.Customer where CID = " + CID_edit_box.Text;
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            try { 
            int TID = Int32.Parse(myReader["TID"].ToString());
            string Start_Date = myReader["Start_Date"].ToString();
            string End_Date = myReader["END_Date"].ToString();
            int StartMonth, StartDay = 1, StartYear = Int32.Parse(Start_Date.Substring(0, 4));
            int EndMonth, EndDay = 1, EndYear = Int32.Parse(End_Date.Substring(0, 4));
            //StartDate
            if (Start_Date.IndexOf('-', 5) == 6)
            {
                StartMonth = Int32.Parse(Start_Date.Substring(5, 1));
                if (Start_Date.Length == 8) StartDay = Int32.Parse(Start_Date.Substring(7, 1));
            }
            else
            {
                StartMonth = Int32.Parse(Start_Date.Substring(5, 2));
                if (Start_Date.Length == 10) StartDay = Int32.Parse(Start_Date.Substring(8, 2));
                else StartDay = Int32.Parse(Start_Date.Substring(8, 1));
            }
            // endDate
            if (End_Date.IndexOf('-', 5) == 6)
            {
                EndMonth = Int32.Parse(End_Date.Substring(5, 1));
                if (End_Date.Length == 8) EndDay = Int32.Parse(End_Date.Substring(7, 1));
            }
            else
            {
                EndMonth = Int32.Parse(End_Date.Substring(5, 2));
                if (End_Date.Length == 10) EndDay = Int32.Parse(End_Date.Substring(8, 2));
                else EndDay = Int32.Parse(End_Date.Substring(8, 1));
            }


            // shows current values in the boxes
            FName_edit_box.Text = myReader["FName"].ToString();
            LName_edit_box.Text = myReader["LName"].ToString();
            Address_edit_box.Text = myReader["Address"].ToString();
            City_edit_box.Text = myReader["City"].ToString();
            State_edit_box.Text = myReader["State"].ToString();
            ZIP_edit_box.Text = myReader["ZIP"].ToString();
            Phone_edit_box.Text = myReader["Phone"].ToString();
            Email_edit_box.Text = myReader["Email"].ToString();
            Password_edit_box.Text = myReader["password"].ToString();
            Credit_edit_box.Text = myReader["CreditCardNum"].ToString();
            if (TID == 4) PremiumEdit.Checked = true;
            else if (TID == 3) StandardEdit.Checked = true;
            else if (TID == 2) BasicEdit.Checked = true;
            else if (TID == 1) LimitedEdit.Checked = true;
            startDate_edit_box.Value = new DateTime(StartYear, StartMonth, StartDay);
            endDate_edit_box.Value = new DateTime(EndYear, EndMonth, EndDay);
            myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer Id does not exist");
                myReader.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
