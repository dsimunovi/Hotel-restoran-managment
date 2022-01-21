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
    public partial class Izbornik : Form
    {
        public Izbornik()
        {
            InitializeComponent();
        }
        private void btn_odjava_Click(object sender, EventArgs e)
        {
            Prijava forma_prijava = new Prijava();
            forma_prijava.Show();
            this.Hide();
        }

        private void btn_gost_Click(object sender, EventArgs e)
        {
            Gost forma_gost = new Gost();
            forma_gost.Show();
            this.Hide();
        }

        private void btn_rezervacija_Click(object sender, EventArgs e)
        {
            Rezervacije forma_rezervacije = new Rezervacije();
            forma_rezervacije.Show();
            this.Hide();
        }

        private void btn_soba_Click(object sender, EventArgs e)
        {
            Sobe forma_sobe = new Sobe();
            forma_sobe.Show();
            this.Hide();
        }

        private void btn_osoblje_Click(object sender, EventArgs e)
        {
            Osoblje forma_osoblje = new Osoblje();
            forma_osoblje.Show();
            this.Hide();
        }

        private void btn_evidencija_Click(object sender, EventArgs e)
        {
            EvidencijaObroka forma_evidencija = new EvidencijaObroka();
            forma_evidencija.Show();
            this.Hide();
        }
    }
}
