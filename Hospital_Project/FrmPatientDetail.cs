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
    public partial class FrmPatientDetail : Form
    {
        public FrmPatientDetail()
        {
            InitializeComponent();
        }
        public string tc;
        sqlconnect bgl = new sqlconnect();

        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            // name surname 
            SqlCommand komut = new SqlCommand("Select PatientName, PatientSurname From Tbl_Patients where PatientSSN=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader sqlDataReader = komut.ExecuteReader();
            while (sqlDataReader.Read())
            {
                LblNameSurname.Text = sqlDataReader[0] + " " + sqlDataReader[1];

            }
            bgl.baglanti().Close();

            // appointment history
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointments where TRY_CAST(PatientSSN as numeric)" + LblTC.Text, bgl.baglanti());
            //da.Fill(dt);
            dataGridView2.DataSource = dt;

            // subject

            SqlCommand komut2 = new SqlCommand("Select SubjectName From Tbl_Subjects", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbSubject.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void CmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select DoctorName, DoctorSurname From Tbl_Doctors where DoctorSubject=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbSubject.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointments where AppointmentSubject='" + CmbSubject.Text + "'" + "and AppointmentDoctor='" + CmbDoctor.Text + "' and AppointmentStatus=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void LnkChangeInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmChangeInformation fr = new FrmChangeInformation();
            fr.TCno = LblTC.Text;
            fr.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Appointments set AppointmentStatus=1, PatientSSN=@p1, PatientComplaint=@p2 where appointmentid=@p3 ", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", LblTC.Text);
            cmd.Parameters.AddWithValue("@p2", RchPresenting.Text);
            cmd.Parameters.AddWithValue("@p3", TxtId.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Appointment has been booked", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
