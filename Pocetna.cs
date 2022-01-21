using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektUpi
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

       
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            trakaNapredka.Value = start;
            if(trakaNapredka.Value == 100)
            {
                trakaNapredka.Value = 0;
                timer1.Stop();
                Prijava LogInForma = new Prijava();
                LogInForma.Show();
                this.Hide();
            }
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
