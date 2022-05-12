using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistrationProject
{
    public partial class Enterance : Form
    {
        public Enterance()
        {
            InitializeComponent();
            txtID.Visible = false;
            lblID.Visible = false;
            txtPassword.Visible = false;
            lblPassword.Visible = false;
        }
        public void loadForm2(UserControl userControl)
        {
           
            
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
           
          
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblID.Visible = true;
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            txtID.Visible = true;
            if (cbDepartment.SelectedIndex == 0)
            {
                lblID.Text = "Student ID :";
            }
            else if (cbDepartment.SelectedIndex == 1)
            {
                lblID.Text = "Instructor ID :";
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (cbDepartment.Text == "Student")
                loadForm2(new StudentPage(txtID.Text));
            else if (cbDepartment.Text == "Instructor")
                loadForm2(new InstructorPage(txtID.Text));
            else
            {
                MessageBox.Show("Please select your Type");
            }
        }

       
    }
}
