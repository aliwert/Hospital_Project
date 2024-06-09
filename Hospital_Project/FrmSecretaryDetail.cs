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
namespace Hospital_Project
{
    public partial class FrmSecretaryDetail : Form
    {
        public FrmSecretaryDetail()
        {
            InitializeComponent();
        }
        public string TCnu;
        sqlconnect bgl = new sqlconnect();
        private void FrmSecretaryDetail_Load(object sender, EventArgs e)
        {
            LblTC.Text = TCnu;

            // name-surname
            SqlCommand cmd = new SqlCommand("Select SecretaryNameSurname From Tbl_Secretary where SecretarySSN=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                LblNameSurname.Text= dr1[0].ToString();
            }
            bgl.baglanti().Close();


            // add subject to datagrid

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select SubjectName from Tbl_Subjects", bgl.baglanti());
            da.Fill(dt1);
            dataGridView2.DataSource = dt1;


            // doctors add to list

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoctorName + ' ' + DoctorSurname) as 'Doctors', DoctorSubject From Tbl_Doctors", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView3.DataSource = dt2;

            // subject add to cmbbox

            SqlCommand cmd2 = new SqlCommand("Select SubjectName From Tbl_Subjects", bgl.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                CmbSubject.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand save = new SqlCommand("insert into Tbl_Appointments (AppointmentDate,AppointmentClock,AppointmentSubject, AppointmentDoctor)values (@r1, @r2, @r3, @r4)", bgl.baglanti());
            save.Parameters.AddWithValue("@r1", MskDate.Text);
            save.Parameters.AddWithValue("@r2", MskClock.Text);
            save.Parameters.AddWithValue("@r3", CmbSubject.Text);
            save.Parameters.AddWithValue("@r4", CmbDoctor.Text);
            save.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Appointment has been created");
        }

        private void CmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbSubject.Items.Clear();

            SqlCommand kmt = new SqlCommand("Select DoctorName,DoctorSurname From Tbl_Doctors Where DoctorSubject=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", CmbSubject.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                CmbDoctor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnAnnouncementsCreate_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into Tbl_Announcements (announcement) values (@d1)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@d1", RchAnnouncements.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Announcement has been created.");
        }

        private void BtnDoctorPanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel dct = new FrmDoctorPanel();
            dct.Show();
        }
    }
}
