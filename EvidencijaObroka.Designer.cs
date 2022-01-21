
namespace ProjektUpi
{
    partial class EvidencijaObroka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvidencijaObroka));
            this.txb_pretragaSobe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EvidencijaGridView = new System.Windows.Forms.DataGridView();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_brojac = new System.Windows.Forms.Label();
            this.btn_pretraga = new System.Windows.Forms.Button();
            this.txb_brojSobe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_brojLjudi = new System.Windows.Forms.TextBox();
            this.btn_evidentiraj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_veceraPlatiti = new System.Windows.Forms.Label();
            this.lbl_freeVecera = new System.Windows.Forms.Label();
            this.lbl_provjera = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_ponovnoUcitaj = new System.Windows.Forms.PictureBox();
            this.btn_povratak = new System.Windows.Forms.Button();
            this.rtb_infoOVeceri = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EvidencijaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ponovnoUcitaj)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_pretragaSobe
            // 
            this.txb_pretragaSobe.Location = new System.Drawing.Point(145, 67);
            this.txb_pretragaSobe.Name = "txb_pretragaSobe";
            this.txb_pretragaSobe.Size = new System.Drawing.Size(82, 22);
            this.txb_pretragaSobe.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 77;
            this.label1.Text = "Unesite broj sobe :";
            // 
            // EvidencijaGridView
            // 
            this.EvidencijaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EvidencijaGridView.Location = new System.Drawing.Point(15, 107);
            this.EvidencijaGridView.Name = "EvidencijaGridView";
            this.EvidencijaGridView.RowHeadersWidth = 51;
            this.EvidencijaGridView.RowTemplate.Height = 24;
            this.EvidencijaGridView.Size = new System.Drawing.Size(940, 639);
            this.EvidencijaGridView.TabIndex = 78;
            this.EvidencijaGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RezervacijaGridView_CellContentClick);
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datum.Location = new System.Drawing.Point(12, 9);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(64, 20);
            this.lbl_datum.TabIndex = 96;
            this.lbl_datum.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 17);
            this.label2.TabIndex = 97;
            this.label2.Text = "Broj ljudi koji su ušli u restoran : ";
            // 
            // lbl_brojac
            // 
            this.lbl_brojac.AutoSize = true;
            this.lbl_brojac.Location = new System.Drawing.Point(961, 12);
            this.lbl_brojac.Name = "lbl_brojac";
            this.lbl_brojac.Size = new System.Drawing.Size(16, 17);
            this.lbl_brojac.TabIndex = 98;
            this.lbl_brojac.Text = "0";
            // 
            // btn_pretraga
            // 
            this.btn_pretraga.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_pretraga.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_pretraga.Location = new System.Drawing.Point(243, 65);
            this.btn_pretraga.Name = "btn_pretraga";
            this.btn_pretraga.Size = new System.Drawing.Size(75, 27);
            this.btn_pretraga.TabIndex = 99;
            this.btn_pretraga.Text = "Pretraga";
            this.btn_pretraga.UseVisualStyleBackColor = false;
            this.btn_pretraga.Click += new System.EventHandler(this.btn_pretraga_Click);
            // 
            // txb_brojSobe
            // 
            this.txb_brojSobe.Location = new System.Drawing.Point(280, 792);
            this.txb_brojSobe.Name = "txb_brojSobe";
            this.txb_brojSobe.ReadOnly = true;
            this.txb_brojSobe.Size = new System.Drawing.Size(82, 22);
            this.txb_brojSobe.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 772);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 101;
            this.label3.Text = "Soba";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 772);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 102;
            this.label4.Text = "Broj ljudi";
            // 
            // txb_brojLjudi
            // 
            this.txb_brojLjudi.Location = new System.Drawing.Point(377, 792);
            this.txb_brojLjudi.Name = "txb_brojLjudi";
            this.txb_brojLjudi.Size = new System.Drawing.Size(82, 22);
            this.txb_brojLjudi.TabIndex = 103;
            // 
            // btn_evidentiraj
            // 
            this.btn_evidentiraj.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_evidentiraj.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_evidentiraj.Location = new System.Drawing.Point(485, 774);
            this.btn_evidentiraj.Name = "btn_evidentiraj";
            this.btn_evidentiraj.Size = new System.Drawing.Size(115, 45);
            this.btn_evidentiraj.TabIndex = 104;
            this.btn_evidentiraj.Text = "Evidentiraj";
            this.btn_evidentiraj.UseVisualStyleBackColor = false;
            this.btn_evidentiraj.Click += new System.EventHandler(this.btn_evidentiraj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 17);
            this.label5.TabIndex = 105;
            this.label5.Text = "Broj ljudi koji nemaju besplatnu večeru : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(706, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 17);
            this.label6.TabIndex = 106;
            this.label6.Text = "Broj ljudi koji imaju besplatnu večeru : ";
            // 
            // lbl_veceraPlatiti
            // 
            this.lbl_veceraPlatiti.AutoSize = true;
            this.lbl_veceraPlatiti.Location = new System.Drawing.Point(961, 40);
            this.lbl_veceraPlatiti.Name = "lbl_veceraPlatiti";
            this.lbl_veceraPlatiti.Size = new System.Drawing.Size(16, 17);
            this.lbl_veceraPlatiti.TabIndex = 107;
            this.lbl_veceraPlatiti.Text = "0";
            // 
            // lbl_freeVecera
            // 
            this.lbl_freeVecera.AutoSize = true;
            this.lbl_freeVecera.Location = new System.Drawing.Point(961, 67);
            this.lbl_freeVecera.Name = "lbl_freeVecera";
            this.lbl_freeVecera.Size = new System.Drawing.Size(16, 17);
            this.lbl_freeVecera.TabIndex = 108;
            this.lbl_freeVecera.Text = "0";
            // 
            // lbl_provjera
            // 
            this.lbl_provjera.AutoSize = true;
            this.lbl_provjera.Location = new System.Drawing.Point(12, 795);
            this.lbl_provjera.Name = "lbl_provjera";
            this.lbl_provjera.Size = new System.Drawing.Size(254, 17);
            this.lbl_provjera.TabIndex = 109;
            this.lbl_provjera.Text = "Broj sobe i ljudi koji su ušli u restoran : ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_ponovnoUcitaj
            // 
            this.btn_ponovnoUcitaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ponovnoUcitaj.Image = ((System.Drawing.Image)(resources.GetObject("btn_ponovnoUcitaj.Image")));
            this.btn_ponovnoUcitaj.Location = new System.Drawing.Point(341, 67);
            this.btn_ponovnoUcitaj.Name = "btn_ponovnoUcitaj";
            this.btn_ponovnoUcitaj.Size = new System.Drawing.Size(21, 25);
            this.btn_ponovnoUcitaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_ponovnoUcitaj.TabIndex = 110;
            this.btn_ponovnoUcitaj.TabStop = false;
            this.btn_ponovnoUcitaj.Click += new System.EventHandler(this.btn_ponovnoUcitaj_Click);
            // 
            // btn_povratak
            // 
            this.btn_povratak.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_povratak.Location = new System.Drawing.Point(12, 32);
            this.btn_povratak.Name = "btn_povratak";
            this.btn_povratak.Size = new System.Drawing.Size(78, 33);
            this.btn_povratak.TabIndex = 111;
            this.btn_povratak.Text = "Povratak";
            this.btn_povratak.UseVisualStyleBackColor = false;
            this.btn_povratak.Click += new System.EventHandler(this.btn_povratak_Click);
            // 
            // rtb_infoOVeceri
            // 
            this.rtb_infoOVeceri.Location = new System.Drawing.Point(1119, 107);
            this.rtb_infoOVeceri.Name = "rtb_infoOVeceri";
            this.rtb_infoOVeceri.Size = new System.Drawing.Size(379, 639);
            this.rtb_infoOVeceri.TabIndex = 112;
            this.rtb_infoOVeceri.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1210, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 17);
            this.label7.TabIndex = 113;
            this.label7.Text = "Detaljne informacije o večeri: ";
            // 
            // EvidencijaObroka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 831);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtb_infoOVeceri);
            this.Controls.Add(this.btn_povratak);
            this.Controls.Add(this.btn_ponovnoUcitaj);
            this.Controls.Add(this.lbl_provjera);
            this.Controls.Add(this.lbl_freeVecera);
            this.Controls.Add(this.lbl_veceraPlatiti);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_evidentiraj);
            this.Controls.Add(this.txb_brojLjudi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_brojSobe);
            this.Controls.Add(this.btn_pretraga);
            this.Controls.Add(this.lbl_brojac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.EvidencijaGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_pretragaSobe);
            this.Name = "EvidencijaObroka";
            this.Text = "EvidencijaObroka";
            this.Load += new System.EventHandler(this.EvidencijaObroka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EvidencijaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ponovnoUcitaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_pretragaSobe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView EvidencijaGridView;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_brojac;
        private System.Windows.Forms.Button btn_pretraga;
        private System.Windows.Forms.TextBox txb_brojSobe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_brojLjudi;
        private System.Windows.Forms.Button btn_evidentiraj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_veceraPlatiti;
        private System.Windows.Forms.Label lbl_freeVecera;
        private System.Windows.Forms.Label lbl_provjera;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox btn_ponovnoUcitaj;
        private System.Windows.Forms.Button btn_povratak;
        private System.Windows.Forms.RichTextBox rtb_infoOVeceri;
        private System.Windows.Forms.Label label7;
    }
}