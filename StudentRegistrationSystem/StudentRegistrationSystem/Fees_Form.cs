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
    public partial class Fees_Form : MaterialSkin.Controls.MaterialForm
    {
        connection con = new connection();
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;

        public Fees_Form()
        {
            InitializeComponent();
            StName();
            ClassName();
            FieldName();
            Months();
            btn_fees_delete.Enabled = false;
            btn_fees_update.Enabled = false;
        }

        public void StName()
        {
            adpt = new SqlDataAdapter("select * from studentdata", con.opencon());
            dt = new DataTable();
            adpt.Fill(dt);
            cmb_Student_Name.DataSource = dt;
            cmb_Student_Name.DisplayMember = "FName";
            cmb_Student_Name.ValueMember = "Student_id";
        }

       
        public void FieldName()
        {
            try
            {
                adpt = new SqlDataAdapter("select * from field", con.opencon());
                dt = new DataTable();
                adpt.Fill(dt);
                cmb_field.DataSource = dt;
                cmb_field.DisplayMember = "FieldName";
                cmb_field.ValueMember = "Field_id";
            }
            catch (Exception)
            { 
            }
        }
        public void ClassName()
        {
            try
            {
                adpt = new SqlDataAdapter("select * from class", con.opencon());
                dt = new DataTable();
                adpt.Fill(dt);
                cmb_class.DataSource = dt;
                cmb_class.DisplayMember = "ClassName";
                cmb_class.ValueMember = "Class_id";
            }
            catch (Exception){ }

        }

        public void Months()
        {
            adpt = new SqlDataAdapter("select * from StudentMonths", con.opencon());
            dt = new DataTable();
            adpt.Fill(dt);
            cmb_month.DataSource = dt;
            cmb_month.DisplayMember = "Months";
            cmb_month.ValueMember = "Month_ID";
        }

        private void btn_fees_save_Click(object sender, EventArgs e)
        {
            int ST_Name = Convert.ToInt32(cmb_Student_Name.SelectedValue.ToString());
            string Class = cmb_class.SelectedValue.ToString();
            int Month = Convert.ToInt32(cmb_month.SelectedValue.ToString());
            int field = Convert.ToInt32(cmb_field.SelectedValue.ToString());


            if (txt_amount.Text!="" && cmb_month.Text!="" && cmb_class.Text!="" && cmb_Student_Name.Text!="" && fees_date_of_adminision.Text != "")
            {
                cmd = new SqlCommand("insert into fees_Form values('"+ ST_Name + "','" + Class + "','"+field+ "','" + Month + "','"+ fees_date_of_adminision .Text+ "','"+txt_amount.Text+"')", con.opencon());
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Your Record Has Been Saved in the Database ");
            }
            else
            {
                MessageBox.Show(" Please Fill in the Blanks");
            }
        }

        private void btn_fees_get_date_Click(object sender, EventArgs e)
        {
            Fees_Form_Data_Show obj = new Fees_Form_Data_Show();
            obj.Show();
            this.Hide();
        }

        private void btn_fees_update_Click(object sender, EventArgs e)
        {
            try
            {
                int NameID = Convert.ToInt32(cmb_Student_Name.SelectedValue);
                int ClassID = Convert.ToInt32(cmb_class.SelectedValue);
                int MonthID = Convert.ToInt32(cmb_month.SelectedValue);
                int FieldID = Convert.ToInt32(cmb_field.SelectedValue);
                string DOADMIN = fees_date_of_adminision.Value.ToString("MM-dd-yyyy");

                if (cmb_class.Text != "" && cmb_month.Text != "" && cmb_Student_Name.Text != "" && cmb_field.Text!="" && txt_amount.Text != "")
                {
                    cmd = new SqlCommand("update fees_Form set Student_Name_Id='" + NameID + "',Class='" + ClassID+"',Field_ID='" + FieldID + "',Month_ID='" + MonthID + "',DO_Adminision='" + DOADMIN + "',Amount='" + txt_amount.Text + "' where F_ID='" + Fees_Form_Data_Show.Fees_IDGet + "'", con.opencon());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Record Has Been Updated ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void btn_fees_delete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from fees_Form where F_ID='" + Fees_Form_Data_Show.Fees_IDGet + "'", con.opencon());
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Record Has Been Deleted ");
        }
        private void cmb_month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_field_SelectedIndexChanged(object sender, EventArgs e)
        {
            int clas = Convert.ToInt32(cmb_class.SelectedValue.ToString());
            adpt = new SqlDataAdapter("select * from class where fld_id='" + clas + "'", con.opencon());
            dt = new DataTable();
            adpt.Fill(dt);
            cmb_class.DataSource = dt;
            cmb_class.DisplayMember = "ClassName";
            cmb_class.ValueMember = "Class_id";
        }
    }
}
