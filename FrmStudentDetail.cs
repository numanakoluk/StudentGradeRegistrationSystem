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
    public partial class FrmStudentDetail : Form
    {
        public FrmStudentDetail()
        {
            InitializeComponent();
        }
        public string no;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-DPB315I;Initial Catalog=DbNoteRecord;Integrated Security=True");
        
        private void FrmStudentDetail_Load(object sender, EventArgs e)
        {
            LblNo.Text = no;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLLESSON where StudentNO=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", no);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblNameSurname.Text = dr[2].ToString() + " " + dr[3].ToString();
                LblExam1.Text = dr[4].ToString();
                LblExam2.Text = dr[5].ToString();
                LblExam3.Text = dr[6].ToString();
                LblAvarage.Text = dr[7].ToString();
                LblStatus.Text = dr[8].ToString();

            }
            baglanti.Close();
        }
    }
}
