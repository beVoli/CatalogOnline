namespace StudentRegistrationSystem
{
    partial class View_Grades_Student
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_export_student = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(799, 337);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_export_student
            // 
            this.btn_export_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_export_student.FlatAppearance.BorderSize = 0;
            this.btn_export_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export_student.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export_student.ForeColor = System.Drawing.Color.White;
            this.btn_export_student.Location = new System.Drawing.Point(660, 70);
            this.btn_export_student.Name = "btn_export_student";
            this.btn_export_student.Size = new System.Drawing.Size(128, 38);
            this.btn_export_student.TabIndex = 40;
            this.btn_export_student.Text = "Export in Excel";
            this.btn_export_student.UseVisualStyleBackColor = false;
            this.btn_export_student.Click += new System.EventHandler(this.btn_export_student_Click);
            // 
            // View_Grades_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_export_student);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "View_Grades_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Grades_Student";
            this.Load += new System.EventHandler(this.st_data_display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btn_export_student;
    }
}