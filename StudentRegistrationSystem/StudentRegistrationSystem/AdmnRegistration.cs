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
    public partial class AdmnRegistration : MaterialSkin.Controls.MaterialForm
    {
        connection con = new connection();
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int R_id;

        public AdmnRegistration()
        {
            InitializeComponent();
            DisplayData();
            btn_Delete.Enabled = false;
            btnUpdate_Registration.Enabled = false;
        }

        private void btnSave_Registration_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUserName.Text!="" && txtPassword.Text != "")
                {
                    cmd = new SqlCommand("select * from Registration where UserName=@UserName", con.opencon());
                    cmd.Parameters.AddWithValue("UserName", txtUserName.Text);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        MessageBox.Show(" User Name Available in the Database ");
                    }
                    else
                    {
                        dr.Close();
                        string admin = "admin";
                        cmd = new SqlCommand("insert into Registration values('" + txtUserName.Text + "','" + txtPassword.Text + "','"+admin + "')", con.opencon());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(" Data Has Been Stored in the Database ");
                        DisplayData();
                    }
                }
                else
                {
                    MessageBox.Show(" Please Enter User Name & Passowrd ");
                }


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                
            }
        }

        public void DisplayData()
        {
            adpt = new SqlDataAdapter("select * from Registration", con.opencon());
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            R_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtUserName.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            btnUpdate_Registration.Enabled = true;
            btn_Delete.Enabled = true;
        }

        private void btn_New_registration_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void btnUpdate_Registration_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text!="" && txtPassword.Text != "")
            {
                cmd = new SqlCommand("update Registration set UserName='" + txtUserName.Text + "',UserPassword='" + txtPassword.Text + "' where Registration_ID='" + R_id + "'", con.opencon());
                cmd.ExecuteNonQuery();
                MessageBox.Show(" The Record Has Been Updated ");
                DisplayData();
            }
            else
            {
                MessageBox.Show(" please Enter the User Name and Password ");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from Registration where Registration_ID='" + R_id + "'", con.opencon());
            cmd.ExecuteNonQuery();
            MessageBox.Show(" The Data Has Been Deleted ");
            DisplayData();
        }
    }
}
