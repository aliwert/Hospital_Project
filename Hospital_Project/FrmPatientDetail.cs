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
            SqlCommand komut = new SqlCommand("Select PatientName, PatientSurname From Tbl_Patients where PatientSSN=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader sqlDataReader = komut.ExecuteReader();
            while(sqlDataReader.Read()) {
                LblNameSurname.Text = sqlDataReader[0] + " " + sqlDataReader[1];

            }
            bgl.baglanti().Close();
        }
    }
}
