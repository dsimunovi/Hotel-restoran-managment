
namespace ProjektUpi
{
    partial class Sobe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sobe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datumlb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SobaTelefontxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SobaIdtxb = new System.Windows.Forms.TextBox();
            this.rb_neVecera = new System.Windows.Forms.RadioButton();
            this.rb_daVecera = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_uredi = new System.Windows.Forms.Button();
            this.btn_izbrisi = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.SobeGridView = new System.Windows.Forms.DataGridView();
            this.btn_pretraga = new System.Windows.Forms.Button();
            this.sobaPretraga = new System.Windows.Forms.TextBox();
            this.btn_ponovnoUcitaj = new System.Windows.Forms.PictureBox();
            this.btn_povratak = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SobeGridView)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1104, 77);
            this.panel1.TabIndex = 15;
            // 
            // Datumlb
            // 
            this.Datumlb.AutoSize = true;
            this.Datumlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datumlb.Location = new System.Drawing.Point(12, 9);
            this.Datumlb.Name = "Datumlb";
            this.Datumlb.Size = new System.Drawing.Size(64, 20);
            this.Datumlb.TabIndex = 3;
            this.Datumlb.Text = "Datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sobe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Telefon:";
            // 
            // SobaTelefontxb
            // 
            this.SobaTelefontxb.Location = new System.Drawing.Point(22, 211);
            this.SobaTelefontxb.Name = "SobaTelefontxb";
            this.SobaTelefontxb.Size = new System.Drawing.Size(158, 22);
            this.SobaTelefontxb.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Broj sobe:";
            // 
            // SobaIdtxb
            // 
            this.SobaIdtxb.Location = new System.Drawing.Point(22, 144);
            this.SobaIdtxb.Name = "SobaIdtxb";
            this.SobaIdtxb.Size = new System.Drawing.Size(158, 22);
            this.SobaIdtxb.TabIndex = 22;
            // 
            // rb_neVecera
            // 
            this.rb_neVecera.AutoSize = true;
            this.rb_neVecera.Location = new System.Drawing.Point(92, 270);
            this.rb_neVecera.Name = "rb_neVecera";
            this.rb_neVecera.Size = new System.Drawing.Size(47, 21);
            this.rb_neVecera.TabIndex = 33;
            this.rb_neVecera.Text = "Ne";
            this.rb_neVecera.UseVisualStyleBackColor = true;
            // 
            // rb_daVecera
            // 
            this.rb_daVecera.AutoSize = true;
            this.rb_daVecera.Checked = true;
            this.rb_daVecera.Location = new System.Drawing.Point(22, 270);
            this.rb_daVecera.Name = "rb_daVecera";
            this.rb_daVecera.Size = new System.Drawing.Size(47, 21);
            this.rb_daVecera.TabIndex = 32;
            this.rb_daVecera.TabStop = true;
            this.rb_daVecera.Text = "Da";
            this.rb_daVecera.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Vecera:";
            // 
            // btn_uredi
            // 
            this.btn_uredi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_uredi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_uredi.Location = new System.Drawing.Point(92, 350);
            this.btn_uredi.Name = "btn_uredi";
            this.btn_uredi.Size = new System.Drawing.Size(64, 33);
            this.btn_uredi.TabIndex = 36;
            this.btn_uredi.Text = "Uredi";
            this.btn_uredi.UseVisualStyleBackColor = false;
            this.btn_uredi.Click += new System.EventHandler(this.btn_uredi_Click);
            // 
            // btn_izbrisi
            // 
            this.btn_izbrisi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_izbrisi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_izbrisi.Location = new System.Drawing.Point(162, 350);
            this.btn_izbrisi.Name = "btn_izbrisi";
            this.btn_izbrisi.Size = new System.Drawing.Size(64, 33);
            this.btn_izbrisi.TabIndex = 35;
            this.btn_izbrisi.Text = "Izbriši";
            this.btn_izbrisi.UseVisualStyleBackColor = false;
            this.btn_izbrisi.Click += new System.EventHandler(this.btn_izbrisi_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_dodaj.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_dodaj.Location = new System.Drawing.Point(22, 350);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(64, 33);
            this.btn_dodaj.TabIndex = 34;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = false;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // SobeGridView
            // 
            this.SobeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SobeGridView.Location = new System.Drawing.Point(260, 133);
            this.SobeGridView.Name = "SobeGridView";
            this.SobeGridView.RowHeadersWidth = 51;
            this.SobeGridView.RowTemplate.Height = 24;
            this.SobeGridView.Size = new System.Drawing.Size(832, 305);
            this.SobeGridView.TabIndex = 37;
            this.SobeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SobeGridView_CellContentClick);
            // 
            // btn_pretraga
            // 
            this.btn_pretraga.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_pretraga.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_pretraga.Location = new System.Drawing.Point(260, 94);
            this.btn_pretraga.Name = "btn_pretraga";
            this.btn_pretraga.Size = new System.Drawing.Size(101, 33);
            this.btn_pretraga.TabIndex = 78;
            this.btn_pretraga.Text = "Pretraga";
            this.btn_pretraga.UseVisualStyleBackColor = false;
            this.btn_pretraga.Click += new System.EventHandler(this.btn_pretraga_Click);
            // 
            // sobaPretraga
            // 
            this.sobaPretraga.Location = new System.Drawing.Point(376, 99);
            this.sobaPretraga.Name = "sobaPretraga";
            this.sobaPretraga.Size = new System.Drawing.Size(158, 22);
            this.sobaPretraga.TabIndex = 79;
            this.sobaPretraga.Text = "Pretraga sobe";
            // 
            // btn_ponovnoUcitaj
            // 
            this.btn_ponovnoUcitaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ponovnoUcitaj.Image = ((System.Drawing.Image)(resources.GetObject("btn_ponovnoUcitaj.Image")));
            this.btn_ponovnoUcitaj.Location = new System.Drawing.Point(551, 92);
            this.btn_ponovnoUcitaj.Name = "btn_ponovnoUcitaj";
            this.btn_ponovnoUcitaj.Size = new System.Drawing.Size(31, 35);
            this.btn_ponovnoUcitaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_ponovnoUcitaj.TabIndex = 80;
            this.btn_ponovnoUcitaj.TabStop = false;
            this.btn_ponovnoUcitaj.Click += new System.EventHandler(this.btn_ponovnoUcitaj_Click);
            // 
            // btn_povratak
            // 
            this.btn_povratak.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_povratak.Location = new System.Drawing.Point(68, 405);
            this.btn_povratak.Name = "btn_povratak";
            this.btn_povratak.Size = new System.Drawing.Size(88, 33);
            this.btn_povratak.TabIndex = 96;
            this.btn_povratak.Text = "Povratak";
            this.btn_povratak.UseVisualStyleBackColor = false;
            this.btn_povratak.Click += new System.EventHandler(this.btn_povratak_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Sobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 450);
            this.Controls.Add(this.btn_povratak);
            this.Controls.Add(this.btn_ponovnoUcitaj);
            this.Controls.Add(this.sobaPretraga);
            this.Controls.Add(this.btn_pretraga);
            this.Controls.Add(this.SobeGridView);
            this.Controls.Add(this.btn_uredi);
            this.Controls.Add(this.btn_izbrisi);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.rb_neVecera);
            this.Controls.Add(this.rb_daVecera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SobaTelefontxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SobaIdtxb);
            this.Controls.Add(this.panel1);
            this.Name = "Sobe";
            this.Text = "Sobe";
            this.Load += new System.EventHandler(this.Sobe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SobeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ponovnoUcitaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SobaTelefontxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SobaIdtxb;
        private System.Windows.Forms.RadioButton rb_neVecera;
        private System.Windows.Forms.RadioButton rb_daVecera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_uredi;
        private System.Windows.Forms.Button btn_izbrisi;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.DataGridView SobeGridView;
        private System.Windows.Forms.Button btn_pretraga;
        private System.Windows.Forms.TextBox sobaPretraga;
        private System.Windows.Forms.PictureBox btn_ponovnoUcitaj;
        private System.Windows.Forms.Label Datumlb;
        private System.Windows.Forms.Button btn_povratak;
        private System.Windows.Forms.Timer timer1;
    }
}