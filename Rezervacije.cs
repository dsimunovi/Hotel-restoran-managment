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

namespace ProjektUpi
{
    public partial class Rezervacije : Form
    {
        SqlConnection VezaNaBazu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dajana\Desktop\UPI\UPI_Projekt\UPI_Final_demo\Final_demo_projekt\Baza\Database1.mdf;Integrated Security=True;Connect Timeout=30");

        public void ispuniTablicu()
        {
            VezaNaBazu.Open();
            string Myquery = "select * from Rezervacije_Table";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, VezaNaBazu);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RezervacijaGridView.DataSource = ds.Tables[0];
            VezaNaBazu.Close();
        }

        public Boolean IsNumber(String value)
        {
            return value.All(Char.IsDigit);
        }
        public Rezervacije()
        {
            InitializeComponent();
        }

        public void IspuniSobeCombo()
        {
            VezaNaBazu.Open();
            string stanjesobe = "NE";
            SqlCommand cmd = new SqlCommand("select SobaId from Sobe_Table where SobaZauzeta = '" + stanjesobe + "'", VezaNaBazu);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SobaId", typeof(int));
            dt.Load(rdr);
            cb_BrojSobe.ValueMember = "SobaId";
            cb_BrojSobe.DataSource = dt;
            VezaNaBazu.Close();
        }
        public void IspuniGostaCombo()
        {
            VezaNaBazu.Open();
            SqlCommand cmd = new SqlCommand("select GostIme from Gost_Table", VezaNaBazu);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("GostIme", typeof(string));
            dt.Load(rdr);
            cb_gost.ValueMember = "GostIme";
            cb_gost.DataSource = dt;
            VezaNaBazu.Close();
        }
        private void Rezervacije_Load(object sender, EventArgs e)
        {
            timer1.Start();
            IspuniSobeCombo();
            IspuniGostaCombo();
            ispuniTablicu();
            Datumlb.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
        }

        private void dateIn_ValueChanged(object sender, EventArgs e)
        {
            //ne moze se rezervirati proslost
            int res = DateTime.Compare(dateIn.Value, DateTime.Now);
            if (res < 0)
                MessageBox.Show("Krivi datum za rezervaciju");
        }

        private void dateOut_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(dateOut.Value, dateIn.Value);
            if (res < 0)
                MessageBox.Show("Krivi datum za odjavu, pokušajte ponovno!");
        }
        public void azurirajstanje_sobe()
        {
            VezaNaBazu.Open();
            string novostanje = "DA";
            string myquery = "UPDATE Sobe_Table set SobaZauzeta = '" + novostanje + "'where SobaId =" + Convert.ToInt32(cb_BrojSobe.SelectedValue.ToString()) + ";";
            SqlCommand cmd = new SqlCommand(myquery, VezaNaBazu);
            cmd.ExecuteNonQuery();
            // MessageBox.Show("Rezervacija uspješno uređena!");
            VezaNaBazu.Close();
            IspuniSobeCombo();
        }
        public void azurirajsobu_brisanje()
        {
            VezaNaBazu.Open();
            string novostanje = "NE";
            int sobaid = Convert.ToInt32(txb_brojsobe.Text);
            string myquery = "UPDATE Sobe_Table set SobaZauzeta = '" + novostanje + "'where SobaId =" + sobaid + ";";
            SqlCommand cmd = new SqlCommand(myquery, VezaNaBazu);
            cmd.ExecuteNonQuery();
            // MessageBox.Show("Rezervacija uspješno uređena!");
            VezaNaBazu.Close();
            IspuniSobeCombo();
        }

        private void RezervacijaGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = RezervacijaGridView.Rows[i];
            txb_rezervacijaID.Text = row.Cells[0].Value.ToString();
            txb_brojsobe.Text = row.Cells[2].Value.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Datumlb.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            VezaNaBazu.Open();
            if (txb_rezervacijaID.Text == "" || !IsNumber(txb_rezervacijaID.Text) || cb_gost.SelectedIndex < 0 || cb_BrojSobe.SelectedIndex < 0)
            {
                VezaNaBazu.Close();
                MessageBox.Show("Nisu uneseni svi podaci.\n Krivo uneseni podaci!");
                return;
            }
            SqlCommand cmd2 = new SqlCommand("Select * from Rezervacije_Table where RezervacijaId=@RezervacijaId", VezaNaBazu);
            cmd2.Parameters.AddWithValue("RezervacijaId", txb_rezervacijaID.Text);
            SqlDataReader myreader = cmd2.ExecuteReader();
            if (myreader.Read())
            {
                VezaNaBazu.Close();
                MessageBox.Show("Rezervacija s unesenim ID već postoji!");
            }
            else
            {
                VezaNaBazu.Close();
                SqlCommand cmd = new SqlCommand("insert into Rezervacije_Table values(" + txb_rezervacijaID.Text + ", '" + cb_gost.SelectedValue.ToString() + "', '" + cb_BrojSobe.SelectedValue.ToString() + "', '" + dateIn.Text + "', '" + dateOut.Text + "' )", VezaNaBazu);
                cmd.Parameters.AddWithValue("RezervacijaId", txb_rezervacijaID.Text);
                VezaNaBazu.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rezervacija uspješno dodana!");
                VezaNaBazu.Close();
                azurirajstanje_sobe();
                ispuniTablicu();

            }
        }

        private void btn_uredi_Click(object sender, EventArgs e)
        {
            if (txb_rezervacijaID.Text == "")
            {
                MessageBox.Show("Niste odabrali rezervaciju!");
            }
            else
            {
                VezaNaBazu.Open();
                string myquery = "UPDATE Rezervacije_Table set Gost = '" + cb_gost.SelectedValue.ToString() + "', Soba ='" + txb_brojsobe.Text + "', DatumOd ='" + dateIn.Text + "', DatumDo ='" + dateOut.Text + "'where RezervacijaId =" + txb_rezervacijaID.Text + ";";
                SqlCommand cmd = new SqlCommand(myquery, VezaNaBazu);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rezervacija uspješno uređena!");
                VezaNaBazu.Close();
                ispuniTablicu();
            }
        }

        private void btn_izbrisi_Click(object sender, EventArgs e)
        {
            if (txb_rezervacijaID.Text == "")
            {
                MessageBox.Show("Odaberite rezervaciju da bi bila izbrisana");
            }
            else
            {
                VezaNaBazu.Open();
                string query = "delete from Rezervacije_Table where RezervacijaId =" + txb_rezervacijaID.Text + "";
                SqlCommand cmd = new SqlCommand(query, VezaNaBazu);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rezervacija je uspjesno izbrisana!");
                VezaNaBazu.Close();
                azurirajsobu_brisanje();
                ispuniTablicu();
            }
        }

        private void btn_povratak_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Izbornik glavna = new Izbornik();
            glavna.Show();
            this.Hide();
        }

        private void btn_pretraga_Click(object sender, EventArgs e)
        {
            VezaNaBazu.Open();
            if (!IsNumber(txb_rezervacijePretraga.Text))
            {
                VezaNaBazu.Close();
                MessageBox.Show("Unesite ID rezervacije za pretragu");
                return;
            }
            string Myquery = "select * from Rezervacije_Table where RezervacijaId  = '" + txb_rezervacijePretraga.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, VezaNaBazu);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RezervacijaGridView.DataSource = ds.Tables[0];
            VezaNaBazu.Close();
        }

        private void btn_ponovnoUcitaj_Click(object sender, EventArgs e)
        {
            ispuniTablicu();
        }
    }
}
