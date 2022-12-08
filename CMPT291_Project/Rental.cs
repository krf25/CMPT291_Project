using CMPT291_Group3_Project;
using System.Data;
using System.Data.SqlClient;

namespace CMPT291_Project
{
    public partial class Rental : Form
    {
        //starts the sql
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public Rental()
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


        private void CopySearch_Click_1(object sender, EventArgs e)
        {
            // value to check if box is empty
            myCommand.CommandText = "select m.mName, c.CPID,c.MID,c.mType,c.State,c.Availability,c.ReturnDate from dbo.Movies as m, dbo.Copies as c where c.MID=m.MID and ";
                // make command base on boxes filled
                if (MIDSearch.Text != "")
                    myCommand.CommandText += "c.MID = " + MIDSearch.Text + " and ";
                if (CopyTypeSearch.Text != "")
                    myCommand.CommandText += "c.mType = '" + CopyTypeSearch.Text + "' and ";
                if (AvailableCheckBox.Checked)
                    myCommand.CommandText += "Availability = 'Y' and ";
                myCommand.CommandText += "c.MID > 0 and c.State != 'Removed'";
            try
            {
                // shows the command
                MessageBox.Show(myCommand.CommandText);
                // runs command
                myReader = myCommand.ExecuteReader();

                CopyGrid.Rows.Clear();
                while (myReader.Read())
                {
                    // fills in the box with the sql return
                    CopyGrid.Rows.Add(myReader["CPID"].ToString(), myReader["MID"].ToString(), myReader["mName"].ToString(), myReader["State"].ToString()
                        , myReader["mType"].ToString(), myReader["Availability"].ToString(), myReader["ReturnDate"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            if (CPIDRent.Text == "") { return; }
            int orderMonths = 0;
            int startYear, startMonth, totalOrders = 0, nMonth, nYear;
            int score;
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            // needs to replace with login
            int dueYear, dueMonth;
            string CheckOutDay = year.ToString() + "-" + month.ToString() + "-" + day.ToString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(), availability;
            if (month + 1 == 13) { dueYear = year + 1; dueMonth = 1; } else { dueMonth = month + 1; dueYear = year; }
            string dueDate = dueYear.ToString() + "-" + dueMonth.ToString() + "-" + day.ToString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            // finds avalible OID by finding highest OID
            string MaxOID = "";
            //temp EID until global variable is made
            int OID, MID;
            myCommand.CommandText = "select max(OID) as OID from dbo.\"Order\"";
            try
            {
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    // returns highest OID
                    MaxOID += (myReader["OID"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");

            }
            // gets the avalible OID
            if (MaxOID == "") OID = 1;
            else OID = Convert.ToInt32(MaxOID) + 1;

            //check if copy is available
            myCommand.CommandText = "select Availability, MID from dbo.Copies where CPID = " + CPIDRent.Text;
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            availability = myReader["Availability"].ToString();
            MID = Int32.Parse(myReader["MID"].ToString());
            myReader.Close();

            if (availability == "Y")
            {
                //make sql command change copy as unavalible
                myCommand.CommandText = "update dbo.Copies set Availability = 'N',ReturnDate = '"+dueDate+"'  where CPID = " + CPIDRent.Text;
                // executes the sql commend
                myCommand.ExecuteNonQuery();
                //makes sql command to make order
                myCommand.CommandText = "insert into dbo.\"Order\" values(" + OID.ToString() + "," + MID.ToString() +
                "," + CPIDRent.Text + "," + IDtracker.CustomerID + "," + IDtracker.CustomerID + ",'" + CheckOutDay + "','"+ dueDate + "','N',0)";
                MessageBox.Show(myCommand.CommandText);
                // executes the sql commend
                myCommand.ExecuteNonQuery();
                Close();
                // update score for user
                // get dates to calculate score
                myCommand.CommandText = "select MONTH(START_Date) as month, YEAR(START_Date) as year from dbo.Customer where CID = " + IDtracker.CustomerID;
                myReader = myCommand.ExecuteReader();
                myReader.Read();
                startYear = Int32.Parse(myReader["year"].ToString());
                startMonth = Int32.Parse(myReader["month"].ToString());
                month += 1;
                if (month == 13) { month = 1; year += 1; }
                myReader.Close();
                // calculate score
                while ((startYear != year && startMonth != month) || orderMonths == 0)
                {
                    nMonth = startMonth + 1;
                    nYear = startYear;
                    if (nMonth == 13) { nMonth = 1; nYear += 1; }
                    myCommand.CommandText = "select count(*) as orderPerMonth from dbo.\"order\" where CID = "+IDtracker.CustomerID+" and CheckOutDate > '"+startYear.ToString()+"-"+startMonth.ToString()+"-1 0:0:0' and CheckOutDate <'"+ nYear.ToString()+"-"+ nMonth.ToString()+"-1 0:0:0'";
                    myReader = myCommand.ExecuteReader();
                    myReader.Read();
                    totalOrders += Int32.Parse(myReader["orderPerMonth"].ToString());
                    startMonth += 1;
                    orderMonths += 1;
                    if (startMonth == 13) {startMonth = 1; startYear += 1; }
                    myReader.Close();
                }
                if (totalOrders / orderMonths <= 2) score = 1;
                else if (totalOrders / orderMonths <= 4) score = 2;
                else if (orderMonths / orderMonths <= 6) score = 3;
                else if (orderMonths / orderMonths <= 8) score = 4;
                else score = 5;
                myCommand.CommandText = "update dbo.Customer set Rating = " + score.ToString() + " where CID = " + IDtracker.CustomerID;
                myCommand.ExecuteNonQuery();
            }
            else MessageBox.Show("Copy is not available");
        }

        private void MovieSearch_Click(object sender, EventArgs e)
        {
            // value to check if box is empty
            myCommand.CommandText = "select * from dbo.Movies";
            // if available checked
            if (MovieNameSerach.Text != "" || MovieTypeSearch.Text != "" || AvailableCheck.Checked)
            {
                myCommand.CommandText += " where ";
                // make command base on boxes filled
                if (MovieNameSerach.Text != "")
                    myCommand.CommandText += "mName like  '%" + MovieNameSerach.Text + "%' and ";
                if (MovieTypeSearch.Text != "")
                    myCommand.CommandText += "mType = '" + MovieTypeSearch.Text + "' and ";
                if (AvailableCheck.Checked)
                    myCommand.CommandText += "MID in (select MID from dbo.Copies where Availability = 'Y') and ";
                myCommand.CommandText += "MID > 0";
            }
                try
                {
                    // shows the command
                    MessageBox.Show(myCommand.CommandText);
                    // runs command
                    myReader = myCommand.ExecuteReader();

                    MovieGrid.Rows.Clear();
                    while (myReader.Read())
                    {
                        // fills in the box with the sql return
                        MovieGrid.Rows.Add(myReader["MID"].ToString(), myReader["mName"].ToString(), myReader["mType"].ToString(), myReader["mRating"].ToString());
                    }

                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
        }

        private void MovieQueueButton_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from dbo.MovieQueue as q, dbo.Movies as m where q.MID = m.MID and CID = " + IDtracker.CustomerID;
            myReader = myCommand.ExecuteReader();
            MovieQueueGrid.Rows.Clear();
            while (myReader.Read())
            {
                // fills in the box with the sql return
                MovieQueueGrid.Rows.Add(myReader["MID"].ToString(), myReader["mName"].ToString(), myReader["mType"].ToString(), myReader["mRating"].ToString());
            }

            myReader.Close();
        }
    }
}
