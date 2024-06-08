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
    public partial class FrmPatientSignUp : Form
    {
        public FrmPatientSignUp()
        {
            InitializeComponent();
        }
        sqlconnect bgl = new sqlconnect();
        private void BtnSignup_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Patients(PatientName, PatientSurname, PatientSSN, PatientPhone, PatientPassword, PatientGender) values (@p1, @p2, @p3, @p4, @p5, @p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtName.Text);
            komut.Parameters.AddWithValue("@p2", TxtSurname.Text);
            komut.Parameters.AddWithValue("@p3", MskTC.Text);
            komut.Parameters.AddWithValue("@p4", MskPhone.Text);
            komut.Parameters.AddWithValue("@p5", TxtPassword.Text);
            komut.Parameters.AddWithValue("@p6", CmbGender.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Your registration has been successfully completed, Your password: " + TxtPassword.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
