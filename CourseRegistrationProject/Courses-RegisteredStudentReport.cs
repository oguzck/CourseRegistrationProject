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
    public partial class Courses_RegisteredStudentReport : UserControl
    {
        SqlConnection conn;
        public Courses_RegisteredStudentReport()
        {
            InitializeComponent();
            String ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            conn = new SqlConnection(ConnectionString);
            getReport();
        }
        private void getReport()
        {
            conn.Open();
            string Query = "SELECT C.COURSE_CODE , C.COURSE_NAME , COUNT(*)AS NORS FROM COURSE AS C INNER JOIN ENROLL_STD_CRS AS ER ON ER.COURSE_CODE = C.COURSE_CODE GROUP BY C.COURSE_CODE , C.COURSE_NAME ORDER BY NORS DESC ";
            SqlCommand cmd = new SqlCommand(Query, conn);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            conn.Close();
            dataGridView1.Columns[0].HeaderText = "Course Code";
            dataGridView1.Columns[1].HeaderText = "Course Name";
            dataGridView1.Columns[2].HeaderText = "Number Of Registered Students";
        }


    }
}
