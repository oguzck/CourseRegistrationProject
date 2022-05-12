
namespace CourseRegistrationProject
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnInstCourse = new System.Windows.Forms.Button();
            this.btnStdPayment = new System.Windows.Forms.Button();
            this.btnStdCourse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCoursesStudent = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Info;
            this.pnlHeader.Controls.Add(this.btnCoursesStudent);
            this.pnlHeader.Controls.Add(this.btnInstCourse);
            this.pnlHeader.Controls.Add(this.btnStdPayment);
            this.pnlHeader.Controls.Add(this.btnStdCourse);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 77);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnInstCourse
            // 
            this.btnInstCourse.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnInstCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInstCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInstCourse.Location = new System.Drawing.Point(422, 25);
            this.btnInstCourse.Name = "btnInstCourse";
            this.btnInstCourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInstCourse.Size = new System.Drawing.Size(158, 27);
            this.btnInstCourse.TabIndex = 2;
            this.btnInstCourse.Text = "Instructor-Courses";
            this.btnInstCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstCourse.UseVisualStyleBackColor = false;
            this.btnInstCourse.Click += new System.EventHandler(this.btnInstCourse_Click);
            // 
            // btnStdPayment
            // 
            this.btnStdPayment.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnStdPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStdPayment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStdPayment.Location = new System.Drawing.Point(223, 25);
            this.btnStdPayment.Name = "btnStdPayment";
            this.btnStdPayment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStdPayment.Size = new System.Drawing.Size(158, 27);
            this.btnStdPayment.TabIndex = 1;
            this.btnStdPayment.Text = "Student-Payments";
            this.btnStdPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdPayment.UseVisualStyleBackColor = false;
            this.btnStdPayment.Click += new System.EventHandler(this.btnStdPayment_Click);
            // 
            // btnStdCourse
            // 
            this.btnStdCourse.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnStdCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStdCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStdCourse.Location = new System.Drawing.Point(22, 25);
            this.btnStdCourse.Name = "btnStdCourse";
            this.btnStdCourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStdCourse.Size = new System.Drawing.Size(158, 27);
            this.btnStdCourse.TabIndex = 0;
            this.btnStdCourse.Text = "Student-Courses";
            this.btnStdCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdCourse.UseVisualStyleBackColor = false;
            this.btnStdCourse.Click += new System.EventHandler(this.btnStdCourse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 373);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(285, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTS";
            // 
            // btnCoursesStudent
            // 
            this.btnCoursesStudent.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCoursesStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCoursesStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCoursesStudent.Location = new System.Drawing.Point(620, 25);
            this.btnCoursesStudent.Name = "btnCoursesStudent";
            this.btnCoursesStudent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCoursesStudent.Size = new System.Drawing.Size(158, 27);
            this.btnCoursesStudent.TabIndex = 3;
            this.btnCoursesStudent.Text = "Courses-Student";
            this.btnCoursesStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoursesStudent.UseVisualStyleBackColor = false;
            this.btnCoursesStudent.Click += new System.EventHandler(this.btnCoursesStudent_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Reports";
            this.pnlHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnStdCourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInstCourse;
        private System.Windows.Forms.Button btnStdPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCoursesStudent;
    }
}