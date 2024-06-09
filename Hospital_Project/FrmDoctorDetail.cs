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
        }
    }
}
