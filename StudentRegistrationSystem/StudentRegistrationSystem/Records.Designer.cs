namespace StudentRegistrationSystem
{
    partial class Records
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
            this.btn_Student_Record = new System.Windows.Forms.Button();
            this.btn_teacher_record = new System.Windows.Forms.Button();
            this.btn_Fees_record = new System.Windows.Forms.Button();
            this.btn_fees_record_student = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Student_Record
            // 
            this.btn_Student_Record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_Student_Record.FlatAppearance.BorderSize = 0;
            this.btn_Student_Record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Student_Record.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student_Record.ForeColor = System.Drawing.Color.White;
            this.btn_Student_Record.Location = new System.Drawing.Point(86, 70);
            this.btn_Student_Record.Name = "btn_Student_Record";
            this.btn_Student_Record.Size = new System.Drawing.Size(128, 38);
            this.btn_Student_Record.TabIndex = 1;
            this.btn_Student_Record.Text = "Student Record";
            this.btn_Student_Record.UseVisualStyleBackColor = false;
            this.btn_Student_Record.Click += new System.EventHandler(this.btn_Student_Record_Click);
            // 
            // btn_teacher_record
            // 
            this.btn_teacher_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_teacher_record.FlatAppearance.BorderSize = 0;
            this.btn_teacher_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teacher_record.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher_record.ForeColor = System.Drawing.Color.White;
            this.btn_teacher_record.Location = new System.Drawing.Point(86, 114);
            this.btn_teacher_record.Name = "btn_teacher_record";
            this.btn_teacher_record.Size = new System.Drawing.Size(128, 38);
            this.btn_teacher_record.TabIndex = 2;
            this.btn_teacher_record.Text = "Teacher Record";
            this.btn_teacher_record.UseVisualStyleBackColor = false;
            this.btn_teacher_record.Click += new System.EventHandler(this.btn_teacher_record_Click);
            // 
            // btn_Fees_record
            // 
            this.btn_Fees_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_Fees_record.FlatAppearance.BorderSize = 0;
            this.btn_Fees_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fees_record.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fees_record.ForeColor = System.Drawing.Color.White;
            this.btn_Fees_record.Location = new System.Drawing.Point(86, 158);
            this.btn_Fees_record.Name = "btn_Fees_record";
            this.btn_Fees_record.Size = new System.Drawing.Size(128, 38);
            this.btn_Fees_record.TabIndex = 3;
            this.btn_Fees_record.Text = "Fees Record";
            this.btn_Fees_record.UseVisualStyleBackColor = false;
            this.btn_Fees_record.Click += new System.EventHandler(this.btn_Fees_record_Click);
            // 
            // btn_fees_record_student
            // 
            this.btn_fees_record_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_fees_record_student.FlatAppearance.BorderSize = 0;
            this.btn_fees_record_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fees_record_student.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fees_record_student.ForeColor = System.Drawing.Color.White;
            this.btn_fees_record_student.Location = new System.Drawing.Point(86, 202);
            this.btn_fees_record_student.Name = "btn_fees_record_student";
            this.btn_fees_record_student.Size = new System.Drawing.Size(128, 47);
            this.btn_fees_record_student.TabIndex = 4;
            this.btn_fees_record_student.Text = "Fees Record (Student only)";
            this.btn_fees_record_student.UseVisualStyleBackColor = false;
            this.btn_fees_record_student.Click += new System.EventHandler(this.btn_fees_record_student_Click);
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 261);
            this.Controls.Add(this.btn_fees_record_student);
            this.Controls.Add(this.btn_Fees_record);
            this.Controls.Add(this.btn_teacher_record);
            this.Controls.Add(this.btn_Student_Record);
            this.MaximizeBox = false;
            this.Name = "Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_Student_Record;
        public System.Windows.Forms.Button btn_teacher_record;
        public System.Windows.Forms.Button btn_Fees_record;
        public System.Windows.Forms.Button btn_fees_record_student;
    }
}