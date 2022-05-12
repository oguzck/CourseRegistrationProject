
namespace CourseRegistrationProject
{
    partial class InstructorCoursesReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InstructorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstructorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GivenCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InstructorID,
            this.InstructorName,
            this.GivenCourse});
            this.dataGridView1.Location = new System.Drawing.Point(186, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(403, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // InstructorID
            // 
            this.InstructorID.HeaderText = "Instructor ID ";
            this.InstructorID.Name = "InstructorID";
            this.InstructorID.Width = 120;
            // 
            // InstructorName
            // 
            this.InstructorName.HeaderText = "Instructor Name";
            this.InstructorName.Name = "InstructorName";
            this.InstructorName.Width = 120;
            // 
            // GivenCourse
            // 
            this.GivenCourse.HeaderText = "Given Course";
            this.GivenCourse.Name = "GivenCourse";
            this.GivenCourse.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // InstructorCoursesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InstructorCoursesReport";
            this.Size = new System.Drawing.Size(775, 428);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstructorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstructorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GivenCourse;
        private System.Windows.Forms.Label label1;
    }
}
