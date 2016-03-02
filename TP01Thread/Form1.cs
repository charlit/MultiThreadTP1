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

namespace TP01Thread
{
    public partial class HorlogeV2 : Form
    {
        private Thread leThread;
        public HorlogeV2()
        {
            InitializeComponent();
            leThread = new Thread(Go);
           
        }
        private void Go()
        {
            while (true)
            {
                AfficherDateHeure();
                Thread.Sleep(1000);
                
            }
        }
        private void MAJDATE()
        {
            lblDateHeure.Text = DateTime.Now.ToShortDateString();
        }
        private void AfficherDateHeure()
        {
            if (rbtnDate.Checked)
                lblDateHeure.Invoke(new Action(MAJDATE));
            else if (rbtnHeure.Checked)
                lblDateHeure.Invoke(new Action(() => lblDateHeure.Text = DateTime.Now.ToLongTimeString()));
            else
                lblDateHeure.Invoke(new Action(() => lblDateHeure.Text = DateTime.Now.ToString()));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leThread.Start();
        }

        private void rbtnDateHeure_CheckedChanged(object sender, EventArgs e)
        {
            AfficherDateHeure();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void Quitter()
        {
            leThread.Abort();
            leThread.Join();
            
        }

        private void HorlogeV2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Quitter();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
