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
            SqlCommand komut = new SqlCommand("insert into Tbl_Patients(PatientName, PatientSurname, PatientSSN, PatientPhone, PatientPassword, PatientGender) values (@p1, @p2, @p3, @p4, @p5, @p6)" ,bgl.baglanti());
        }
    }
}
