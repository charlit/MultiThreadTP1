using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V3
{
    public partial class HorlogeV3 : Form
    {
        public HorlogeV3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void rbtnDateHeure_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void AfficherDateHeure()
        {
            if (rbtnDate.Checked)
                lblDateHeure.Text = DateTime.Now.ToLongDateString();
            else if (rbtnHeure.Checked)
                lblDateHeure.Text = DateTime.Now.ToLongTimeString();
            else
                lblDateHeure.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AfficherDateHeure();
        }

        private void rbtnDate_Click(object sender, EventArgs e)
        {
            AfficherDateHeure();
        }

        private void rbtnDateHeure_Click(object sender, EventArgs e)
        {
            AfficherDateHeure();
        }
    }
}
