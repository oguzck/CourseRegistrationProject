
namespace CourseRegistrationProject
{
    partial class InstructorPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInstInfo = new System.Windows.Forms.Button();
            this.btnCourseSelection = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 455);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(439, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(266, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnInstInfo);
            this.panel2.Controls.Add(this.btnCourseSelection);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 67);
            this.panel2.TabIndex = 1;
            // 
            // btnInstInfo
            // 
            this.btnInstInfo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInstInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInstInfo.Location = new System.Drawing.Point(497, 22);
            this.btnInstInfo.Name = "btnInstInfo";
            this.btnInstInfo.Size = new System.Drawing.Size(183, 23);
            this.btnInstInfo.TabIndex = 5;
            this.btnInstInfo.Text = "Instructor Info";
            this.btnInstInfo.UseVisualStyleBackColor = false;
            this.btnInstInfo.Click += new System.EventHandler(this.btnInstInfo_Click);
            // 
            // btnCourseSelection
            // 
            this.btnCourseSelection.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCourseSelection.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCourseSelection.Location = new System.Drawing.Point(79, 22);
            this.btnCourseSelection.Name = "btnCourseSelection";
            this.btnCourseSelection.Size = new System.Drawing.Size(183, 23);
            this.btnCourseSelection.TabIndex = 3;
            this.btnCourseSelection.Text = "Course Selection";
            this.btnCourseSelection.UseVisualStyleBackColor = false;
            this.btnCourseSelection.Click += new System.EventHandler(this.btnCourseSelection_Click);
            // 
            // InstructorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InstructorPage";
            this.Size = new System.Drawing.Size(802, 455);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInstInfo;
        private System.Windows.Forms.Button btnCourseSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
