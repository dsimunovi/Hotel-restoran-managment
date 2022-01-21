
namespace ProjektUpi
{
    partial class Rezervacije
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezervacije));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datumlb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_rezervacijaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateOut = new System.Windows.Forms.DateTimePicker();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.RezervacijaGridView = new System.Windows.Forms.DataGridView();
            this.btn_pretraga = new System.Windows.Forms.Button();
            this.btn_ponovnoUcitaj = new System.Windows.Forms.PictureBox();
            this.labela_pretrage = new System.Windows.Forms.Label();
            this.txb_rezervacijePretraga = new System.Windows.Forms.TextBox();
            this.btn_uredi = new System.Windows.Forms.Button();
            this.btn_izbrisi = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.cb_gost = new System.Windows.Forms.ComboBox();
            this.cb_BrojSobe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_povratak = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txb_brojsobe = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RezervacijaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ponovnoUcitaj)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.Datumlb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 77);
            this.panel1.TabIndex = 30;
            // 
            // Datumlb
            // 
            this.Datumlb.AutoSize = true;
            this.Datumlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datumlb.Location = new System.Drawing.Point(12, 9);
            this.Datumlb.Name = "Datumlb";
            this.Datumlb.Size = new System.Drawing.Size(64, 20);
            this.Datumlb.TabIndex = 95;
            this.Datumlb.Text = "Datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezervacije";
            // 
            // txb_rezervacijaID
            // 
            this.txb_rezervacijaID.Location = new System.Drawing.Point(21, 142);
            this.txb_rezervacijaID.Name = "txb_rezervacijaID";
            this.txb_rezervacijaID.Size = new System.Drawing.Size(158, 22);
            this.txb_rezervacijaID.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Odjava:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Prijava:";
            // 
            // dateOut
            // 
            this.dateOut.Location = new System.Drawing.Point(21, 390);
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(187, 22);
            this.dateOut.TabIndex = 48;
            this.dateOut.ValueChanged += new System.EventHandler(this.dateOut_ValueChanged);
            // 
            // dateIn
            // 
            this.dateIn.Location = new System.Drawing.Point(21, 328);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(187, 22);
            this.dateIn.TabIndex = 47;
            this.dateIn.ValueChanged += new System.EventHandler(this.dateIn_ValueChanged);
            // 
            // RezervacijaGridView
            // 
            this.RezervacijaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RezervacijaGridView.Location = new System.Drawing.Point(262, 133);
            this.RezervacijaGridView.Name = "RezervacijaGridView";
            this.RezervacijaGridView.RowHeadersWidth = 51;
            this.RezervacijaGridView.RowTemplate.Height = 24;
            this.RezervacijaGridView.Size = new System.Drawing.Size(768, 305);
            this.RezervacijaGridView.TabIndex = 51;
            this.RezervacijaGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RezervacijaGridView_CellContentClick);
            // 
            // btn_pretraga
            // 
            this.btn_pretraga.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_pretraga.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_pretraga.Location = new System.Drawing.Point(262, 96);
            this.btn_pretraga.Name = "btn_pretraga";
            this.btn_pretraga.Size = new System.Drawing.Size(101, 33);
            this.btn_pretraga.TabIndex = 86;
            this.btn_pretraga.Text = "Pretraga";
            this.btn_pretraga.UseVisualStyleBackColor = false;
            this.btn_pretraga.Click += new System.EventHandler(this.btn_pretraga_Click);
            // 
            // btn_ponovnoUcitaj
            // 
            this.btn_ponovnoUcitaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ponovnoUcitaj.Image = ((System.Drawing.Image)(resources.GetObject("btn_ponovnoUcitaj.Image")));
            this.btn_ponovnoUcitaj.Location = new System.Drawing.Point(553, 96);
            this.btn_ponovnoUcitaj.Name = "btn_ponovnoUcitaj";
            this.btn_ponovnoUcitaj.Size = new System.Drawing.Size(31, 35);
            this.btn_ponovnoUcitaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_ponovnoUcitaj.TabIndex = 85;
            this.btn_ponovnoUcitaj.TabStop = false;
            this.btn_ponovnoUcitaj.Click += new System.EventHandler(this.btn_ponovnoUcitaj_Click);
            // 
            // labela_pretrage
            // 
            this.labela_pretrage.AutoSize = true;
            this.labela_pretrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela_pretrage.Location = new System.Drawing.Point(470, 96);
            this.labela_pretrage.Name = "labela_pretrage";
            this.labela_pretrage.Size = new System.Drawing.Size(0, 20);
            this.labela_pretrage.TabIndex = 84;
            // 
            // txb_rezervacijePretraga
            // 
            this.txb_rezervacijePretraga.Location = new System.Drawing.Point(378, 101);
            this.txb_rezervacijePretraga.Name = "txb_rezervacijePretraga";
            this.txb_rezervacijePretraga.Size = new System.Drawing.Size(158, 22);
            this.txb_rezervacijePretraga.TabIndex = 83;
            this.txb_rezervacijePretraga.Text = "Pretraga rezervacija";
            // 
            // btn_uredi
            // 
            this.btn_uredi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_uredi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_uredi.Location = new System.Drawing.Point(91, 444);
            this.btn_uredi.Name = "btn_uredi";
            this.btn_uredi.Size = new System.Drawing.Size(64, 33);
            this.btn_uredi.TabIndex = 90;
            this.btn_uredi.Text = "Uredi";
            this.btn_uredi.UseVisualStyleBackColor = false;
            this.btn_uredi.Click += new System.EventHandler(this.btn_uredi_Click);
            // 
            // btn_izbrisi
            // 
            this.btn_izbrisi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_izbrisi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_izbrisi.Location = new System.Drawing.Point(161, 444);
            this.btn_izbrisi.Name = "btn_izbrisi";
            this.btn_izbrisi.Size = new System.Drawing.Size(64, 33);
            this.btn_izbrisi.TabIndex = 89;
            this.btn_izbrisi.Text = "Izbriši";
            this.btn_izbrisi.UseVisualStyleBackColor = false;
            this.btn_izbrisi.Click += new System.EventHandler(this.btn_izbrisi_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_dodaj.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_dodaj.Location = new System.Drawing.Point(21, 444);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(64, 33);
            this.btn_dodaj.TabIndex = 88;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = false;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // cb_gost
            // 
            this.cb_gost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_gost.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cb_gost.FormattingEnabled = true;
            this.cb_gost.Location = new System.Drawing.Point(21, 203);
            this.cb_gost.Name = "cb_gost";
            this.cb_gost.Size = new System.Drawing.Size(158, 24);
            this.cb_gost.TabIndex = 91;
            this.cb_gost.Text = "Gost";
            // 
            // cb_BrojSobe
            // 
            this.cb_BrojSobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_BrojSobe.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cb_BrojSobe.FormattingEnabled = true;
            this.cb_BrojSobe.Location = new System.Drawing.Point(21, 267);
            this.cb_BrojSobe.Name = "cb_BrojSobe";
            this.cb_BrojSobe.Size = new System.Drawing.Size(158, 24);
            this.cb_BrojSobe.TabIndex = 92;
            this.cb_BrojSobe.Text = "Broj sobe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Gost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 94;
            this.label4.Text = "Soba:";
            // 
            // btn_povratak
            // 
            this.btn_povratak.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_povratak.Location = new System.Drawing.Point(67, 499);
            this.btn_povratak.Name = "btn_povratak";
            this.btn_povratak.Size = new System.Drawing.Size(88, 33);
            this.btn_povratak.TabIndex = 95;
            this.btn_povratak.Text = "Povratak";
            this.btn_povratak.UseVisualStyleBackColor = false;
            this.btn_povratak.Click += new System.EventHandler(this.btn_povratak_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txb_brojsobe
            // 
            this.txb_brojsobe.Location = new System.Drawing.Point(185, 269);
            this.txb_brojsobe.Name = "txb_brojsobe";
            this.txb_brojsobe.Size = new System.Drawing.Size(71, 22);
            this.txb_brojsobe.TabIndex = 97;
            // 
            // Rezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 558);
            this.Controls.Add(this.txb_brojsobe);
            this.Controls.Add(this.btn_povratak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_BrojSobe);
            this.Controls.Add(this.cb_gost);
            this.Controls.Add(this.btn_uredi);
            this.Controls.Add(this.btn_izbrisi);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.btn_pretraga);
            this.Controls.Add(this.btn_ponovnoUcitaj);
            this.Controls.Add(this.labela_pretrage);
            this.Controls.Add(this.txb_rezervacijePretraga);
            this.Controls.Add(this.RezervacijaGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateOut);
            this.Controls.Add(this.dateIn);
            this.Controls.Add(this.txb_rezervacijaID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Rezervacije";
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.Rezervacije_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RezervacijaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ponovnoUcitaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_rezervacijaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateOut;
        private System.Windows.Forms.DateTimePicker dateIn;
        private System.Windows.Forms.DataGridView RezervacijaGridView;
        private System.Windows.Forms.Button btn_pretraga;
        private System.Windows.Forms.PictureBox btn_ponovnoUcitaj;
        private System.Windows.Forms.Label labela_pretrage;
        private System.Windows.Forms.TextBox txb_rezervacijePretraga;
        private System.Windows.Forms.Button btn_uredi;
        private System.Windows.Forms.Button btn_izbrisi;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.ComboBox cb_gost;
        private System.Windows.Forms.ComboBox cb_BrojSobe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Datumlb;
        private System.Windows.Forms.Button btn_povratak;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txb_brojsobe;
    }
}