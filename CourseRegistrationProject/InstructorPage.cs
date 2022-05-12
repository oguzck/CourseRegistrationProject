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
    public partial class InstructorPage : UserControl
    {
        public InstructorPage(String ID)
        {
            InitializeComponent();
            label2.Text = ID;
        }
        public void loadForm4(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();


        }
        private void btnCourseSelection_Click(object sender, EventArgs e)
        {
            loadForm4(new CourseSelectionINST());
        }

        private void btnInstInfo_Click(object sender, EventArgs e)
        {
            loadForm4(new InstructorInfo());
        }
    }
}
