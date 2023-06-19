namespace StudentRegistrationSystem
{
    partial class Fees_Record_Student
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
            this.btn_export_fees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 319);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_export_fees
            // 
            this.btn_export_fees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_export_fees.FlatAppearance.BorderSize = 0;
            this.btn_export_fees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export_fees.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export_fees.ForeColor = System.Drawing.Color.White;
            this.btn_export_fees.Location = new System.Drawing.Point(660, 85);
            this.btn_export_fees.Name = "btn_export_fees";
            this.btn_export_fees.Size = new System.Drawing.Size(128, 38);
            this.btn_export_fees.TabIndex = 39;
            this.btn_export_fees.Text = "Export in Excel";
            this.btn_export_fees.UseVisualStyleBackColor = false;
            this.btn_export_fees.Click += new System.EventHandler(this.btn_export_fees_Click);
            // 
            // Fees_Record_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_export_fees);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Fees_Record_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fees_Record_Student";
            this.Load += new System.EventHandler(this.Fees_Record_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btn_export_fees;
    }
}