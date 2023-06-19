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
    public partial class Add_grade_form : MaterialSkin.Controls.MaterialForm
    {
        connection con = new connection();
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        SqlCommand cmd;
        public Add_grade_form()
        {
            InitializeComponent();
            teachernames();
        }
        public void teachernames()
        {
            if (LoginForm.Role == "teacher")
            {
                string nume = LoginForm.Username;
                string[] parti = nume.Split('_');
                adpt = new SqlDataAdapter("select * from teacherdata where TeachName like '" + parti[0] + "' and TeachLastName like '" + parti[1] + "'", con.opencon());
            }
            else
            {
                adpt = new SqlDataAdapter("select * from teacherdata", con.opencon());
            }
            dt = new System.Data.DataTable();
            adpt.Fill(dt);
            teacher_nameBox.DataSource = dt;
            teacher_nameBox.DisplayMember = "TeachLastName";
            teacher_nameBox.ValueMember = "Teach_id";
        }
        public void experbox()
        {
            adpt = new SqlDataAdapter("select * from exper", con.opencon());
            dt = new System.Data.DataTable();
            adpt.Fill(dt);
            expertiseBox.DataSource = dt;
            expertiseBox.DisplayMember = "Expertise";
            expertiseBox.ValueMember = "Ex_id";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
            
                First_Name_Box.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Last_Name_Box.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Field_Box.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                Class_Box.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            
        }
        public void searchdata(string search)
        {
            adpt = new SqlDataAdapter("SELECT studentdata.Student_id, studentdata.FName, studentdata.LName, studentdata.FatherName, studentdata.FatherID, studentdata.Email, studentdata.Mobile, studentdata.DOB, studentdata.DOR, class.ClassName, field.FieldName, studentdata.Adress, studentdata.gender, country.CountryName, province.ProvinceName, city.CityName " +
    "FROM studentdata " +
    "INNER JOIN class ON studentdata.Cls_id = class.Class_id " +
    "INNER JOIN field ON studentdata.Fld_id = field.Field_id " +
    "INNER JOIN country ON studentdata.c_id = country.country_id " +
    "INNER JOIN province ON studentdata.p_id = province.province_id " +
    "INNER JOIN city ON studentdata.ct_id = city.city_id " +
    "WHERE studentdata.FName LIKE '%' + @SearchKeyword + '%'", con.opencon());
            adpt.SelectCommand.Parameters.AddWithValue("@SearchKeyword", search);
            dt = new System.Data.DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Search_Box_TextChanged(object sender, EventArgs e)
        {
            searchdata(Search_Box.Text);
        }

        private void teacher_nameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedTeacher = (DataRowView)teacher_nameBox.SelectedItem;
            int selectedTeacherID = Convert.ToInt32(selectedTeacher["Teach_id"]);
            adpt = new SqlDataAdapter("SELECT * FROM exper INNER JOIN teacherdata ON exper.Ex_id = teacherdata.Expertise WHERE teacherdata.Teach_id = @TeacherID", con.opencon());
            adpt.SelectCommand.Parameters.AddWithValue("@TeacherID", selectedTeacherID);


            dt = new System.Data.DataTable();
            adpt.Fill(dt);
            expertiseBox.DataSource = dt;
            expertiseBox.DisplayMember = "Expertise";
            expertiseBox.ValueMember = "Ex_id";
        }
        private void btn_st_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (First_Name_Box.Text != "" && gradeBox.Text !="")
                {
                    cmd = new SqlCommand("insert into StudentGrades values('" + First_Name_Box.Text + "','" + Last_Name_Box.Text + "','" + Field_Box.Text + "','" + Class_Box.Text + "','" + teacher_nameBox.Text + "','" + expertiseBox.Text + "','" + gradeDate.Text + "','" + gradeBox.Text  + "')", con.opencon());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Data Has Been Saved in the Database ");
                }
                else
                {
                    MessageBox.Show(" Please Fill in the Blanks ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_st_new_Click(object sender, EventArgs e)
        {
            First_Name_Box.Text = "";
            Last_Name_Box.Text = "";
            Field_Box.Text = "";
            Class_Box.Text = "";
            gradeBox.Text = "";
        }
        private void btn_st_update_Click(object sender, EventArgs e)
        {
            try
            {
                double grade= Convert.ToDouble(gradeBox.Text);
                string gradedate = gradeDate.Value.ToString("MM-dd-yyyy");
                string teacher_name = teacher_nameBox.Text;
                string teacher_exper = expertiseBox.Text;

                if (First_Name_Box.Text != "" && grade != 0 && gradedate != "" && teacher_name != "" && teacher_exper != "")
                {
                    cmd = new SqlCommand("update StudentGrades set Teacher_Name='" + teacher_name + "',Expertise='" + teacher_exper + "',GradeDate='" + gradedate + "',Grade='" + grade + "' where Student_LName='" + Last_Name_Box.Text + "'", con.opencon());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Data Has Been Updated ");
                }
                else
                {
                    MessageBox.Show(" Please Fill in the Blanks");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void btn_st_delete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("delete from StudentGrades where Student_LName='" + Last_Name_Box.Text + "'", con.opencon());
                cmd.ExecuteNonQuery();
                MessageBox.Show(" The Data Has Been Deleted ");
            }
            catch (Exception)
            {

            }
        }

        private void btn_st_get_date_Click(object sender, EventArgs e)
        {
            GradesDataShow obj= new GradesDataShow();
            obj.Show();
        }
    }
}
