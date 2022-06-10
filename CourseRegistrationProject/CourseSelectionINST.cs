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
    public partial class CourseSelectionINST : UserControl
    {
        SqlConnection conn;
        SqlCommand com = new SqlCommand();
        string _id = "";
        public CourseSelectionINST(string ID)
        {
            InitializeComponent();
            _id = ID;
            String ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            conn = new SqlConnection(ConnectionString);
            com = new SqlCommand();
            
        }
        private void GetCourses()
        {
            conn.Open();
            string Query = "";
            if (cbTerm.SelectedIndex == 0)
            {
                Query = "SELECT * FROM COURSE WHERE COURSE_TERM = 'Spring' AND  COURSE_CODE NOT IN(SELECT COURSE_CODE FROM ENROLL_INST_CRS) ";

            }
            else
            {
                Query = "SELECT * FROM COURSE WHERE COURSE_TERM = 'Fall' AND  COURSE_CODE NOT IN(SELECT COURSE_CODE FROM ENROLL_INST_CRS) ";
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

        private void cbTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCourses();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            com.Connection = conn;
            bool dataInsterted = false;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells[0].Value is true)
                {
                    string crsid = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    com.CommandText = "INSERT INTO ENROLL_INST_CRS VALUES ('" + _id + "','" + crsid + "','" + DateTime.Now.Year.ToString() + "')";
                    com.ExecuteNonQuery();
                    dataInsterted = true;

                }

            }
            if (dataInsterted is true)
                MessageBox.Show("Enrollement Succesfull");
            conn.Close();
            GetCourses();
        }
    }
}
