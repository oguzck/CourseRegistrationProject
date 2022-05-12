using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistrationProject
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        public void loadForm3(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();


        }

        private void btnStdCourse_Click(object sender, EventArgs e)
        {
            loadForm3(new StudentCoursesReport());
        }

        private void btnStdPayment_Click(object sender, EventArgs e)
        {
            loadForm3(new StudentPaymentReport());
        }

        private void btnInstCourse_Click(object sender, EventArgs e)
        {
            loadForm3(new InstructorCoursesReport());
        }

        private void btnCoursesStudent_Click(object sender, EventArgs e)
        {
            loadForm3(new Courses_RegisteredStudentReport());
        }
    }
}
