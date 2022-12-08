using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Windows.Forms.VisualStyles;

namespace CMPT291_Project
{
    public partial class emp_movie_form : Form
    {
        // starts the sql connection
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public emp_movie_form()
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void movie_cast_label_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void FindCopies_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from dbo.Copies ";
            // see if there's any search parameters
            if (MovieIDSearch.Text != "" && CopyTypeSearch.Text != "")
                myCommand.CommandText += " where MID = " + MovieIDSearch.Text + "and mType = " + "'" + CopyTypeSearch.Text + "'";
            else if (MovieIDSearch.Text != "")
                myCommand.CommandText += "where MID = " + MovieIDSearch.Text;
            else if (CopyTypeSearch.Text != "")
                myCommand.CommandText += "where mType = " + "'" + CopyTypeSearch.Text + "'";
            // runs
            try
            {
                // shows the command
                MessageBox.Show(myCommand.CommandText);
                // runs command
                myReader = myCommand.ExecuteReader();

                CopyDisplay.Rows.Clear();
                while (myReader.Read())
                {
                    // fills in the box with the sql return
                    CopyDisplay.Rows.Add(myReader["CPID"].ToString(), myReader["MID"].ToString(), myReader["mType"].ToString(), myReader["State"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void RemoveCopiesButton_Click(object sender, EventArgs e)
        {
            if (CPID_Delete_Box.Text == "")
            {
                MessageBox.Show("Please fill in the Copy ID field.");
                return;
            }
            // command to delete copy base on CPID from the box
            myCommand.CommandText = "update dbo.Copies set Availability = 'N', ReturnDate = '' where CID = " + CPID_Delete_Box.Text;
            MessageBox.Show(myCommand.CommandText);
            myCommand.ExecuteNonQuery();
        }

        private void AddCopiesButton_Click(object sender, EventArgs e)
        {
            //make sure all the boxes are filled

            // finds avalible CPID by finding highest CPID
            string MaxCPID = "";
            int CPID;
            int num = 0;
            myCommand.CommandText = "select max(CPID) as CPID from dbo.Copies";
            try
            {
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    // returns highest CPID
                    MaxCPID += (myReader["CPID"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");

            }
            // gets the avalible CPID
            if (MaxCPID == "") CPID = 1;
            else CPID = Convert.ToInt32(MaxCPID) + 1;
            try
            {
                // loop to add all copies
                while (num != Int32.Parse(Add_NumCopies_Box.Text))
                {
                    //make the sql to add the typed in data to copy table
                    myCommand.CommandText = "insert into dbo.Copies values (" + CPID.ToString() + "," + Add_MID_Box.Text +
                        ",'" + Add_CopyType_Box.Text + "','New','Y', '')";
                    // executes the sql commend
                    myCommand.ExecuteNonQuery();
                    //add value for loop
                    CPID += 1;
                    num += 1;
                }
                MessageBox.Show("added " + num.ToString() + " copies");
                myCommand.CommandText = "update dbo.Movies set NumCopies = NumCopies+" + num.ToString() + "where MID = " + Add_MID_Box.Text + "";
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // gets current values from Copy from CPID
            myCommand.CommandText = "select * from dbo.Copies where CPID = " + CopyIDEdit.Text + "";
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            // shows current values in the boxes
            CopyTypeEdit.Text = myReader["mType"].ToString();
            CopyStateEdit.Text = myReader["State"].ToString();
            myReader.Close();
        }

        private void EditCopyButton_Click(object sender, EventArgs e)
        {
            string CopyType = CopyTypeEdit.Text, CopyState = CopyStateEdit.Text;
            // makes the command for change
            myCommand.CommandText = "update dbo.Copies set mType = '" + CopyType + "', State = '" + CopyState + "' where CPID =" + CopyIDEdit.Text + "";
            MessageBox.Show(myCommand.CommandText);
            // runs command
            myCommand.ExecuteNonQuery();
        }

        private void ViewCopies_Click(object sender, EventArgs e)
        {

        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {   // ADDING MOVIES TAB
            const double distro_FEE = 1.99;
            string title = movie_text_box.Text;
            string genre = genre_movie_box.Text;
            Dictionary<int, string> participation = new Dictionary<int, string>();
            Dictionary<string, string> cast = new Dictionary<string, string>();
            cast.Add("lead_1", lead_act_1.Text);
            cast.Add("lead_2", lead_act_2.Text);
            cast.Add("support_1", support_act_1.Text);
            cast.Add("support_2", support_act_2.Text);

            // check for movie already existing in database
            myCommand.CommandText = "select mName from Movies where mName ='" + title + "'";
            object movie_check = myCommand.ExecuteScalar();

            if (title == "" || genre == "")
            {
                MessageBox.Show("Please fill in the Movie title and Genre fields");
                return;
            }

            // movie titles.text are not case sensitive when adding movies to the database
            if (movie_check != null)
            {
                MessageBox.Show("'" + title + "' already exists in the database.");
                return;
            }

            // if lead actor 1 gender not chosen, throw exception
            if (lead_1_gender.SelectedIndex == -1 || lead_act_1.Text == "" || lead_Age1.Text == "")
            {
                MessageBox.Show("Please fill in all Lead Actor 1 fields");
                return;
            }

            // generate new MID
            myCommand.CommandText = "Select max(MID) FROM Movies";
            int max_MID = (int)myCommand.ExecuteScalar();
            max_MID++;


            foreach (var actor_name in cast)
            {

                if (actor_name.Value == "")
                {
                    continue;
                }
                // check for actor already in database
                myCommand.CommandText = "select name from Actor where name = '" + actor_name.Value + "'";
                object actor_exist = myCommand.ExecuteScalar();
                if (actor_exist != null)
                {
                    MessageBox.Show("Actor " + actor_name.Value + " Already Exists");
                    continue;
                }
                // Lead Actor 1 insertion
                if (actor_name.Key == "lead_1")
                {
                    if (lead_1_gender.SelectedIndex == 0)
                    {
                        //gen new ID for new actor
                        string actor_gender = "M";
                        int actor_age = Int32.Parse(lead_Age1.Text);
                        myCommand.CommandText = "Select max(AID) FROM Actor";
                        int max_AID = (int)myCommand.ExecuteScalar();
                        max_AID++;
                        participation.Add(max_AID, "Lead_1");

                        // insert into actor table
                        myCommand.CommandText = "insert into dbo.Actor values (" + max_AID + ", '" + actor_name.Value + "', '" + actor_gender + "', '" + actor_age + "', 0)";
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(myCommand.CommandText);
                        continue;
                    }
                    if (lead_1_gender.SelectedIndex == 1)
                    {
                        //gen new ID for new actor
                        string actor_gender = "F";
                        int actor_age = Int32.Parse(lead_Age1.Text);
                        myCommand.CommandText = "Select max(AID) FROM Actor";
                        int max_AID = (int)myCommand.ExecuteScalar();
                        max_AID++;
                        participation.Add(max_AID, "Lead_1");

                        // insert into actor table
                        myCommand.CommandText = "insert into dbo.Actor values (" + max_AID + ", '" + actor_name.Value + "', '" + actor_gender + "', '" + actor_age + "', 0)";
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(myCommand.CommandText);
                        continue;
                    }

                }
                // Lead Actor 2 insertion
                if (actor_name.Key == "lead_2")
                {
                    if (lead_2_gender.SelectedIndex == 0 && lead_Age2.Text != "")
                    {   //gen new ID for new actor
                        string actor_gender = "M";
                        int actor_age = Int32.Parse(lead_Age2.Text);
                        myCommand.CommandText = "Select max(AID) FROM Actor";
                        int max_AID = (int)myCommand.ExecuteScalar();
                        max_AID++;
                        participation.Add(max_AID, "Lead_2");

                        // insert into actor table
                        myCommand.CommandText = "insert into dbo.Actor values (" + max_AID + ", '" + actor_name.Value + "', '" + actor_gender + "', '" + actor_age + "', 0)";
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(myCommand.CommandText);
                        continue;
                    }
                    if (lead_2_gender.SelectedIndex == 1 && lead_Age2.Text != "")
                    {   //gen new ID for new actor
                        string actor_gender = "F";
                        int actor_age = Int32.Parse(lead_Age2.Text);
                        myCommand.CommandText = "Select max(AID) FROM Actor";
                        int max_AID = (int)myCommand.ExecuteScalar();
                        max_AID++;
                        participation.Add(max_AID, "Lead_2");

                        // insert into actor table
                        myCommand.CommandText = "insert into dbo.Actor values (" + max_AID + ", '" + actor_name.Value + "', '" + actor_gender + "', '" + actor_age + "', 0)";
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(myCommand.CommandText);
                        continue;
                    }
                    // empty age box or combobox
                    if (lead_Age2.Text == "")
                    {
                        MessageBox.Show("Please fill in the age box for Lead Actor 2");
                    }
                    if (lead_2_gender.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select gender for Lead Actor 2");
                        return;
                    }
                }
                // Support Actor 1 insertion
                if (actor_name.Key == "support_1" && support_age1.Text != "")
                {
                    if (support_1_gender.SelectedIndex == 0 && support_age1.Text != "")
                    {   //gen new ID for new actor
                        string actor_gender = "M";
                        int actor_age = Int32.Parse(support_age1.Text);
                        myCommand.CommandText = "Select max(AID) FROM Actor";
                        int max_AID = (int)myCommand.ExecuteScalar();
                        max_AID++;
                        participation.Add(max_AID, "Support_1");

                        // insert into actor table
                        myCommand.CommandText = "insert into dbo.Actor values (" + max_AID + ", '" + actor_name.Value + "', '" + actor_gender + "', '" + actor_age + "', 0)";
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(myCommand.CommandText);
                        continue;
                    }
                    if (support_1_gender.SelectedIndex == 1 && support_age1.Text != "")
                    {   //gen new ID for new actor
                        string actor_gender = "F";
                        int actor_age = Int32.Parse(support_age1.Text);
                        myCommand.CommandText = "Select max(AID) FROM Actor";
                        int max_AID = (int)myCommand.ExecuteScalar();
                        max_AID++;
                        participation.Add(max_AID, "Support_1");

                        // insert into actor table
                        myCommand.CommandText = "insert into dbo.Actor values (" + max_AID + ", '" + actor_name.Value + "', '" + actor_gender + "', '" + actor_age + "', 0)";
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(myCommand.CommandText);
                        continue;
                    }
                    // empty age box or gender combobox
                    if (support_age1.Text == "")
                    {
                        MessageBox.Show("Please fill in the age box for Support Actor 1");
                    }
                    if (support_1_gender.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select gender for Support Actor 1");
                        return;
                    }
                }
                // Support Actor 2 insertion
                if (actor_name.Key == "support_2")
                {
                    if (support_2_gender.SelectedIndex == 0 && support_age2.Text != "")
                    {   //gen new ID for new actor
                        string actor_gender = "M";
                        int actor_age = Int32.Parse(support_age2.Text);
                        myCommand.CommandText = "Select max(AID) FROM Actor";
                        int max_AID = (int)myCommand.ExecuteScalar();
                        max_AID++;
                        participation.Add(max_AID, "Support_2");

                        // insert into actor table
                        myCommand.CommandText = "insert into dbo.Actor values (" + max_AID + ", '" + actor_name.Value + "', '" + actor_gender + "', '" + actor_age + "', 0)";
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(myCommand.CommandText);
                        continue;
                    }
                    if (support_2_gender.SelectedIndex == 1 && support_age2.Text != "")
                    {   //gen new ID for new actor
                        string actor_gender = "F";
                        int actor_age = Int32.Parse(support_age2.Text);
                        myCommand.CommandText = "Select max(AID) FROM Actor";
                        int max_AID = (int)myCommand.ExecuteScalar();
                        max_AID++;
                        participation.Add(max_AID, "Support_2");

                        // insert into actor table
                        myCommand.CommandText = "insert into dbo.Actor values (" + max_AID + ", '" + actor_name.Value + "', '" + actor_gender + "', '" + actor_age + "', 0)";
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(myCommand.CommandText);
                        continue;
                    }
                    // empty age box or gender combobox
                    if (support_age2.Text == "")
                    {
                        MessageBox.Show("Please fill in the age box for Support Actor 2");
                    }
                    if (support_2_gender.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select gender for Support Actor 2");
                        return;
                    }
                }
            }

            // random number between 1 and 5 for deciding how many copies exist for a movie; unconcerned with potential hanging random int being duplicated in following entries
            Random num_gen = new Random();
            int movie_copies = num_gen.Next(1, 6);
            myCommand.CommandText = "insert into dbo.Movies values (" + max_MID + ", '" + title + "', '" + genre + "', " + distro_FEE + ", " + movie_copies + ", 0)";
            myCommand.ExecuteNonQuery();
            MessageBox.Show(myCommand.CommandText);

            foreach (var participant in participation)
            {
                if (participant.Value == "Lead_1")
                {
                    myCommand.CommandText = "insert into dbo.Participated_IN values (" + participant.Key + ", " + max_MID + ", 'Lead')";
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show(myCommand.CommandText);
                    continue;
                }
                if (participant.Value == "Lead_2")
                {
                    myCommand.CommandText = "insert into dbo.Participated_IN values (" + participant.Key + ", " + max_MID + ", 'Lead')";
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show(myCommand.CommandText);
                    continue;
                }
                if (participant.Value == "Support_1")
                {
                    myCommand.CommandText = "insert into dbo.Participated_IN values (" + participant.Key + ", " + max_MID + ", 'Support')";
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show(myCommand.CommandText);
                    continue;
                }
                if (participant.Value == "Support_2")
                {
                    myCommand.CommandText = "insert into dbo.Participated_IN values (" + participant.Key + ", " + max_MID + ", 'Support')";
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show(myCommand.CommandText);
                    continue;
                }
            }
        }


        private static void gen_movies_btn_Click1(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {   //EDIT MOVIE
            string title = textBox2.Text;
            string genre = textBox1.Text;
            string new_title = textBox4.Text;
            string new_genre = textBox3.Text;

            if (title == "" || genre == "")
            {
                MessageBox.Show("Please fill in the Movie Title and Genre fields");
                return;
            }

            // check for movie in database
            myCommand.CommandText = "select mName from Movies where mName ='" + title + "' and mType ='" + genre + "'";
            object movie_check = myCommand.ExecuteScalar();
            if (movie_check == null)
            {
                MessageBox.Show("'" + title + "' under the '" + genre + "' genre does not exist in the database.");
                return;
            }
            if (movie_check != null)
            {
                myCommand.CommandText = "UPDATE Movies SET mName = '" + new_title + "', mType = '" + new_genre + "' WHERE mName ='" + title + "' and mType ='" + genre + "'";
                myCommand.ExecuteNonQuery();
                return;
            }


        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void DeleteMovieButton_Click(object sender, EventArgs e)
        {
            string movie_title = textBox6.Text;
            // check for movie in database
            myCommand.CommandText = "select mName from Movies where mName ='" + movie_title + "'";
            object movie_check = myCommand.ExecuteScalar();
            if (movie_title == "")
            {
                MessageBox.Show("Please fill in the Movie Name field");
                return;
            }

            if (movie_check is null)
            {
                MessageBox.Show("Movie title '" + movie_title + "' does not exist in the database.");
                return;
            }
            else
            {
                myCommand.CommandText = "select MID from Movies where mName = '" + movie_title + "'";
                int movie_ID = (int)myCommand.ExecuteScalar();
                // delete participated_in entry where MID exists before deleting the movie entry from Movies because of FK constraint
                myCommand.CommandText = "DELETE FROM Participated_IN WHERE MID=" + movie_ID + "";
                myCommand.ExecuteNonQuery();

                // grab name of movie from MID
                myCommand.CommandText = "select mName from Movies where mName ='" + movie_title + "'";
                object movie_name = myCommand.ExecuteScalar();

                // delete movie from Movies table
                myCommand.CommandText = "DELETE FROM Movies WHERE mName ='" + movie_title + "'";
                myCommand.ExecuteNonQuery();

                // show user what has been deleted
                MessageBox.Show("Movie ID '" + movie_title + "', '" + movie_name + "' has been deleted from the database.");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   // ADDING ACTORS BTN
            int movie_title_MID = 0;
            string title = textBox7.Text;
            Dictionary<int, string> participation_actor = new Dictionary<int, string>();
            Dictionary<string, string> cast = new Dictionary<string, string>();
            cast.Add("lead_1", richTextBox8.Text);
            cast.Add("lead_2", richTextBox6.Text);
            cast.Add("support_1", richTextBox5.Text);
            cast.Add("support_2", richTextBox7.Text);

            
            if (title == "")
            {
                MessageBox.Show("Please fill in the Movie field");
                return;
            }

            // check for movie already existing in database
            myCommand.CommandText = "select mName from Movies where mName ='" + title + "'";
            object movie_check = myCommand.ExecuteScalar();

            // movie titles.text are not case sensitive when adding movies to the database
            if (movie_check == null)
            {
                MessageBox.Show("'" + title + "' doesn't exist in the database.");
                return;
            }

            // grab movie title MID
            myCommand.CommandText = "select MID from Movies where mName ='" + title + "'";
            movie_title_MID = (int)myCommand.ExecuteScalar();
            

            // if lead actor 1 gender not chosen, throw exception
            if (actor_lead_1_gender.SelectedIndex == -1 || richTextBox8.Text == "" || actor_lead_age1.Text == "")
            {
                MessageBox.Show("Please fill in all Lead Actor 1 fields");
                return;
            }

            foreach (var actor_name in cast)
            {

                if (actor_name.Value == "")
                {
                    continue;
                }
                // check for actor already in database
                myCommand.CommandText = "select name from Actor where name = '" + actor_name.Value + "'";
                object actor_exist = myCommand.ExecuteScalar();
                if (actor_exist != null)
                {
                    MessageBox.Show("Actor " + actor_name.Value + " Already Exists");
                    continue;
                }
                // Lead Actor 1 insertion
                if (actor_name.Key == "lead_1")
                {
                    if (actor_lead_1_gender.SelectedIndex == 0)
                    {
                        //gen new ID for new actor
                        string actor_gender = "M";
                        int actor_age = Int32.Parse(actor_lead_age1.Text);
                        myCommand.CommandText = "Select max(AID) FROM Actor";
                        int max_AID = (int)myCommand.ExecuteScalar();
                        max_AID++;
                        participation_actor.Add(max_AID, "Lead_1");

                        // insert into actor table
                        myCommand.CommandText = "insert into dbo.Actor values (" + max_AID + ", '" + actor_name.Value + "', '" + actor_gender + "', '" + actor_age + "', 0)";
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(myCommand.CommandText);
                        continue;
                    }
                    if (actor_lead_1_gender.SelectedIndex == 1)
                    {
                        //gen new ID for new actor
                        string actor_gender = "F";
                        int actor_age = Int32.Parse(actor_lead_age1.Text);
                        myCommand.CommandText = "Select max(AID) FROM Actor";
                        int max_AID = (int)myCommand.ExecuteScalar();
                        max_AID++;
                        participation_actor.Add(max_AID, "Lead_1");

                        // insert into actor table
                        myCommand.CommandText = "insert into dbo.Actor values (" + max_AID + ", '" + actor_name.Value + "', '" + actor_gender + "', '" + actor_age + "', 0)";
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(myCommand.CommandText);
                        continue;
                    }

                }
                // Lead Actor 2 insertion
                if (actor_name.Key == "lead_2")
                {
                    if (actor_lead_2_gender.SelectedIndex == 0 && actor_lead_age2.Text != "")
                    {   //gen new ID for new actor
                        string actor_gender = "M";
                        int actor_age = Int32.Parse(actor_lead_age2.Text);
                        myCommand.CommandText = "Select max(AID) FROM Actor";
                        int max_AID = (int)myCommand.ExecuteScalar();
                        max_AID++;
                        participation_actor.Add(max_AID, "Lead_2");

                        // insert into actor table
                        myCommand.CommandText = "insert into dbo.Actor values (" + max_AID + ", '" + actor_name.Value + "', '" + actor_gender + "', '" + actor_age + "', 0)";
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(myCommand.CommandText);
                        continue;
                    }
                    if (actor_lead_2_gender.SelectedIndex == 1 && actor_lead_age2.Text != "")
                    {   //gen new ID for new actor
                        string actor_gender = "F";
                        int actor_age = Int32.Parse(actor_lead_age2.Text);
                        myCommand.CommandText = "Select max(AID) FROM Actor";
                        int max_AID = (int)myCommand.ExecuteScalar();
                        max_AID++;
                        participation_actor.Add(max_AID, "Lead_2");

                        // insert into actor table
                        myCommand.CommandText = "insert into dbo.Actor values (" + max_AID + ", '" + actor_name.Value + "', '" + actor_gender + "', '" + actor_age + "', 0)";
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(myCommand.CommandText);
                        continue;
                    }
                    // empty age box or combobox
                    if (actor_lead_age2.Text == "")
                    {
                        MessageBox.Show("Please fill in the age box for Lead Actor 2");
                    }
                    if (actor_lead_2_gender.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select gender for Lead Actor 2");
                        return;
                    }
                }
                // Support Actor 1 insertion
                if (actor_name.Key == "support_1" && actor_support_age1.Text != "")
                {
                    if (actor_support_1_gender.SelectedIndex == 0 && actor_support_age1.Text != "")
                    {   //gen new ID for new actor
                        string actor_gender = "M";
                        int actor_age = Int32.Parse(actor_support_age1.Text);
                        myCommand.CommandText = "Select max(AID) FROM Actor";
                        int max_AID = (int)myCommand.ExecuteScalar();
                        max_AID++;
                        participation_actor.Add(max_AID, "Support_1");

                        // insert into actor table
                        myCommand.CommandText = "insert into dbo.Actor values (" + max_AID + ", '" + actor_name.Value + "', '" + actor_gender + "', '" + actor_age + "', 0)";
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(myCommand.CommandText);
                        continue;
                    }
                    if (actor_support_1_gender.SelectedIndex == 1 && actor_support_age1.Text != "")
                    {   //gen new ID for new actor
                        string actor_gender = "F";
                        int actor_age = Int32.Parse(actor_support_age1.Text);
                        myCommand.CommandText = "Select max(AID) FROM Actor";
                        int max_AID = (int)myCommand.ExecuteScalar();
                        max_AID++;
                        participation_actor.Add(max_AID, "Support_1");

                        // insert into actor table
                        myCommand.CommandText = "insert into dbo.Actor values (" + max_AID + ", '" + actor_name.Value + "', '" + actor_gender + "', '" + actor_age + "', 0)";
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(myCommand.CommandText);
                        continue;
                    }
                    // empty age box or gender combobox
                    if (actor_support_age1.Text == "")
                    {
                        MessageBox.Show("Please fill in the age box for Support Actor 1");
                    }
                    if (actor_support_1_gender.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select gender for Support Actor 1");
                        return;
                    }
                }
                // Support Actor 2 insertion
                if (actor_name.Key == "support_2")
                {
                    if (actor_support_2_gender.SelectedIndex == 0 && actor_support_age2.Text != "")
                    {   //gen new ID for new actor
                        string actor_gender = "M";
                        int actor_age = Int32.Parse(actor_support_age2.Text);
                        myCommand.CommandText = "Select max(AID) FROM Actor";
                        int max_AID = (int)myCommand.ExecuteScalar();
                        max_AID++;
                        participation_actor.Add(max_AID, "Support_2");

                        // insert into actor table
                        myCommand.CommandText = "insert into dbo.Actor values (" + max_AID + ", '" + actor_name.Value + "', '" + actor_gender + "', '" + actor_age + "', 0)";
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(myCommand.CommandText);
                        continue;
                    }
                    if (actor_support_2_gender.SelectedIndex == 1 && actor_support_age2.Text != "")
                    {   //gen new ID for new actor
                        string actor_gender = "F";
                        int actor_age = Int32.Parse(actor_support_age2.Text);
                        myCommand.CommandText = "Select max(AID) FROM Actor";
                        int max_AID = (int)myCommand.ExecuteScalar();
                        max_AID++;
                        participation_actor.Add(max_AID, "Support_2");

                        // insert into actor table
                        myCommand.CommandText = "insert into dbo.Actor values (" + max_AID + ", '" + actor_name.Value + "', '" + actor_gender + "', '" + actor_age + "', 0)";
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(myCommand.CommandText);
                        continue;
                    }
                    // empty age box or gender combobox
                    if (actor_support_age2.Text == "")
                    {
                        MessageBox.Show("Please fill in the age box for Support Actor 2");
                    }
                    if (actor_support_2_gender.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select gender for Support Actor 2");
                        return;
                    }
                }
            }
            foreach (var participant in participation_actor)
            {
                if (participant.Value == "Lead_1")
                {
                    myCommand.CommandText = "insert into dbo.Participated_IN values (" + participant.Key + ", " + movie_title_MID + ", 'Lead')";
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show(myCommand.CommandText);
                    continue;
                }
                if (participant.Value == "Lead_2")
                {
                    myCommand.CommandText = "insert into dbo.Participated_IN values (" + participant.Key + ", " + movie_title_MID + ", 'Lead')";
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show(myCommand.CommandText);
                    continue;
                }
                if (participant.Value == "Support_1")
                {
                    myCommand.CommandText = "insert into dbo.Participated_IN values (" + participant.Key + ", " + movie_title_MID + ", 'Support')";
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show(myCommand.CommandText);
                    continue;
                }
                if (participant.Value == "Support_2")
                {
                    myCommand.CommandText = "insert into dbo.Participated_IN values (" + participant.Key + ", " + movie_title_MID + ", 'Support')";
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show(myCommand.CommandText);
                    continue;
                }
            }
        }

        private void edit_actor_btn_Click(object sender, EventArgs e)
        {   // EDITING ACTORS TAB
            string old_actor = richTextBox2.Text;
            string new_actor = richTextBox4.Text;
            string new_role = richTextBox10.Text;
            string edit_actor_age = richTextBox3.Text;

            if (edit_actor_age == "" || new_actor == "")
            {
                MessageBox.Show("Please fill in the New Actor name and Age fields.");
                return;
            }

            // no update to actor role
            if (new_role == "")
            {
                // do nothing
            }

            // grab actor AID
            myCommand.CommandText = "select AID from Actor WHERE name ='" + old_actor + "'";
            int actor_AID = (int)myCommand.ExecuteScalar();

            // check for actor in database
            myCommand.CommandText = "select name from Actor WHERE name ='" + old_actor + "'";
            object actor_check = myCommand.ExecuteScalar();
            if (actor_check == null)
            {
                MessageBox.Show("Actor does not exist in the database.");
                return;
            }
            if (actor_check != null)
            {
                int new_actor_age = Int32.Parse(richTextBox3.Text);
                myCommand.CommandText = "UPDATE Actor SET Name = '" + new_actor + "', Age = '" + new_actor_age + "' WHERE Name ='" + old_actor + "'";
                MessageBox.Show(myCommand.CommandText);
                myCommand.ExecuteNonQuery();
            }
            
            // if role is to be updated
            if (new_role != "")
            {
                myCommand.CommandText = "UPDATE Participated_IN SET Role = '" + new_role + "' WHERE AID =" + actor_AID + "";
                MessageBox.Show(myCommand.CommandText);
                myCommand.ExecuteNonQuery();
                return;
            }
            
        }
        //DELETE ACTORS FROM DATABASE BTN
        private void button1_Click_2(object sender, EventArgs e)
        {   
            string actor_name_remove = remove_actor_name.Text;
            // if actor name field is empty
            if (actor_name_remove == "")
            {
                MessageBox.Show("Please fill in the Actor Name field.");
                return;
            }

            // check for Actor in database
            myCommand.CommandText = "select Name from Actor where Name ='" + actor_name_remove + "'";
            object actor_name_check_rem = myCommand.ExecuteScalar();
            if (actor_name_check_rem is null)
            {
                MessageBox.Show("Actor '" + actor_name_remove + "' does not exist in the database.");
                return;
            }
            else
            {
                myCommand.CommandText = "select AID from Actor where Name ='" + actor_name_remove + "'";
                int actor_rem_AID = (int)myCommand.ExecuteScalar();
                // delete participated_in entry where AID exists before deleting the Actor entry from Actor because of FK constraint
                myCommand.CommandText = "DELETE FROM Participated_IN WHERE AID=" + actor_rem_AID + "";
                myCommand.ExecuteNonQuery();
                // delete movie from Movies table
                myCommand.CommandText = "DELETE FROM Actor WHERE Name ='" + actor_name_remove + "'";
                myCommand.ExecuteNonQuery();
                return;
            }
        }

        private void gen_movies_btn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
