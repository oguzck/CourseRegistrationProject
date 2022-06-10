
namespace CourseRegistrationProject
{
    partial class InstructorInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorInfo));
            this.cbCourses = new System.Windows.Forms.ComboBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.CurrentTerm = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCourses
            // 
            this.cbCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCourses.FormattingEnabled = true;
            this.cbCourses.Location = new System.Drawing.Point(135, 269);
            this.cbCourses.Name = "cbCourses";
            this.cbCourses.Size = new System.Drawing.Size(121, 28);
            this.cbCourses.TabIndex = 27;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTerm.Location = new System.Drawing.Point(409, 201);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(51, 20);
            this.lblTerm.TabIndex = 26;
            this.lblTerm.Text = "label7";
            // 
            // CurrentTerm
            // 
            this.CurrentTerm.AutoSize = true;
            this.CurrentTerm.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentTerm.Location = new System.Drawing.Point(281, 196);
            this.CurrentTerm.Name = "CurrentTerm";
            this.CurrentTerm.Size = new System.Drawing.Size(117, 25);
            this.CurrentTerm.TabIndex = 25;
            this.CurrentTerm.Text = "Current Term : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(269, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Instructor Information";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAge.Location = new System.Drawing.Point(395, 134);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(51, 20);
            this.lblAge.TabIndex = 22;
            this.lblAge.Text = "label6";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.Location = new System.Drawing.Point(152, 201);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(51, 20);
            this.lblSurname.TabIndex = 21;
            this.lblSurname.Text = "label6";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(152, 134);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(52, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Courses :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(281, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Age : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(534, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // InstructorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.cbCourses);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.CurrentTerm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InstructorInfo";
            this.Size = new System.Drawing.Size(718, 468);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCourses;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label CurrentTerm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
