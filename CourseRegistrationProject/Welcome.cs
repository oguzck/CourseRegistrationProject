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
    
    public partial class Welcome : Form
    {
        
        public Welcome()
        {
            InitializeComponent();
            
            
        }
        public void loadForm(object Form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();
        }

        private void btnRegisteration_Click(object sender, EventArgs e)
        {
            loadForm(new Registration());


        }

        private void btnEnterance_Click(object sender, EventArgs e)
        {
            loadForm(new Enterance());
            
        }

        private void btnCourseCreation_Click(object sender, EventArgs e)
        {
            loadForm(new CourseCreation());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            loadForm(new Reports());
        }
    }
}
