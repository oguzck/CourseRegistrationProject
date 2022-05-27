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
    public partial class CourseCreation : Form
    {
        SqlConnection conn;
        SqlCommand com = new SqlCommand();
        public CourseCreation()
        {
            InitializeComponent();
            String ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            conn = new SqlConnection(ConnectionString);
            com = new SqlCommand();
        }
        private void clearComponent()
        {
            txtCourseCode.Clear();
            txtCourseName.Clear();
            txtPrice.Clear();
            cbSemester.SelectedIndex = -1;
            txtCourseCode.Focus();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            conn.Open();         
            com.Connection = conn;
            com.CommandText = "INSERT INTO COURSE VALUES ('" + txtCourseCode.Text + "','" + txtCourseName.Text + "','" + cbSemester.Text + "','" + Convert.ToInt32(txtPrice.Text)+ "')";
            com.ExecuteNonQuery() ;
            conn.Close();
            MessageBox.Show("Course Created");
            clearComponent();

        }
    }
}
