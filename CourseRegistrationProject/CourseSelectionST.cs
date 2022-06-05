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
            GetCourses();

        }

        private void GetCourses()
        {
            conn.Open();
            string Query = "SELECT * FROM COURSE WHERE COURSE_CODE NOT IN (SELECT COURSE_CODE FROM ENROLL_STD_CRS WHERE STUDENT_ID = '"+_id+"') ";
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
            for (int i = 0; i<dataGridView1.Rows.Count; ++i)
            {
                if(dataGridView1.Rows[i].Cells[0].Value is true)
                {
                    string crsid = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    com.CommandText = "INSERT INTO ENROLL_STD_CRS VALUES ('" + _id + "','" + crsid + "','"+ DateTime.Now.Year.ToString()+"')";
                    com.ExecuteNonQuery();
                    
                }
            }
            MessageBox.Show("Enrollement Succesfull");
            conn.Close();
            GetCourses();
        }
    }
}
