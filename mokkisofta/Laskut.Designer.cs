namespace mokkisofta
{
    partial class Laskut
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
            this.lblLasAsiakas = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslTpstatuslabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboxLasVaraus = new System.Windows.Forms.ComboBox();
            this.btnLasLisaa = new System.Windows.Forms.Button();
            this.btnLasPoista = new System.Windows.Forms.Button();
            this.btnLasMuokkaa = new System.Windows.Forms.Button();
            this.lblLasPostinro = new System.Windows.Forms.Label();
            this.lblLasOsoite = new System.Windows.Forms.Label();
            this.lblLasPostitoimipaikka = new System.Windows.Forms.Label();
            this.lblLasNimi = new System.Windows.Forms.Label();
            this.lblLasVaraus = new System.Windows.Forms.Label();
            this.txbLasPostinro = new System.Windows.Forms.TextBox();
            this.txbLasOsoite = new System.Windows.Forms.TextBox();
            this.txbLasPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.txbLasNimi = new System.Windows.Forms.TextBox();
            this.dgwLaskut = new System.Windows.Forms.DataGridView();
            this.ohjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cboxLasAsiakas = new System.Windows.Forms.ComboBox();
            this.lblLasSumma = new System.Windows.Forms.Label();
            this.txbLasSumma = new System.Windows.Forms.TextBox();
            this.txbLasAlv = new System.Windows.Forms.TextBox();
            this.lblLasAlv = new System.Windows.Forms.Label();
            this.btnLasPeruuta = new System.Windows.Forms.Button();
            this.btnLasTallenna = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLaskut)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLasAsiakas
            // 
            this.lblLasAsiakas.AutoSize = true;
            this.lblLasAsiakas.Location = new System.Drawing.Point(14, 422);
            this.lblLasAsiakas.Name = "lblLasAsiakas";
            this.lblLasAsiakas.Size = new System.Drawing.Size(44, 13);
            this.lblLasAsiakas.TabIndex = 84;
            this.lblLasAsiakas.Text = "Asiakas";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTpstatuslabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(858, 22);
            this.statusStrip1.TabIndex = 82;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslTpstatuslabel1
            // 
            this.tslTpstatuslabel1.Name = "tslTpstatuslabel1";
            this.tslTpstatuslabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // cboxLasVaraus
            // 
            this.cboxLasVaraus.FormattingEnabled = true;
            this.cboxLasVaraus.Location = new System.Drawing.Point(104, 393);
            this.cboxLasVaraus.Name = "cboxLasVaraus";
            this.cboxLasVaraus.Size = new System.Drawing.Size(121, 21);
            this.cboxLasVaraus.TabIndex = 1;
            this.cboxLasVaraus.SelectionChangeCommitted += new System.EventHandler(this.CboxLasVaraus_SelectionChangeCommitted);
            // 
            // btnLasLisaa
            // 
            this.btnLasLisaa.Location = new System.Drawing.Point(709, 399);
            this.btnLasLisaa.Name = "btnLasLisaa";
            this.btnLasLisaa.Size = new System.Drawing.Size(99, 41);
            this.btnLasLisaa.TabIndex = 81;
            this.btnLasLisaa.Text = "Lisää";
            this.btnLasLisaa.UseVisualStyleBackColor = true;
            this.btnLasLisaa.Click += new System.EventHandler(this.btnLasLisää_Click);
            // 
            // btnLasPoista
            // 
            this.btnLasPoista.Location = new System.Drawing.Point(709, 448);
            this.btnLasPoista.Name = "btnLasPoista";
            this.btnLasPoista.Size = new System.Drawing.Size(99, 41);
            this.btnLasPoista.TabIndex = 80;
            this.btnLasPoista.Text = "Poista";
            this.btnLasPoista.UseVisualStyleBackColor = true;
            this.btnLasPoista.Click += new System.EventHandler(this.btnLasPoista_Click);
            // 
            // btnLasMuokkaa
            // 
            this.btnLasMuokkaa.Location = new System.Drawing.Point(604, 448);
            this.btnLasMuokkaa.Name = "btnLasMuokkaa";
            this.btnLasMuokkaa.Size = new System.Drawing.Size(99, 41);
            this.btnLasMuokkaa.TabIndex = 79;
            this.btnLasMuokkaa.Text = "Muokkaa";
            this.btnLasMuokkaa.UseVisualStyleBackColor = true;
            this.btnLasMuokkaa.Click += new System.EventHandler(this.btnLasMuokkaa_Click);
            // 
            // lblLasPostinro
            // 
            this.lblLasPostinro.AutoSize = true;
            this.lblLasPostinro.Location = new System.Drawing.Point(249, 448);
            this.lblLasPostinro.Name = "lblLasPostinro";
            this.lblLasPostinro.Size = new System.Drawing.Size(45, 13);
            this.lblLasPostinro.TabIndex = 78;
            this.lblLasPostinro.Text = "Postinro";
            // 
            // lblLasOsoite
            // 
            this.lblLasOsoite.AutoSize = true;
            this.lblLasOsoite.Location = new System.Drawing.Point(249, 393);
            this.lblLasOsoite.Name = "lblLasOsoite";
            this.lblLasOsoite.Size = new System.Drawing.Size(55, 13);
            this.lblLasOsoite.TabIndex = 77;
            this.lblLasOsoite.Text = "Lähiosoite";
            // 
            // lblLasPostitoimipaikka
            // 
            this.lblLasPostitoimipaikka.AutoSize = true;
            this.lblLasPostitoimipaikka.Location = new System.Drawing.Point(249, 422);
            this.lblLasPostitoimipaikka.Name = "lblLasPostitoimipaikka";
            this.lblLasPostitoimipaikka.Size = new System.Drawing.Size(83, 13);
            this.lblLasPostitoimipaikka.TabIndex = 76;
            this.lblLasPostitoimipaikka.Text = "Postitoimipaikka";
            // 
            // lblLasNimi
            // 
            this.lblLasNimi.AutoSize = true;
            this.lblLasNimi.Location = new System.Drawing.Point(14, 448);
            this.lblLasNimi.Name = "lblLasNimi";
            this.lblLasNimi.Size = new System.Drawing.Size(84, 13);
            this.lblLasNimi.TabIndex = 75;
            this.lblLasNimi.Text = "Laskun maksaja";
            // 
            // lblLasVaraus
            // 
            this.lblLasVaraus.AutoSize = true;
            this.lblLasVaraus.Location = new System.Drawing.Point(14, 396);
            this.lblLasVaraus.Name = "lblLasVaraus";
            this.lblLasVaraus.Size = new System.Drawing.Size(40, 13);
            this.lblLasVaraus.TabIndex = 74;
            this.lblLasVaraus.Text = "Varaus";
            // 
            // txbLasPostinro
            // 
            this.txbLasPostinro.Location = new System.Drawing.Point(338, 445);
            this.txbLasPostinro.MaxLength = 5;
            this.txbLasPostinro.Name = "txbLasPostinro";
            this.txbLasPostinro.Size = new System.Drawing.Size(130, 20);
            this.txbLasPostinro.TabIndex = 6;
            this.txbLasPostinro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbLasPostinro_KeyPress);
            // 
            // txbLasOsoite
            // 
            this.txbLasOsoite.Location = new System.Drawing.Point(338, 393);
            this.txbLasOsoite.MaxLength = 40;
            this.txbLasOsoite.Name = "txbLasOsoite";
            this.txbLasOsoite.Size = new System.Drawing.Size(130, 20);
            this.txbLasOsoite.TabIndex = 4;
            // 
            // txbLasPostitoimipaikka
            // 
            this.txbLasPostitoimipaikka.Location = new System.Drawing.Point(338, 419);
            this.txbLasPostitoimipaikka.MaxLength = 30;
            this.txbLasPostitoimipaikka.Name = "txbLasPostitoimipaikka";
            this.txbLasPostitoimipaikka.Size = new System.Drawing.Size(130, 20);
            this.txbLasPostitoimipaikka.TabIndex = 5;
            // 
            // txbLasNimi
            // 
            this.txbLasNimi.Location = new System.Drawing.Point(104, 445);
            this.txbLasNimi.MaxLength = 60;
            this.txbLasNimi.Name = "txbLasNimi";
            this.txbLasNimi.Size = new System.Drawing.Size(121, 20);
            this.txbLasNimi.TabIndex = 3;
            // 
            // dgwLaskut
            // 
            this.dgwLaskut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLaskut.Location = new System.Drawing.Point(29, 43);
            this.dgwLaskut.Name = "dgwLaskut";
            this.dgwLaskut.Size = new System.Drawing.Size(807, 329);
            this.dgwLaskut.TabIndex = 67;
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
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 66;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cboxLasAsiakas
            // 
            this.cboxLasAsiakas.FormattingEnabled = true;
            this.cboxLasAsiakas.Location = new System.Drawing.Point(104, 419);
            this.cboxLasAsiakas.Name = "cboxLasAsiakas";
            this.cboxLasAsiakas.Size = new System.Drawing.Size(121, 21);
            this.cboxLasAsiakas.TabIndex = 2;
            // 
            // lblLasSumma
            // 
            this.lblLasSumma.AutoSize = true;
            this.lblLasSumma.Location = new System.Drawing.Point(249, 471);
            this.lblLasSumma.Name = "lblLasSumma";
            this.lblLasSumma.Size = new System.Drawing.Size(42, 13);
            this.lblLasSumma.TabIndex = 87;
            this.lblLasSumma.Text = "Summa";
            // 
            // txbLasSumma
            // 
            this.txbLasSumma.Location = new System.Drawing.Point(338, 471);
            this.txbLasSumma.MaxLength = 8;
            this.txbLasSumma.Name = "txbLasSumma";
            this.txbLasSumma.Size = new System.Drawing.Size(130, 20);
            this.txbLasSumma.TabIndex = 7;
            this.txbLasSumma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbLasSumma_KeyPress);
            // 
            // txbLasAlv
            // 
            this.txbLasAlv.Location = new System.Drawing.Point(533, 393);
            this.txbLasAlv.MaxLength = 8;
            this.txbLasAlv.Name = "txbLasAlv";
            this.txbLasAlv.Size = new System.Drawing.Size(77, 20);
            this.txbLasAlv.TabIndex = 8;
            this.txbLasAlv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbLasAlv_KeyPress);
            // 
            // lblLasAlv
            // 
            this.lblLasAlv.AutoSize = true;
            this.lblLasAlv.Location = new System.Drawing.Point(485, 396);
            this.lblLasAlv.Name = "lblLasAlv";
            this.lblLasAlv.Size = new System.Drawing.Size(22, 13);
            this.lblLasAlv.TabIndex = 89;
            this.lblLasAlv.Text = "Alv";
            // 
            // btnLasPeruuta
            // 
            this.btnLasPeruuta.Location = new System.Drawing.Point(604, 495);
            this.btnLasPeruuta.Name = "btnLasPeruuta";
            this.btnLasPeruuta.Size = new System.Drawing.Size(99, 41);
            this.btnLasPeruuta.TabIndex = 91;
            this.btnLasPeruuta.Text = "Peruuta";
            this.btnLasPeruuta.UseVisualStyleBackColor = true;
            this.btnLasPeruuta.Click += new System.EventHandler(this.BtnLasPeruuta_Click);
            // 
            // btnLasTallenna
            // 
            this.btnLasTallenna.Location = new System.Drawing.Point(709, 495);
            this.btnLasTallenna.Name = "btnLasTallenna";
            this.btnLasTallenna.Size = new System.Drawing.Size(99, 41);
            this.btnLasTallenna.TabIndex = 92;
            this.btnLasTallenna.Text = "Tallenna";
            this.btnLasTallenna.UseVisualStyleBackColor = true;
            this.btnLasTallenna.Click += new System.EventHandler(this.BtnLasTallenna_Click);
            // 
            // Laskut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 579);
            this.Controls.Add(this.btnLasPeruuta);
            this.Controls.Add(this.btnLasTallenna);
            this.Controls.Add(this.txbLasAlv);
            this.Controls.Add(this.lblLasAlv);
            this.Controls.Add(this.txbLasSumma);
            this.Controls.Add(this.lblLasSumma);
            this.Controls.Add(this.cboxLasAsiakas);
            this.Controls.Add(this.lblLasAsiakas);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cboxLasVaraus);
            this.Controls.Add(this.btnLasLisaa);
            this.Controls.Add(this.btnLasPoista);
            this.Controls.Add(this.btnLasMuokkaa);
            this.Controls.Add(this.lblLasPostinro);
            this.Controls.Add(this.lblLasOsoite);
            this.Controls.Add(this.lblLasPostitoimipaikka);
            this.Controls.Add(this.lblLasNimi);
            this.Controls.Add(this.lblLasVaraus);
            this.Controls.Add(this.txbLasPostinro);
            this.Controls.Add(this.txbLasOsoite);
            this.Controls.Add(this.txbLasPostitoimipaikka);
            this.Controls.Add(this.txbLasNimi);
            this.Controls.Add(this.dgwLaskut);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Laskut";
            this.Text = "Laskut";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLaskut)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLasAsiakas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslTpstatuslabel1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboxLasVaraus;
        private System.Windows.Forms.Button btnLasLisaa;
        private System.Windows.Forms.Button btnLasPoista;
        private System.Windows.Forms.Button btnLasMuokkaa;
        private System.Windows.Forms.Label lblLasPostinro;
        private System.Windows.Forms.Label lblLasOsoite;
        private System.Windows.Forms.Label lblLasPostitoimipaikka;
        private System.Windows.Forms.Label lblLasNimi;
        private System.Windows.Forms.Label lblLasVaraus;
        private System.Windows.Forms.TextBox txbLasPostinro;
        private System.Windows.Forms.TextBox txbLasOsoite;
        private System.Windows.Forms.TextBox txbLasPostitoimipaikka;
        private System.Windows.Forms.TextBox txbLasNimi;
        private System.Windows.Forms.DataGridView dgwLaskut;
        private System.Windows.Forms.ToolStripMenuItem ohjeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cboxLasAsiakas;
        private System.Windows.Forms.Label lblLasSumma;
        private System.Windows.Forms.TextBox txbLasSumma;
        private System.Windows.Forms.TextBox txbLasAlv;
        private System.Windows.Forms.Label lblLasAlv;
        private System.Windows.Forms.Button btnLasPeruuta;
        private System.Windows.Forms.Button btnLasTallenna;
    }
}