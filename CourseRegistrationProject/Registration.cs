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
    public partial class Registration : Form
    {
        SqlConnection conn;
        SqlCommand com = new SqlCommand();
        public Registration()
        {
            InitializeComponent();
            String ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            conn = new SqlConnection(ConnectionString);
            com = new SqlCommand();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            conn.Open();
            string str1 = txtIDNumber.Text.Substring(0, 5);
            string str2 = txtSurname.Text.Substring(0, 2);
            string ID = str1 + str2;
            string message = "";
            string gender="";
            string tarih = Convert.ToDateTime(dtpDateOfBirth.Value).ToString("yyyy-MM-dd");
            if (rbFemale.Checked = true)
                gender = "Female";
            if (rbMale.Checked = true)
                gender = "Male";
            if (cbType.SelectedIndex == 0)
            {
                com.Connection = conn;
                com.CommandText = "INSERT INTO STUDENT (STUDENT_ID,STD_FNAME,STD_LNAME,STD_PASSWORD,STD_BIRTHYEAR,STD_GENDER,STD_PASSP_ID) VALUES ('" + ID + "','" + txtName.Text + "','" + txtSurname.Text + "','" + txtPassword.Text + "','" + tarih + "','" + gender + "','" + txtIDNumber.Text + "')";
                com.ExecuteNonQuery();
                message = "  Registration Succesfull\n\n  Your Student Id is :" + ID;
            }
            else if (cbType.SelectedIndex == 1){
                com.Connection = conn;
                com.CommandText = "INSERT INTO INSTRUCTOR (INST_ID,INST_FNAME,INST_LNAME,INST_PASSWORD,INST_BIRTHYEAR,INST_GENDER,INST_PASSP_ID) VALUES ('" + ID + "','" + txtName.Text + "','" + txtSurname.Text + "','" + txtPassword.Text + "','" + tarih + "','" + gender + "','" + txtIDNumber.Text + "')";
                com.ExecuteNonQuery();  
                message = "  Registration Succesfull\n\n  Your Instructor Id is :" + ID;
            }
            MessageBox.Show(message,"Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtIDNumber.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtPassword.Clear();     
            cbType.SelectedIndex = -1;
            txtName.Focus();
            conn.Close();

            
        }

     
    }
}
