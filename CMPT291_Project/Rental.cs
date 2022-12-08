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
                myCommand.CommandText += "c.MID > 0";
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
            }else MessageBox.Show("Copy is not available");
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
    }
}
