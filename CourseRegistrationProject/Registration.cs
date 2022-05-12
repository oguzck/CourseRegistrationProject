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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string str1 = txtIDNumber.Text.Substring(0, 5);
            string str2 = txtSurname.Text.Substring(0, 2);
            string ID = str1 + str2;
            string message = "";
            if (cbType.SelectedIndex == 0)
            {
                 message = "  Registration Succesfull\n\n  Your Student Id is :" + ID;
            }
            else if (cbType.SelectedIndex == 1){
                 message = "  Registration Succesfull\n\n  Your Instructor Id is :" + ID;
            }
            MessageBox.Show(message,"Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtIDNumber.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtPassword.Clear();
            cbDepartment.SelectedIndex = -1;
            cbType.SelectedIndex = -1;
            cbYear.SelectedIndex = -1;
            txtName.Focus();

            
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex == 0)
            {
                lblYear.Enabled = true;
                cbYear.Enabled = true;
            }
            else if (cbType.SelectedIndex == 1)
            {
                lblYear.Enabled = false;
                cbYear.Enabled = false;
            }

        }

       
    }
}
