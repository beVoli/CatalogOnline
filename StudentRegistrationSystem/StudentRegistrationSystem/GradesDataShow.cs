using Microsoft.Office.Interop.Excel;
using System;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace StudentRegistrationSystem
{
    
    public partial class GradesDataShow : MaterialSkin.Controls.MaterialForm
    {
        connection con = new connection();
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        SqlCommand cmd;
        public GradesDataShow()
        {
            InitializeComponent();
        }
        private void st_data_display_Load(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("select * from StudentGrades", con.opencon());
            dt = new System.Data.DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Add_grade_form obj= new Add_grade_form();
                obj.First_Name_Box.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                obj.Last_Name_Box.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                obj.Field_Box.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                obj.Class_Box.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                obj.teacher_nameBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                obj.expertiseBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                string dateValue = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                DateTime.TryParseExact(dateValue, "MM-dd-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);
                obj.gradeDate.Value = date;
                obj.gradeBox.Text= dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                obj.Show();
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        public void searchdata(string search)
        {
            adpt = new SqlDataAdapter("select * from StudentGrades where Student_FName like '%" + search + "%'", con.opencon());
            adpt.SelectCommand.Parameters.AddWithValue("@SearchKeyword", search);
            dt = new System.Data.DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Search_Box_TextChanged(object sender, EventArgs e)
        {
            searchdata(Search_Box.Text);
        }
        private void btn_export_student_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)Excel.ActiveSheet;
                Excel.Visible = true;

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    ws.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }

            }
            catch (Exception)
            {


            }
        }
    }
}
