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
    public partial class FrmDoctorDetail : Form
    {
        public FrmDoctorDetail()
        {
            InitializeComponent();
        }
        sqlconnect bgl = new sqlconnect();
        public string TC;
        private void FrmDoctorDetail_Load(object sender, EventArgs e)
        {
            LblTC.Text = TC;

            // doctor name surname

            SqlCommand cmd = new SqlCommand("select doctorname, doctorsurname from Tbl_Doctors where doctorssn=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblNameSurname.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();


            //appointmens
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointments where AppointmentDoctor='" + LblNameSurname.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FrmDoctorInformationChange ifc = new FrmDoctorInformationChange();
            ifc.TCno = LblTC.Text;
            ifc.Show();
        }
    }
}
