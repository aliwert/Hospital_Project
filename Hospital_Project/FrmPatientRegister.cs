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
    public partial class FrmPatientRegister : Form
    {
        public FrmPatientRegister()
        {
            InitializeComponent();
        }
        sqlconnect bgl = new sqlconnect();
        private void LnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientSignUp fr = new FrmPatientSignUp();
            fr.Show();
            
        }
       
        private void BtnRegister_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select * From Tbl_Patients Where PatientSSN=@p1 and PatientPassword=@p2", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("p2", TxtPassword.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmPatientDetail detail = new FrmPatientDetail();
                detail.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong T.C. (SSN) or password");
            }
            bgl.baglanti().Close();
        }
    }
}
