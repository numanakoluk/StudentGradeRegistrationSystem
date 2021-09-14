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
    public partial class FrmStudentDetail : Form
    {
        public FrmStudentDetail()
        {
            InitializeComponent();
        }
        public string no;

        private void FrmStudentDetail_Load(object sender, EventArgs e)
        {
            LblNo.Text = no;

        }
    }
}
