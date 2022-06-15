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
    public partial class StudentPaymentReport : UserControl
    {
        SqlConnection conn;
        public StudentPaymentReport()
        {
            InitializeComponent();
            String ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            conn = new SqlConnection(ConnectionString);
            getReport();
        }
        private void getReport()
        {
            conn.Open();
            string Query = "SELECT ST.STUDENT_ID , ST.STD_FNAME+' '+ST.STD_LNAME , P.TOTAL_COAST FROM STUDENT AS ST INNER JOIN PAYMENTS AS P ON P.STUDENT_ID = ST.STUDENT_ID ORDER BY P.TOTAL_COAST desc";
            SqlCommand cmd = new SqlCommand(Query, conn);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader); 
            dataGridView1.DataSource = table;
            conn.Close();
            dataGridView1.Columns[0].HeaderText = "Student Id ";
            dataGridView1.Columns[1].HeaderText = "Student Name";
            dataGridView1.Columns[2].HeaderText = "Total Coast ";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }
    }
}
