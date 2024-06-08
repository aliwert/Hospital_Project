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
    public partial class FrmChangeInformation : Form
    {
        public FrmChangeInformation()
        {
            InitializeComponent();
        }
        public string TCno;
        private void FrmChangeInformation_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCno;

        }
    }
}
