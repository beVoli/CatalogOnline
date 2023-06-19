using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationSystem
{
    public partial class Grades : MaterialSkin.Controls.MaterialForm
    {
        public Grades()
        {
            InitializeComponent();
            if(LoginForm.Role=="student")
                btn_add_grade.Enabled = false;
        }

        private void btn_add_grade_Click(object sender, EventArgs e)
        {
            Add_grade_form obj= new Add_grade_form();
            obj.Show();
            this.Close();
        }

        private void btn_student_view_Click(object sender, EventArgs e)
        {
            View_Grades_Student obj= new View_Grades_Student();
            obj.Show();
            this.Close();
        }
    }
}
