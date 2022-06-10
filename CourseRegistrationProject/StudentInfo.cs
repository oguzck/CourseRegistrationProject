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
    public partial class StudentInfo : UserControl
    {
        SqlConnection conn;
        SqlCommand com;
        string _id;
        public StudentInfo(String ID)
        {
            InitializeComponent();
            _id = ID;
            String ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            conn = new SqlConnection(ConnectionString);
            com = new SqlCommand();
            getStudentInfo();
        }
        private void getStudentInfo()
        {
            conn.Open();
            string Query = "SELECT STD_FNAME , STD_LNAME ,YEAR(GETDATE())-YEAR(STD_BIRTHYEAR) AS Age FROM STUDENT WHERE STUDENT_ID = '"+_id+"'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
          
            com = conn.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = " SELECT COURSE_NAME FROM COURSE AS C INNER JOIN ENROLL_STD_CRS AS ER ON ER.COURSE_CODE = C.COURSE_CODE INNER JOIN STUDENT AS ST ON ST.STUDENT_ID = ER.STUDENT_ID WHERE ST.STUDENT_ID = '" + _id + "'";
            com.ExecuteNonQuery();
            DataTable table2 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(table2);
            foreach (DataRow dr in table2.Rows)
            {
                cbCourses.Items.Add(dr["COURSE_NAME"].ToString());
            }
            Object firstname = table.Rows[0]["STD_FNAME"];
            Object lastname = table.Rows[0]["STD_LNAME"];
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
