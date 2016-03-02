using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TP01Threads
{
    public partial class Horloge : Form
    {
        public Horloge()
        {
            InitializeComponent();
        }

        private void rbtnDateHeure_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Horloge_Load(object sender, EventArgs e)
        {
            lblDateHeure.Text = DateTime.Now.ToString();

   
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Horloge_Paint(object sender, PaintEventArgs e)
        {
            AfficherDateHeure();
        }

        private void AfficherDateHeure()
        {
            if (rbtnDate.Checked)
                lblDateHeure.Text = DateTime.Now.ToShortDateString();
            else if (rbtnHeure.Checked)
                lblDateHeure.Text = DateTime.Now.ToLongTimeString();
            else
                lblDateHeure.Text = DateTime.Now.ToString();
        }

        private void btnRaffraichir_Click(object sender, EventArgs e)
        {
            while (true)
            {
                AfficherDateHeure();
                this.Refresh();
                Thread.Sleep(1000);

            }
            
        }

        private void rbtnDate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnHeure_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblDateHeure_Click(object sender, EventArgs e)
        {

        }
    }
}
