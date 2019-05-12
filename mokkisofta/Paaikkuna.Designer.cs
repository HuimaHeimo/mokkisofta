namespace mokkisofta
{
    partial class Paaikkuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paaikkuna));
            this.btnTpisteet = new System.Windows.Forms.Button();
            this.btnPalvelut = new System.Windows.Forms.Button();
            this.btnVaraukset = new System.Windows.Forms.Button();
            this.btnAsiakkaat = new System.Windows.Forms.Button();
            this.btnLaskut = new System.Windows.Forms.Button();
            this.btnRaportit = new System.Windows.Forms.Button();
            this.MmStrip = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MmmsPoistu = new System.Windows.Forms.ToolStripMenuItem();
            this.ohjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietojaOhjelmastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbPvTietokanta = new System.Windows.Forms.TextBox();
            this.lblPvTietokanta = new System.Windows.Forms.Label();
            this.btnPvYhdista = new System.Windows.Forms.Button();
            this.lblPvPalvelin = new System.Windows.Forms.Label();
            this.txbPvPalvelin = new System.Windows.Forms.TextBox();
            this.lblTunnus = new System.Windows.Forms.Label();
            this.lblSalasana = new System.Windows.Forms.Label();
            this.txbPvSalasana = new System.Windows.Forms.TextBox();
            this.txbPvTunnus = new System.Windows.Forms.TextBox();
            this.cbPvAutentikointi = new System.Windows.Forms.CheckBox();
            this.MmStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTpisteet
            // 
            this.btnTpisteet.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTpisteet.Location = new System.Drawing.Point(12, 71);
            this.btnTpisteet.Name = "btnTpisteet";
            this.btnTpisteet.Size = new System.Drawing.Size(167, 60);
            this.btnTpisteet.TabIndex = 0;
            this.btnTpisteet.Text = "Toimipisteet";
            this.btnTpisteet.UseVisualStyleBackColor = true;
            this.btnTpisteet.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // btnPalvelut
            // 
            this.btnPalvelut.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalvelut.Location = new System.Drawing.Point(12, 137);
            this.btnPalvelut.Name = "btnPalvelut";
            this.btnPalvelut.Size = new System.Drawing.Size(167, 60);
            this.btnPalvelut.TabIndex = 1;
            this.btnPalvelut.Text = "Palvelut";
            this.btnPalvelut.UseVisualStyleBackColor = true;
            this.btnPalvelut.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // btnVaraukset
            // 
            this.btnVaraukset.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaraukset.Location = new System.Drawing.Point(12, 203);
            this.btnVaraukset.Name = "btnVaraukset";
            this.btnVaraukset.Size = new System.Drawing.Size(167, 60);
            this.btnVaraukset.TabIndex = 2;
            this.btnVaraukset.Text = "Varaukset";
            this.btnVaraukset.UseVisualStyleBackColor = true;
            this.btnVaraukset.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // btnAsiakkaat
            // 
            this.btnAsiakkaat.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsiakkaat.Location = new System.Drawing.Point(12, 269);
            this.btnAsiakkaat.Name = "btnAsiakkaat";
            this.btnAsiakkaat.Size = new System.Drawing.Size(167, 60);
            this.btnAsiakkaat.TabIndex = 3;
            this.btnAsiakkaat.Text = "Asiakkaat";
            this.btnAsiakkaat.UseVisualStyleBackColor = true;
            this.btnAsiakkaat.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // btnLaskut
            // 
            this.btnLaskut.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaskut.Location = new System.Drawing.Point(12, 335);
            this.btnLaskut.Name = "btnLaskut";
            this.btnLaskut.Size = new System.Drawing.Size(167, 60);
            this.btnLaskut.TabIndex = 4;
            this.btnLaskut.Text = "Laskut";
            this.btnLaskut.UseVisualStyleBackColor = true;
            this.btnLaskut.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // btnRaportit
            // 
            this.btnRaportit.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaportit.Location = new System.Drawing.Point(12, 401);
            this.btnRaportit.Name = "btnRaportit";
            this.btnRaportit.Size = new System.Drawing.Size(167, 60);
            this.btnRaportit.TabIndex = 5;
            this.btnRaportit.Text = "Raportit";
            this.btnRaportit.UseVisualStyleBackColor = true;
            this.btnRaportit.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // MmStrip
            // 
            this.MmStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.ohjeToolStripMenuItem});
            this.MmStrip.Location = new System.Drawing.Point(0, 0);
            this.MmStrip.Name = "MmStrip";
            this.MmStrip.Size = new System.Drawing.Size(681, 24);
            this.MmStrip.TabIndex = 6;
            this.MmStrip.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MmmsPoistu});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // MmmsPoistu
            // 
            this.MmmsPoistu.Name = "MmmsPoistu";
            this.MmmsPoistu.Size = new System.Drawing.Size(107, 22);
            this.MmmsPoistu.Text = "Poistu";
            this.MmmsPoistu.Click += new System.EventHandler(this.MmmsPoistu_Click);
            // 
            // ohjeToolStripMenuItem
            // 
            this.ohjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tietojaOhjelmastaToolStripMenuItem});
            this.ohjeToolStripMenuItem.Name = "ohjeToolStripMenuItem";
            this.ohjeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ohjeToolStripMenuItem.Text = "Ohje";
            // 
            // tietojaOhjelmastaToolStripMenuItem
            // 
            this.tietojaOhjelmastaToolStripMenuItem.Name = "tietojaOhjelmastaToolStripMenuItem";
            this.tietojaOhjelmastaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.tietojaOhjelmastaToolStripMenuItem.Text = "Tietoja ohjelmasta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://d1zpvjny0s6omk.cloudfront.net/media/cache/61/2c/612cc1b4a1876c3db01283ed3" +
    "f52116b.jpg";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txbPvTietokanta
            // 
            this.txbPvTietokanta.Location = new System.Drawing.Point(441, 27);
            this.txbPvTietokanta.Name = "txbPvTietokanta";
            this.txbPvTietokanta.Size = new System.Drawing.Size(124, 20);
            this.txbPvTietokanta.TabIndex = 9;
            // 
            // lblPvTietokanta
            // 
            this.lblPvTietokanta.AutoSize = true;
            this.lblPvTietokanta.Location = new System.Drawing.Point(377, 30);
            this.lblPvTietokanta.Name = "lblPvTietokanta";
            this.lblPvTietokanta.Size = new System.Drawing.Size(58, 13);
            this.lblPvTietokanta.TabIndex = 10;
            this.lblPvTietokanta.Text = "Tietokanta";
            // 
            // btnPvYhdista
            // 
            this.btnPvYhdista.Location = new System.Drawing.Point(578, 25);
            this.btnPvYhdista.Name = "btnPvYhdista";
            this.btnPvYhdista.Size = new System.Drawing.Size(91, 23);
            this.btnPvYhdista.TabIndex = 12;
            this.btnPvYhdista.Text = "Yhdistä";
            this.btnPvYhdista.UseVisualStyleBackColor = true;
            this.btnPvYhdista.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // lblPvPalvelin
            // 
            this.lblPvPalvelin.AutoSize = true;
            this.lblPvPalvelin.Location = new System.Drawing.Point(173, 30);
            this.lblPvPalvelin.Name = "lblPvPalvelin";
            this.lblPvPalvelin.Size = new System.Drawing.Size(44, 13);
            this.lblPvPalvelin.TabIndex = 11;
            this.lblPvPalvelin.Text = "Palvelin";
            // 
            // txbPvPalvelin
            // 
            this.txbPvPalvelin.Location = new System.Drawing.Point(223, 27);
            this.txbPvPalvelin.Name = "txbPvPalvelin";
            this.txbPvPalvelin.Size = new System.Drawing.Size(139, 20);
            this.txbPvPalvelin.TabIndex = 8;
            // 
            // lblTunnus
            // 
            this.lblTunnus.AutoSize = true;
            this.lblTunnus.Location = new System.Drawing.Point(173, 56);
            this.lblTunnus.Name = "lblTunnus";
            this.lblTunnus.Size = new System.Drawing.Size(43, 13);
            this.lblTunnus.TabIndex = 16;
            this.lblTunnus.Text = "Tunnus";
            // 
            // lblSalasana
            // 
            this.lblSalasana.AutoSize = true;
            this.lblSalasana.Location = new System.Drawing.Point(377, 56);
            this.lblSalasana.Name = "lblSalasana";
            this.lblSalasana.Size = new System.Drawing.Size(51, 13);
            this.lblSalasana.TabIndex = 15;
            this.lblSalasana.Text = "Salasana";
            // 
            // txbPvSalasana
            // 
            this.txbPvSalasana.Location = new System.Drawing.Point(441, 53);
            this.txbPvSalasana.Name = "txbPvSalasana";
            this.txbPvSalasana.Size = new System.Drawing.Size(124, 20);
            this.txbPvSalasana.TabIndex = 14;
            // 
            // txbPvTunnus
            // 
            this.txbPvTunnus.Location = new System.Drawing.Point(223, 53);
            this.txbPvTunnus.Name = "txbPvTunnus";
            this.txbPvTunnus.Size = new System.Drawing.Size(139, 20);
            this.txbPvTunnus.TabIndex = 13;
            // 
            // cbPvAutentikointi
            // 
            this.cbPvAutentikointi.AutoSize = true;
            this.cbPvAutentikointi.Location = new System.Drawing.Point(380, 79);
            this.cbPvAutentikointi.Name = "cbPvAutentikointi";
            this.cbPvAutentikointi.Size = new System.Drawing.Size(130, 17);
            this.cbPvAutentikointi.TabIndex = 17;
            this.cbPvAutentikointi.Text = "Windows-autentikointi";
            this.cbPvAutentikointi.UseVisualStyleBackColor = true;
            this.cbPvAutentikointi.CheckedChanged += new System.EventHandler(this.cbPvAutentikointi_CheckedChanged);
            // 
            // Paaikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 509);
            this.Controls.Add(this.cbPvAutentikointi);
            this.Controls.Add(this.lblTunnus);
            this.Controls.Add(this.lblSalasana);
            this.Controls.Add(this.txbPvSalasana);
            this.Controls.Add(this.txbPvTunnus);
            this.Controls.Add(this.btnPvYhdista);
            this.Controls.Add(this.lblPvPalvelin);
            this.Controls.Add(this.lblPvTietokanta);
            this.Controls.Add(this.txbPvTietokanta);
            this.Controls.Add(this.txbPvPalvelin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRaportit);
            this.Controls.Add(this.btnLaskut);
            this.Controls.Add(this.btnAsiakkaat);
            this.Controls.Add(this.btnVaraukset);
            this.Controls.Add(this.btnPalvelut);
            this.Controls.Add(this.btnTpisteet);
            this.Controls.Add(this.MmStrip);
            this.MainMenuStrip = this.MmStrip;
            this.Name = "Paaikkuna";
            this.Text = "Päävalikko";
            this.MmStrip.ResumeLayout(false);
            this.MmStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTpisteet;
        private System.Windows.Forms.Button btnPalvelut;
        private System.Windows.Forms.Button btnVaraukset;
        private System.Windows.Forms.Button btnAsiakkaat;
        private System.Windows.Forms.Button btnLaskut;
        private System.Windows.Forms.Button btnRaportit;
        private System.Windows.Forms.MenuStrip MmStrip;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MmmsPoistu;
        private System.Windows.Forms.ToolStripMenuItem ohjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietojaOhjelmastaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbPvTietokanta;
        private System.Windows.Forms.Label lblPvTietokanta;
        private System.Windows.Forms.Button btnPvYhdista;
        private System.Windows.Forms.Label lblPvPalvelin;
        private System.Windows.Forms.TextBox txbPvPalvelin;
        private System.Windows.Forms.Label lblTunnus;
        private System.Windows.Forms.Label lblSalasana;
        private System.Windows.Forms.TextBox txbPvSalasana;
        private System.Windows.Forms.TextBox txbPvTunnus;
        private System.Windows.Forms.CheckBox cbPvAutentikointi;
    }
}

