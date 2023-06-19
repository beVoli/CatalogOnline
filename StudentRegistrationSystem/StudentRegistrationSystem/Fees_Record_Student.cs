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

namespace StudentRegistrationSystem
{
    public partial class Fees_Record_Student : MaterialSkin.Controls.MaterialForm
    {
        connection con = new connection();
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        public static int Fees_IDGet;
        SqlCommand cmd;
        public Fees_Record_Student()
        {
            InitializeComponent();
        }
        private void btn_export_fees_Click(object sender, EventArgs e)
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
        private void Fees_Record_Student_Load(object sender, EventArgs e)
        {
            string nume = LoginForm.Username;
            string[] parti = nume.Split('_');
            adpt = new SqlDataAdapter("SELECT fees_Form.F_ID, studentdata.FName, field.FieldName, fees_Form.Class, StudentMonths.Months, fees_Form.DO_Adminision, fees_Form.Amount FROM fees_Form INNER JOIN studentdata ON fees_Form.Student_Name_Id = studentdata.Student_id INNER JOIN StudentMonths ON fees_Form.Month_ID = StudentMonths.Month_ID INNER JOIN field ON fees_Form.Field_ID = field.Field_id where studentdata.FName like '" + parti[0] + "'", con.opencon());
            dt = new System.Data.DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
