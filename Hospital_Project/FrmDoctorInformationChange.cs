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
    public partial class FrmDoctorInformationChange : Form
    {
        public FrmDoctorInformationChange()
        {
            InitializeComponent();
        }
        sqlconnect bgl = new sqlconnect();
        public string TCno;

        private void FrmDoctorInformationChange_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCno;

            SqlCommand cmd = new SqlCommand("Select * from Tbl_doctors where doctorssn=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TxtName.Text = reader[1].ToString();
                TxtSurname.Text = reader[2].ToString();
                TxtPassword.Text += reader[5].ToString();
                CmbSubject.Text = reader[3].ToString();
                
            }
            bgl.baglanti().Close();
        }

        private void BtnUpdateInformation_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update tbl_doctors set DoctorName=@p1, DoctorSurname=@p2, DoctorSubject=@p3, DoctorPassword=@p4 where DoctorSSN=@p5", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", TxtName.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", CmbSubject.Text);
            cmd.Parameters.AddWithValue("@p4", TxtPassword.Text);
            cmd.Parameters.AddWithValue("@p5", MskTC.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Information has been updated");

        }
    }
}
