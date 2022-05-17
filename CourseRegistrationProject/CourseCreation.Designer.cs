
namespace CourseRegistrationProject
{
    partial class CourseCreation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(241, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(241, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(241, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Semester : ";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(374, 145);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(161, 23);
            this.txtCourseName.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(374, 206);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(161, 23);
            this.txtPrice.TabIndex = 2;
            // 
            // cbSemester
            // 
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Items.AddRange(new object[] {
            "Spring",
            "Fall"});
            this.cbSemester.Location = new System.Drawing.Point(374, 274);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(161, 23);
            this.cbSemester.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(348, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Course Creation";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(374, 346);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // CourseCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSemester);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseCreation";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreate;
    }
}