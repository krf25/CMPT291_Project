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
using System.Net;
using System.Runtime.Intrinsics.X86;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Windows.Forms.VisualStyles;


namespace CMPT291_Project
{
    public partial class CustomerScreen : Form
    {
        
        // starts the sql connection
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlCommand actorCommand;
        public SqlDataReader myReader;
        public CustomerScreen()
        {
            InitializeComponent();
            SqlConnection myConnection = new SqlConnection(@"Data Source=(local);Initial Catalog=Cmpt291_GroupProject;Integrated Security=True");
            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
                actorCommand = new SqlCommand();
                actorCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void MovieType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        public void button2_Click(object sender, EventArgs e)
        {
            int SelectedIndex = MovieType.SelectedIndex;
            bool CheckCopies = checkBox1.Checked;
            string Names = richTextBox1.Text;
            string[] ActNames = Names.Split(',');
            string MovieTitle = textBox1.Text;
            string SelectedGenre = "";
           
            if (SelectedIndex == -1)
            {
                SelectedIndex = 0;
            }


            myCommand.CommandText = "select * from dbo.Movies ";
            // filters
            
            if (CheckCopies && MovieTitle == "" && ActNames[0] == "" && (SelectedIndex == 0 || SelectedIndex == -1)) //only copies //work
            {
                myCommand.CommandText += " where NumCopies > 1";
                
            }
            if (MovieTitle != "" && ActNames[0] == "" && (SelectedIndex == -1 || SelectedIndex == 0) && !CheckCopies) //only title //work
            {
                myCommand.CommandText += " where mName like " + "'%" + MovieTitle + "%'";
            }
                    
            if  (SelectedIndex != -1 && !CheckCopies && MovieTitle == "" && ActNames[0] == "") //only genre //work 
            {
                SelectedGenre = MovieType.Items[MovieType.SelectedIndex].ToString();
                if (SelectedGenre != "")
                {
                    myCommand.CommandText += " where mType = " + "'" + SelectedGenre + "'";
                }
            }

            if (ActNames[0] != "" && (SelectedIndex == -1 || SelectedIndex == 0) && !CheckCopies && MovieTitle == "") //only actor //work
            {

                myCommand.CommandText += ", dbo.Actor A, dbo.Participated_IN P where Movies.MID=P.MID and A.AID=P.AID and A.Name like '%" + ActNames[0] + "%'";
                if (ActNames.Length > 1)
                {
                    myCommand.CommandText = "select * from dbo.Movies M where M.MID IN((select Movies.MID from dbo.Movies, dbo.Actor A, dbo.Participated_IN P where Movies.MID = P.MID and A.AID = P.AID and A.Name like '%" + ActNames[0] + "%')";
                    for (int i = 1; i < ActNames.Length; i++)
                    {
                        myCommand.CommandText += " INTERSECT (select Movies.MID from dbo.Movies, dbo.Actor A, dbo.Participated_IN P where Movies.MID = P.MID and A.AID = P.AID and A.Name like '%" + ActNames[i] + "%'))";
                      
                    }
                }
            }
            if (ActNames[0] == "" && (SelectedIndex != -1 && SelectedIndex != 0) && CheckCopies && MovieTitle == "")//genre and copies // work
            {
                SelectedGenre = MovieType.Items[MovieType.SelectedIndex].ToString();
                myCommand.CommandText += " where mType = " + "'" + SelectedGenre + "'";
                myCommand.CommandText += " and NumCopies > 1";
            }

            if (ActNames[0] != "" && (SelectedIndex != -1 && SelectedIndex != 0) && !CheckCopies && MovieTitle == "")//genre and actors //work 
            {
                SelectedGenre = MovieType.Items[MovieType.SelectedIndex].ToString();
                myCommand.CommandText += ", dbo.Actor A, dbo.Participated_IN P where Movies.MID=P.MID and A.AID=P.AID and A.Name like '%" + ActNames[0] + "%'";
                if (ActNames.Length > 1)
                {
                    myCommand.CommandText = "select * from dbo.Movies M where M.MID IN((select Movies.MID from dbo.Movies, dbo.Actor A, dbo.Participated_IN P where Movies.MID = P.MID and A.AID = P.AID and A.Name like '%" + ActNames[0] + "%')";
                    for (int i = 1; i < ActNames.Length; i++)
                    {
                        myCommand.CommandText += " INTERSECT (select Movies.MID from dbo.Movies, dbo.Actor A, dbo.Participated_IN P where Movies.MID = P.MID and A.AID = P.AID and A.Name like '%" + ActNames[i] + "%'))";

                    }
                }
                myCommand.CommandText += " and mType = " + "'" + SelectedGenre + "'";
            }
            if (ActNames[0] == "" && (SelectedIndex != -1 && SelectedIndex != 0) && !CheckCopies && MovieTitle != "")//genre and title //work
            {
                SelectedGenre = MovieType.Items[MovieType.SelectedIndex].ToString();
                myCommand.CommandText += " where mType = " + "'" + SelectedGenre + "'";
                myCommand.CommandText += " and mName like " + "'%" + MovieTitle + "%'";
            }
            if (ActNames[0] != "" && (SelectedIndex == -1 || SelectedIndex == 0) && CheckCopies && MovieTitle == "")//copies and actor //work
            {
                myCommand.CommandText += ", dbo.Actor A, dbo.Participated_IN P where Movies.MID=P.MID and A.AID=P.AID and A.Name like '%" + ActNames[0] + "%'";
                if (ActNames.Length > 1)
                {
                    myCommand.CommandText = "select * from dbo.Movies M where M.MID IN((select Movies.MID from dbo.Movies, dbo.Actor A, dbo.Participated_IN P where Movies.MID = P.MID and A.AID = P.AID and A.Name like '%" + ActNames[0] + "%')";
                    for (int i = 1; i < ActNames.Length; i++)
                    {
                        myCommand.CommandText += " INTERSECT (select Movies.MID from dbo.Movies, dbo.Actor A, dbo.Participated_IN P where Movies.MID = P.MID and A.AID = P.AID and A.Name like '%" + ActNames[i] + "%'))";

                    }
                }
                myCommand.CommandText += " and NumCopies > 1";
            }
            if (ActNames[0] == "" && (SelectedIndex == -1 || SelectedIndex == 0) && CheckCopies && MovieTitle != "")//copies and title //work
            {
                myCommand.CommandText += " where mName like " + "'%" + MovieTitle + "%'";
                myCommand.CommandText += " and NumCopies > 1";
            }
            if (ActNames[0] != "" && (SelectedIndex == -1 || SelectedIndex == 0) && !CheckCopies && MovieTitle != "") //actor and title //work
            {
                myCommand.CommandText += ", dbo.Actor A, dbo.Participated_IN P where Movies.MID=P.MID and A.AID=P.AID and A.Name like '%" + ActNames[0] + "%'";
                if (ActNames.Length > 1)
                {
                    myCommand.CommandText = "select * from dbo.Movies M where M.MID IN((select Movies.MID from dbo.Movies, dbo.Actor A, dbo.Participated_IN P where Movies.MID = P.MID and A.AID = P.AID and A.Name like '%" + ActNames[0] + "%')";
                    for (int i = 1; i < ActNames.Length; i++)
                    {
                        myCommand.CommandText += " INTERSECT (select Movies.MID from dbo.Movies, dbo.Actor A, dbo.Participated_IN P where Movies.MID = P.MID and A.AID = P.AID and A.Name like '%" + ActNames[i] + "%'))";

                    }
                }
                myCommand.CommandText += " and mName like " + "'%" + MovieTitle + "%'";
            }
            if (ActNames[0] == "" && (SelectedIndex != -1 && SelectedIndex != 0) && CheckCopies && MovieTitle != "")//genre copies title // work
            {
                SelectedGenre = MovieType.Items[MovieType.SelectedIndex].ToString();
                myCommand.CommandText += " where mType = " + "'" + SelectedGenre + "'";
                myCommand.CommandText += " and mName like " + "'%" + MovieTitle + "%'";
                myCommand.CommandText += " and NumCopies > 1";
            }
            if (ActNames[0] != "" && (SelectedIndex != -1 && SelectedIndex != 0) && CheckCopies && MovieTitle == "") //genre actors copies //work
            {
                myCommand.CommandText += ", dbo.Actor A, dbo.Participated_IN P where Movies.MID=P.MID and A.AID=P.AID and A.Name like '%" + ActNames[0] + "%'";
                if (ActNames.Length > 1)
                {
                    myCommand.CommandText = "select * from dbo.Movies M where M.MID IN((select Movies.MID from dbo.Movies, dbo.Actor A, dbo.Participated_IN P where Movies.MID = P.MID and A.AID = P.AID and A.Name like '%" + ActNames[0] + "%')";
                    for (int i = 1; i < ActNames.Length; i++)
                    {
                        myCommand.CommandText += " INTERSECT (select Movies.MID from dbo.Movies, dbo.Actor A, dbo.Participated_IN P where Movies.MID = P.MID and A.AID = P.AID and A.Name like '%" + ActNames[i] + "%'))";

                    }
                }
                myCommand.CommandText += " and NumCopies > 1";
                SelectedGenre = MovieType.Items[MovieType.SelectedIndex].ToString();
                myCommand.CommandText += " and mType = " + "'" + SelectedGenre + "'";
            }
            if (ActNames[0] != "" && (SelectedIndex != -1 && SelectedIndex != 0) && !CheckCopies && MovieTitle != "")//genre actor title //work
            {
                myCommand.CommandText += ", dbo.Actor A, dbo.Participated_IN P where Movies.MID=P.MID and A.AID=P.AID and A.Name like '%" + ActNames[0] + "%'";
                if (ActNames.Length > 1)
                {
                    myCommand.CommandText = "select * from dbo.Movies M where M.MID IN((select Movies.MID from dbo.Movies, dbo.Actor A, dbo.Participated_IN P where Movies.MID = P.MID and A.AID = P.AID and A.Name like '%" + ActNames[0] + "%')";
                    for (int i = 1; i < ActNames.Length; i++)
                    {
                        myCommand.CommandText += " INTERSECT (select Movies.MID from dbo.Movies, dbo.Actor A, dbo.Participated_IN P where Movies.MID = P.MID and A.AID = P.AID and A.Name like '%" + ActNames[i] + "%'))";

                    }
                }
                myCommand.CommandText += " and mName like " + "'%" + MovieTitle + "%'";
                SelectedGenre = MovieType.Items[MovieType.SelectedIndex].ToString();
                myCommand.CommandText += " and mType = " + "'" + SelectedGenre + "'";
            }
            if (ActNames[0] != "" && (SelectedIndex == -1 || SelectedIndex == 0) && CheckCopies && MovieTitle != "")//copies actor title //work
            {
                myCommand.CommandText += ", dbo.Actor A, dbo.Participated_IN P where Movies.MID=P.MID and A.AID=P.AID and A.Name like '%" + ActNames[0] + "%'";
                myCommand.CommandText += " and mName like " + "'%" + MovieTitle + "%'";
                myCommand.CommandText += " and NumCopies > 1";
            }

            if ((SelectedIndex != -1 && SelectedIndex != 0) && CheckCopies && MovieTitle != "" && ActNames[0] != "") //all filters //work
            {
                myCommand.CommandText += ", dbo.Actor A, dbo.Participated_IN P where Movies.MID=P.MID and A.AID=P.AID and A.Name like '%" + ActNames[0] + "%'";
                if (ActNames.Length > 1)
                {
                    myCommand.CommandText = "select * from dbo.Movies M where M.MID IN((select Movies.MID from dbo.Movies, dbo.Actor A, dbo.Participated_IN P where Movies.MID = P.MID and A.AID = P.AID and A.Name like '%" + ActNames[0] + "%')";
                    for (int i = 1; i < ActNames.Length; i++)
                    {
                        myCommand.CommandText += " INTERSECT (select Movies.MID from dbo.Movies, dbo.Actor A, dbo.Participated_IN P where Movies.MID = P.MID and A.AID = P.AID and A.Name like '%" + ActNames[i] + "%'))";

                    }
                }
                myCommand.CommandText += " and mName like " + "'%" + MovieTitle + "%'";
                SelectedGenre = MovieType.Items[MovieType.SelectedIndex].ToString();
                myCommand.CommandText += " and mType = " + "'" + SelectedGenre + "'";
                myCommand.CommandText += " and NumCopies > 1";
            }
            
            try
            {
                // shows the command
                MessageBox.Show(myCommand.CommandText);
                // runs command
                myReader = myCommand.ExecuteReader();

                MovieDisplay.Rows.Clear();
                while (myReader.Read())
                {
                    // fills in the box with the sql return
                    MovieDisplay.Rows.Add(myReader["MID"].ToString(), myReader["mName"].ToString(), myReader["mType"].ToString(), myReader["NumCopies"].ToString(), myReader["mRating"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RemoveMovieId.Text != "")
            {
                myCommand.CommandText = "DELETE FROM dbo.MovieQueue WHERE MID = " + RemoveMovieId.Text + " and CID = " + IDtracker.CustomerID;
                MessageBox.Show("MID:" + RemoveMovieId.Text + " Removed from queue");
                myCommand.ExecuteNonQuery();
                MovieQueueGrid.Rows.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AddMovieId.Text != "")
            {
                // check if repeat email
                myCommand.CommandText = "select count(*) as repeat from dbo.MovieQueue where MID = " + AddMovieId.Text;
                myReader = myCommand.ExecuteReader();
                myReader.Read();
                if (myReader["repeat"].ToString() == "0")
                {
                    myReader.Close();
                    // finds avalible QID by finding highest QID
                    string MaxQID = "";
                    int QID;
                    myCommand.CommandText = "select max(QID) as QID from dbo.MovieQueue";
                    try
                    {
                        myReader = myCommand.ExecuteReader();
                        while (myReader.Read())
                        {
                            // returns highest CID
                            MaxQID += (myReader["QID"].ToString());
                        }
                        myReader.Close();
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show(e3.ToString(), "Error");

                    }
                    // gets the avalible CID
                    if (MaxQID == "") QID = 1;
                    else QID = Convert.ToInt32(MaxQID) + 1;
                    myCommand.CommandText = "insert into dbo.MovieQueue values (" + QID.ToString() + "," +
                            IDtracker.CustomerID + "," + AddMovieId.Text + ")";
                    MessageBox.Show(myCommand.CommandText);
                    // executes the sql command
                    myCommand.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Movie Already in queue");
                    myReader.Close();
                }
            }
        }

        private void SearchMovieQueueButton_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from dbo.MovieQueue as q, dbo.Movies as m where q.MID = m.MID and CID = " + IDtracker.CustomerID;
            try
            {
                // runs command
                myReader = myCommand.ExecuteReader();
                MovieQueueGrid.Rows.Clear();
                while (myReader.Read())
                {
                    // fills in the box with the sql return
                    MovieQueueGrid.Rows.Add(myReader["MID"].ToString(), myReader["mName"].ToString(), myReader["mType"].ToString(), myReader["mRating"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void ViewRentalButton_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from dbo.\"Order\" as o, dbo.Movies as m where o.MID = m.MID and o.CID = " + IDtracker.CustomerID + " and ";
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            string today = year.ToString() + "-" + month.ToString() + "-" + day.ToString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            // fill in filters in command
            if (HeldMovieCheckBox.Checked)
                myCommand.CommandText += "Returned = 'N' and ";
            if (OverDueMovieCheckBox.Checked)
                myCommand.CommandText += "CheckOutDate < '" + today + "' and ";
            myCommand.CommandText += "m.MID > 0";
            try
            {
                // shows the command
                MessageBox.Show(myCommand.CommandText);
                // runs command
                myReader = myCommand.ExecuteReader();

                CustomerRentalGrid.Rows.Clear();
                while (myReader.Read())
                {
                    // fills in the box with the sql return
                    CustomerRentalGrid.Rows.Add(myReader["MID"].ToString(), myReader["CPID"].ToString(), myReader["mName"].ToString(), myReader["CheckOutDate"].ToString(), myReader["ReturnDate"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void RateMovieButton_Click(object sender, EventArgs e)
        {
            string AID;
            int score;
            actorCommand.CommandText = "";
            if (ScoreNumberBox.Text != "" && RateMIDBox.Text != "")
            {
                myCommand.CommandText = "select Count(*) from Movies where MID = '" + RateMIDBox.Text + "'";
                int exist = (int)myCommand.ExecuteScalar();
                if (exist == 0) { MessageBox.Show("You have not rented this movie"); return; }
                score = Int32.Parse(ScoreNumberBox.Text);
                if (score<6 && score > 0) { 
                //set all customers movie scores
                myCommand.CommandText = "update dbo.\"Order\" set Rating = " + ScoreNumberBox.Text + " where MID = "+ RateMIDBox.Text+" and CID = " + IDtracker.CustomerID;
                // runs command
                myCommand.ExecuteNonQuery();
                //update the movies score
                myCommand.CommandText = "update dbo.Movies set mRating = (select avg(Rating) from (select distinct CID, Rating from dbo.\"Order\" where MID = "+ RateMIDBox.Text + ")x where Rating > 0) where MID = " + RateMIDBox.Text;
                myCommand.ExecuteNonQuery();
                //update all actor scores
                myCommand.CommandText = "select AID from Participated_IN where MID = " + RateMIDBox.Text;
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    // gets the AID to update score for all actors
                    AID = myReader["AID"].ToString();
                    actorCommand.CommandText += "update dbo.Actor set Rating = (select avg(mRating) from dbo.Participated_IN as p, dbo.Movies as m where p.AID = " + AID + " and p.MID = m.MID and m.mRating >0) where AID = " + AID + "\n";
                }
                myReader.Close();
                actorCommand.ExecuteNonQuery();
                MessageBox.Show("rating received");
                }else MessageBox.Show("Score must be between 1-5");
            }
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void ViewInfoButton_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from dbo.Customer where CID = " + IDtracker.CustomerID;
            myReader = myCommand.ExecuteReader();

            CustomerDisplay.Rows.Clear();
            while (myReader.Read())
            {
                // fills in the box with the sql return
                CustomerDisplay.Rows.Add(myReader["CID"].ToString(), myReader["LName"].ToString(), myReader["FName"].ToString(), myReader["Address"].ToString(), myReader["City"].ToString(), myReader["State"].ToString(), myReader["ZIP"].ToString(), myReader["Phone"].ToString(), myReader["Email"].ToString(), myReader["password"].ToString(), myReader["CreditCardNum"].ToString(), myReader["TID"].ToString(), myReader["START_Date"].ToString(), myReader["END_Date"].ToString());
            }

            myReader.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (AVCopiesCheck.Checked) myCommand.CommandText = "select m.MID, m.mName, m.mType, m.mRating, count(OID) as retailAmount from dbo.\"Order\" o, dbo.Movies m, dbo.Copies c where o.MID>0 and o.MID=m.MID and c.MID = m.MID and c.Availability = 'Y'  group by m.MID, m.mName, m.mType, m.mRating order by retailAmount desc";
            else myCommand.CommandText = "select m.MID, m.mName, m.mType, m.mRating, count(OID) as retailAmount from dbo.\"Order\" o, dbo.Movies m where o.MID>0 and o.MID=m.MID  group by m.MID, m.mName, m.mType, m.mRating order by retailAmount desc";
            try
            {
                // shows the command
                MessageBox.Show(myCommand.CommandText);
                // runs command
                myReader = myCommand.ExecuteReader();

                CustBest.Rows.Clear();
                while (myReader.Read())
                {
                    // fills in the box with the sql return
                    CustBest.Rows.Add(myReader["MID"].ToString(), myReader["mName"].ToString(), myReader["mType"].ToString(), myReader["mRating"].ToString());
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
