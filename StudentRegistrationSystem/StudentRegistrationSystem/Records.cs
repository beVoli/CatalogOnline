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
    public partial class Records : MaterialSkin.Controls.MaterialForm
    {
        public Records()
        {
            InitializeComponent();
        }

        private void btn_Student_Record_Click(object sender, EventArgs e)
        {
            st_data_display obj = new st_data_display();
            obj.Show();
        }

        private void btn_teacher_record_Click(object sender, EventArgs e)
        {
            TeacherDataShow obj = new TeacherDataShow();
            obj.Show();
        }

        private void btn_Fees_record_Click(object sender, EventArgs e)
        {
            Fees_Form_Data_Show obj = new Fees_Form_Data_Show();
            obj.Show();
        }

        private void btn_fees_record_student_Click(object sender, EventArgs e)
        {
            Fees_Record_Student obj = new Fees_Record_Student();
            obj.Show();
        }
    }
}
