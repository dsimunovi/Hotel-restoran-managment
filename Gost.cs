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
    public partial class Gost : Form
    {
        SqlConnection VezaNaBazu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dajana\Desktop\UPI\UPI_Projekt\UPI_Final_demo\Final_demo_projekt\Baza\Database1.mdf;Integrated Security=True;Connect Timeout=30");

        public void ispuniTablicu()
        {
            VezaNaBazu.Open();
            string Myquery = "select * from Gost_Table";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, VezaNaBazu);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Gost_GridView.DataSource = ds.Tables[0];
            VezaNaBazu.Close();
        }

        public Boolean IsNumber(String value)
        {
            return value.All(Char.IsDigit);
        }
        public Gost()
        {
            InitializeComponent();
        }

        private void Gost_Load(object sender, EventArgs e)
        {
            ispuniTablicu();
            timer1.Start();
        }

        private void Gost_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = Gost_GridView.Rows[i];
            GostIdtxb.Text = row.Cells[0].Value.ToString();
            GostImetxb.Text = row.Cells[1].Value.ToString();
            GostMobiteltxb.Text = row.Cells[2].Value.ToString();
        }  

        private void btn_pretraga_Click(object sender, EventArgs e)
        {
            VezaNaBazu.Open();
            if (gostPretraga.Text == "" || gostPretraga.Text == "Pretraga gosta")
            {
                VezaNaBazu.Close();
                MessageBox.Show("Unesite ime i prezime gosta za pretragu");
                return;
            }
            string Myquery = "select * from Gost_Table where GostIme = '" + gostPretraga.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, VezaNaBazu);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Gost_GridView.DataSource = ds.Tables[0];
            VezaNaBazu.Close();
        }

        private void btn_ponovnoUcitaj_Click(object sender, EventArgs e)
        {
            ispuniTablicu();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            VezaNaBazu.Open();
            if(GostIdtxb.Text == "" || !IsNumber(GostIdtxb.Text) || GostImetxb.Text == "" || IsNumber(GostImetxb.Text) || GostMobiteltxb.Text == "" || !IsNumber(GostMobiteltxb.Text)  || cmbDrzave.SelectedIndex < 0)
            {
                VezaNaBazu.Close();
                MessageBox.Show("Nisu uneseni svi podaci!\n Krivo uneseni podaci!");
                return;
            }
            SqlCommand cmd2 = new SqlCommand("Select * from Gost_Table where GostId=@GostId", VezaNaBazu);
            cmd2.Parameters.AddWithValue("GostId", GostIdtxb.Text);
            SqlDataReader myreader = cmd2.ExecuteReader();
            if(myreader.Read())
            {
                VezaNaBazu.Close();
                MessageBox.Show("Gost s unesenim ID već postoji!");
            }
            else
            {
                VezaNaBazu.Close();
                SqlCommand cmd = new SqlCommand("insert into Gost_Table values(" + GostIdtxb.Text + ", '" + GostImetxb.Text + "', '" + GostMobiteltxb.Text + "', '" + cmbDrzave.SelectedItem.ToString() + "' )", VezaNaBazu);
                cmd.Parameters.AddWithValue("GostId", GostIdtxb.Text);
                VezaNaBazu.Open();
                cmd.ExecuteNonQuery();
                VezaNaBazu.Close();
                MessageBox.Show("Gost uspješno dodan!");
                ispuniTablicu();
            }
        }

        private void btn_izbrisi_Click(object sender, EventArgs e)
        {
            VezaNaBazu.Open();
            if(GostIdtxb.Text == "")
            {
                VezaNaBazu.Close();
                MessageBox.Show("Odaberite gosta da bi bio izbrisan");
                return;
            }
            string query = "delete from Gost_Table where GostId =" + GostIdtxb.Text + "";
            SqlCommand cmd = new SqlCommand(query, VezaNaBazu);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Gost je uspješno izbrisan!");
            VezaNaBazu.Close();
            ispuniTablicu();
        }

        private void btn_povratak_Click(object sender, EventArgs e)
        {
            Izbornik glavna = new Izbornik();
            timer1.Stop();
            glavna.Show();
            this.Hide();
        }

        private void btn_uredi_Click(object sender, EventArgs e)
        {
            VezaNaBazu.Open();
            if (GostIdtxb.Text == "")
            {
                VezaNaBazu.Close();
                MessageBox.Show("Niste odabrali gosta!");
                return;
            }
            else
            {
                string myquery = "UPDATE Gost_Table set GostIme = '" + GostImetxb.Text + "',GostMob ='" + GostMobiteltxb.Text + "',GostDrzava ='" + cmbDrzave.SelectedItem.ToString() + "'where GostId =" + GostIdtxb.Text + ";";
                SqlCommand cmd = new SqlCommand(myquery, VezaNaBazu);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Gost uspješno uređen!");
                VezaNaBazu.Close();
                ispuniTablicu();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datumlb.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }
    }
}
