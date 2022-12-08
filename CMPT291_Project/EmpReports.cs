using Microsoft.VisualBasic;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT291_Project
{
    public partial class EmpReports : Form
    {
        // starts the sql connection
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public EmpReports()
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

        private void tab1_gen_Click(object sender, EventArgs e)
        {

        }
        // SALES REPORT TAB
        private void gen_sales_report_btn_Click(object sender, EventArgs e)
        {
            string temp_sales = sales_datetimepicker.Value.ToLongDateString();
            string[] date_time_list = temp_sales.Split(" ");
            string month_name_sales = date_time_list[0];
            string year_sales = date_time_list[2];
            Dictionary<string, int> month_dict_sales = new Dictionary<string, int>();
            month_dict_sales.Add("January", 1);
            month_dict_sales.Add("February", 2);
            month_dict_sales.Add("March", 3);
            month_dict_sales.Add("April", 4);
            month_dict_sales.Add("May", 5);
            month_dict_sales.Add("June", 6);
            month_dict_sales.Add("July", 7);
            month_dict_sales.Add("August", 8);
            month_dict_sales.Add("September", 9);
            month_dict_sales.Add("October", 10);
            month_dict_sales.Add("November", 11);
            month_dict_sales.Add("December", 12);
            int month_var_id = month_dict_sales[month_name_sales];

            // Show ALL Radio button
            if (SearchAll_sales_report.Checked)
            {
                // run the Query, add results to salesReport_grid
                try
                {
                    myCommand.CommandText = "select sum(AccountType.cost) Total_Income, count(dates.cid) #OfAccounts from (select CID, TID from customer where month(START_Date) <= " + month_var_id + " and year(START_Date) <= year(getdate()) and (month(END_Date) >= " + month_var_id + " or END_Date = '' )) as dates, AccountType, customer c2 where AccountType.tid = dates.tid and c2.cid = dates.cid";
                    salesReport_grid.Rows.Clear();
                    myReader = myCommand.ExecuteReader();
                    // add queried data to salesReport_grid
                    while (myReader.Read())
                    {
                        salesReport_grid.Rows.Add(myReader["Total_Income"].ToString(), myReader["#OfAccounts"].ToString());
                    }
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }



            }
            // Limited Plan Radio button
            if (Limited_Plan_btn.Checked)
            {
                // run the Query, add results to salesReport_grid
                try
                {
                    myCommand.CommandText = "select sum(AccountType.cost) Total_Income, count(dates.cid) #OfAccounts from (select CID, TID from customer where month(START_Date) <= " + month_var_id + " and year(START_Date) <= year(getdate()) and (month(END_Date) >= " + month_var_id + " or END_Date = '' )) as dates, AccountType, customer c2 where AccountType.tid = dates.tid and c2.cid = dates.cid and AccountType.tid = 1";
                    salesReport_grid.Rows.Clear();
                    myReader = myCommand.ExecuteReader();
                    // add queried data to salesReport_grid
                    while (myReader.Read())
                    {
                        salesReport_grid.Rows.Add(myReader["Total_Income"].ToString(), myReader["#OfAccounts"].ToString());
                    }
                    myReader.Close();
                    return;
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
            // Basic Plan Radio button
            if (basic_plan_btn.Checked)
            {
                // run the Query, add results to salesReport_grid
                try
                {
                    myCommand.CommandText = "select sum(AccountType.cost) Total_Income, count(dates.cid) #OfAccounts from (select CID, TID from customer where month(START_Date) <= " + month_var_id + " and year(START_Date) <= year(getdate()) and (month(END_Date) >= " + month_var_id + " or END_Date = '' )) as dates, AccountType, customer c2 where AccountType.tid = dates.tid and c2.cid = dates.cid and AccountType.tid = 2";
                    salesReport_grid.Rows.Clear();
                    myReader = myCommand.ExecuteReader();
                    // add queried data to salesReport_grid
                    while (myReader.Read())
                    {
                        salesReport_grid.Rows.Add(myReader["Total_Income"].ToString(), myReader["#OfAccounts"].ToString());
                    }
                    myReader.Close();
                    return;
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
            // Standard Plan Radio button
            if (Standard_plan_btn.Checked)
            {
                // run the Query, add results to salesReport_grid
                try
                {
                    myCommand.CommandText = "select sum(AccountType.cost) Total_Income, count(dates.cid) #OfAccounts from (select CID, TID from customer where month(START_Date) <= " + month_var_id + " and year(START_Date) <= year(getdate()) and (month(END_Date) >= " + month_var_id + " or END_Date = '' )) as dates, AccountType, customer c2 where AccountType.tid = dates.tid and c2.cid = dates.cid and AccountType.tid = 3";
                    salesReport_grid.Rows.Clear();
                    myReader = myCommand.ExecuteReader();
                    // add queried data to salesReport_grid
                    while (myReader.Read())
                    {
                        salesReport_grid.Rows.Add(myReader["Total_Income"].ToString(), myReader["#OfAccounts"].ToString());
                    }
                    myReader.Close();
                    return;
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
            // Premium Plan Radio button
            if (premium_plan_btn.Checked)
            {
                // run the Query, add results to salesReport_grid
                try
                {
                    myCommand.CommandText = "select sum(AccountType.cost) Total_Income, count(dates.cid) #OfAccounts from (select CID, TID from customer where month(START_Date) <= " + month_var_id + " and year(START_Date) <= year(getdate()) and (month(END_Date) >= " + month_var_id + " or END_Date = '' )) as dates, AccountType, customer c2 where AccountType.tid = dates.tid and c2.cid = dates.cid and AccountType.tid = 4";
                    salesReport_grid.Rows.Clear();
                    myReader = myCommand.ExecuteReader();
                    // add queried data to salesReport_grid
                    while (myReader.Read())
                    {
                        salesReport_grid.Rows.Add(myReader["Total_Income"].ToString(), myReader["#OfAccounts"].ToString());
                    }
                    
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
        }

        // CUSTOMER MAILING LIST TAB
        private void mailinglist_gen_btn_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "select distinct FName + ' ' + LName as FULLNAME, Address, City, State, ZIP, Email, Phone from customer where CID >0 and TID >0";
                mailing_list_grid.Rows.Clear();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    mailing_list_grid.Rows.Add(myReader["FULLNAME"].ToString(), myReader["Address"].ToString(), myReader["City"].ToString(), myReader["State"].ToString(), myReader["ZIP"].ToString(), myReader["Email"].ToString(), myReader["Phone"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        // MOST ACTIVE CUSTOMERS TAB
        private void most_active_customer_btn_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "select Top 3 FName + ' ' + LName as FULLNAME, count([dbo].[Order].OID) RentalCount from [dbo].[Order], customer where [dbo].[Order].cid = customer.cid and customer.cid > 0 group by Fname, LName";
                most_active_customer_grid.Rows.Clear();
                myReader = myCommand.ExecuteReader();
                // add queried data to grid
                while (myReader.Read())
                {
                    most_active_customer_grid.Rows.Add(myReader["FULLNAME"].ToString(), myReader["RentalCount"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        // TOP EMPLOYEE RENTAL TAB
        private void top_employee_btn_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "select Top 1 FName + ' ' + LName as FULLNAME, count([dbo].[Order].OID) TransactionCount from [dbo].[Order], Employees where [dbo].[Order].eid = Employees.eid and Employees.eid >0 group by Fname, LName";
                top_employee_grid.Rows.Clear();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    top_employee_grid.Rows.Add(myReader["FULLNAME"].ToString(), myReader["TransactionCount"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }
        // MOST POPULAR RENTALS TAB
        private void most_popular_rent_btn_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "select Top 3 mName, count([dbo].[Order].OID) from Movies, [dbo].[Order] WHERE [dbo].[Order].MID = Movies.MID, Movies.MID >0 group by mName";
                popular_rental_grid.Rows.Clear();
                myReader = myCommand.ExecuteReader();
                // add queried data to grid
                while (myReader.Read())
                {
                    popular_rental_grid.Rows.Add(myReader["mName"].ToString(), myReader["count([dbo].[Order].OID)"].ToString());
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
