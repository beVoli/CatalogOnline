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
using Microsoft.Office.Interop.Excel;
using System.Globalization;

namespace StudentRegistrationSystem
{
    public partial class st_data_display : MaterialSkin.Controls.MaterialForm
    {
        connection con = new connection();
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        SqlCommand cmd;
        public static int St_id;

        public st_data_display()
        {
            InitializeComponent();
        }

        private void st_data_display_Load(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("select studentdata.Student_id, studentdata.FName, studentdata.LName, studentdata.FatherName, studentdata.FatherID, studentdata.Email,studentdata.Mobile,studentdata.DOB,studentdata.DOR, class.ClassName, field.FieldName, studentdata.Adress, studentdata.gender, country.CountryName, province.ProvinceName, city.CityName " +
                "from studentdata " +
                "inner join class on studentdata.Cls_id=class.Class_id " +
                "inner join field on studentdata.Fld_id=field.Field_id " +
                "inner join country on studentdata.c_id=country.country_id " +
                "inner join province on studentdata.p_id=province.province_id " +
                "inner join city on studentdata.ct_id=city.city_id", con.opencon());
            dt = new System.Data.DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            st_registration_form obj = new st_registration_form();
            St_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            obj.txt_st_name.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            obj.txt_st_lname.Text= (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            obj.txt_st_father_name.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            obj.txt_father_id.Text = (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            obj.txt_st_email.Text = (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            obj.txt_st_mobile.Text = (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            obj.date_of_birth.Text = (dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
            string dateValue = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            DateTime.TryParseExact(dateValue, "MM-dd-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);
            obj.date_of_registration.Value = date;
            obj.cmb_st_class.Text = (dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString());
            obj.cmb_st_field.Text = (dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString());
            obj.txt_st_address.Text = (dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString());

            obj.rbtn_male.Checked = true;
            obj.rbtn_female.Checked = false;

            if (dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString() == "Female")
            {
                obj.rbtn_male.Checked = false;
                obj.rbtn_female.Checked = true;
            }

            obj.cmb_country.Text = (dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString());
            obj.cmb_province.Text = (dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString());
            obj.cmb_city.Text = (dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString());

            obj.Show();
            obj.btn_st_delete.Enabled = true;
            obj.btn_st_update.Enabled = true;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            searchdata(txt_search.Text);
        }

        public void searchdata(string search)
        {
            string query = "select * from studentdata where FName like '%" + search + "%'";
            cmd = new SqlCommand(query, con.opencon());
            adpt = new SqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            
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
