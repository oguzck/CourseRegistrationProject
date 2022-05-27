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
    public partial class InstructorPage : UserControl
    {
        SqlConnection conn;
        string _id = "";
        public InstructorPage(String ID)
        {
            _id = ID;
            String ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            conn = new SqlConnection(ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT INST_FNAME FROM INSTRUCTOR WHERE INST_ID='" + ID + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            String name = dt.Rows[0][0].ToString();
            InitializeComponent();
            label2.Text = name;
        }
        public void loadForm4(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();


        }
        private void btnCourseSelection_Click(object sender, EventArgs e)
        {
            loadForm4(new CourseSelectionINST(_id));
        }

        private void btnInstInfo_Click(object sender, EventArgs e)
        {
            loadForm4(new InstructorInfo(_id));
        }
    }
}
