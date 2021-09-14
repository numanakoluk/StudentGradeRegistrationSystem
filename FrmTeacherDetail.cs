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
    public partial class FrmTeacherDetail : Form
    {
        public FrmTeacherDetail()
        {
            InitializeComponent();
        }

        private void FrmTeacherDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNoteRecordDataSet.TBLLESSON' table. You can move, or remove it, as needed.
            this.tBLLESSONTableAdapter.Fill(this.dbNoteRecordDataSet.TBLLESSON);

        }
    }
}
