using CMPT291_Group3_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT291_Project
{
    public partial class EmpRental : Form
    {
        // starts the sql connection
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public EmpRental()
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            string CheckOutDay = year.ToString()+"-"+month.ToString()+"-"+day.ToString()+" "+DateTime.Now.Hour.ToString()+":"+DateTime.Now.Minute.ToString()+":"+DateTime.Now.Second.ToString(), availability;
            int MaxMonthlyNum, MaxConcurrently, CustomerConcurrently, CustomerMonthlyNum;
            //gets customer account plan
            myCommand.CommandText = "select MonthlyNum, Concurrently from Customer c, AccountType a where c.TID = a.TID and c.CID = " + CIDBox.Text;
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            MaxMonthlyNum = Int32.Parse(myReader["MonthlyNum"].ToString());
            MaxConcurrently = Int32.Parse(myReader["Concurrently"].ToString());
            myReader.Close();
            //gets customer current concurrent movies
            myCommand.CommandText = "select count(CID) as Concurrently from dbo.\"Order\" where CID = "+ CIDBox.Text + " and Returned = 'N'";
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            CustomerConcurrently = Int32.Parse(myReader["Concurrently"].ToString());
            myReader.Close();
            //gets amount of movies customer rented this month
            myCommand.CommandText = "select count(CID) as MonthlyNum from dbo.\"Order\" where CID = "+ CIDBox.Text + " and CheckOutDate like '%"+ year.ToString()+"-"+month.ToString()+"%'";
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            CustomerMonthlyNum = Int32.Parse(myReader["MonthlyNum"].ToString());
            myReader.Close();
            //check if all requirements are met
            if (MaxMonthlyNum > CustomerMonthlyNum)
            {
                if (MaxConcurrently > CustomerConcurrently)
                {
                    IDtracker.CustomerID = CIDBox.Text;
                    Rental r = new Rental();
                    r.Show();
                }
                else MessageBox.Show("Customer has reach max concurrent movies");
            }
            else MessageBox.Show("Customer has reach max movies for this month");

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            IDtracker.CustomerID = ReturnCID.Text;
            Return r = new Return();
            r.Show();
        }

        private void RentalSearchButton_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from dbo.\"Order\" as o, dbo.Movies as m, dbo.Customer as c where o.MID = m.MID and c.CID = o.CID and ";
            // fill in filters in command
            if (MovieNameSearchBox.Text != "")
                myCommand.CommandText += "mName like  '%" + MovieNameSearchBox.Text + "%' and ";
            if (MovieTypeSearchBox.Text != "")
                myCommand.CommandText += "mType = '" + MovieTypeSearchBox.Text + "' and ";
            if (FirstNameSearchBox.Text != "")
                myCommand.CommandText += "FName = '" + FirstNameSearchBox.Text + "' and ";
            if (LastNameSearchBox.Text != "")
                myCommand.CommandText += "LName = '" + LastNameSearchBox.Text + "' and ";
            if (CIDSearchBox.Text != "")
                myCommand.CommandText += "o.CID = " + CIDSearchBox.Text + " and ";
            myCommand.CommandText += "OID > 0";
            try
            {
                // shows the command
                MessageBox.Show(myCommand.CommandText);
                // runs command
                myReader = myCommand.ExecuteReader();

                RentalGrid.Rows.Clear();
                while (myReader.Read())
                {
                    // fills in the box with the sql return
                    RentalGrid.Rows.Add(myReader["MID"].ToString(), myReader["CPID"].ToString(), myReader["EID"].ToString(), myReader["mName"].ToString(), myReader["mType"].ToString(), myReader["CheckOutDate"].ToString(), myReader["ReturnDate"].ToString());
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
