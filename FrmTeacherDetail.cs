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

namespace StudentGradeRegistrationSystem
{
    public partial class FrmTeacherDetail : Form
    {
        public FrmTeacherDetail()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-DPB315I;Initial Catalog=DbNoteRecord;Integrated Security=True");
        private void FrmTeacherDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNoteRecordDataSet.TBLLESSON' table. You can move, or remove it, as needed.
            this.tBLLESSONTableAdapter.Fill(this.dbNoteRecordDataSet.TBLLESSON);

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert Into TBLLESSON (STUDENTNO, STUDENTNAME,STUDENTSURNAME) values(@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", MskNo.Text);
            komut.Parameters.AddWithValue("@p2", TxtName.Text);
            komut.Parameters.AddWithValue("@p3", TxtSurname.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Student Add System");
            this.tBLLESSONTableAdapter.Fill(this.dbNoteRecordDataSet.TBLLESSON);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            MskNo.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtName.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtExam1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtExam2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtExam3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string status;

            double avarage, e1, e2, e3;
            e1 = Convert.ToDouble(TxtExam1.Text);
            e2 = Convert.ToDouble(TxtExam2.Text);
            e3 = Convert.ToDouble(TxtExam3.Text);
            avarage = (e1 + e2 + e3) / 3;
            LblAvarage.Text = avarage.ToString();


            if (avarage >50 )
            {
                status = "True";
            }
            else
            {
                status = "False";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TBLLESSON set STUDENTEX1=@P1, STUDENTEX2=@P2, STUDENTEX3=@P3, AVARAGE=@P4, STATUS=@P5 WHERE STUDENTNO=@P6" , baglanti);
            komut.Parameters.AddWithValue("@P1", TxtExam1.Text);
            komut.Parameters.AddWithValue("@P2", TxtExam2.Text);
            komut.Parameters.AddWithValue("@P3", TxtExam3.Text);
            komut.Parameters.AddWithValue("@P4", decimal.Parse(LblAvarage.Text));
            komut.Parameters.AddWithValue("@P5", status);
            komut.Parameters.AddWithValue("@P6", MskNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Student Updated");
            this.tBLLESSONTableAdapter.Fill(this.dbNoteRecordDataSet.TBLLESSON);


        }
    }
}
