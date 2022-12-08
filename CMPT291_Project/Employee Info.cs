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
    public partial class Employee_Info : Form
    {
        //starts the sql
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Employee_Info()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // value to check if box is empty
            bool valid = false;
            myCommand.CommandText = "select * from dbo.Employees";
            // if search all box is not nessary to be filled
            if (SearchShowAll.Checked) valid = true;
            // if box is empty then put up error
            else if (SearchBy.Text == "") 
                MessageBox.Show("please type in search box");
            else { 
                valid = true;
                // makes the sort sql commend base on radio button
                if (searchEmail.Checked)
              myCommand.CommandText += " where Email = " + "'" + SearchBy.Text + "'";
            else if (SearchLName.Checked)
                myCommand.CommandText += " where LName = " + "'" + SearchBy.Text + "'";
            else if (SearchPhone.Checked)
                myCommand.CommandText += " where PhoneNum = " + "'" + SearchBy.Text + "'";
            }
            // runs if box is filled or search all
            if (valid == true) { 
            try
                {
                    // shows the command
                    MessageBox.Show(myCommand.CommandText);
                    // runs command
                    myReader = myCommand.ExecuteReader();

                    EmployeeFilter.Rows.Clear();
                    while (myReader.Read())
                    {
                        // fills in the box with the sql return
                        EmployeeFilter.Rows.Add(myReader["EID"].ToString(), myReader["SSN"].ToString(), myReader["LName"].ToString(), myReader["FName"].ToString(), myReader["Address"].ToString(), myReader["City"].ToString(), myReader["State"].ToString(), myReader["ZIP"].ToString(), myReader["Start_Date"].ToString(), myReader["Hourly_Rate"].ToString(), myReader["PhoneNum"].ToString(), myReader["Email"].ToString(), myReader["password"].ToString());
                    }

                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void add_employee_btn_Click(object sender, EventArgs e)
        {
            //checks if importent boxes are empty
            if (LName_add_box.Text != "" && FName_add_box.Text != "" && Email_add_box.Text != "" && socialSEC_add_box.Text != "" && Password_add_box.Text != "" && HourRate_add_box.Text != "")
            {
                // check if repeat email
                myCommand.CommandText = "select count(*) as repeat from dbo.Employees where Email = '" + Email_add_box.Text + "'";
                myReader = myCommand.ExecuteReader();
                myReader.Read();
                if (myReader["repeat"].ToString() == "0")
                {
                    myReader.Close();
                    // finds avalible EID by finding highest EID
                    string MaxEID = "";
                    int EID;
                    myCommand.CommandText = "select max(EID) as EID from dbo.Employees";
                    try
                    {
                        myReader = myCommand.ExecuteReader();
                        while (myReader.Read())
                        {
                            // returns highest EID
                            MaxEID += (myReader["EID"].ToString());
                        }
                        myReader.Close();
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString(), "Error");

                    }
                    // gets the avalible EID
                    if (MaxEID == "") EID = 1;
                    else EID = Convert.ToInt32(MaxEID) + 1;
                    // gets date and converts to proper format
                    int day = StartDate.Value.Day;
                    int month = StartDate.Value.Month;
                    int year = StartDate.Value.Year;
                    try
                    {
                        //make the sql to add the typed in data to customer table
                        myCommand.CommandText = "insert into dbo.Employees values (" + EID.ToString() + "," + socialSEC_add_box.Text +
                            ",'" + LName_add_box.Text + "','" + FName_add_box.Text + "','" + Address_add_box.Text + "','" +
                            City_add_box.Text + "','" + State_add_box.Text + "','" + ZIP_add_box.Text + "','" +
                            year.ToString() + "-" + month.ToString() + "-" + day.ToString() + "'," + HourRate_add_box.Text + ",0" + phone_add_box.Text + ",'" + Email_add_box.Text + "','" + Password_add_box.Text + "')";
                        MessageBox.Show(myCommand.CommandText);
                        // executes the sql commend
                        myCommand.ExecuteNonQuery();
                    }
                    catch (Exception e2)
                    {
                        MessageBox.Show("please make sure all boxes are filled in the right format EX: phone: numbers");
                    }
                }
                else { 
                    MessageBox.Show("Email is already registored");
                    myReader.Close();
                }
            }
            else
                {
                MessageBox.Show("Please fill in all boxes with asteries");
            }

        }

        private void FName_add_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_employee_Click(object sender, EventArgs e)
        {
            // command to delete base on EID from the box
            myCommand.CommandText = "update dbo.Customer set Hourly_Rate = 0 where CID = " + EID_DELETE_BOX.Text;
            MessageBox.Show("Employee removed");
            myCommand.ExecuteNonQuery();
        }

        private void searchEmail_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void edit_confirm_btn_Click(object sender, EventArgs e)
        {
            // values to use in command
            string FName = FName_edit_box.Text, LName = LName_edit_box_emp.Text, Address = Address_edit_box_emp.Text, City = City_edit_box_emp.Text, State = State_edit_box_emp.Text, Zip = ZIP_edit_box_emp.Text, SSN = socialSEC_edit_box_emp.Text,  Hourly_Rate = HourRate_edit_box_emp.Text, Email = Email_edit_box_emp.Text, PhoneNum = phone_edit_box_emp.Text, Password = Password_edit_box_emp.Text;
            int day = StartDatePickerEdit.Value.Day;
            int month = StartDatePickerEdit.Value.Month;
            int year = StartDatePickerEdit.Value.Year;
            if (LName_edit_box_emp.Text != "" && FName_edit_box.Text != "" && socialSEC_edit_box_emp.Text != "" && HourRate_edit_box_emp.Text != "" && Password_edit_box_emp.Text != "" && Email_edit_box_emp.Text != "")
            {
                myCommand.CommandText = "select count(*) as repeat from dbo.Employees where Email = '" + Email_add_box.Text + "' and EID != " + EID_edit_box.Text;
                myReader = myCommand.ExecuteReader();
                myReader.Read();
                if (myReader["repeat"].ToString() == "0")
                {
                    myReader.Close();
                    try
                    {
                        // makes the command for change
                        myCommand.CommandText = "update dbo.Employees set SSN = " + SSN + ", LName = '" + LName +
                       "', FName = '" + FName + "', Address = '" + Address + "', City = '" + City + "' , State = '" +
                       State + "', ZIP = '" + Zip + "', Start_Date = '" + year.ToString() + "-" + month.ToString() + "-" + day.ToString() + "', Hourly_Rate = " +
                        Hourly_Rate + ", PhoneNum = " + PhoneNum + ", Email = '" + Email + "', password = '" + Password + "' where EID = " + EID_edit_box.Text;
                        MessageBox.Show(myCommand.CommandText);
                        // runs command
                        myCommand.ExecuteNonQuery();
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

        private void button2_Click(object sender, EventArgs e)
        {
            // gets current values from employee from EID
            myCommand.CommandText = "select * from dbo.Employees where EID = " + EID_edit_box.Text;
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            try
            {
                string Start_Date = myReader["Start_Date"].ToString();
            int year = Int32.Parse(Start_Date.Substring(0, 4)),month,day = 1;
            if (Start_Date.IndexOf('-', 5) == 6)
            {
                month = Int32.Parse(Start_Date.Substring(5, 1));
                if (Start_Date.Length == 8) day = Int32.Parse(Start_Date.Substring(7, 1));
            }
            else
            {
                month = Int32.Parse(Start_Date.Substring(5, 2));
                if (Start_Date.Length == 10) day = Int32.Parse(Start_Date.Substring(8, 2));
                else day = Int32.Parse(Start_Date.Substring(8, 1));
            }
            // shows current values in the boxes
            FName_edit_box.Text = myReader["FName"].ToString();
            LName_edit_box_emp.Text = myReader["LName"].ToString();
            Address_edit_box_emp.Text = myReader["Address"].ToString();
            City_edit_box_emp.Text = myReader["City"].ToString();
            State_edit_box_emp.Text = myReader["State"].ToString();
            ZIP_edit_box_emp.Text = myReader["ZIP"].ToString();
            socialSEC_edit_box_emp.Text = myReader["SSN"].ToString();
            StartDatePickerEdit.Value = new DateTime(year, month, day);
            HourRate_edit_box_emp.Text = myReader["Hourly_Rate"].ToString();
            phone_edit_box_emp.Text = myReader["PhoneNum"].ToString();
            Email_edit_box_emp.Text = myReader["Email"].ToString();
            Password_edit_box_emp.Text = myReader["password"].ToString();
            myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer Id does not exist");
                myReader.Close();
            }
        }
    }
}
