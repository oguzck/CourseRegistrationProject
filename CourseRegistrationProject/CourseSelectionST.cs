using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CourseRegistrationProject
{
    public partial class CourseSelectionST : UserControl
    {
        SqlConnection conn;
        SqlCommand com = new SqlCommand();
        string _id = "";
        public CourseSelectionST(String ID)
        {
            InitializeComponent();
            _id = ID;
            String ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            conn = new SqlConnection(ConnectionString);
            com = new SqlCommand();
            //GetCourses();

        }

        private void GetCourses()
        {
            conn.Open();
            string Query = "";
            if(cbTerm.SelectedIndex == 0)
            {
                 Query = "SELECT * FROM COURSE WHERE COURSE_TERM = 'Spring' AND COURSE_CODE NOT IN (SELECT COURSE_CODE FROM ENROLL_STD_CRS WHERE STUDENT_ID = '" + _id + "') ";

            }
            else
            {
                 Query = "SELECT * FROM COURSE WHERE COURSE_TERM = 'Fall' AND COURSE_CODE NOT IN (SELECT COURSE_CODE FROM ENROLL_STD_CRS WHERE STUDENT_ID = '" + _id + "') ";

            }
            SqlCommand cmd = new SqlCommand(Query, conn);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            
            foreach (DataGridViewColumn dc in dataGridView1.Columns)
            {
                if (dc.Index != 0)
                {
                    dc.ReadOnly = true;
                }
            }
            conn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            com.Connection = conn;
            bool dataInsterted = false;
            for (int i = 0; i<dataGridView1.Rows.Count; ++i)
            {
                if(dataGridView1.Rows[i].Cells[0].Value is true)
                {
                    string crsid = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    com.CommandText = "INSERT INTO ENROLL_STD_CRS VALUES ('" + _id + "','" + crsid + "','"+ DateTime.Now.Year.ToString()+"')";
                    com.ExecuteNonQuery();
                    dataInsterted = true;
                    
                }
                
            }
            if(dataInsterted is true)
                MessageBox.Show("Enrollement Succesfull");
            conn.Close();
            GetCourses();
        }

 
        private void cbTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCourses();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            conn.Open();
            string Query = "";
            if (cbTerm.SelectedIndex == 0)
            {
                 Query = "SELECT  SUM(C.COURSE_PRICE) AS TOTALCOAST FROM ENROLL_STD_CRS AS ER INNER JOIN COURSE AS C ON C.COURSE_CODE = ER.COURSE_CODE WHERE ER.STUDENT_ID = '"+_id+"' and C.COURSE_TERM = 'Spring'";

            }
            else
            {
                 Query = "SELECT  SUM(C.COURSE_PRICE) AS TOTALCOAST FROM ENROLL_STD_CRS AS ER INNER JOIN COURSE AS C ON C.COURSE_CODE = ER.COURSE_CODE WHERE ER.STUDENT_ID = '"+_id+"' and C.COURSE_TERM = 'Fall'";

            }
            SqlCommand cmd = new SqlCommand(Query, conn);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Object o = table.Rows[0]["TOTALCOAST"];
            int TotalValue = Convert.ToInt32(o);
            com.Connection = conn;
            com.CommandText = "INSERT INTO PAYMENTS VALUES ("+TotalValue+ ",'"+ DateTime.Now+ "','"+_id+"')";
            com.ExecuteNonQuery();
            conn.Close();

        }
    }
}
