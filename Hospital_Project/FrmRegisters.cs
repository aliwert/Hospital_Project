using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class FrmRegisters : Form
    {
        public FrmRegisters()
        {
            InitializeComponent();
        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            FrmPatientRegister fr = new FrmPatientRegister();
            fr.Show();
            this.Hide();
        }

        private void BtnDoctor_Click(object sender, EventArgs e)
        {
            FrmDoctorRegister fr = new FrmDoctorRegister();
            fr .Show(); this.Hide();
        }

        private void BtnSecretary_Click(object sender, EventArgs e)
        {
            FrmSecretaryRegister fr = new FrmSecretaryRegister();
            fr .Show(); 
            this.Hide();

        }
    }
}
