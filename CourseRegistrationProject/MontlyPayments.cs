using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CourseRegistrationProject
{
    public partial class MontlyPayments : UserControl
    {
        SqlConnection conn;
        SqlCommand com;
        string _id;

        public MontlyPayments(String ID)
        {
            InitializeComponent();
            _id = ID;
            String ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            conn = new SqlConnection(ConnectionString);
            com = new SqlCommand();
            getPayments();
            asc();

        }
        private void asc()
        {
            conn.Open();
            string Query = " (SELECT TOTAL_COAST FROM PAYMENTS WHERE STUDENT_ID = '" + _id + "') ";
            SqlCommand cmd = new SqlCommand(Query, conn);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Object o = table.Rows[0]["TOTAL_COAST"];
            int PreliminaryPayment = Convert.ToInt32(o);
            MessageBox.Show("you have premilinary payment " + PreliminaryPayment/4 + " ");
            conn.Close();
        }
        private void getPayments()
        {
            conn.Open();
            string Query = " (SELECT TOTAL_COAST , PAYMENT_START_DATE , MONTH1 , MONTH2 , MONTH3 FROM PAYMENTS WHERE STUDENT_ID = '" + _id+"') ";
            SqlCommand cmd = new SqlCommand(Query, conn);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader); 
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Total Coast";
            dataGridView1.Columns[1].HeaderText = "Start Date";
            if (DateTime.Now.Month >= 3 && DateTime.Now.Month <= 6)
            {
                dataGridView1.Columns[2].HeaderText = "March";
                dataGridView1.Columns[3].HeaderText = "April";
                dataGridView1.Columns[4].HeaderText = "May";
            }
            else if (DateTime.Now.Month >=10 && DateTime.Now.Month == 1)
            {
                dataGridView1.Columns[2].HeaderText = "October";
                dataGridView1.Columns[3].HeaderText = "November";
                dataGridView1.Columns[4].HeaderText = "December";
            }
            conn.Close();
        }

    }
   
}
