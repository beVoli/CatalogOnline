namespace StudentRegistrationSystem
{
    partial class GradesDataShow
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
            this.Search_Box = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_export_student = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(799, 337);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Search_Box
            // 
            this.Search_Box.Location = new System.Drawing.Point(129, 88);
            this.Search_Box.Name = "Search_Box";
            this.Search_Box.Size = new System.Drawing.Size(193, 20);
            this.Search_Box.TabIndex = 23;
            this.Search_Box.TextChanged += new System.EventHandler(this.Search_Box_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Search by First Name:";
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
            this.btn_export_student.TabIndex = 39;
            this.btn_export_student.Text = "Export in Excel";
            this.btn_export_student.UseVisualStyleBackColor = false;
            this.btn_export_student.Click += new System.EventHandler(this.btn_export_student_Click);
            // 
            // GradesDataShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_export_student);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Search_Box);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "GradesDataShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GradesDataShow";
            this.Load += new System.EventHandler(this.st_data_display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Search_Box;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btn_export_student;
    }
}