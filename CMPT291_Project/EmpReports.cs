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
            int day = 1;
            int month = sales_datetimepicker.Value.Month;
            int year = sales_datetimepicker.Value.Year;
            string SaleMonthStart = year.ToString() + "-" + month.ToString() + "-" + day.ToString();
            int endMonth, endYear;
            if (month + 1 == 13) { endMonth = 1; endYear = year + 1; } else { endMonth = month + 1; endYear = year; }
            string SaleMonthEnd = year.ToString() + "-" + month.ToString() + "-" + day.ToString();
            // Show ALL Radio button
            if (SearchAll_sales_report.Checked)
            {
                // run the Query, add results to salesReport_grid
                try
                {
                    myCommand.CommandText = "select sum(Cost) Total_Income, count(CID) #OfAccounts from (select CID, Cost from Customer c, AccountType a where c.TID = A.TID and c.TID > 0 and START_Date<= '"+SaleMonthEnd+"' and END_Date >= '"+SaleMonthStart+"') x";
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
                    myCommand.CommandText = "select sum(Cost) Total_Income, count(CID) #OfAccounts from (select CID, Cost from Customer c, AccountType a where c.TID = A.TID and c.TID = 1 and START_Date<= '" + SaleMonthEnd + "' and END_Date >= '" + SaleMonthStart + "') x";
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
                    myCommand.CommandText = "select sum(Cost) Total_Income, count(CID) #OfAccounts from (select CID, Cost from Customer c, AccountType a where c.TID = A.TID and c.TID = 2 and START_Date<= '" + SaleMonthEnd + "' and END_Date >= '" + SaleMonthStart + "') x";
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
                    myCommand.CommandText = "select sum(Cost) Total_Income, count(CID) #OfAccounts from (select CID, Cost from Customer c, AccountType a where c.TID = A.TID and c.TID = 3 and START_Date<= '" + SaleMonthEnd + "' and END_Date >= '" + SaleMonthStart + "') x";
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
                    myCommand.CommandText = "select sum(Cost) Total_Income, count(CID) #OfAccounts from (select CID, Cost from Customer c, AccountType a where c.TID = A.TID and c.TID = 4 and START_Date<= '" + SaleMonthEnd + "' and END_Date >= '" + SaleMonthStart + "') x";
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
            int StartDay = StartDateCustomerPicker.Value.Day;
            int StartMonth = StartDateCustomerPicker.Value.Month;
            int StartYear = StartDateCustomerPicker.Value.Year;
            int EndDay = EndDateCustomerPicker.Value.Day;
            int EndMonth = EndDateCustomerPicker.Value.Month;
            int EndYear = EndDateCustomerPicker.Value.Year;
            string StartCustomer = StartYear.ToString() + "-" + StartMonth.ToString() + "-" + StartDay.ToString()+" 0:0:0";
            string EndCustomer = EndYear.ToString() + "-" + EndMonth.ToString() + "-" + EndDay.ToString() + " 0:0:0";

            try
            {
                if (DescCustomer.Checked) myCommand.CommandText = "select FName +', ' +LName as FULLNAME, count(OID) as RentalCount, x3.mType from dbo.\"Order\" o, dbo.Customer c, \r\n(select mType, x1.CID from (select count(*) as bestType, CID, mType from dbo.\"Order\" o, dbo.Movies m where o.MID=m.MID and m.MID >0 group by CID, mType)x1,\r\n(select max(bestType) as highestType, CID from (select count(*) as bestType, CID, mType from dbo.\"Order\" o, dbo.Movies m where o.MID=m.MID and m.MID >0 group by CID, mType)x2 group by CID)x2\r\nwhere x2.highestType = x1.bestType and x2.CID = x1.CID)x3\r\nwhere CheckOutDate >= '" + StartCustomer + "' and CheckOutDate <= '" + EndCustomer + "' and o.CID = c.CID and c.CID >0 and x3.CID = o.CID group by FName, LName, x3.mType order by RentalCount desc";
                else myCommand.CommandText = "select FName +', ' +LName as FULLNAME, count(OID) as RentalCount, x3.mType from dbo.\"Order\" o, dbo.Customer c, \r\n(select mType, x1.CID from (select count(*) as bestType, CID, mType from dbo.\"Order\" o, dbo.Movies m where o.MID=m.MID and m.MID >0 group by CID, mType)x1,\r\n(select max(bestType) as highestType, CID from (select count(*) as bestType, CID, mType from dbo.\"Order\" o, dbo.Movies m where o.MID=m.MID and m.MID >0 group by CID, mType)x2 group by CID)x2\r\nwhere x2.highestType = x1.bestType and x2.CID = x1.CID)x3\r\nwhere CheckOutDate >= '" + StartCustomer + "' and CheckOutDate <= '" + EndCustomer + "' and o.CID = c.CID and c.CID >0 and x3.CID = o.CID group by FName, LName, x3.mType order by RentalCount asc";
                most_active_customer_grid.Rows.Clear();
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();
                // add queried data to grid
                while (myReader.Read())
                {
                    most_active_customer_grid.Rows.Add(myReader["FULLNAME"].ToString(), myReader["RentalCount"].ToString(), myReader["mType"].ToString());
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
            int StartDay = StartDateEmployee.Value.Day;
            int StartMonth = StartDateEmployee.Value.Month;
            int StartYear = StartDateEmployee.Value.Year;
            int EndDay = EndDateEmployee.Value.Day;
            int EndMonth = EndDateEmployee.Value.Month;
            int EndYear = EndDateEmployee.Value.Year;
            string StartEmployee = StartYear.ToString() + "-" + StartMonth.ToString() + "-" + StartDay.ToString() + " 0:0:0";
            string EndEmployee = EndYear.ToString() + "-" + EndMonth.ToString() + "-" + EndDay.ToString() + " 0:0:0";
            try
            {
                if (DescEmp.Checked) myCommand.CommandText = "select FName +', ' +LName as FULLNAME, count(OID) as TransactionCount, x3.mType from dbo.\"Order\" o, dbo.Employees c, (select mType, x1.EID from (select count(*) as bestType, EID, mType from dbo.\"Order\" o, dbo.Movies m where o.MID=m.MID and m.MID >0 group by EID, mType)x1,(select max(bestType) as highestType, EID from (select count(*) as bestType, EID, mType from dbo.\"Order\" o, dbo.Movies m where o.MID=m.MID and m.MID >0 group by EID, mType)x2 group by EID)x2 where x2.highestType = x1.bestType and x2.EID = x1.EID)x3 where CheckOutDate >= '" + StartEmployee + "' and CheckOutDate <= '" + EndEmployee + "' and o.EID = c.EID and c.EID >0 and x3.EID = o.EID group by FName, LName, x3.mType order by TransactionCount desc";
                else myCommand.CommandText = "select FName +', ' +LName as FULLNAME, count(OID) as TransactionCount, x3.mType from dbo.\"Order\" o, dbo.Employees c, (select mType, x1.EID from (select count(*) as bestType, EID, mType from dbo.\"Order\" o, dbo.Movies m where o.MID=m.MID and m.MID >0 group by EID, mType)x1,(select max(bestType) as highestType, EID from (select count(*) as bestType, EID, mType from dbo.\"Order\" o, dbo.Movies m where o.MID=m.MID and m.MID >0 group by EID, mType)x2 group by EID)x2 where x2.highestType = x1.bestType and x2.EID = x1.EID)x3 where CheckOutDate >= '" + StartEmployee + "' and CheckOutDate <= '" + EndEmployee + "' and o.EID = c.EID and c.EID >0 and x3.EID = o.EID group by FName, LName, x3.mType order by TransactionCount asc";
                top_employee_grid.Rows.Clear();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    top_employee_grid.Rows.Add(myReader["FULLNAME"].ToString(), myReader["TransactionCount"].ToString(), myReader["mType"].ToString());
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
            int StartDay = StartDateRentalPicker.Value.Day;
            int StartMonth = StartDateRentalPicker.Value.Month;
            int StartYear = StartDateRentalPicker.Value.Year;
            int EndDay = EndDateRentalPicker.Value.Day;
            int EndMonth = EndDateRentalPicker.Value.Month;
            int EndYear = EndDateRentalPicker.Value.Year;
            string StartRental = StartYear.ToString() + "-" + StartMonth.ToString() + "-" + StartDay.ToString() + " 0:0:0";
            string EndRental = EndYear.ToString() + "-" + EndMonth.ToString() + "-" + EndDay.ToString() + " 0:0:0";
            try
            {
                if (DescRental.Checked) myCommand.CommandText = "select mName, count(*) as retailAmount from dbo.\"Order\" o, dbo.Movies m where o.MID>0 and o.MID=m.MID and CheckOutDate >= '"+StartRental+"' and CheckOutDate <= '"+EndRental+"' group by mName order by retailAmount desc";
                else myCommand.CommandText = "select mName, count(*) as retailAmount from dbo.\"Order\" o, dbo.Movies m where o.MID>0 and o.MID=m.MID and CheckOutDate >= '"+StartRental+"' and CheckOutDate <= '"+EndRental+"' group by mName order by retailAmount asc";
                popular_rental_grid.Rows.Clear();
                myReader = myCommand.ExecuteReader();
                // add queried data to grid
                while (myReader.Read())
                {
                    popular_rental_grid.Rows.Add(myReader["mName"].ToString(), myReader["retailAmount"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
            try
            {
                if (DescRental.Checked) myCommand.CommandText = "select mType, count(*) as retailAmount from dbo.\"Order\" o, dbo.Movies m where o.MID>0 and o.MID=m.MID and CheckOutDate >= '"+StartRental+"' and CheckOutDate <= '"+EndRental+"' group by mType order by retailAmount desc";
                else myCommand.CommandText = "select mType, count(*) as retailAmount from dbo.\"Order\" o, dbo.Movies m where o.MID>0 and o.MID=m.MID and CheckOutDate >= '"+StartRental+"' and CheckOutDate <= '"+EndRental+"' group by mType order by retailAmount asc";
                popular_type_rental_grid.Rows.Clear();
                myReader = myCommand.ExecuteReader();
                // add queried data to grid
                while (myReader.Read())
                {
                    popular_type_rental_grid.Rows.Add(myReader["mType"].ToString(), myReader["retailAmount"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void report_tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
