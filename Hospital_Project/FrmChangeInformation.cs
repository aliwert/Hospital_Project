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
    public partial class FrmChangeInformation : Form
    {
        public FrmChangeInformation()
        {
            InitializeComponent();
        }
        public string TCno;
        sqlconnect bgl = new sqlconnect();
        private void FrmChangeInformation_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCno;
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Patients where PatientSSN=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TxtName.Text = dr[1].ToString();
                TxtSurname.Text = dr[2].ToString();
                MskPhone.Text = dr[4].ToString();
                TxtPassword.Text = dr[5].ToString();
                CmbGender.Text = dr[6].ToString();

            }
            bgl.baglanti().Close();


        }

        private void BtnUpdateInformation_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("update Tbl_Patients set PatientName=@p1, PatientSurname=@p2, PatientPhone=@p3, PatientPassword=@p4, PatientGender=@p5 where PatientSSN=@p6", bgl.baglanti());
            cmd2.Parameters.AddWithValue("@p1", TxtName.Text);
            cmd2.Parameters.AddWithValue("@p2", TxtSurname.Text);
            cmd2.Parameters.AddWithValue("@p3", MskPhone.Text);
            cmd2.Parameters.AddWithValue("@p4", TxtPassword.Text);
            cmd2.Parameters.AddWithValue("@p5", CmbGender.Text);
            cmd2.Parameters.AddWithValue("@p6", MskTC.Text);
            cmd2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Your information has been successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
