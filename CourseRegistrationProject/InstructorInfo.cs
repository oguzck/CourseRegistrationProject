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
    public partial class InstructorInfo : UserControl
    {
        SqlConnection conn;
        SqlCommand com;
        string _id;
        public InstructorInfo(String ID)
        {
            InitializeComponent();
            _id = ID;
            String ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            conn = new SqlConnection(ConnectionString);
            com = new SqlCommand();
            getInstInfo();
        }
        private void getInstInfo()
        {
            conn.Open();
            string Query = "SELECT INST_FNAME , INST_LNAME ,YEAR(GETDATE()) - YEAR(INST_BIRTHYEAR) AS Age FROM INSTRUCTOR WHERE INST_ID = '"+_id+"'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            com = conn.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = " SELECT COURSE_NAME FROM COURSE AS C INNER JOIN ENROLL_INST_CRS AS ER ON ER.COURSE_CODE = C.COURSE_CODE INNER JOIN INSTRUCTOR AS INST ON INST.INST_ID = ER.INST_ID WHERE INST.INST_ID = '" + _id + "'";
            com.ExecuteNonQuery();
            DataTable table2 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(table2);
            foreach (DataRow dr in table2.Rows)
            {
                cbCourses.Items.Add(dr["COURSE_NAME"].ToString());
            }
            Object firstname = table.Rows[0]["INST_FNAME"];
            Object lastname = table.Rows[0]["INST_LNAME"];
            Object Age = table.Rows[0]["Age"];
            string age = Age.ToString();
            string lname = lastname.ToString();
            string fname = firstname.ToString();
            lblName.Text = fname;
            lblAge.Text = age;
            lblSurname.Text = lname;
            if (DateTime.Now.Month >= 3 && DateTime.Now.Month <= 6)
            {
                lblTerm.Text = "Spring";
            }
            else if (DateTime.Now.Month >= 10 && DateTime.Now.Month == 1)
            {
                lblTerm.Text = "Fall";
            }
            conn.Close();

        }
    }
}
