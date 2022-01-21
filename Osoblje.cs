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
    public partial class Osoblje : Form
    {
        SqlConnection VezaNaBazu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dajana\Desktop\UPI\UPI_Projekt\UPI_Final_demo\Final_demo_projekt\Baza\Database1.mdf;Integrated Security=True;Connect Timeout=30");

        public void ispuniTablicu()
        {
            VezaNaBazu.Open();
            string Myquery = "select * from Osoblje_Table";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, VezaNaBazu);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            OsobljeGridView.DataSource = ds.Tables[0];
            VezaNaBazu.Close();
        }

        public Boolean IsNumber(String value)
        {
            return value.All(Char.IsDigit);
        }
        public Osoblje()
        {
            InitializeComponent();
        }

        private void Osoblje_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ispuniTablicu();
            Datumlb.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();

        }

        private void OsobljeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = OsobljeGridView.Rows[i];
            txb_osobljeID.Text = row.Cells[0].Value.ToString();
            txb_osobljeIme.Text = row.Cells[1].Value.ToString();
            txb_osobljeMob.Text = row.Cells[2].Value.ToString();
            txb_osobljeLozinka.Text = row.Cells[4].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datumlb.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            VezaNaBazu.Open();
            if(txb_osobljeID.Text == "" || !IsNumber(txb_osobljeID.Text) || txb_osobljeIme.Text == "" || IsNumber(txb_osobljeIme.Text) || txb_osobljeMob.Text == "" || !IsNumber(txb_osobljeMob.Text) || cmbSpol.SelectedIndex < 0 || txb_osobljeLozinka.Text == "")
            {
                VezaNaBazu.Close();
                MessageBox.Show("Nisu uneseni svi podaci!\n Krivo uneseni podaci!");
                return;
            }

            SqlCommand cmd2 = new SqlCommand("Select * from Osoblje_Table where OsobljeId=@OsobljeId", VezaNaBazu);
            cmd2.Parameters.AddWithValue("OsobljeId", txb_osobljeID.Text);
            SqlDataReader myreader = cmd2.ExecuteReader();
            if (myreader.Read())
            {
                VezaNaBazu.Close();
                MessageBox.Show("Član osoblja s unesenim ID već postoji!");
            }
            else
            {
                VezaNaBazu.Close();
                SqlCommand cmd = new SqlCommand("insert into Osoblje_Table values(" + txb_osobljeID.Text + ", '" + txb_osobljeIme.Text + "', '" + txb_osobljeMob.Text + "', '" + txb_osobljeLozinka.Text + "', '" + cmbSpol.SelectedItem.ToString() + "' )", VezaNaBazu);
                cmd.Parameters.AddWithValue("GostId", txb_osobljeID.Text);
                VezaNaBazu.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Član osoblja uspješno dodan");
                VezaNaBazu.Close();
                ispuniTablicu();
            }
        }

        private void btn_uredi_Click(object sender, EventArgs e)
        {
            VezaNaBazu.Open();
            if (txb_osobljeID.Text == "")
            {
                VezaNaBazu.Close();
                MessageBox.Show("Niste odabrali člana osoblja!");
                return;
            }
            else
            {
                string myquery = "UPDATE Osoblje_Table set OsobljeIme = '" + txb_osobljeIme.Text + "', OsobljeMob ='" + txb_osobljeMob.Text + "', OsobljePassword ='" + txb_osobljeLozinka.Text + "', OsobljeSpol ='" + cmbSpol.SelectedItem.ToString() + "'where OsobljeId =" + txb_osobljeID.Text + ";";
                SqlCommand cmd = new SqlCommand(myquery, VezaNaBazu);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Osoblje uspješno uređeno!");
                VezaNaBazu.Close();
                ispuniTablicu();
            }
        }

        private void btn_izbrisi_Click(object sender, EventArgs e)
        {
            VezaNaBazu.Open();
            if (txb_osobljeID.Text == "")
            {
                VezaNaBazu.Close();
                MessageBox.Show("Odaberite člana osoblja da bi bio izbrisan");
                return;
            }
            string query = "delete from Osoblje_Table where OsobljeId =" + txb_osobljeID.Text + "";
            SqlCommand cmd = new SqlCommand(query, VezaNaBazu);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Osoblje je uspješno izbrisano!");
            VezaNaBazu.Close();
            ispuniTablicu();
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
            if(txb_osobljepretraga.Text == "" ||txb_osobljepretraga.Text == "Pretraga osoblja")
            {
                VezaNaBazu.Close();
                MessageBox.Show("Unesite ime člana osoblja za pretragu");
                return;
            }
            string Myquery = "select * from Osoblje_Table where OsobljeIme = '" + txb_osobljepretraga.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, VezaNaBazu);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            OsobljeGridView.DataSource = ds.Tables[0];
            VezaNaBazu.Close();
        }

        private void btn_ponovnoUcitaj_Click(object sender, EventArgs e)
        {
            ispuniTablicu();
        }
    }
}
