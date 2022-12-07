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
            string ActNames = richTextBox1.Text;
            string MovieTitle = textBox1.Text;
            string SelectedGenre = "";
            if (SelectedIndex == -1)
            {
                SelectedIndex = 0;
            }


            myCommand.CommandText = "select * from dbo.Movies ";
            // filters
            
            if (CheckCopies && MovieTitle == "" && ActNames == "" && (SelectedIndex == 0 || SelectedIndex == -1)) //only copies //work
            {
                myCommand.CommandText += " where NumCopies > 1";
                
            }
            if (MovieTitle != "" && ActNames == "" && (SelectedIndex == -1 || SelectedIndex == 0) && !CheckCopies) //only title //work
            {
                myCommand.CommandText += " where mName like " + "'%" + MovieTitle + "%'";
            }
                    
            if  (SelectedIndex != -1 && !CheckCopies && MovieTitle == "" && ActNames == "") //only genre //work 
            {
                SelectedGenre = MovieType.Items[MovieType.SelectedIndex].ToString();
                if (SelectedGenre != "")
                {
                    myCommand.CommandText += " where mType = " + "'" + SelectedGenre + "'";
                }
            }

            if (ActNames != "" && (SelectedIndex == -1 || SelectedIndex == 0) && !CheckCopies && MovieTitle == "") //only actor //work
            {
                myCommand.CommandText += ", dbo.Actor A, dbo.Participated_IN P where Movies.MID=P.MID and A.AID=P.AID and A.Name like '%" + ActNames + "%'";
            }
            if (ActNames == "" && (SelectedIndex != -1 && SelectedIndex != 0) && CheckCopies && MovieTitle == "")//genre and copies // work
            {
                SelectedGenre = MovieType.Items[MovieType.SelectedIndex].ToString();
                myCommand.CommandText += " where mType = " + "'" + SelectedGenre + "'";
                myCommand.CommandText += " and NumCopies > 1";
            }

            if (ActNames != "" && (SelectedIndex != -1 && SelectedIndex != 0) && !CheckCopies && MovieTitle == "")//genre and actors //work 
            {
                SelectedGenre = MovieType.Items[MovieType.SelectedIndex].ToString();
                myCommand.CommandText += ", dbo.Actor A, dbo.Participated_IN P where Movies.MID=P.MID and A.AID=P.AID and A.Name like '%" + ActNames + "%'";
                myCommand.CommandText += " and mType = " + "'" + SelectedGenre + "'";
            }
            if (ActNames == "" && (SelectedIndex != -1 && SelectedIndex != 0) && !CheckCopies && MovieTitle != "")//genre and title //work
            {
                SelectedGenre = MovieType.Items[MovieType.SelectedIndex].ToString();
                myCommand.CommandText += " where mType = " + "'" + SelectedGenre + "'";
                myCommand.CommandText += " and mName like " + "'%" + MovieTitle + "%'";
            }
            if (ActNames != "" && (SelectedIndex == -1 || SelectedIndex == 0) && CheckCopies && MovieTitle == "")//copies and actor //work
            {
                myCommand.CommandText += ", dbo.Actor A, dbo.Participated_IN P where Movies.MID=P.MID and A.AID=P.AID and A.Name like '%" + ActNames + "%'";
                myCommand.CommandText += " and NumCopies > 1";
            }
            if (ActNames == "" && (SelectedIndex == -1 || SelectedIndex == 0) && CheckCopies && MovieTitle != "")//copies and title //work
            {
                myCommand.CommandText += " where mName like " + "'%" + MovieTitle + "%'";
                myCommand.CommandText += " and NumCopies > 1";
            }
            if (ActNames != "" && (SelectedIndex == -1 || SelectedIndex == 0) && !CheckCopies && MovieTitle != "") //actor and title //work
            {
                myCommand.CommandText += ", dbo.Actor A, dbo.Participated_IN P where Movies.MID=P.MID and A.AID=P.AID and A.Name like '%" + ActNames + "%'";
                myCommand.CommandText += " and mName like " + "'%" + MovieTitle + "%'";
            }
            if (ActNames == "" && (SelectedIndex != -1 && SelectedIndex != 0) && CheckCopies && MovieTitle != "")//genre copies title // work
            {
                SelectedGenre = MovieType.Items[MovieType.SelectedIndex].ToString();
                myCommand.CommandText += " where mType = " + "'" + SelectedGenre + "'";
                myCommand.CommandText += " and mName like " + "'%" + MovieTitle + "%'";
                myCommand.CommandText += " and NumCopies > 1";
            }
            if (ActNames != "" && (SelectedIndex != -1 && SelectedIndex != 0) && CheckCopies && MovieTitle == "") //genre actors copies //work
            {
                myCommand.CommandText += ", dbo.Actor A, dbo.Participated_IN P where Movies.MID=P.MID and A.AID=P.AID and A.Name like '%" + ActNames + "%'";
                myCommand.CommandText += " and NumCopies > 1";
                SelectedGenre = MovieType.Items[MovieType.SelectedIndex].ToString();
                myCommand.CommandText += " and mType = " + "'" + SelectedGenre + "'";
            }
            if (ActNames != "" && (SelectedIndex != -1 && SelectedIndex != 0) && !CheckCopies && MovieTitle != "")//genre actor title //work
            {
                myCommand.CommandText += ", dbo.Actor A, dbo.Participated_IN P where Movies.MID=P.MID and A.AID=P.AID and A.Name like '%" + ActNames + "%'";
                myCommand.CommandText += " and mName like " + "'%" + MovieTitle + "%'";
                SelectedGenre = MovieType.Items[MovieType.SelectedIndex].ToString();
                myCommand.CommandText += " and mType = " + "'" + SelectedGenre + "'";
            }
            if (ActNames != "" && (SelectedIndex == -1 || SelectedIndex == 0) && CheckCopies && MovieTitle != "")//copies actor title //work
            {
                myCommand.CommandText += ", dbo.Actor A, dbo.Participated_IN P where Movies.MID=P.MID and A.AID=P.AID and A.Name like '%" + ActNames + "%'";
                myCommand.CommandText += " and mName like " + "'%" + MovieTitle + "%'";
                myCommand.CommandText += " and NumCopies > 1";
            }

            if ((SelectedIndex != -1 && SelectedIndex != 0) && CheckCopies && MovieTitle != "" && ActNames != "") //all filters //work
            {
                myCommand.CommandText += ", dbo.Actor A, dbo.Participated_IN P where Movies.MID=P.MID and A.AID=P.AID and A.Name like '%" + ActNames + "%'";
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
                    MovieDisplay.Rows.Add(myReader["mName"].ToString(), myReader["mType"].ToString(), myReader["NumCopies"].ToString(), myReader["mRating"].ToString());
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
    }
}
