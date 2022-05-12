
namespace CourseRegistrationProject
{
    partial class StudentPage
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStudentInfo = new System.Windows.Forms.Button();
            this.btnMonthlyPayments = new System.Windows.Forms.Button();
            this.btnCourseSelection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 440);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnStudentInfo);
            this.panel2.Controls.Add(this.btnMonthlyPayments);
            this.panel2.Controls.Add(this.btnCourseSelection);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 73);
            this.panel2.TabIndex = 1;
            // 
            // btnStudentInfo
            // 
            this.btnStudentInfo.Location = new System.Drawing.Point(582, 25);
            this.btnStudentInfo.Name = "btnStudentInfo";
            this.btnStudentInfo.Size = new System.Drawing.Size(183, 23);
            this.btnStudentInfo.TabIndex = 2;
            this.btnStudentInfo.Text = "Student Info";
            this.btnStudentInfo.UseVisualStyleBackColor = true;
            this.btnStudentInfo.Click += new System.EventHandler(this.btnStudentInfo_Click);
            // 
            // btnMonthlyPayments
            // 
            this.btnMonthlyPayments.Location = new System.Drawing.Point(313, 25);
            this.btnMonthlyPayments.Name = "btnMonthlyPayments";
            this.btnMonthlyPayments.Size = new System.Drawing.Size(183, 23);
            this.btnMonthlyPayments.TabIndex = 1;
            this.btnMonthlyPayments.Text = "Monthly Payments";
            this.btnMonthlyPayments.UseVisualStyleBackColor = true;
            this.btnMonthlyPayments.Click += new System.EventHandler(this.btnMonthlyPayments_Click);
            // 
            // btnCourseSelection
            // 
            this.btnCourseSelection.Location = new System.Drawing.Point(31, 26);
            this.btnCourseSelection.Name = "btnCourseSelection";
            this.btnCourseSelection.Size = new System.Drawing.Size(183, 23);
            this.btnCourseSelection.TabIndex = 0;
            this.btnCourseSelection.Text = "Course Selection";
            this.btnCourseSelection.UseVisualStyleBackColor = true;
            this.btnCourseSelection.Click += new System.EventHandler(this.btnCourseSelection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // StudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentPage";
            this.Size = new System.Drawing.Size(808, 440);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCourseSelection;
        private System.Windows.Forms.Button btnStudentInfo;
        private System.Windows.Forms.Button btnMonthlyPayments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
