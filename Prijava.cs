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
    public partial class Prijava : Form
    {
        SqlConnection VezaNaBazu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dajana\Desktop\UPI\UPI_Projekt\UPI_Final_demo\Final_demo_projekt\Baza\Database1.mdf;Integrated Security=True;Connect Timeout=30");

        public Prijava()
        {
            InitializeComponent();
        }

        private void btn_prijava_Click(object sender, EventArgs e)
        {
            VezaNaBazu.Open();
            
            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Osoblje_Table where OsobljeIme='" + txb_korisnickoime.Text + "' and OsobljePassword='" + txb_lozinka.Text + "' ", VezaNaBazu);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Izbornik formaIzbornik = new Izbornik();
                formaIzbornik.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka! Pokušajte ponovno.");
            }
            VezaNaBazu.Close();
        }
    }
}
