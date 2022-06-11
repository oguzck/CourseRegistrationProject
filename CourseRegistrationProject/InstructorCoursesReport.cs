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
    public partial class InstructorCoursesReport : UserControl
    {
        SqlConnection conn;
        public InstructorCoursesReport()
        {
            InitializeComponent();
            String ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            conn = new SqlConnection(ConnectionString);
            getReport();
        }
        private void getReport()
        {
            conn.Open();
            string Query = "SELECT INST.INST_ID AS [Instructor Id], (INST.INST_FNAME+' '+INST.INST_LNAME) AS [Instructor Name] , COUNT(*) AS [Number Of Given Coursees] FROM INSTRUCTOR AS INST INNER JOIN ENROLL_INST_CRS AS ER ON ER.INST_ID = INST.INST_ID GROUP BY INST.INST_ID , INST.INST_FNAME , INST.INST_LNAME ORDER BY [Number Of Given Coursees]DESC";
            SqlCommand cmd = new SqlCommand(Query, conn);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            conn.Close();
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }
    }
}
