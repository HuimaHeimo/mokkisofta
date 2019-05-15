namespace mokkisofta
{
    partial class Asiakkaat
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ohjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietoaOhjelmastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslTpstatuslabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAsLisaa = new System.Windows.Forms.Button();
            this.lblTpPuhnro = new System.Windows.Forms.Label();
            this.txbAsPuhnro = new System.Windows.Forms.TextBox();
            this.btnAsPoista = new System.Windows.Forms.Button();
            this.btnAsMuokkaa = new System.Windows.Forms.Button();
            this.lblTpSposti = new System.Windows.Forms.Label();
            this.lblTpPostinumero = new System.Windows.Forms.Label();
            this.lblTpPtoimipaikka = new System.Windows.Forms.Label();
            this.lblTpOsoite = new System.Windows.Forms.Label();
            this.lblTpNimi = new System.Windows.Forms.Label();
            this.lblTpNumero = new System.Windows.Forms.Label();
            this.txbAsSposti = new System.Windows.Forms.TextBox();
            this.txbAsPostinumero = new System.Windows.Forms.TextBox();
            this.txbAsPtoimipaikka = new System.Windows.Forms.TextBox();
            this.txbAsOsoite = new System.Windows.Forms.TextBox();
            this.txbAsEtunimi = new System.Windows.Forms.TextBox();
            this.dgwAsiakkaat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAsSukunimi = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnTpPeruuta = new System.Windows.Forms.Button();
            this.btnTpTallenna = new System.Windows.Forms.Button();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAsiakkaat)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.ohjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poistuToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // ohjeToolStripMenuItem
            // 
            this.ohjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tietoaOhjelmastaToolStripMenuItem});
            this.ohjeToolStripMenuItem.Name = "ohjeToolStripMenuItem";
            this.ohjeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ohjeToolStripMenuItem.Text = "Ohje";
            // 
            // tietoaOhjelmastaToolStripMenuItem
            // 
            this.tietoaOhjelmastaToolStripMenuItem.Name = "tietoaOhjelmastaToolStripMenuItem";
            this.tietoaOhjelmastaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.tietoaOhjelmastaToolStripMenuItem.Text = "Tietoa ohjelmasta";
            this.tietoaOhjelmastaToolStripMenuItem.Click += new System.EventHandler(this.tietoaOhjelmastaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTpstatuslabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 566);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(816, 22);
            this.statusStrip1.TabIndex = 39;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslTpstatuslabel1
            // 
            this.tslTpstatuslabel1.Name = "tslTpstatuslabel1";
            this.tslTpstatuslabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btnAsLisaa
            // 
            this.btnAsLisaa.Location = new System.Drawing.Point(673, 411);
            this.btnAsLisaa.Name = "btnAsLisaa";
            this.btnAsLisaa.Size = new System.Drawing.Size(99, 41);
            this.btnAsLisaa.TabIndex = 9;
            this.btnAsLisaa.Text = "Lisää";
            this.btnAsLisaa.UseVisualStyleBackColor = true;
            this.btnAsLisaa.Click += new System.EventHandler(this.BtnAsLisaa_Click);
            // 
            // lblTpPuhnro
            // 
            this.lblTpPuhnro.AutoSize = true;
            this.lblTpPuhnro.Location = new System.Drawing.Point(259, 529);
            this.lblTpPuhnro.Name = "lblTpPuhnro";
            this.lblTpPuhnro.Size = new System.Drawing.Size(77, 13);
            this.lblTpPuhnro.TabIndex = 37;
            this.lblTpPuhnro.Text = "Puhelinnumero";
            // 
            // txbAsPuhnro
            // 
            this.txbAsPuhnro.Location = new System.Drawing.Point(348, 526);
            this.txbAsPuhnro.MaxLength = 15;
            this.txbAsPuhnro.Name = "txbAsPuhnro";
            this.txbAsPuhnro.Size = new System.Drawing.Size(130, 20);
            this.txbAsPuhnro.TabIndex = 8;
            this.txbAsPuhnro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbAsPuhnro_KeyPress);
            // 
            // btnAsPoista
            // 
            this.btnAsPoista.Location = new System.Drawing.Point(673, 458);
            this.btnAsPoista.Name = "btnAsPoista";
            this.btnAsPoista.Size = new System.Drawing.Size(99, 41);
            this.btnAsPoista.TabIndex = 11;
            this.btnAsPoista.Text = "Poista";
            this.btnAsPoista.UseVisualStyleBackColor = true;
            this.btnAsPoista.Click += new System.EventHandler(this.BtnAsPoista_Click);
            // 
            // btnAsMuokkaa
            // 
            this.btnAsMuokkaa.Location = new System.Drawing.Point(568, 458);
            this.btnAsMuokkaa.Name = "btnAsMuokkaa";
            this.btnAsMuokkaa.Size = new System.Drawing.Size(99, 41);
            this.btnAsMuokkaa.TabIndex = 10;
            this.btnAsMuokkaa.Text = "Muokkaa";
            this.btnAsMuokkaa.UseVisualStyleBackColor = true;
            this.btnAsMuokkaa.Click += new System.EventHandler(this.BtnAsMuokkaa_Click);
            // 
            // lblTpSposti
            // 
            this.lblTpSposti.AutoSize = true;
            this.lblTpSposti.Location = new System.Drawing.Point(52, 525);
            this.lblTpSposti.Name = "lblTpSposti";
            this.lblTpSposti.Size = new System.Drawing.Size(60, 13);
            this.lblTpSposti.TabIndex = 33;
            this.lblTpSposti.Text = "Sähköposti";
            // 
            // lblTpPostinumero
            // 
            this.lblTpPostinumero.AutoSize = true;
            this.lblTpPostinumero.Location = new System.Drawing.Point(259, 490);
            this.lblTpPostinumero.Name = "lblTpPostinumero";
            this.lblTpPostinumero.Size = new System.Drawing.Size(65, 13);
            this.lblTpPostinumero.TabIndex = 32;
            this.lblTpPostinumero.Text = "Postinumero";
            // 
            // lblTpPtoimipaikka
            // 
            this.lblTpPtoimipaikka.AutoSize = true;
            this.lblTpPtoimipaikka.Location = new System.Drawing.Point(259, 454);
            this.lblTpPtoimipaikka.Name = "lblTpPtoimipaikka";
            this.lblTpPtoimipaikka.Size = new System.Drawing.Size(83, 13);
            this.lblTpPtoimipaikka.TabIndex = 31;
            this.lblTpPtoimipaikka.Text = "Postitoimipaikka";
            // 
            // lblTpOsoite
            // 
            this.lblTpOsoite.AutoSize = true;
            this.lblTpOsoite.Location = new System.Drawing.Point(259, 414);
            this.lblTpOsoite.Name = "lblTpOsoite";
            this.lblTpOsoite.Size = new System.Drawing.Size(55, 13);
            this.lblTpOsoite.TabIndex = 30;
            this.lblTpOsoite.Text = "Lähiosoite";
            // 
            // lblTpNimi
            // 
            this.lblTpNimi.AutoSize = true;
            this.lblTpNimi.Location = new System.Drawing.Point(52, 450);
            this.lblTpNimi.Name = "lblTpNimi";
            this.lblTpNimi.Size = new System.Drawing.Size(41, 13);
            this.lblTpNimi.TabIndex = 29;
            this.lblTpNimi.Text = "Etunimi";
            // 
            // lblTpNumero
            // 
            this.lblTpNumero.AutoSize = true;
            this.lblTpNumero.Location = new System.Drawing.Point(52, 414);
            this.lblTpNumero.Name = "lblTpNumero";
            this.lblTpNumero.Size = new System.Drawing.Size(44, 13);
            this.lblTpNumero.TabIndex = 28;
            this.lblTpNumero.Text = "Numero";
            // 
            // txbAsSposti
            // 
            this.txbAsSposti.Location = new System.Drawing.Point(118, 522);
            this.txbAsSposti.MaxLength = 50;
            this.txbAsSposti.Name = "txbAsSposti";
            this.txbAsSposti.Size = new System.Drawing.Size(130, 20);
            this.txbAsSposti.TabIndex = 4;
            // 
            // txbAsPostinumero
            // 
            this.txbAsPostinumero.Location = new System.Drawing.Point(348, 487);
            this.txbAsPostinumero.MaxLength = 5;
            this.txbAsPostinumero.Name = "txbAsPostinumero";
            this.txbAsPostinumero.Size = new System.Drawing.Size(77, 20);
            this.txbAsPostinumero.TabIndex = 7;
            this.txbAsPostinumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbAsPostinumero_KeyPress);
            // 
            // txbAsPtoimipaikka
            // 
            this.txbAsPtoimipaikka.Location = new System.Drawing.Point(348, 450);
            this.txbAsPtoimipaikka.MaxLength = 30;
            this.txbAsPtoimipaikka.Name = "txbAsPtoimipaikka";
            this.txbAsPtoimipaikka.Size = new System.Drawing.Size(130, 20);
            this.txbAsPtoimipaikka.TabIndex = 6;
            // 
            // txbAsOsoite
            // 
            this.txbAsOsoite.Location = new System.Drawing.Point(348, 414);
            this.txbAsOsoite.MaxLength = 40;
            this.txbAsOsoite.Name = "txbAsOsoite";
            this.txbAsOsoite.Size = new System.Drawing.Size(130, 20);
            this.txbAsOsoite.TabIndex = 5;
            // 
            // txbAsEtunimi
            // 
            this.txbAsEtunimi.Location = new System.Drawing.Point(118, 447);
            this.txbAsEtunimi.MaxLength = 20;
            this.txbAsEtunimi.Name = "txbAsEtunimi";
            this.txbAsEtunimi.Size = new System.Drawing.Size(130, 20);
            this.txbAsEtunimi.TabIndex = 2;
            // 
            // dgwAsiakkaat
            // 
            this.dgwAsiakkaat.AllowUserToAddRows = false;
            this.dgwAsiakkaat.AllowUserToDeleteRows = false;
            this.dgwAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAsiakkaat.Location = new System.Drawing.Point(12, 43);
            this.dgwAsiakkaat.Name = "dgwAsiakkaat";
            this.dgwAsiakkaat.Size = new System.Drawing.Size(787, 330);
            this.dgwAsiakkaat.TabIndex = 15;
            this.dgwAsiakkaat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dgwAsiakkaat.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwAsiakkaat_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Sukunimi";
            // 
            // txbAsSukunimi
            // 
            this.txbAsSukunimi.Location = new System.Drawing.Point(118, 487);
            this.txbAsSukunimi.MaxLength = 40;
            this.txbAsSukunimi.Name = "txbAsSukunimi";
            this.txbAsSukunimi.Size = new System.Drawing.Size(130, 20);
            this.txbAsSukunimi.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(102, 414);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(10, 13);
            this.lblId.TabIndex = 42;
            this.lblId.Text = "-";
            // 
            // btnTpPeruuta
            // 
            this.btnTpPeruuta.Location = new System.Drawing.Point(568, 505);
            this.btnTpPeruuta.Name = "btnTpPeruuta";
            this.btnTpPeruuta.Size = new System.Drawing.Size(99, 41);
            this.btnTpPeruuta.TabIndex = 12;
            this.btnTpPeruuta.Text = "Peruuta";
            this.btnTpPeruuta.UseVisualStyleBackColor = true;
            this.btnTpPeruuta.Click += new System.EventHandler(this.BtnTpPeruuta_Click);
            // 
            // btnTpTallenna
            // 
            this.btnTpTallenna.Location = new System.Drawing.Point(673, 505);
            this.btnTpTallenna.Name = "btnTpTallenna";
            this.btnTpTallenna.Size = new System.Drawing.Size(99, 41);
            this.btnTpTallenna.TabIndex = 13;
            this.btnTpTallenna.Text = "Tallenna";
            this.btnTpTallenna.UseVisualStyleBackColor = true;
            this.btnTpTallenna.Click += new System.EventHandler(this.BtnTpTallenna_Click);
            // 
            // poistuToolStripMenuItem
            // 
            this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            this.poistuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poistuToolStripMenuItem.Text = "Poistu";
            this.poistuToolStripMenuItem.Click += new System.EventHandler(this.poistuToolStripMenuItem_Click);
            // 
            // Asiakkaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 588);
            this.Controls.Add(this.btnTpPeruuta);
            this.Controls.Add(this.btnTpTallenna);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbAsSukunimi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAsLisaa);
            this.Controls.Add(this.lblTpPuhnro);
            this.Controls.Add(this.txbAsPuhnro);
            this.Controls.Add(this.btnAsPoista);
            this.Controls.Add(this.btnAsMuokkaa);
            this.Controls.Add(this.lblTpSposti);
            this.Controls.Add(this.lblTpPostinumero);
            this.Controls.Add(this.lblTpPtoimipaikka);
            this.Controls.Add(this.lblTpOsoite);
            this.Controls.Add(this.lblTpNimi);
            this.Controls.Add(this.lblTpNumero);
            this.Controls.Add(this.txbAsSposti);
            this.Controls.Add(this.txbAsPostinumero);
            this.Controls.Add(this.txbAsPtoimipaikka);
            this.Controls.Add(this.txbAsOsoite);
            this.Controls.Add(this.txbAsEtunimi);
            this.Controls.Add(this.dgwAsiakkaat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Asiakkaat";
            this.Text = "Asiakkaat";
            this.Load += new System.EventHandler(this.Asiakkaat_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAsiakkaat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ohjeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslTpstatuslabel1;
        private System.Windows.Forms.Button btnAsLisaa;
        private System.Windows.Forms.Label lblTpPuhnro;
        private System.Windows.Forms.TextBox txbAsPuhnro;
        private System.Windows.Forms.Button btnAsPoista;
        private System.Windows.Forms.Button btnAsMuokkaa;
        private System.Windows.Forms.Label lblTpSposti;
        private System.Windows.Forms.Label lblTpPostinumero;
        private System.Windows.Forms.Label lblTpPtoimipaikka;
        private System.Windows.Forms.Label lblTpOsoite;
        private System.Windows.Forms.Label lblTpNimi;
        private System.Windows.Forms.Label lblTpNumero;
        private System.Windows.Forms.TextBox txbAsSposti;
        private System.Windows.Forms.TextBox txbAsPostinumero;
        private System.Windows.Forms.TextBox txbAsPtoimipaikka;
        private System.Windows.Forms.TextBox txbAsOsoite;
        private System.Windows.Forms.TextBox txbAsEtunimi;
        private System.Windows.Forms.DataGridView dgwAsiakkaat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAsSukunimi;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnTpPeruuta;
        private System.Windows.Forms.Button btnTpTallenna;
        private System.Windows.Forms.ToolStripMenuItem tietoaOhjelmastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
    }
}