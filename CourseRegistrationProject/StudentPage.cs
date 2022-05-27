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
    public partial class StudentPage : UserControl
    {
        SqlConnection conn;
        SqlCommand com = new SqlCommand();
        string _id = "";
        public StudentPage(String ID)
        {
            _id = ID;
            String ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            conn = new SqlConnection(ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT STD_FNAME FROM STUDENT WHERE STUDENT_ID='" + ID + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            String name = dt.Rows[0][0].ToString(); 
            InitializeComponent();
            label2.Text = name;


        }
        
        public void loadForm3(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();


        }

        private void btnCourseSelection_Click(object sender, EventArgs e)
        {
            loadForm3(new CourseSelectionST(_id));
        }

        private void btnMonthlyPayments_Click(object sender, EventArgs e)
        {
            loadForm3(new MontlyPayments(_id));
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            loadForm3(new StudentInfo(_id));
        }


    }
}
