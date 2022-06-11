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
    public partial class StudentCoursesReport : UserControl
    {
        SqlConnection conn;
        public StudentCoursesReport()
        {
            InitializeComponent();
            String ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            conn = new SqlConnection(ConnectionString);
            getReport();
        }
        private void getReport()
        {
            conn.Open();
            string Query = "SELECT ST.STUDENT_ID , ST.STD_FNAME +' '+ ST.STD_LNAME , C.COURSE_TERM, COUNT(*) AS RGS FROM STUDENT AS ST INNER JOIN ENROLL_STD_CRS AS ER ON ER.STUDENT_ID = ST.STUDENT_ID INNER JOIN COURSE AS C ON C.COURSE_CODE = ER.COURSE_CODE GROUP BY ST.STUDENT_ID , ST.STD_FNAME , C.COURSE_TERM ,ST.STD_LNAME ORDER BY RGS desc";
            SqlCommand cmd = new SqlCommand(Query, conn);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            conn.Close();
            dataGridView1.Columns[0].HeaderText = "Student Id";
            dataGridView1.Columns[1].HeaderText = "Student Name";
            dataGridView1.Columns[2].HeaderText = "Term";
            dataGridView1.Columns[3].HeaderText = "Number Of Registered Courses By Students";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }
    }
}
