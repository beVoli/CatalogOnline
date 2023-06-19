namespace StudentRegistrationSystem
{
    partial class Grades
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
            this.btn_add_grade = new System.Windows.Forms.Button();
            this.btn_student_view = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add_grade
            // 
            this.btn_add_grade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_add_grade.FlatAppearance.BorderSize = 0;
            this.btn_add_grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_grade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_grade.ForeColor = System.Drawing.Color.White;
            this.btn_add_grade.Location = new System.Drawing.Point(110, 75);
            this.btn_add_grade.Name = "btn_add_grade";
            this.btn_add_grade.Size = new System.Drawing.Size(128, 38);
            this.btn_add_grade.TabIndex = 2;
            this.btn_add_grade.Text = "Add grade";
            this.btn_add_grade.UseVisualStyleBackColor = false;
            this.btn_add_grade.Click += new System.EventHandler(this.btn_add_grade_Click);
            // 
            // btn_student_view
            // 
            this.btn_student_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_student_view.FlatAppearance.BorderSize = 0;
            this.btn_student_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_student_view.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student_view.ForeColor = System.Drawing.Color.White;
            this.btn_student_view.Location = new System.Drawing.Point(110, 138);
            this.btn_student_view.Name = "btn_student_view";
            this.btn_student_view.Size = new System.Drawing.Size(128, 60);
            this.btn_student_view.TabIndex = 3;
            this.btn_student_view.Text = "View grades (student only)";
            this.btn_student_view.UseVisualStyleBackColor = false;
            this.btn_student_view.Click += new System.EventHandler(this.btn_student_view_Click);
            // 
            // Grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 240);
            this.Controls.Add(this.btn_student_view);
            this.Controls.Add(this.btn_add_grade);
            this.MaximizeBox = false;
            this.Name = "Grades";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "grades";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_add_grade;
        public System.Windows.Forms.Button btn_student_view;
    }
}