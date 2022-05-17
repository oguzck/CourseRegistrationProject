
namespace CourseRegistrationProject
{
    partial class MontlyPayments
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
            this.Month1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Month1,
            this.Month2,
            this.Month3,
            this.Year,
            this.Term});
            this.dataGridView1.Location = new System.Drawing.Point(104, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(543, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // Month1
            // 
            this.Month1.HeaderText = "Month1";
            this.Month1.Name = "Month1";
            this.Month1.ReadOnly = true;
            // 
            // Month2
            // 
            this.Month2.HeaderText = "Month2";
            this.Month2.Name = "Month2";
            this.Month2.ReadOnly = true;
            // 
            // Month3
            // 
            this.Month3.HeaderText = "Month3";
            this.Month3.Name = "Month3";
            this.Month3.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Term
            // 
            this.Term.HeaderText = "Term";
            this.Term.Name = "Term";
            this.Term.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(303, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monthly Payments";
            // 
            // MontlyPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MontlyPayments";
            this.Size = new System.Drawing.Size(750, 436);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term;
        private System.Windows.Forms.Label label1;
    }
}
