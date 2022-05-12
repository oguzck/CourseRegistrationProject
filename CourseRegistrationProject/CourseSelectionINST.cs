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

namespace CourseRegistrationProject
{
    public partial class CourseSelectionINST : UserControl
    {
        public CourseSelectionINST()
        {
            InitializeComponent();
            GetCourses();
        }
        private void GetCourses()
        {
            string constring = "Data Source= DESKTOP-NBBUC0A;Initial Catalog=deneme123; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string Query = "SELECT * FROM Courses";
            SqlCommand cmd = new SqlCommand(Query, con);
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




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Kaydedildi");
            dataGridView1.Enabled = false;
        }
    }
}
