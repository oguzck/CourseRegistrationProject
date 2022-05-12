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
    public partial class StudentPage : UserControl
    {
        public StudentPage(String ID )
        {
            InitializeComponent();
            label2.Text = ID;
        }
        public void loadForm3(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();


        }

        private void btnCourseSelection_Click(object sender, EventArgs e)
        {
            loadForm3(new CourseSelectionST());
        }

        private void btnMonthlyPayments_Click(object sender, EventArgs e)
        {
            loadForm3(new MontlyPayments());
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            loadForm3(new StudentInfo());
        }


    }
}
