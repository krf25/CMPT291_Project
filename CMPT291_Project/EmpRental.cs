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
            // finds avalible OID by finding highest OID
            string MaxOID = "";
            //temp EID until global variable is made
            int OID, MID, EID = 1;
            myCommand.CommandText = "select max(OID) as OID from dbo.\"Order\"";
            try
            {
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    // returns highest EID
                    MaxOID += (myReader["OID"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");

            }
            // gets the avalible EID
            if (MaxOID == "") OID = 1;
            else OID = Convert.ToInt32(MaxOID) + 1;
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
            myCommand.CommandText = "select count(CID) as Concurrently from dbo.\"Order\" where CID = "+ CIDBox.Text + " and ReturnDate = '0'";
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
            //check if copy is available
            myCommand.CommandText = "select available, MID from dbo.Copies where CPID = "+CopyIDBox.Text;
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            availability = myReader["available"].ToString();
            MID = Int32.Parse(myReader["MID"].ToString());
            myReader.Close();
            //check if all requirements are met
            if (MaxMonthlyNum > CustomerMonthlyNum)
            {
                if (MaxConcurrently > CustomerConcurrently)
                {
                    if (availability == "Y")
                    {
                        //make sql command change copy as unavalible
                        myCommand.CommandText = "update dbo.Copies set available = 'N' where CPID = " + CopyIDBox.Text;
                        // executes the sql commend
                        myCommand.ExecuteNonQuery();
                        //makes sql command to make order
                        myCommand.CommandText = "insert into dbo.\"Order\" values(" + OID.ToString() + "," + MID.ToString() +
                        "," + CopyIDBox.Text + ","+CIDBox.Text+","+EID.ToString()+",'"+ CheckOutDay+ "','0',0)";
                        MessageBox.Show(myCommand.CommandText);
                        // executes the sql commend
                        myCommand.ExecuteNonQuery();
                    }
                }
                else MessageBox.Show("YUP IT WORKS");
            }

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int CPID;
            string ReturnDate = year.ToString() + "-" + month.ToString() + "-" + day.ToString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            // make sql for return date on order
            myCommand.CommandText = "update dbo.\"Order\" set ReturnDate = '"+ ReturnDate + "' where OID = " + ReturnOID.Text;
            MessageBox.Show(myCommand.CommandText);
            // executes the sql commend
            myCommand.ExecuteNonQuery();
            //get CPID
            myCommand.CommandText = "select CPID from dbo.\"Order\" where OID = " + ReturnOID.Text;
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            CPID = Int32.Parse(myReader["CPID"].ToString());
            myReader.Close();
            // make sql to set order as avaliable
            myCommand.CommandText = "update dbo.Copies set available = 'Y' where CPID = " + CPID.ToString();
            //executes the sql commend
            myCommand.ExecuteNonQuery();
        }
    }
}
