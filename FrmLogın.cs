using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeRegistrationSystem
{
    public partial class FrmLogın : Form
    {
        public FrmLogın()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStudentDetail frm = new FrmStudentDetail();
            frm.no = maskedTextBox1.Text;
            frm.Show();
            

        }

      

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")
            {
                FrmTeacherDetail fr = new FrmTeacherDetail();
                fr.Show();
            }
        }
    }
}
