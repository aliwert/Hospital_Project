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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }
        sqlconnect bgl = new sqlconnect();
        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doctors", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            // subject add to cmbbox
            SqlCommand cmd2 = new SqlCommand("Select SubjectName From Tbl_Subjects", bgl.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                CmbSubject.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Doctors (DoctorName,DoctorSurname,DoctorSubject, DoctorSSN, DoctorPassword) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@d1", TxtName.Text);
            cmd.Parameters.AddWithValue("d2", TxtSurname.Text);
            cmd.Parameters.AddWithValue("@d3", CmbSubject.Text);
            cmd.Parameters.AddWithValue("@d4", MskTC.Text);
            cmd.Parameters.AddWithValue("@d5", TxtPassword.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor has been added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbSubject.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtPassword.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("delete from Tbl_Doctors where DoctorSSN=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", MskTC.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor has been deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Tbl_Doctors set DoctorName=@d1, DoctorSurname=@d2, DoctorSubject=@d3, DoctorPassword=@d5 where DoctorSSN=@d4",bgl.baglanti());
            cmd.Parameters.AddWithValue("@d1", TxtName.Text);
            cmd.Parameters.AddWithValue("d2", TxtSurname.Text);
            cmd.Parameters.AddWithValue("@d3", CmbSubject.Text);
            cmd.Parameters.AddWithValue("@d4", MskTC.Text);
            cmd.Parameters.AddWithValue("@d5", TxtPassword.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor has been updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

