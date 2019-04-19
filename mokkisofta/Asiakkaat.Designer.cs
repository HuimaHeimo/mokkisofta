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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslTpstatuslabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAsLisää = new System.Windows.Forms.Button();
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
            this.txbAsNumero = new System.Windows.Forms.TextBox();
            this.dgwAsiakkaat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAsSukunimi = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // ohjeToolStripMenuItem
            // 
            this.ohjeToolStripMenuItem.Name = "ohjeToolStripMenuItem";
            this.ohjeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ohjeToolStripMenuItem.Text = "Ohje";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTpstatuslabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(801, 22);
            this.statusStrip1.TabIndex = 39;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslTpstatuslabel1
            // 
            this.tslTpstatuslabel1.Name = "tslTpstatuslabel1";
            this.tslTpstatuslabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btnAsLisää
            // 
            this.btnAsLisää.Location = new System.Drawing.Point(668, 400);
            this.btnAsLisää.Name = "btnAsLisää";
            this.btnAsLisää.Size = new System.Drawing.Size(99, 41);
            this.btnAsLisää.TabIndex = 38;
            this.btnAsLisää.Text = "Lisää";
            this.btnAsLisää.UseVisualStyleBackColor = true;
            this.btnAsLisää.Click += new System.EventHandler(this.BtnAsLisää_Click);
            // 
            // lblTpPuhnro
            // 
            this.lblTpPuhnro.AutoSize = true;
            this.lblTpPuhnro.Location = new System.Drawing.Point(429, 400);
            this.lblTpPuhnro.Name = "lblTpPuhnro";
            this.lblTpPuhnro.Size = new System.Drawing.Size(77, 13);
            this.lblTpPuhnro.TabIndex = 37;
            this.lblTpPuhnro.Text = "Puhelinnumero";
            // 
            // txbAsPuhnro
            // 
            this.txbAsPuhnro.Location = new System.Drawing.Point(512, 400);
            this.txbAsPuhnro.Name = "txbAsPuhnro";
            this.txbAsPuhnro.Size = new System.Drawing.Size(130, 20);
            this.txbAsPuhnro.TabIndex = 36;
            // 
            // btnAsPoista
            // 
            this.btnAsPoista.Location = new System.Drawing.Point(668, 449);
            this.btnAsPoista.Name = "btnAsPoista";
            this.btnAsPoista.Size = new System.Drawing.Size(99, 41);
            this.btnAsPoista.TabIndex = 35;
            this.btnAsPoista.Text = "Poista";
            this.btnAsPoista.UseVisualStyleBackColor = true;
            this.btnAsPoista.Click += new System.EventHandler(this.BtnAsPoista_Click);
            // 
            // btnAsMuokkaa
            // 
            this.btnAsMuokkaa.Location = new System.Drawing.Point(563, 449);
            this.btnAsMuokkaa.Name = "btnAsMuokkaa";
            this.btnAsMuokkaa.Size = new System.Drawing.Size(99, 41);
            this.btnAsMuokkaa.TabIndex = 34;
            this.btnAsMuokkaa.Text = "Muokkaa";
            this.btnAsMuokkaa.UseVisualStyleBackColor = true;
            this.btnAsMuokkaa.Click += new System.EventHandler(this.BtnAsMuokkaa_Click);
            // 
            // lblTpSposti
            // 
            this.lblTpSposti.AutoSize = true;
            this.lblTpSposti.Location = new System.Drawing.Point(234, 471);
            this.lblTpSposti.Name = "lblTpSposti";
            this.lblTpSposti.Size = new System.Drawing.Size(60, 13);
            this.lblTpSposti.TabIndex = 33;
            this.lblTpSposti.Text = "Sähköposti";
            // 
            // lblTpPostinumero
            // 
            this.lblTpPostinumero.AutoSize = true;
            this.lblTpPostinumero.Location = new System.Drawing.Point(234, 400);
            this.lblTpPostinumero.Name = "lblTpPostinumero";
            this.lblTpPostinumero.Size = new System.Drawing.Size(65, 13);
            this.lblTpPostinumero.TabIndex = 32;
            this.lblTpPostinumero.Text = "Postinumero";
            // 
            // lblTpPtoimipaikka
            // 
            this.lblTpPtoimipaikka.AutoSize = true;
            this.lblTpPtoimipaikka.Location = new System.Drawing.Point(234, 436);
            this.lblTpPtoimipaikka.Name = "lblTpPtoimipaikka";
            this.lblTpPtoimipaikka.Size = new System.Drawing.Size(83, 13);
            this.lblTpPtoimipaikka.TabIndex = 31;
            this.lblTpPtoimipaikka.Text = "Postitoimipaikka";
            // 
            // lblTpOsoite
            // 
            this.lblTpOsoite.AutoSize = true;
            this.lblTpOsoite.Location = new System.Drawing.Point(40, 474);
            this.lblTpOsoite.Name = "lblTpOsoite";
            this.lblTpOsoite.Size = new System.Drawing.Size(37, 13);
            this.lblTpOsoite.TabIndex = 30;
            this.lblTpOsoite.Text = "Osoite";
            // 
            // lblTpNimi
            // 
            this.lblTpNimi.AutoSize = true;
            this.lblTpNimi.Location = new System.Drawing.Point(40, 422);
            this.lblTpNimi.Name = "lblTpNimi";
            this.lblTpNimi.Size = new System.Drawing.Size(41, 13);
            this.lblTpNimi.TabIndex = 29;
            this.lblTpNimi.Text = "Etunimi";
            // 
            // lblTpNumero
            // 
            this.lblTpNumero.AutoSize = true;
            this.lblTpNumero.Location = new System.Drawing.Point(40, 393);
            this.lblTpNumero.Name = "lblTpNumero";
            this.lblTpNumero.Size = new System.Drawing.Size(44, 13);
            this.lblTpNumero.TabIndex = 28;
            this.lblTpNumero.Text = "Numero";
            // 
            // txbAsSposti
            // 
            this.txbAsSposti.Location = new System.Drawing.Point(323, 471);
            this.txbAsSposti.Name = "txbAsSposti";
            this.txbAsSposti.Size = new System.Drawing.Size(130, 20);
            this.txbAsSposti.TabIndex = 27;
            // 
            // txbAsPostinumero
            // 
            this.txbAsPostinumero.Location = new System.Drawing.Point(323, 400);
            this.txbAsPostinumero.Name = "txbAsPostinumero";
            this.txbAsPostinumero.Size = new System.Drawing.Size(77, 20);
            this.txbAsPostinumero.TabIndex = 26;
            // 
            // txbAsPtoimipaikka
            // 
            this.txbAsPtoimipaikka.Location = new System.Drawing.Point(323, 436);
            this.txbAsPtoimipaikka.Name = "txbAsPtoimipaikka";
            this.txbAsPtoimipaikka.Size = new System.Drawing.Size(130, 20);
            this.txbAsPtoimipaikka.TabIndex = 25;
            // 
            // txbAsOsoite
            // 
            this.txbAsOsoite.Location = new System.Drawing.Point(90, 471);
            this.txbAsOsoite.Name = "txbAsOsoite";
            this.txbAsOsoite.Size = new System.Drawing.Size(130, 20);
            this.txbAsOsoite.TabIndex = 24;
            // 
            // txbAsEtunimi
            // 
            this.txbAsEtunimi.Location = new System.Drawing.Point(90, 419);
            this.txbAsEtunimi.Name = "txbAsEtunimi";
            this.txbAsEtunimi.Size = new System.Drawing.Size(130, 20);
            this.txbAsEtunimi.TabIndex = 23;
            // 
            // txbAsNumero
            // 
            this.txbAsNumero.Enabled = false;
            this.txbAsNumero.Location = new System.Drawing.Point(90, 393);
            this.txbAsNumero.Name = "txbAsNumero";
            this.txbAsNumero.Size = new System.Drawing.Size(58, 20);
            this.txbAsNumero.TabIndex = 22;
            // 
            // dgwAsiakkaat
            // 
            this.dgwAsiakkaat.AllowUserToAddRows = false;
            this.dgwAsiakkaat.AllowUserToDeleteRows = false;
            this.dgwAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAsiakkaat.Location = new System.Drawing.Point(29, 43);
            this.dgwAsiakkaat.Name = "dgwAsiakkaat";
            this.dgwAsiakkaat.Size = new System.Drawing.Size(738, 330);
            this.dgwAsiakkaat.TabIndex = 21;
            this.dgwAsiakkaat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dgwAsiakkaat.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwAsiakkaat_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Sukunimi";
            // 
            // txbAsSukunimi
            // 
            this.txbAsSukunimi.Location = new System.Drawing.Point(90, 445);
            this.txbAsSukunimi.Name = "txbAsSukunimi";
            this.txbAsSukunimi.Size = new System.Drawing.Size(130, 20);
            this.txbAsSukunimi.TabIndex = 40;
            // 
            // Asiakkaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbAsSukunimi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAsLisää);
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
            this.Controls.Add(this.txbAsNumero);
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
        private System.Windows.Forms.Button btnAsLisää;
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
        private System.Windows.Forms.TextBox txbAsNumero;
        private System.Windows.Forms.DataGridView dgwAsiakkaat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAsSukunimi;
    }
}