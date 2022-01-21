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
    public partial class EvidencijaObroka : Form
    {

        SqlConnection VezaNaBazu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dajana\Desktop\UPI\UPI_Projekt\UPI_Final_demo\Final_demo_projekt\Baza\Database1.mdf;Integrated Security=True;Connect Timeout=30");

        int brojacUkupno = 0;
        int brojacFree = 0;
        int brojacPlatiti = 0;

        public void ispuniTablicu()
        {
            VezaNaBazu.Open();
            string Myquery = "select * from Rezervacije_Table ";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, VezaNaBazu);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            EvidencijaGridView.DataSource = ds.Tables[0];
            VezaNaBazu.Close();
        }

        public EvidencijaObroka()
        {
            InitializeComponent();
        }
        public Boolean IsNumber(String value)
        {
            return value.All(Char.IsDigit);
        }

        private void btn_evidentiraj_Click(object sender, EventArgs e)
        {
            VezaNaBazu.Open();
            string datumD = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            //nakon što se upiše broj ljudi(provjeri da nije prazno) klikom se upisuju podatci u bazu
            if (txb_brojSobe.Text == "" || !IsNumber(txb_brojSobe.Text) || txb_brojLjudi.Text == "" || !IsNumber(txb_brojLjudi.Text))
            {
                VezaNaBazu.Close();
                MessageBox.Show("Niste unijeli ispravne podatke! Pokušajte ponovno!");
                return;
            }
            //id_vecera upiši.... kako bi mogli izlistati sobe koje su taj dan bile na večeri
            //u infoVecera upisi datum/broj osoba ...to se nadodaje kako bi na kraju mogli vidjeti kojim sve danima je ta soba bila na večeri
            string myquery = "UPDATE Sobe_Table set InfoVecera = InfoVecera +'"
                + "#Datum:" + datumD + "/" + txb_brojSobe.Text + "//" + txb_brojLjudi.Text + "\r\n"
                + "',VeceraId ='" + datumD + "'where SobaId =" + txb_brojSobe.Text + ";";

            SqlCommand cmd = new SqlCommand(myquery, VezaNaBazu);
            cmd.ExecuteNonQuery();
            VezaNaBazu.Close();
            ispuniTablicu();
            rtb_infoOVeceri.Text = "";
            //sveukupan broj ljudi koji su bili na veceri 
            int ukupanBrojLjudi = int.Parse(txb_brojLjudi.Text);
            brojacUkupno += ukupanBrojLjudi;
            lbl_brojac.Text = brojacUkupno.ToString();
            VezaNaBazu.Open();
            string g = "Gost ima veceru.";
            //prema veceraFree se racuna broj ljudi koji su bili na veceri a imaju besplatnu veceru
            SqlCommand myqueryy = new SqlCommand("select VeceraFree from Sobe_Table where SobaId = '" + txb_brojSobe.Text + "'and VeceraFree = '" + g + "';", VezaNaBazu);

            SqlDataReader reader = myqueryy.ExecuteReader();
            string uvjet = reader.Read().ToString();
            if (uvjet == "True")
            {
                lbl_freeVecera.Text = (brojacFree + int.Parse(txb_brojLjudi.Text)).ToString();
                brojacFree += int.Parse(txb_brojLjudi.Text.ToString());
            }
            else
            {
                lbl_veceraPlatiti.Text = (brojacPlatiti + int.Parse(txb_brojLjudi.Text)).ToString();
                brojacPlatiti += int.Parse(txb_brojLjudi.Text.ToString());
            }
            VezaNaBazu.Close();

        }

        private void RezervacijaGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //odabranu sobu upiši u txb_brojSobe
            int i = e.RowIndex;
            DataGridViewRow row = EvidencijaGridView.Rows[i];
            txb_brojSobe.Text = row.Cells[0].Value.ToString();

        }

        private void EvidencijaObroka_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ispuniTablicu();
        }

        private void btn_pretraga_Click(object sender, EventArgs e)
        {
            VezaNaBazu.Open();
            if (!IsNumber(txb_pretragaSobe.Text) || txb_pretragaSobe.Text == "")
            {
                VezaNaBazu.Close();
                MessageBox.Show("Unesite broj sobe za pretragu!");
                return;
            }
            string Myquery = "select * from Sobe_Table where SobaId  = '" + txb_pretragaSobe.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, VezaNaBazu);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            EvidencijaGridView.DataSource = ds.Tables[0];
            VezaNaBazu.Close();

            VezaNaBazu.Open();
            SqlCommand Myqueryp = new SqlCommand("select InfoVecera from Sobe_Table where SobaId  = '" + txb_pretragaSobe.Text + "'", VezaNaBazu);
            //SqlCommandBuilder cbuilderp = new SqlCommandBuilder(dap);
            var dsp = new DataSet();
            //dap.Fill(dsp);

            SqlDataReader reader = Myqueryp.ExecuteReader();
            string b = (reader.Read().ToString());
            if (b == "True")
            {
                txb_brojSobe.Text = txb_pretragaSobe.Text;
                rtb_infoOVeceri.Text = reader.GetString(reader.GetOrdinal("InfoVecera"));
            }
            else
            {
                MessageBox.Show("Unijeli ste pogrešnu sobu!");
            }


            VezaNaBazu.Close();
        }

        private void btn_ponovnoUcitaj_Click(object sender, EventArgs e)
        {
            ispuniTablicu();
            rtb_infoOVeceri.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_datum.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void btn_povratak_Click(object sender, EventArgs e)
        {
            Izbornik glavna = new Izbornik();
            timer1.Stop();
            glavna.Show();
            this.Hide();
        }
    }
}
