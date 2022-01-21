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
    public partial class Sobe : Form
    {
        SqlConnection VezaNaBazu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dajana\Desktop\UPI\UPI_Projekt\UPI_Final_demo\Final_demo_projekt\Baza\Database1.mdf;Integrated Security=True;Connect Timeout=30");

        public void ispuniTablicu()
        {
            VezaNaBazu.Open();
            string Myquery = "select * from Sobe_Table";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, VezaNaBazu);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            SobeGridView.DataSource = ds.Tables[0];
            VezaNaBazu.Close();
        }

        public Boolean IsNumber(String value)
        {
            return value.All(Char.IsDigit);
        }
        public Sobe()
        {
            InitializeComponent();
        }


        private void SobeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = SobeGridView.Rows[i];
            SobaIdtxb.Text = row.Cells[0].Value.ToString();
            SobaTelefontxb.Text = row.Cells[1].Value.ToString();
        }

        private void Sobe_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ispuniTablicu();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            string vecerafree;
            string sobazauzeta = "NE";
            if (rb_daVecera.Checked == true)
                vecerafree = "Gost ima veceru.";
            else
                vecerafree = "Gost nema veceru.";

            /*if (rb_daSoba.Checked == true)
                sobanotfree = "DA";
            else
                sobanotfree = "NE"; */

            VezaNaBazu.Open();
            if (SobaIdtxb.Text == "" || !IsNumber(SobaIdtxb.Text) || SobaTelefontxb.Text == "" || !IsNumber(SobaTelefontxb.Text))
            {
                VezaNaBazu.Close();
                MessageBox.Show("Nisu uneseni svi podaci!\n Krivo uneseni podaci!");
                return;
            }
            SqlCommand cmd2 = new SqlCommand("Select * from Sobe_Table where SobaId=@SobaId", VezaNaBazu);
            cmd2.Parameters.AddWithValue("SobaId", SobaIdtxb.Text);
            SqlDataReader myreader = cmd2.ExecuteReader();
            if (myreader.Read())
            {
                VezaNaBazu.Close();
                MessageBox.Show("Soba s unesenim ID već postoji!");
            }
            else
            {
                VezaNaBazu.Close();
                SqlCommand cmd = new SqlCommand("insert into Sobe_Table values(" + SobaIdtxb.Text + ", '" + SobaTelefontxb.Text + "', '" + vecerafree + "', '" + sobazauzeta + "', '" + "Informacije o veceri:" + "', '" + "" + "')", VezaNaBazu);

                cmd.Parameters.AddWithValue("SobaId", SobaIdtxb.Text);
                VezaNaBazu.Open();
                cmd.ExecuteNonQuery();
                VezaNaBazu.Close();
                MessageBox.Show("Soba uspješno dodana!");
                ispuniTablicu();
            }


        }

        private void btn_uredi_Click(object sender, EventArgs e)
        {
            string vecerafree;
            if (rb_daVecera.Checked == true)
                vecerafree = "Gost ima veceru.";
            else
                vecerafree = "Gost nema veceru.";
            VezaNaBazu.Open();
            if (SobaIdtxb.Text == "")
            {
                VezaNaBazu.Close();
                MessageBox.Show("Niste odabrali sobu!");
                return;
            }
            else
            {
                string myquery = "UPDATE Sobe_Table set SobaTelefon = '" + SobaTelefontxb.Text + "',VeceraFree ='" + vecerafree + "'where SobaId =" + SobaIdtxb.Text + ";";
                SqlCommand cmd = new SqlCommand(myquery, VezaNaBazu);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Soba uspješno uređena!");
                VezaNaBazu.Close();
                ispuniTablicu();
            }
        }

        private void btn_izbrisi_Click(object sender, EventArgs e)
        {
            VezaNaBazu.Open();
            if (SobaIdtxb.Text == "")
            {
                VezaNaBazu.Close();
                MessageBox.Show("Odaberite sobu da bi bila izbrisana");
                return;
            }
            string query = "delete from Sobe_Table where SobaId =" + SobaIdtxb.Text + "";
            SqlCommand cmd = new SqlCommand(query, VezaNaBazu);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Soba je uspjesno izbrisana!");
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

        private void btn_pretraga_Click(object sender, EventArgs e)
        {
            VezaNaBazu.Open();
            if (!IsNumber(sobaPretraga.Text))
            {
                VezaNaBazu.Close();
                MessageBox.Show("Unesite broj sobe za pretragu");
                return;
            }
            string Myquery = "select * from Sobe_Table where SobaId  = '" + sobaPretraga.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, VezaNaBazu);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            SobeGridView.DataSource = ds.Tables[0];
            VezaNaBazu.Close();
        }

        private void btn_ponovnoUcitaj_Click(object sender, EventArgs e)
        {
            ispuniTablicu();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datumlb.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }
    }
}
