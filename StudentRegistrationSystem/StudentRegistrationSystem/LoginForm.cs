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
    public partial class LoginForm : MaterialSkin.Controls.MaterialForm
    {
        public static string Username;
        public static string Role;
        connection con = new connection();
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter adpt;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_UserName.Text != "" && txtPassword.Text != "")
                {
                    cmd = new SqlCommand("select * from Registration where UserName=@UserName and UserPassword=@UserPassword", con.opencon());
                    cmd.Parameters.AddWithValue("@UserName", txt_UserName.Text);
                    cmd.Parameters.AddWithValue("@UserPassword", txtPassword.Text);
                    Username = txt_UserName.Text;
                    adpt = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    adpt.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        string roles = ds.Tables[0].Rows[0]["Roles"].ToString();
                        Role = roles;
                        if (roles == "admin")
                        {
                            MessageBox.Show(" You Have Successfully Logged in ");
                            this.Hide();
                            Form1 obj = new Form1();
                            obj.Show();
                        }
                        else
                            if(roles == "student")
                        {
                            MessageBox.Show(" You Have Successfully Logged in ");
                            this.Hide();
                            Form1 obj = new Form1();
                            obj.btn_admin_registration.Enabled = false;
                            obj.btn_st_registration.Enabled = false;
                            obj.btn_teach_registration.Enabled = false;
                            obj.btn_fees.Enabled = false;
                            obj.Show();
                        }
                        else
                            if(roles =="teacher")
                        {
                            MessageBox.Show(" You Have Successfully Logged in ");
                            this.Hide();
                            Form1 obj = new Form1();
                            obj.btn_admin_registration.Enabled = false;
                            obj.btn_fees.Enabled = false;
                            obj.btn_teach_registration.Enabled = false;
                            obj.Show();
                        }
                    }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
