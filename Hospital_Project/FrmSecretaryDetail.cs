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
    public partial class FrmSecretaryDetail : Form
    {
        public FrmSecretaryDetail()
        {
            InitializeComponent();
        }
        public string TCnu;
        sqlconnect bgl = new sqlconnect();
        private void FrmSecretaryDetail_Load(object sender, EventArgs e)
        {
            LblTC.Text = TCnu;

            // name-surname
            SqlCommand cmd = new SqlCommand("Select SecretaryNameSurname From Tbl_Secretary where SecretarySSN=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                LblNameSurname.Text= dr1[0].ToString();
            }
            bgl.baglanti().Close();


            // add subject to datagrid

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select SubjectName from Tbl_Subjects", bgl.baglanti());
            da.Fill(dt1);
            dataGridView2.DataSource = dt1;

        }
    }
}
