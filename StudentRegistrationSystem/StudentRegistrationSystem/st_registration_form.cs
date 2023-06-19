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
    public partial class st_registration_form : MaterialSkin.Controls.MaterialForm
    {

        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;
        connection con = new connection();

        public st_registration_form()
        {
            InitializeComponent();
            showdata();
            classnames();
            fieldnames();
            btn_st_delete.Enabled = false;
            btn_st_update.Enabled = false;
        }

        public void showdata()
        {
            adpt = new SqlDataAdapter("select * from country", con.opencon());
            dt = new DataTable();
            adpt.Fill(dt);
            cmb_country.DataSource = dt;
            cmb_country.DisplayMember = "CountryName";
            cmb_country.ValueMember = "country_id";
        }

        private void cmb_country_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int count = Convert.ToInt32(cmb_country.SelectedValue.ToString());
                adpt = new SqlDataAdapter("select * from province where count_id='" + count + "'", con.opencon());
                dt = new DataTable();
                adpt.Fill(dt);
                cmb_province.DataSource = dt;
                cmb_province.DisplayMember = "ProvinceName";
                cmb_province.ValueMember = "province_id";
            }
            catch (Exception)
            {

                
            }
         
           
        }

        private void cmb_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int pro = Convert.ToInt32(cmb_province.SelectedValue.ToString());
                adpt = new SqlDataAdapter("select * from city where prov_id='" + pro + "'", con.opencon());
                dt = new DataTable();
                adpt.Fill(dt);
                cmb_city.DataSource = dt;
                cmb_city.DisplayMember = "CityName";
                cmb_city.ValueMember = "city_id";
            }
            catch (Exception)
            {


                
            }
        }

        public void classnames()
        {
            try
            {
                adpt = new SqlDataAdapter("select * from class", con.opencon());
                dt = new DataTable();
                adpt.Fill(dt);
                cmb_st_class.DataSource = dt;
                cmb_st_class.DisplayMember = "ClassName";
                cmb_st_class.ValueMember = "Class_id";
            }
            catch (Exception)
            {
                
               
            }
        }
        public void fieldnames()
        {
            try
            {
                adpt = new SqlDataAdapter("select * from field", con.opencon());
                dt = new DataTable();
                adpt.Fill(dt);
                cmb_st_field.DataSource = dt;
                cmb_st_field.DisplayMember = "FieldName";
                cmb_st_field.ValueMember = "Field_id";
            }
            catch (Exception)
            {


            }
        }
        private void btn_st_save_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = "Female";
                if (rbtn_male.Checked)
                {
                    gender = "Male";
                }
                int countryid = Convert.ToInt32(cmb_country.SelectedValue);
                int provinceid = Convert.ToInt32(cmb_province.SelectedValue);
                int cityid = Convert.ToInt32(cmb_city.SelectedValue);
                int classid = Convert.ToInt32(cmb_st_class.SelectedValue);
                int fieldid = Convert.ToInt32(cmb_st_field.SelectedValue);

                if (txt_st_name.Text != "" && txt_st_lname.Text != "" && txt_st_father_name.Text != "" && txt_father_id.Text != "" && txt_st_email.Text != "" && txt_st_mobile.Text != "" && cmb_st_class.Text != "" && cmb_st_field.Text != "" && txt_st_address.Text != "" && cmb_country.Text != "" && cmb_province.Text != "" && cmb_city.Text != ""  && cmb_st_field.Text !="")
                {
                    cmd = new SqlCommand("insert into studentdata values('" + txt_st_name.Text + "','" + txt_st_lname.Text + "','" + txt_st_father_name.Text + "','" + txt_father_id.Text + "','" + txt_st_email.Text + "','" + txt_st_mobile.Text + "','" + date_of_birth.Text + "','" + date_of_registration.Text + "','" + classid + "','" +fieldid+ "','"+ txt_st_address.Text + "','" + gender + "','" + countryid + "','" + provinceid + "','" + cityid + "')", con.opencon());
                    cmd.ExecuteNonQuery();
                    string parola_basic = "1234";
                    string student = "student";
                    string username = txt_st_name.Text.Trim() + "_" + txt_st_lname.Text.Trim();
                    cmd = new SqlCommand("insert into Registration values('" + username + "','" + parola_basic + "','" + student + "')", con.opencon());
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
            txt_st_name.Text = "";
            txt_st_lname.Text = "";
            txt_st_father_name.Text = "";
            txt_father_id.Text = "";
            txt_st_email.Text = "";
            txt_st_mobile.Text = "";
            cmb_st_class.Text = "";
            txt_st_address.Text = "";
            cmb_st_field.Text = "";
            cmb_country.Text = "";
            cmb_province.Text = "";
            cmb_city.Text = "";
        }

        private void btn_st_get_date_Click(object sender, EventArgs e)
        {
            st_data_display obj = new st_data_display();
            obj.Show();
            this.Hide();
        }

        private void btn_st_update_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = "";
                if (rbtn_male.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                string DOB_Student = date_of_birth.Value.ToString("MM-dd-yyyy");
                string DOR_Student = date_of_registration.Value.ToString("MM-dd-yyyy");
                int st_country_id = Convert.ToInt32(cmb_country.SelectedValue);
                int st_prov_id = Convert.ToInt32(cmb_province.SelectedValue);
                int st_cty_id = Convert.ToInt32(cmb_city.SelectedValue);
                int st_class_id = Convert.ToInt32(cmb_st_class.SelectedValue);
                int st_field_id = Convert.ToInt32(cmb_st_field.SelectedValue);

                if (txt_st_name.Text != "" && txt_st_lname.Text != "" && txt_st_father_name.Text != "" && txt_father_id.Text != "" && txt_st_email.Text != "" && txt_st_mobile.Text != "" && cmb_st_class.Text != "" && txt_st_address.Text != "" && cmb_country.Text != "" && cmb_province.Text != "" && cmb_city.Text != "" && cmb_st_field.Text !="")
                {
                    cmd = new SqlCommand("update studentdata set FName='" + txt_st_name.Text + "',LName='" + txt_st_lname.Text + "',FatherName='" + txt_st_father_name.Text + "',FatherID='" + txt_father_id.Text + "',Email='" + txt_st_email.Text + "', Mobile='" + txt_st_mobile.Text + "',DOB='" + DOB_Student + "',DOR='" + DOR_Student + "',Cls_id='" + st_class_id + "',Fld_id='" + st_field_id + "',Adress='" +  txt_st_address.Text + "',gender='" + gender + "',c_id='" + st_country_id + "',p_id='" + st_prov_id + "', ct_id='" + st_cty_id + "' where Student_id='" + st_data_display.St_id + "'", con.opencon());
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
                cmd = new SqlCommand("delete from studentdata where student_id='" + st_data_display.St_id + "'", con.opencon());
                cmd.ExecuteNonQuery();
                MessageBox.Show(" The Data Has Been Deleted ");
            }
            catch (Exception)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int clas = Convert.ToInt32(cmb_st_class.SelectedValue.ToString());
            adpt = new SqlDataAdapter("select * from class where fld_id='" + clas + "'", con.opencon());
            dt = new DataTable();
            adpt.Fill(dt);
            cmb_st_class.DataSource = dt;
            cmb_st_class.DisplayMember = "ClassName";
            cmb_st_class.ValueMember = "Class_id";
        }

        private void cmb_st_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }    

    
}
