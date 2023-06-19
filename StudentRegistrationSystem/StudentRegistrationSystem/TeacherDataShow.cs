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



namespace StudentRegistrationSystem
{
    public partial class TeacherDataShow : MaterialSkin.Controls.MaterialForm
    {
        connection con = new connection();
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        public static int teach_id;
        SqlCommand cmd;

        public TeacherDataShow()
        {
            InitializeComponent();
        }

        private void TeacherDataShow_Load(object sender, EventArgs e)
        {
            try
            {
                adpt = new SqlDataAdapter("SELECT * FROM teacherdata", con.opencon());
                //adpt = new SqlDataAdapter("SELECT teacherdata.Teach_id, teacherdata.TeachName, teacherdata.TeachLastName, teacherdata.TeachFaterhName, teacherdata.TeachID, teacherdata.TeachEmail, teacherdata.TeachMobile, teacherdata.teachDOB, exper.Expertise, teacherdata.TeachAdd, teacherdata.TeachGender, country.CountryName, province.ProvinceName, city.CityName FROM teacherdata INNER JOIN exper ON exper.Ex_id = teacherdata.Expertise INNER JOIN country ON country.country_id = teacherdata.Teachc_id INNER JOIN province ON province.province_id = teacherdata.Teachp_id INNER JOIN city ON city.city_id = teacherdata.Teachct_id", con.opencon());
                dt = new System.Data.DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {


            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        private void dataGridView1_CellDoubleClick_2(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Teacher_Form obj = new Teacher_Form();
                teach_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                obj.txt_teach_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                obj.txt_teach_lname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                obj.txt_teach_father_name.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                obj.txt_teach_id.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                obj.txt_teach_email.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                obj.txt_teach_mobile.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                obj.teach_date_of_birth.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                obj.cmb_teach_exp.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                obj.txt_teach_address.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

                obj.rbtn_male_teach.Checked = true;
                obj.rbtn_female_teach.Checked = false;

                if (dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString() == "Female")
                {
                    obj.rbtn_male_teach.Checked = false;
                    obj.rbtn_female_teach.Checked = true;
                }

                obj.cmb_country_teach.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                obj.cmb_province_tech.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                obj.cmb_city_teach.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();

                obj.Show();
                obj.btn_st_delete_teach.Enabled = true;
                obj.btn_st_update_teach.Enabled = true;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        public void searchrecord(string search)
        {
            string query = "select * from teacherdata where TeachName like '%" + search + "%'";
            cmd = new SqlCommand(query, con.opencon());
            adpt = new SqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchrecord(textBox1.Text);
        }

        private void btn_export_Click(object sender, EventArgs e)
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
