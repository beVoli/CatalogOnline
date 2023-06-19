using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Globalization;

namespace StudentRegistrationSystem
{
    public partial class Fees_Form_Data_Show : MaterialSkin.Controls.MaterialForm
    {
        connection con = new connection();
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        public static int Fees_IDGet;
        SqlCommand cmd;

        public Fees_Form_Data_Show()
        {
            InitializeComponent();
            displayrecord();
        }

        public void displayrecord()
        {
            adpt = new SqlDataAdapter("SELECT fees_Form.F_ID, studentdata.FName, field.FieldName, fees_Form.Class, StudentMonths.Months, fees_Form.DO_Adminision, fees_Form.Amount FROM fees_Form INNER JOIN studentdata ON fees_Form.Student_Name_Id = studentdata.Student_id INNER JOIN StudentMonths ON fees_Form.Month_ID = StudentMonths.Month_ID INNER JOIN field ON fees_Form.Field_ID = field.Field_id", con.opencon());
            dt = new System.Data.DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Fees_Form obj = new Fees_Form();
            Fees_IDGet = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            obj.cmb_Student_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            obj.cmb_field.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            obj.cmb_class.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            obj.cmb_month.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
           
            string dateValue = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            DateTime.TryParseExact(dateValue, "MM-dd-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);
            obj.fees_date_of_adminision.Value = date;
            obj.txt_amount.Text= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            obj.Show();
            obj.btn_fees_delete.Enabled = true;
            obj.btn_fees_update.Enabled = true;
        }

    
        private void txtSearchBox_TextChanged_1(object sender, EventArgs e)
        {
            Search(txtSearchBox.Text);
        }

        public void Search(string searchrecord)
        {
            string query = "select fees_Form.F_ID,studentdata.FName, studentclass.Class_Name,StudentMonths.Months, fees_Form.DO_Adminision,fees_Form.Amount from fees_Form inner join studentdata on fees_Form.Student_Name_Id=studentdata.Student_id inner join studentclass on fees_Form.Class_St_ID=studentclass.Class_id inner join StudentMonths on fees_Form.Month_ID=StudentMonths.Month_ID where FName like '%" + searchrecord + "%'";
            cmd = new SqlCommand(query, con.opencon());
            adpt = new SqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
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
    }
}
