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

        }
        private void getPayments()
        {

        }

    }
   
}
