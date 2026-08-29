using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtube_prac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFullDetails_Click(object sender, EventArgs e)
        {
            // Declaring variables and storing user inputs.
            string title = cbxTitle.Text;
            string initials = txtInitials.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            decimal age = nudAge.Value;

            // The else-if statement to check if all fields are entered, else continue with execution.
            if (title == "" || initials == "" || name == "" ||
               surname == "" || age == 0)
            {
                MessageBox.Show("Please enter all fields!");
            }
            else
            {
                rtbOutput.Text = "Full Details: " + "\n" + "Title: " + title + "\n" + "Initials: " + initials;
                rtbOutput.Text += "\n" + "Name: " + name + "\n" + "Surname: " + surname + "\n"+ "Age: " + Convert.ToString(age);
            }
        }

        private void btnShowSummary_Click(object sender, EventArgs e)
        {
            // Allowing the user input again for this event/event handler.
            string title = cbxTitle.Text;
            string surname = txtSurname.Text;

            if(title == "" || surname == "")
            {
                MessageBox.Show("Enter both your Title and Surname!");
            }
            else
            {
                MessageBox.Show("Summary Details: \n" + title + " " + surname);
            }
        }
    }
}
