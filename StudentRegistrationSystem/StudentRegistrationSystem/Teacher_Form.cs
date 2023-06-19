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

namespace StudentRegistrationSystem
{
    public partial class Teacher_Form : MaterialSkin.Controls.MaterialForm
    {
        connection con = new connection();
        SqlDataAdapter adtp;
        DataTable dt;
        SqlCommand cmd;

        public Teacher_Form()
        {
            InitializeComponent();
            countrydata();
            expertisedata();
            btn_st_delete_teach.Enabled = false;
            btn_st_update_teach.Enabled = false;
        }

        public void countrydata()
        {
            adtp = new SqlDataAdapter("select * from country", con.opencon());
            dt = new DataTable();
            adtp.Fill(dt);
            cmb_country_teach.DataSource = dt;
            cmb_country_teach.DisplayMember = "CountryName";
            cmb_country_teach.ValueMember = "country_id";
        }

      

        private void cmb_country_teach_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int count = Convert.ToInt32(cmb_country_teach.SelectedValue.ToString());
                adtp = new SqlDataAdapter("select * from province where count_id='" + count + "'", con.opencon());
                dt = new DataTable();
                adtp.Fill(dt);
                cmb_province_tech.DataSource = dt;
                cmb_province_tech.DisplayMember = "ProvinceName";
                cmb_province_tech.ValueMember = "province_id";
            }
            catch (Exception)
            {

            }
         
           
        }

        private void cmb_province_tech_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int pro = Convert.ToInt32(cmb_province_tech.SelectedValue.ToString());
                adtp = new SqlDataAdapter("select * from city where Prov_id='" + pro + "'", con.opencon());
                dt = new DataTable();
                adtp.Fill(dt);
                cmb_city_teach.DataSource = dt;
                cmb_city_teach.DisplayMember = "CityName";
                cmb_city_teach.ValueMember = "city_id";
            }
            catch (Exception)
            {

       
            }
        }

        public void expertisedata()
        {
            adtp = new SqlDataAdapter("select * from exper", con.opencon());
            dt = new DataTable();
            adtp.Fill(dt);
            cmb_teach_exp.DataSource = dt;
            cmb_teach_exp.DisplayMember = "Expertise";
            cmb_teach_exp.ValueMember = "Ex_id";
        }

        private void btn_st_save_teach_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = "Female";
                if (rbtn_male_teach.Checked)
                {
                    gender = "Male";
                }

                int coun = Convert.ToInt32(cmb_country_teach.SelectedValue.ToString());
                int prov = Convert.ToInt32(cmb_province_tech.SelectedValue.ToString());
                int city = Convert.ToInt32(cmb_city_teach.SelectedValue.ToString());
                int exper = Convert.ToInt32(cmb_teach_exp.SelectedValue.ToString());

                if (txt_teach_name.Text != "" && txt_teach_lname.Text != "" && txt_teach_father_name.Text != "" && txt_teach_id.Text != "" && txt_teach_email.Text != "" && txt_teach_mobile.Text != "" && cmb_teach_exp.Text != "" && txt_teach_address.Text != "" && cmb_country_teach.Text != "" && cmb_province_tech.Text != "" && cmb_city_teach.Text != "")
                {
                    cmd = new SqlCommand("insert into teacherdata values ('"+ txt_teach_name.Text + "', '"+txt_teach_lname.Text+"','"+txt_teach_father_name.Text+"','"+txt_teach_id.Text+"','"+txt_teach_email.Text+"', '"+txt_teach_mobile.Text+"','"+ teach_date_of_birth .Text+ "','"+ exper + "', '" + txt_teach_address.Text + "','" + gender + "','" + coun + "','" + prov + "', '"+ city + "')", con.opencon());
                    cmd.ExecuteNonQuery();
                    string parola_basic = "1234";
                    string teacher = "teacher";
                    string username = txt_teach_name.Text.Trim() + "_" + txt_teach_lname.Text.Trim();
                    cmd = new SqlCommand("insert into Registration values('" + username + "','" + parola_basic + "','" + teacher + "')", con.opencon());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Data Has Been Saved in the Database ");
                }
                else
                {
                    MessageBox.Show("Not WOrking");
                }
            }
            catch (Exception)
            {
                
      
            }
        }

        private void btn_st_new_teach_Click(object sender, EventArgs e)
        {
            txt_teach_name.Text = "";
            txt_teach_lname.Text = "";
            txt_teach_father_name.Text = "";
            txt_teach_id.Text = "";
            txt_teach_email.Text = "";
            txt_teach_mobile.Text = "";
            txt_teach_address.Text = "";
            cmb_city_teach.Text = "";
            cmb_country_teach.Text = "";
            cmb_teach_exp.Text = "";
            cmb_province_tech.Text = "";
        }

        private void btn_st_get_date_teach_Click(object sender, EventArgs e)
        {
            TeacherDataShow obj = new TeacherDataShow();
            obj.Show();
            this.Hide();
        }

        private void btn_st_update_teach_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = "";
                if (rbtn_male_teach.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                string DOB = teach_date_of_birth.Value.ToString("MM-dd-yyyy");
                int count_id = Convert.ToInt32(cmb_country_teach.SelectedValue);
                int prov_id = Convert.ToInt32(cmb_province_tech.SelectedValue);
                int city_id = Convert.ToInt32(cmb_city_teach.SelectedValue);
                int expert_id = Convert.ToInt32(cmb_teach_exp.SelectedValue);

                if (txt_teach_name.Text != "" && txt_teach_lname.Text != "" && txt_teach_father_name.Text != "" && txt_teach_id.Text != "" && txt_teach_email.Text != "" && txt_teach_mobile.Text != "" && cmb_teach_exp.Text != "" && txt_teach_address.Text != "" && cmb_country_teach.Text != "" && cmb_province_tech.Text != "" && cmb_city_teach.Text != "")
                {
                    cmd = new SqlCommand(" update teacherdata set TeachName='" + txt_teach_name.Text + "', TeachLastName='" + txt_teach_lname.Text + "',TeachFatherName='" + txt_teach_father_name.Text + "',TeachID='" + txt_teach_id.Text + "',TeachEmail='" + txt_teach_email.Text + "',TeachMobile='" + txt_teach_mobile.Text + "',TeachDOB='" + DOB + "',Expertise='" + expert_id + "',TeachAdd='" + txt_teach_address.Text + "',TeachGender='" + gender + "',Teachc_id='" + count_id + "',Teachp_id='" + prov_id + "',Teachct_id='" + city_id + "' where Teach_id='" + TeacherDataShow.teach_id + "'", con.opencon());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" The Record Has Been Updated ");
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

        private void btn_st_delete_teach_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from teacherdata where Teach_id='" + TeacherDataShow.teach_id + "'", con.opencon());
            cmd.ExecuteNonQuery();
            MessageBox.Show(" The Record Has Been Updated ");
        }
    }
}
