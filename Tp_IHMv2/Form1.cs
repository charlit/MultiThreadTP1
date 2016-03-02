using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_IHMv2
{
    public partial class HorlogeV2 : Form
    {
        private Thread leThread;

        public HorlogeV2()
        {
            InitializeComponent();
            leThread = new Thread(Go);
            leThread.Start();
        
        }

        private void Go()
        {
            while (true)
            {
                Thread.Sleep(1000);
                AfficherDateHeure();
            }
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

    }
}
