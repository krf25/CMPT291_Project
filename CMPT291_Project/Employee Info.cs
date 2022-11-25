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
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Employee_Info()
        {
            InitializeComponent();
            SqlConnection db = new SqlConnection(@"Data Source=(local);Initial Catalog=Cmpt291_GroupProject;Integrated Security=True");
            try
            {
                db.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = db; // Link the command stream to the connection
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
            bool valid = false;
            myCommand.CommandText = "select * from dbo.Employees";
            if (SearchShowAll.Checked) valid = true;
            else if (SearchBy.Text == "") 
                MessageBox.Show("please type in search box");
            else { 
                valid = true;
            if (searchEmail.Checked)
              myCommand.CommandText += " where Email = " + "'" + SearchBy.Text + "'";
            else if (SearchLName.Checked)
                myCommand.CommandText += " where LName = " + "'" + SearchBy.Text + "'";
            else if (SearchPhone.Checked)
                myCommand.CommandText += " where PhoneNum = " + "'" + SearchBy.Text + "'";
            }
            if (valid == true) { 
            try
                {
                    MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();

                    EmployeeFilter.Rows.Clear();
                    while (myReader.Read())
                    {
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
            string MaxEID = "";
            int EID;
            myCommand.CommandText = "select max(EID) as EID from dbo.Employees";
            try
            {
                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    MaxEID += (myReader["EID"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");

            }
            if (MaxEID == "") EID = 1;
            else EID = Convert.ToInt32(MaxEID)+1;
            try

            {
                myCommand.CommandText = "insert into dbo.Employees values (" + EID.ToString() + "," + socialSEC_add_box.Text + 
                    ",'" + LName_add_box.Text + "','" + FName_add_box.Text + "','" + Address_add_box.Text + "','" + 
                    City_add_box.Text + "','" + State_add_box.Text + "','" + ZIP_add_box.Text + "','" +
                    startdate_add_box.Text + "'," + HourRate_add_box.Text + ",'" + phone_add_box.Text + "','" + Email_add_box.Text + "','" + Password_add_box.Text + "')";
                MessageBox.Show(myCommand.CommandText);

                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }

        }

        private void FName_add_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_employee_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "delete from dbo.Employees where EID = " + EID_DELETE_BOX.Text;
            MessageBox.Show(myCommand.CommandText);
            myCommand.ExecuteNonQuery();
        }

        private void searchEmail_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
