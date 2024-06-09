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
    public partial class FrmDoctorRegister : Form
    {
        public FrmDoctorRegister()
        {
            InitializeComponent();
        }
        sqlconnect bgl = new sqlconnect();

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tbl_doctors where doctorssn= @p1 and doctorpassword=@p2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmDoctorDetail fr = new FrmDoctorDetail();
                fr.TC =MskTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong T.C.(ssn) or password");
            }
            bgl.baglanti().Close();
        }
    }
}
