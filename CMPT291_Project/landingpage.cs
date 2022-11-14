using CMPT291_Group3_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT291_Project
{
    public partial class landingpage : Form
    {
        public landingpage()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        // reports label
        private void label3_Click(object sender, EventArgs e)
        {
            EmpReports ER = new EmpReports();
            ER.Show();
        }
        //rental label
        private void label4_Click(object sender, EventArgs e)
        {
            EmpRental rental = new EmpRental();
            rental.Show();
        }
        // movie label
        private void label2_Click(object sender, EventArgs e)
        {
            emp_movie_form emf = new emp_movie_form();
            emf.Show();
        }
        // customer label
        private void label1_Click(object sender, EventArgs e)
        {
            CustomerInfo CIF = new CustomerInfo();
            CIF.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Employee_Info EIF = new Employee_Info();
            EIF.Show();
        }
    }
}
