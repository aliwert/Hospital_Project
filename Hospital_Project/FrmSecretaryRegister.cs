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
    public partial class FrmSecretaryRegister : Form
    {
        public FrmSecretaryRegister()
        {
            InitializeComponent();
        }
        sqlconnect bgl =new sqlconnect();
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Secretary where SecretarySSN=@p1 and SecretaryPassword=@p2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmSecretaryDetail detail = new FrmSecretaryDetail();
                detail.TCnu = MskTC.Text;
                detail.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong T.C.(SSN) or password");
            }
            bgl.baglanti().Close();
        }
    }
}
