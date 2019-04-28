namespace mokkisofta
{
    partial class Palvelut
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
            this.lblPlvNimi = new System.Windows.Forms.Label();
            this.txbPlvNimi = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslTpstatuslabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnPlvLisää = new System.Windows.Forms.Button();
            this.btnPlvPoista = new System.Windows.Forms.Button();
            this.btnPlvMuokkaa = new System.Windows.Forms.Button();
            this.lblPlvAlv = new System.Windows.Forms.Label();
            this.lblPlvTyyppi = new System.Windows.Forms.Label();
            this.lblPlvHinta = new System.Windows.Forms.Label();
            this.lblPlvKuvaus = new System.Windows.Forms.Label();
            this.lblPlvToimipiste = new System.Windows.Forms.Label();
            this.lblPlvNumero = new System.Windows.Forms.Label();
            this.txbPlvAlv = new System.Windows.Forms.TextBox();
            this.txbPlvTyyppi = new System.Windows.Forms.TextBox();
            this.txbPlvHinta = new System.Windows.Forms.TextBox();
            this.txbPlvKuvaus = new System.Windows.Forms.TextBox();
            this.txbAsNumero = new System.Windows.Forms.TextBox();
            this.dgwPalvelut = new System.Windows.Forms.DataGridView();
            this.cboxPlvToimipiste = new System.Windows.Forms.ComboBox();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ohjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPalvelut)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlvNimi
            // 
            this.lblPlvNimi.AutoSize = true;
            this.lblPlvNimi.Location = new System.Drawing.Point(40, 448);
            this.lblPlvNimi.Name = "lblPlvNimi";
            this.lblPlvNimi.Size = new System.Drawing.Size(27, 13);
            this.lblPlvNimi.TabIndex = 63;
            this.lblPlvNimi.Text = "Nimi";
            // 
            // txbPlvNimi
            // 
            this.txbPlvNimi.Location = new System.Drawing.Point(104, 445);
            this.txbPlvNimi.Name = "txbPlvNimi";
            this.txbPlvNimi.Size = new System.Drawing.Size(130, 20);
            this.txbPlvNimi.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTpstatuslabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(801, 22);
            this.statusStrip1.TabIndex = 61;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslTpstatuslabel1
            // 
            this.tslTpstatuslabel1.Name = "tslTpstatuslabel1";
            this.tslTpstatuslabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btnPlvLisää
            // 
            this.btnPlvLisää.Location = new System.Drawing.Point(668, 400);
            this.btnPlvLisää.Name = "btnPlvLisää";
            this.btnPlvLisää.Size = new System.Drawing.Size(99, 41);
            this.btnPlvLisää.TabIndex = 9;
            this.btnPlvLisää.Text = "Lisää";
            this.btnPlvLisää.UseVisualStyleBackColor = true;
            this.btnPlvLisää.Click += new System.EventHandler(this.palvelut_Click);
            // 
            // btnPlvPoista
            // 
            this.btnPlvPoista.Location = new System.Drawing.Point(668, 449);
            this.btnPlvPoista.Name = "btnPlvPoista";
            this.btnPlvPoista.Size = new System.Drawing.Size(99, 41);
            this.btnPlvPoista.TabIndex = 11;
            this.btnPlvPoista.Text = "Poista";
            this.btnPlvPoista.UseVisualStyleBackColor = true;
            // 
            // btnPlvMuokkaa
            // 
            this.btnPlvMuokkaa.Location = new System.Drawing.Point(563, 449);
            this.btnPlvMuokkaa.Name = "btnPlvMuokkaa";
            this.btnPlvMuokkaa.Size = new System.Drawing.Size(99, 41);
            this.btnPlvMuokkaa.TabIndex = 10;
            this.btnPlvMuokkaa.Text = "Muokkaa";
            this.btnPlvMuokkaa.UseVisualStyleBackColor = true;
            // 
            // lblPlvAlv
            // 
            this.lblPlvAlv.AutoSize = true;
            this.lblPlvAlv.Location = new System.Drawing.Point(281, 471);
            this.lblPlvAlv.Name = "lblPlvAlv";
            this.lblPlvAlv.Size = new System.Drawing.Size(22, 13);
            this.lblPlvAlv.TabIndex = 55;
            this.lblPlvAlv.Text = "Alv";
            // 
            // lblPlvTyyppi
            // 
            this.lblPlvTyyppi.AutoSize = true;
            this.lblPlvTyyppi.Location = new System.Drawing.Point(281, 400);
            this.lblPlvTyyppi.Name = "lblPlvTyyppi";
            this.lblPlvTyyppi.Size = new System.Drawing.Size(38, 13);
            this.lblPlvTyyppi.TabIndex = 54;
            this.lblPlvTyyppi.Text = "Tyyppi";
            // 
            // lblPlvHinta
            // 
            this.lblPlvHinta.AutoSize = true;
            this.lblPlvHinta.Location = new System.Drawing.Point(281, 436);
            this.lblPlvHinta.Name = "lblPlvHinta";
            this.lblPlvHinta.Size = new System.Drawing.Size(32, 13);
            this.lblPlvHinta.TabIndex = 53;
            this.lblPlvHinta.Text = "Hinta";
            // 
            // lblPlvKuvaus
            // 
            this.lblPlvKuvaus.AutoSize = true;
            this.lblPlvKuvaus.Location = new System.Drawing.Point(40, 474);
            this.lblPlvKuvaus.Name = "lblPlvKuvaus";
            this.lblPlvKuvaus.Size = new System.Drawing.Size(43, 13);
            this.lblPlvKuvaus.TabIndex = 52;
            this.lblPlvKuvaus.Text = "Kuvaus";
            // 
            // lblPlvToimipiste
            // 
            this.lblPlvToimipiste.AutoSize = true;
            this.lblPlvToimipiste.Location = new System.Drawing.Point(40, 422);
            this.lblPlvToimipiste.Name = "lblPlvToimipiste";
            this.lblPlvToimipiste.Size = new System.Drawing.Size(54, 13);
            this.lblPlvToimipiste.TabIndex = 51;
            this.lblPlvToimipiste.Text = "Toimipiste";
            // 
            // lblPlvNumero
            // 
            this.lblPlvNumero.AutoSize = true;
            this.lblPlvNumero.Location = new System.Drawing.Point(40, 393);
            this.lblPlvNumero.Name = "lblPlvNumero";
            this.lblPlvNumero.Size = new System.Drawing.Size(44, 13);
            this.lblPlvNumero.TabIndex = 50;
            this.lblPlvNumero.Text = "Numero";
            // 
            // txbPlvAlv
            // 
            this.txbPlvAlv.Location = new System.Drawing.Point(370, 471);
            this.txbPlvAlv.Name = "txbPlvAlv";
            this.txbPlvAlv.Size = new System.Drawing.Size(130, 20);
            this.txbPlvAlv.TabIndex = 8;
            // 
            // txbPlvTyyppi
            // 
            this.txbPlvTyyppi.Location = new System.Drawing.Point(370, 400);
            this.txbPlvTyyppi.Name = "txbPlvTyyppi";
            this.txbPlvTyyppi.Size = new System.Drawing.Size(77, 20);
            this.txbPlvTyyppi.TabIndex = 6;
            // 
            // txbPlvHinta
            // 
            this.txbPlvHinta.Location = new System.Drawing.Point(370, 436);
            this.txbPlvHinta.Name = "txbPlvHinta";
            this.txbPlvHinta.Size = new System.Drawing.Size(130, 20);
            this.txbPlvHinta.TabIndex = 7;
            // 
            // txbPlvKuvaus
            // 
            this.txbPlvKuvaus.Location = new System.Drawing.Point(104, 471);
            this.txbPlvKuvaus.Name = "txbPlvKuvaus";
            this.txbPlvKuvaus.Size = new System.Drawing.Size(130, 20);
            this.txbPlvKuvaus.TabIndex = 5;
            // 
            // txbAsNumero
            // 
            this.txbAsNumero.Location = new System.Drawing.Point(104, 393);
            this.txbAsNumero.Name = "txbAsNumero";
            this.txbAsNumero.Size = new System.Drawing.Size(58, 20);
            this.txbAsNumero.TabIndex = 2;
            // 
            // dgwPalvelut
            // 
            this.dgwPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPalvelut.Location = new System.Drawing.Point(29, 43);
            this.dgwPalvelut.Name = "dgwPalvelut";
            this.dgwPalvelut.Size = new System.Drawing.Size(738, 330);
            this.dgwPalvelut.TabIndex = 12;
            // 
            // cboxPlvToimipiste
            // 
            this.cboxPlvToimipiste.FormattingEnabled = true;
            this.cboxPlvToimipiste.Location = new System.Drawing.Point(104, 419);
            this.cboxPlvToimipiste.Name = "cboxPlvToimipiste";
            this.cboxPlvToimipiste.Size = new System.Drawing.Size(121, 21);
            this.cboxPlvToimipiste.TabIndex = 3;
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
            // Palvelut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 522);
            this.Controls.Add(this.cboxPlvToimipiste);
            this.Controls.Add(this.lblPlvNimi);
            this.Controls.Add(this.txbPlvNimi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnPlvLisää);
            this.Controls.Add(this.btnPlvPoista);
            this.Controls.Add(this.btnPlvMuokkaa);
            this.Controls.Add(this.lblPlvAlv);
            this.Controls.Add(this.lblPlvTyyppi);
            this.Controls.Add(this.lblPlvHinta);
            this.Controls.Add(this.lblPlvKuvaus);
            this.Controls.Add(this.lblPlvToimipiste);
            this.Controls.Add(this.lblPlvNumero);
            this.Controls.Add(this.txbPlvAlv);
            this.Controls.Add(this.txbPlvTyyppi);
            this.Controls.Add(this.txbPlvHinta);
            this.Controls.Add(this.txbPlvKuvaus);
            this.Controls.Add(this.txbAsNumero);
            this.Controls.Add(this.dgwPalvelut);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Palvelut";
            this.Text = "Palvelut";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPalvelut)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlvNimi;
        private System.Windows.Forms.TextBox txbPlvNimi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslTpstatuslabel1;
        private System.Windows.Forms.Button btnPlvLisää;
        private System.Windows.Forms.Button btnPlvPoista;
        private System.Windows.Forms.Button btnPlvMuokkaa;
        private System.Windows.Forms.Label lblPlvAlv;
        private System.Windows.Forms.Label lblPlvTyyppi;
        private System.Windows.Forms.Label lblPlvHinta;
        private System.Windows.Forms.Label lblPlvKuvaus;
        private System.Windows.Forms.Label lblPlvToimipiste;
        private System.Windows.Forms.Label lblPlvNumero;
        private System.Windows.Forms.TextBox txbPlvAlv;
        private System.Windows.Forms.TextBox txbPlvTyyppi;
        private System.Windows.Forms.TextBox txbPlvHinta;
        private System.Windows.Forms.TextBox txbPlvKuvaus;
        private System.Windows.Forms.TextBox txbAsNumero;
        private System.Windows.Forms.DataGridView dgwPalvelut;
        private System.Windows.Forms.ComboBox cboxPlvToimipiste;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ohjeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}