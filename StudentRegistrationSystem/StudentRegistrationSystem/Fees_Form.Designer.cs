namespace StudentRegistrationSystem
{
    partial class Fees_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_field = new System.Windows.Forms.ComboBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_month = new System.Windows.Forms.ComboBox();
            this.cmb_class = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_Student_Name = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fees_date_of_adminision = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fees_get_date = new System.Windows.Forms.Button();
            this.btn_fees_delete = new System.Windows.Forms.Button();
            this.btn_fees_update = new System.Windows.Forms.Button();
            this.btn_fees_save = new System.Windows.Forms.Button();
            this.btn_fees_new = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_field);
            this.groupBox1.Controls.Add(this.txt_amount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_month);
            this.groupBox1.Controls.Add(this.cmb_class);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmb_Student_Name);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.fees_date_of_adminision);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 411);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teacher Bio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Field:";
            // 
            // cmb_field
            // 
            this.cmb_field.FormattingEnabled = true;
            this.cmb_field.Location = new System.Drawing.Point(121, 74);
            this.cmb_field.Name = "cmb_field";
            this.cmb_field.Size = new System.Drawing.Size(197, 21);
            this.cmb_field.TabIndex = 36;
            this.cmb_field.SelectedIndexChanged += new System.EventHandler(this.cmb_field_SelectedIndexChanged);
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(123, 157);
            this.txt_amount.Multiline = true;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(195, 28);
            this.txt_amount.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "DO Admission: ";
            // 
            // cmb_month
            // 
            this.cmb_month.FormattingEnabled = true;
            this.cmb_month.Location = new System.Drawing.Point(121, 115);
            this.cmb_month.Name = "cmb_month";
            this.cmb_month.Size = new System.Drawing.Size(197, 21);
            this.cmb_month.TabIndex = 33;
            this.cmb_month.SelectedIndexChanged += new System.EventHandler(this.cmb_month_SelectedIndexChanged);
            // 
            // cmb_class
            // 
            this.cmb_class.FormattingEnabled = true;
            this.cmb_class.Location = new System.Drawing.Point(441, 74);
            this.cmb_class.Name = "cmb_class";
            this.cmb_class.Size = new System.Drawing.Size(197, 21);
            this.cmb_class.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Amount";
            // 
            // cmb_Student_Name
            // 
            this.cmb_Student_Name.FormattingEnabled = true;
            this.cmb_Student_Name.Location = new System.Drawing.Point(121, 31);
            this.cmb_Student_Name.Name = "cmb_Student_Name";
            this.cmb_Student_Name.Size = new System.Drawing.Size(197, 21);
            this.cmb_Student_Name.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Month :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Class :";
            // 
            // fees_date_of_adminision
            // 
            this.fees_date_of_adminision.CustomFormat = "MM-dd-yyyy";
            this.fees_date_of_adminision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fees_date_of_adminision.Location = new System.Drawing.Point(441, 115);
            this.fees_date_of_adminision.Name = "fees_date_of_adminision";
            this.fees_date_of_adminision.Size = new System.Drawing.Size(197, 20);
            this.fees_date_of_adminision.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name :";
            // 
            // btn_fees_get_date
            // 
            this.btn_fees_get_date.BackColor = System.Drawing.Color.Blue;
            this.btn_fees_get_date.FlatAppearance.BorderSize = 0;
            this.btn_fees_get_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fees_get_date.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fees_get_date.ForeColor = System.Drawing.Color.White;
            this.btn_fees_get_date.Location = new System.Drawing.Point(694, 300);
            this.btn_fees_get_date.Name = "btn_fees_get_date";
            this.btn_fees_get_date.Size = new System.Drawing.Size(128, 38);
            this.btn_fees_get_date.TabIndex = 40;
            this.btn_fees_get_date.Text = "Get Data";
            this.btn_fees_get_date.UseVisualStyleBackColor = false;
            this.btn_fees_get_date.Click += new System.EventHandler(this.btn_fees_get_date_Click);
            // 
            // btn_fees_delete
            // 
            this.btn_fees_delete.BackColor = System.Drawing.Color.Blue;
            this.btn_fees_delete.FlatAppearance.BorderSize = 0;
            this.btn_fees_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fees_delete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fees_delete.ForeColor = System.Drawing.Color.White;
            this.btn_fees_delete.Location = new System.Drawing.Point(694, 246);
            this.btn_fees_delete.Name = "btn_fees_delete";
            this.btn_fees_delete.Size = new System.Drawing.Size(128, 38);
            this.btn_fees_delete.TabIndex = 39;
            this.btn_fees_delete.Text = "Delete";
            this.btn_fees_delete.UseVisualStyleBackColor = false;
            this.btn_fees_delete.Click += new System.EventHandler(this.btn_fees_delete_Click);
            // 
            // btn_fees_update
            // 
            this.btn_fees_update.BackColor = System.Drawing.Color.Blue;
            this.btn_fees_update.FlatAppearance.BorderSize = 0;
            this.btn_fees_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fees_update.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fees_update.ForeColor = System.Drawing.Color.White;
            this.btn_fees_update.Location = new System.Drawing.Point(694, 192);
            this.btn_fees_update.Name = "btn_fees_update";
            this.btn_fees_update.Size = new System.Drawing.Size(128, 38);
            this.btn_fees_update.TabIndex = 38;
            this.btn_fees_update.Text = "Update";
            this.btn_fees_update.UseVisualStyleBackColor = false;
            this.btn_fees_update.Click += new System.EventHandler(this.btn_fees_update_Click);
            // 
            // btn_fees_save
            // 
            this.btn_fees_save.BackColor = System.Drawing.Color.Blue;
            this.btn_fees_save.FlatAppearance.BorderSize = 0;
            this.btn_fees_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fees_save.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fees_save.ForeColor = System.Drawing.Color.White;
            this.btn_fees_save.Location = new System.Drawing.Point(694, 141);
            this.btn_fees_save.Name = "btn_fees_save";
            this.btn_fees_save.Size = new System.Drawing.Size(128, 38);
            this.btn_fees_save.TabIndex = 37;
            this.btn_fees_save.Text = "Save ";
            this.btn_fees_save.UseVisualStyleBackColor = false;
            this.btn_fees_save.Click += new System.EventHandler(this.btn_fees_save_Click);
            // 
            // btn_fees_new
            // 
            this.btn_fees_new.BackColor = System.Drawing.Color.Blue;
            this.btn_fees_new.FlatAppearance.BorderSize = 0;
            this.btn_fees_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fees_new.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fees_new.ForeColor = System.Drawing.Color.White;
            this.btn_fees_new.Location = new System.Drawing.Point(694, 91);
            this.btn_fees_new.Name = "btn_fees_new";
            this.btn_fees_new.Size = new System.Drawing.Size(128, 38);
            this.btn_fees_new.TabIndex = 36;
            this.btn_fees_new.Text = "New";
            this.btn_fees_new.UseVisualStyleBackColor = false;
            // 
            // Fees_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 500);
            this.Controls.Add(this.btn_fees_get_date);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_fees_delete);
            this.Controls.Add(this.btn_fees_new);
            this.Controls.Add(this.btn_fees_update);
            this.Controls.Add(this.btn_fees_save);
            this.MaximizeBox = false;
            this.Name = "Fees_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fees_Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmb_month;
        public System.Windows.Forms.ComboBox cmb_class;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmb_Student_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker fees_date_of_adminision;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_amount;
        public System.Windows.Forms.Button btn_fees_get_date;
        public System.Windows.Forms.Button btn_fees_delete;
        public System.Windows.Forms.Button btn_fees_update;
        public System.Windows.Forms.Button btn_fees_save;
        public System.Windows.Forms.Button btn_fees_new;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmb_field;
    }
}