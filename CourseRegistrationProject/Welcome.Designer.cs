
namespace CourseRegistrationProject
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegisteration = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnterance = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCourseCreation = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegisteration
            // 
            this.btnRegisteration.Location = new System.Drawing.Point(12, 136);
            this.btnRegisteration.Name = "btnRegisteration";
            this.btnRegisteration.Size = new System.Drawing.Size(175, 51);
            this.btnRegisteration.TabIndex = 0;
            this.btnRegisteration.Text = "Registration";
            this.btnRegisteration.UseVisualStyleBackColor = true;
            this.btnRegisteration.Click += new System.EventHandler(this.btnRegisteration_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 67);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Registration System";
            // 
            // btnEnterance
            // 
            this.btnEnterance.Location = new System.Drawing.Point(12, 42);
            this.btnEnterance.Name = "btnEnterance";
            this.btnEnterance.Size = new System.Drawing.Size(175, 51);
            this.btnEnterance.TabIndex = 1;
            this.btnEnterance.Text = "Enterance";
            this.btnEnterance.UseVisualStyleBackColor = true;
            this.btnEnterance.Click += new System.EventHandler(this.btnEnterance_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Controls.Add(this.btnRegisteration);
            this.panel4.Controls.Add(this.btnCourseCreation);
            this.panel4.Controls.Add(this.btnReports);
            this.panel4.Controls.Add(this.btnEnterance);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 485);
            this.panel4.TabIndex = 3;
            // 
            // btnCourseCreation
            // 
            this.btnCourseCreation.Location = new System.Drawing.Point(12, 227);
            this.btnCourseCreation.Name = "btnCourseCreation";
            this.btnCourseCreation.Size = new System.Drawing.Size(175, 51);
            this.btnCourseCreation.TabIndex = 1;
            this.btnCourseCreation.Text = "Course Creation";
            this.btnCourseCreation.UseVisualStyleBackColor = true;
            this.btnCourseCreation.Click += new System.EventHandler(this.btnCourseCreation_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(12, 319);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(175, 51);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(202, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 485);
            this.panel1.TabIndex = 4;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRegisteration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnterance;
        private System.Windows.Forms.Button btnCourseCreation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReports;
    }
}

