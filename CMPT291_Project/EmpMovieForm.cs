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
                    CopyDisplay.Rows.Add(myReader["CID"].ToString(), myReader["MID"].ToString(), myReader["mType"].ToString(), myReader["State"].ToString());
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
            // command to delete copy base on CPID from the box
            myCommand.CommandText = "delete from dbo.Copies where CID = " + CPID_Delete_Box.Text;
            MessageBox.Show(myCommand.CommandText);
            myCommand.ExecuteNonQuery();
        }

        private void AddCopiesButton_Click(object sender, EventArgs e)
        {
            // finds avalible CID by finding highest CID
            string MaxCID = "";
            int CID;
            int num = 0;
            myCommand.CommandText = "select max(CID) as CID from dbo.Copies";
            try
            {
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    // returns highest CPID
                    MaxCID += (myReader["CID"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");

            }
            // gets the avalible CPID
            if (MaxCID == "") CID = 1;
            else CID = Convert.ToInt32(MaxCID)+1;
            try
            {
                // loop to add all copies
                while (num != Int32.Parse(Add_NumCopies_Box.Text))
                {
                    //make the sql to add the typed in data to copy table
                    myCommand.CommandText = "insert into dbo.Copies values (" + CID.ToString() + "," + Add_MID_Box.Text +
                        ",'" + Add_CopyType_Box.Text + "',' New ')";
                    // executes the sql commend
                    myCommand.ExecuteNonQuery();
                    //add value for loop
                    CID += 1;
                    num += 1;
                }
                MessageBox.Show("added " +num.ToString() + " copies");
                myCommand.CommandText = "update dbo.Movies set NumCopies = NumCopies+"+num.ToString()+ "where MID = "+Add_MID_Box.Text;
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // gets current values from Copy from CID
            myCommand.CommandText = "select * from dbo.Copies where CID = " + CopyIDEdit.Text;
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
            myCommand.CommandText = "update dbo.Copies set mType = '" + CopyType + "', State = '" + CopyState + "' where CID = " + CopyIDEdit.Text;
            MessageBox.Show(myCommand.CommandText);
            // runs command
            myCommand.ExecuteNonQuery();
        }

        private void ViewCopies_Click(object sender, EventArgs e)
        {

        }
    }
}
