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
using System.Configuration;

namespace CourseRegistrationProject
{
    public partial class Enterance : Form
    {
        SqlConnection conn;
        SqlCommand com = new SqlCommand();
        public Enterance()
        {
            InitializeComponent();
            txtID.Visible = false;
            lblID.Visible = false;
            txtPassword.Visible = false;
            lblPassword.Visible = false;
            String ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            conn = new SqlConnection(ConnectionString);
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
            conn.Open();
            
            if (cbDepartment.Text == "Student")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM STUDENT WHERE STUDENT_ID='" + txtID.Text + "' AND STD_PASSWORD ='" + txtPassword.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows[0][0].ToString() == "1") { 
                    loadForm2(new StudentPage(txtID.Text));
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password\n\nPlease Try Again");
                    txtID.Clear();
                    txtPassword.Clear();
                    cbDepartment.SelectedIndex = -1;
                }
                
            }
            else if (cbDepartment.Text == "Instructor") {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM INSTRUCTOR WHERE INST_ID='" + txtID.Text + "' AND INST_PASSWORD ='" + txtPassword.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    loadForm2(new InstructorPage(txtID.Text));
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password\n\nPlease Try Again");
                    txtID.Clear();
                    txtPassword.Clear();
                    cbDepartment.SelectedIndex = -1;
                }


            }
                
            else
            {
                MessageBox.Show("Please select your Type");
            }
            conn.Close();
        }

       
    }
}
