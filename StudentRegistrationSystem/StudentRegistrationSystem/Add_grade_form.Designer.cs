namespace StudentRegistrationSystem
{
    partial class Add_grade_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.First_Name_Box = new System.Windows.Forms.TextBox();
            this.Last_Name_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Field_Box = new System.Windows.Forms.TextBox();
            this.Class_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gradeBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Search_Box = new System.Windows.Forms.TextBox();
            this.teacher_nameBox = new System.Windows.Forms.ComboBox();
            this.expertiseBox = new System.Windows.Forms.ComboBox();
            this.btn_st_new = new System.Windows.Forms.Button();
            this.btn_st_save = new System.Windows.Forms.Button();
            this.btn_st_update = new System.Windows.Forms.Button();
            this.btn_st_delete = new System.Windows.Forms.Button();
            this.gradeDate = new System.Windows.Forms.DateTimePicker();
            this.btn_st_get_date = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(799, 144);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Double click on the student you want to add the grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // First_Name_Box
            // 
            this.First_Name_Box.Location = new System.Drawing.Point(87, 277);
            this.First_Name_Box.Name = "First_Name_Box";
            this.First_Name_Box.ReadOnly = true;
            this.First_Name_Box.Size = new System.Drawing.Size(151, 20);
            this.First_Name_Box.TabIndex = 5;
            // 
            // Last_Name_Box
            // 
            this.Last_Name_Box.Location = new System.Drawing.Point(87, 308);
            this.Last_Name_Box.Name = "Last_Name_Box";
            this.Last_Name_Box.ReadOnly = true;
            this.Last_Name_Box.Size = new System.Drawing.Size(151, 20);
            this.Last_Name_Box.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Field:";
            // 
            // Field_Box
            // 
            this.Field_Box.Location = new System.Drawing.Point(87, 345);
            this.Field_Box.Name = "Field_Box";
            this.Field_Box.ReadOnly = true;
            this.Field_Box.Size = new System.Drawing.Size(151, 20);
            this.Field_Box.TabIndex = 8;
            // 
            // Class_Box
            // 
            this.Class_Box.Location = new System.Drawing.Point(87, 385);
            this.Class_Box.Name = "Class_Box";
            this.Class_Box.ReadOnly = true;
            this.Class_Box.Size = new System.Drawing.Size(151, 20);
            this.Class_Box.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Class:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "SELECTED STUDENT DETAILS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "TEACHER DETAILS:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Expertise:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(566, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Enter the grade you want to add:";
            // 
            // gradeBox
            // 
            this.gradeBox.Location = new System.Drawing.Point(569, 278);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(159, 20);
            this.gradeBox.TabIndex = 20;
            this.gradeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(490, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Search by First Name:";
            // 
            // Search_Box
            // 
            this.Search_Box.Location = new System.Drawing.Point(607, 64);
            this.Search_Box.Name = "Search_Box";
            this.Search_Box.Size = new System.Drawing.Size(193, 20);
            this.Search_Box.TabIndex = 22;
            this.Search_Box.TextChanged += new System.EventHandler(this.Search_Box_TextChanged);
            // 
            // teacher_nameBox
            // 
            this.teacher_nameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacher_nameBox.FormattingEnabled = true;
            this.teacher_nameBox.Location = new System.Drawing.Point(368, 277);
            this.teacher_nameBox.Name = "teacher_nameBox";
            this.teacher_nameBox.Size = new System.Drawing.Size(151, 21);
            this.teacher_nameBox.TabIndex = 23;
            this.teacher_nameBox.SelectedIndexChanged += new System.EventHandler(this.teacher_nameBox_SelectedIndexChanged);
            // 
            // expertiseBox
            // 
            this.expertiseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expertiseBox.FormattingEnabled = true;
            this.expertiseBox.Location = new System.Drawing.Point(369, 311);
            this.expertiseBox.Name = "expertiseBox";
            this.expertiseBox.Size = new System.Drawing.Size(150, 21);
            this.expertiseBox.TabIndex = 24;
            // 
            // btn_st_new
            // 
            this.btn_st_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_st_new.FlatAppearance.BorderSize = 0;
            this.btn_st_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_st_new.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_st_new.ForeColor = System.Drawing.Color.White;
            this.btn_st_new.Location = new System.Drawing.Point(263, 388);
            this.btn_st_new.Name = "btn_st_new";
            this.btn_st_new.Size = new System.Drawing.Size(128, 38);
            this.btn_st_new.TabIndex = 25;
            this.btn_st_new.Text = "New";
            this.btn_st_new.UseVisualStyleBackColor = false;
            this.btn_st_new.Click += new System.EventHandler(this.btn_st_new_Click);
            // 
            // btn_st_save
            // 
            this.btn_st_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_st_save.FlatAppearance.BorderSize = 0;
            this.btn_st_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_st_save.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_st_save.ForeColor = System.Drawing.Color.White;
            this.btn_st_save.Location = new System.Drawing.Point(665, 341);
            this.btn_st_save.Name = "btn_st_save";
            this.btn_st_save.Size = new System.Drawing.Size(128, 38);
            this.btn_st_save.TabIndex = 26;
            this.btn_st_save.Text = "Save ";
            this.btn_st_save.UseVisualStyleBackColor = false;
            this.btn_st_save.Click += new System.EventHandler(this.btn_st_save_Click);
            // 
            // btn_st_update
            // 
            this.btn_st_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_st_update.FlatAppearance.BorderSize = 0;
            this.btn_st_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_st_update.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_st_update.ForeColor = System.Drawing.Color.White;
            this.btn_st_update.Location = new System.Drawing.Point(665, 388);
            this.btn_st_update.Name = "btn_st_update";
            this.btn_st_update.Size = new System.Drawing.Size(128, 38);
            this.btn_st_update.TabIndex = 27;
            this.btn_st_update.Text = "Update";
            this.btn_st_update.UseVisualStyleBackColor = false;
            this.btn_st_update.Click += new System.EventHandler(this.btn_st_update_Click);
            // 
            // btn_st_delete
            // 
            this.btn_st_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_st_delete.FlatAppearance.BorderSize = 0;
            this.btn_st_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_st_delete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_st_delete.ForeColor = System.Drawing.Color.White;
            this.btn_st_delete.Location = new System.Drawing.Point(397, 388);
            this.btn_st_delete.Name = "btn_st_delete";
            this.btn_st_delete.Size = new System.Drawing.Size(128, 38);
            this.btn_st_delete.TabIndex = 28;
            this.btn_st_delete.Text = "Delete";
            this.btn_st_delete.UseVisualStyleBackColor = false;
            this.btn_st_delete.Click += new System.EventHandler(this.btn_st_delete_Click);
            // 
            // gradeDate
            // 
            this.gradeDate.CustomFormat = "MM-dd-yyyy";
            this.gradeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gradeDate.Location = new System.Drawing.Point(569, 315);
            this.gradeDate.Name = "gradeDate";
            this.gradeDate.Size = new System.Drawing.Size(174, 20);
            this.gradeDate.TabIndex = 29;
            // 
            // btn_st_get_date
            // 
            this.btn_st_get_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_st_get_date.FlatAppearance.BorderSize = 0;
            this.btn_st_get_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_st_get_date.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_st_get_date.ForeColor = System.Drawing.Color.White;
            this.btn_st_get_date.Location = new System.Drawing.Point(531, 388);
            this.btn_st_get_date.Name = "btn_st_get_date";
            this.btn_st_get_date.Size = new System.Drawing.Size(128, 38);
            this.btn_st_get_date.TabIndex = 30;
            this.btn_st_get_date.Text = "Get Data";
            this.btn_st_get_date.UseVisualStyleBackColor = false;
            this.btn_st_get_date.Click += new System.EventHandler(this.btn_st_get_date_Click);
            // 
            // Add_grade_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_st_get_date);
            this.Controls.Add(this.gradeDate);
            this.Controls.Add(this.btn_st_delete);
            this.Controls.Add(this.btn_st_update);
            this.Controls.Add(this.btn_st_save);
            this.Controls.Add(this.btn_st_new);
            this.Controls.Add(this.expertiseBox);
            this.Controls.Add(this.teacher_nameBox);
            this.Controls.Add(this.Search_Box);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gradeBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Class_Box);
            this.Controls.Add(this.Field_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Last_Name_Box);
            this.Controls.Add(this.First_Name_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Add_grade_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_grade_form";
            this.Load += new System.EventHandler(this.st_data_display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox First_Name_Box;
        public System.Windows.Forms.TextBox Last_Name_Box;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Field_Box;
        public System.Windows.Forms.TextBox Class_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox gradeBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Search_Box;
        public System.Windows.Forms.ComboBox teacher_nameBox;
        public System.Windows.Forms.ComboBox expertiseBox;
        public System.Windows.Forms.Button btn_st_new;
        public System.Windows.Forms.Button btn_st_save;
        public System.Windows.Forms.Button btn_st_update;
        public System.Windows.Forms.Button btn_st_delete;
        public System.Windows.Forms.DateTimePicker gradeDate;
        public System.Windows.Forms.Button btn_st_get_date;
    }
}