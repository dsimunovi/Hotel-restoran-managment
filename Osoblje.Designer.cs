
namespace ProjektUpi
{
    partial class Osoblje
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Osoblje));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Datumlb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_osobljeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_osobljeIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_osobljeMob = new System.Windows.Forms.TextBox();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.btn_uredi = new System.Windows.Forms.Button();
            this.btn_izbrisi = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.OsobljeGridView = new System.Windows.Forms.DataGridView();
            this.labela_pretrage = new System.Windows.Forms.Label();
            this.txb_osobljepretraga = new System.Windows.Forms.TextBox();
            this.btn_ponovnoUcitaj = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_osobljeLozinka = new System.Windows.Forms.TextBox();
            this.btn_pretraga = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_povratak = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OsobljeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ponovnoUcitaj)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.Datumlb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 77);
            this.panel2.TabIndex = 51;
            // 
            // Datumlb
            // 
            this.Datumlb.AutoSize = true;
            this.Datumlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datumlb.Location = new System.Drawing.Point(12, 9);
            this.Datumlb.Name = "Datumlb";
            this.Datumlb.Size = new System.Drawing.Size(64, 20);
            this.Datumlb.TabIndex = 2;
            this.Datumlb.Text = "Datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(435, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Osoblje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "ID:";
            // 
            // txb_osobljeID
            // 
            this.txb_osobljeID.Location = new System.Drawing.Point(16, 114);
            this.txb_osobljeID.Name = "txb_osobljeID";
            this.txb_osobljeID.Size = new System.Drawing.Size(158, 22);
            this.txb_osobljeID.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Ime i prezime:";
            // 
            // txb_osobljeIme
            // 
            this.txb_osobljeIme.Location = new System.Drawing.Point(16, 172);
            this.txb_osobljeIme.Name = "txb_osobljeIme";
            this.txb_osobljeIme.Size = new System.Drawing.Size(158, 22);
            this.txb_osobljeIme.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Broj mobitela:";
            // 
            // txb_osobljeMob
            // 
            this.txb_osobljeMob.Location = new System.Drawing.Point(16, 230);
            this.txb_osobljeMob.Name = "txb_osobljeMob";
            this.txb_osobljeMob.Size = new System.Drawing.Size(158, 22);
            this.txb_osobljeMob.TabIndex = 69;
            // 
            // cmbSpol
            // 
            this.cmbSpol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.cmbSpol.Location = new System.Drawing.Point(16, 315);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(158, 28);
            this.cmbSpol.TabIndex = 70;
            this.cmbSpol.Text = "Spol";
            // 
            // btn_uredi
            // 
            this.btn_uredi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_uredi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_uredi.Location = new System.Drawing.Point(86, 361);
            this.btn_uredi.Name = "btn_uredi";
            this.btn_uredi.Size = new System.Drawing.Size(64, 33);
            this.btn_uredi.TabIndex = 74;
            this.btn_uredi.Text = "Uredi";
            this.btn_uredi.UseVisualStyleBackColor = false;
            this.btn_uredi.Click += new System.EventHandler(this.btn_uredi_Click);
            // 
            // btn_izbrisi
            // 
            this.btn_izbrisi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_izbrisi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_izbrisi.Location = new System.Drawing.Point(154, 361);
            this.btn_izbrisi.Name = "btn_izbrisi";
            this.btn_izbrisi.Size = new System.Drawing.Size(64, 33);
            this.btn_izbrisi.TabIndex = 73;
            this.btn_izbrisi.Text = "Izbriši";
            this.btn_izbrisi.UseVisualStyleBackColor = false;
            this.btn_izbrisi.Click += new System.EventHandler(this.btn_izbrisi_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_dodaj.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_dodaj.Location = new System.Drawing.Point(16, 361);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(64, 33);
            this.btn_dodaj.TabIndex = 72;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = false;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // OsobljeGridView
            // 
            this.OsobljeGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.OsobljeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OsobljeGridView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.OsobljeGridView.Location = new System.Drawing.Point(224, 129);
            this.OsobljeGridView.Name = "OsobljeGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OsobljeGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OsobljeGridView.RowHeadersWidth = 51;
            this.OsobljeGridView.RowTemplate.Height = 24;
            this.OsobljeGridView.Size = new System.Drawing.Size(736, 294);
            this.OsobljeGridView.TabIndex = 75;
            this.OsobljeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OsobljeGridView_CellContentClick);
            // 
            // labela_pretrage
            // 
            this.labela_pretrage.AutoSize = true;
            this.labela_pretrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela_pretrage.Location = new System.Drawing.Point(229, 97);
            this.labela_pretrage.Name = "labela_pretrage";
            this.labela_pretrage.Size = new System.Drawing.Size(0, 20);
            this.labela_pretrage.TabIndex = 78;
            // 
            // txb_osobljepretraga
            // 
            this.txb_osobljepretraga.Location = new System.Drawing.Point(330, 97);
            this.txb_osobljepretraga.Name = "txb_osobljepretraga";
            this.txb_osobljepretraga.Size = new System.Drawing.Size(158, 22);
            this.txb_osobljepretraga.TabIndex = 77;
            this.txb_osobljepretraga.Text = "Pretraga osoblja";
            // 
            // btn_ponovnoUcitaj
            // 
            this.btn_ponovnoUcitaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ponovnoUcitaj.Image = ((System.Drawing.Image)(resources.GetObject("btn_ponovnoUcitaj.Image")));
            this.btn_ponovnoUcitaj.Location = new System.Drawing.Point(494, 91);
            this.btn_ponovnoUcitaj.Name = "btn_ponovnoUcitaj";
            this.btn_ponovnoUcitaj.Size = new System.Drawing.Size(31, 35);
            this.btn_ponovnoUcitaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_ponovnoUcitaj.TabIndex = 79;
            this.btn_ponovnoUcitaj.TabStop = false;
            this.btn_ponovnoUcitaj.Click += new System.EventHandler(this.btn_ponovnoUcitaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "Lozinka :";
            // 
            // txb_osobljeLozinka
            // 
            this.txb_osobljeLozinka.Location = new System.Drawing.Point(16, 276);
            this.txb_osobljeLozinka.Name = "txb_osobljeLozinka";
            this.txb_osobljeLozinka.Size = new System.Drawing.Size(158, 22);
            this.txb_osobljeLozinka.TabIndex = 81;
            // 
            // btn_pretraga
            // 
            this.btn_pretraga.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_pretraga.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_pretraga.Location = new System.Drawing.Point(223, 90);
            this.btn_pretraga.Name = "btn_pretraga";
            this.btn_pretraga.Size = new System.Drawing.Size(101, 33);
            this.btn_pretraga.TabIndex = 82;
            this.btn_pretraga.Text = "Pretraga";
            this.btn_pretraga.UseVisualStyleBackColor = false;
            this.btn_pretraga.Click += new System.EventHandler(this.btn_pretraga_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_povratak
            // 
            this.btn_povratak.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_povratak.Location = new System.Drawing.Point(62, 405);
            this.btn_povratak.Name = "btn_povratak";
            this.btn_povratak.Size = new System.Drawing.Size(88, 33);
            this.btn_povratak.TabIndex = 96;
            this.btn_povratak.Text = "Povratak";
            this.btn_povratak.UseVisualStyleBackColor = false;
            this.btn_povratak.Click += new System.EventHandler(this.btn_povratak_Click);
            // 
            // Osoblje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.btn_povratak);
            this.Controls.Add(this.btn_pretraga);
            this.Controls.Add(this.txb_osobljeLozinka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ponovnoUcitaj);
            this.Controls.Add(this.labela_pretrage);
            this.Controls.Add(this.txb_osobljepretraga);
            this.Controls.Add(this.OsobljeGridView);
            this.Controls.Add(this.btn_uredi);
            this.Controls.Add(this.btn_izbrisi);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.cmbSpol);
            this.Controls.Add(this.txb_osobljeMob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_osobljeIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_osobljeID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Name = "Osoblje";
            this.Text = "Osoblje";
            this.Load += new System.EventHandler(this.Osoblje_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OsobljeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ponovnoUcitaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_osobljeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_osobljeIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_osobljeMob;
        private System.Windows.Forms.ComboBox cmbSpol;
        private System.Windows.Forms.Button btn_uredi;
        private System.Windows.Forms.Button btn_izbrisi;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.DataGridView OsobljeGridView;
        private System.Windows.Forms.Label labela_pretrage;
        private System.Windows.Forms.TextBox txb_osobljepretraga;
        private System.Windows.Forms.Label Datumlb;
        private System.Windows.Forms.PictureBox btn_ponovnoUcitaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_osobljeLozinka;
        private System.Windows.Forms.Button btn_pretraga;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_povratak;
    }
}