﻿namespace mokkisofta
{
    partial class Toimipisteet
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
            this.DgwToimipisteet = new System.Windows.Forms.DataGridView();
            this.txbTpNumero = new System.Windows.Forms.TextBox();
            this.txbTpNimi = new System.Windows.Forms.TextBox();
            this.txbTpOsoite = new System.Windows.Forms.TextBox();
            this.txbTpPtoimipaikka = new System.Windows.Forms.TextBox();
            this.txbTpPostinumero = new System.Windows.Forms.TextBox();
            this.txbTpSposti = new System.Windows.Forms.TextBox();
            this.lblTpNumero = new System.Windows.Forms.Label();
            this.lblTpNimi = new System.Windows.Forms.Label();
            this.lblTpOsoite = new System.Windows.Forms.Label();
            this.lblTpPtoimipaikka = new System.Windows.Forms.Label();
            this.lblTpPostinumero = new System.Windows.Forms.Label();
            this.lblTpSposti = new System.Windows.Forms.Label();
            this.btnTpMuokkaa = new System.Windows.Forms.Button();
            this.btnTpPoista = new System.Windows.Forms.Button();
            this.txbTpPuhnro = new System.Windows.Forms.TextBox();
            this.lblTpPuhnro = new System.Windows.Forms.Label();
            this.btnTpLisaa = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslTpstatuslabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwToimipisteet)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            // DgwToimipisteet
            // 
            this.DgwToimipisteet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwToimipisteet.Location = new System.Drawing.Point(32, 45);
            this.DgwToimipisteet.Name = "DgwToimipisteet";
            this.DgwToimipisteet.Size = new System.Drawing.Size(738, 330);
            this.DgwToimipisteet.TabIndex = 2;
            // 
            // txbTpNumero
            // 
            this.txbTpNumero.Location = new System.Drawing.Point(93, 402);
            this.txbTpNumero.Name = "txbTpNumero";
            this.txbTpNumero.Size = new System.Drawing.Size(58, 20);
            this.txbTpNumero.TabIndex = 3;
            // 
            // txbTpNimi
            // 
            this.txbTpNimi.Location = new System.Drawing.Point(93, 438);
            this.txbTpNimi.Name = "txbTpNimi";
            this.txbTpNimi.Size = new System.Drawing.Size(130, 20);
            this.txbTpNimi.TabIndex = 4;
            // 
            // txbTpOsoite
            // 
            this.txbTpOsoite.Location = new System.Drawing.Point(93, 473);
            this.txbTpOsoite.Name = "txbTpOsoite";
            this.txbTpOsoite.Size = new System.Drawing.Size(130, 20);
            this.txbTpOsoite.TabIndex = 5;
            // 
            // txbTpPtoimipaikka
            // 
            this.txbTpPtoimipaikka.Location = new System.Drawing.Point(326, 438);
            this.txbTpPtoimipaikka.Name = "txbTpPtoimipaikka";
            this.txbTpPtoimipaikka.Size = new System.Drawing.Size(130, 20);
            this.txbTpPtoimipaikka.TabIndex = 6;
            // 
            // txbTpPostinumero
            // 
            this.txbTpPostinumero.Location = new System.Drawing.Point(326, 402);
            this.txbTpPostinumero.Name = "txbTpPostinumero";
            this.txbTpPostinumero.Size = new System.Drawing.Size(77, 20);
            this.txbTpPostinumero.TabIndex = 7;
            // 
            // txbTpSposti
            // 
            this.txbTpSposti.Location = new System.Drawing.Point(326, 473);
            this.txbTpSposti.Name = "txbTpSposti";
            this.txbTpSposti.Size = new System.Drawing.Size(130, 20);
            this.txbTpSposti.TabIndex = 8;
            // 
            // lblTpNumero
            // 
            this.lblTpNumero.AutoSize = true;
            this.lblTpNumero.Location = new System.Drawing.Point(43, 402);
            this.lblTpNumero.Name = "lblTpNumero";
            this.lblTpNumero.Size = new System.Drawing.Size(44, 13);
            this.lblTpNumero.TabIndex = 9;
            this.lblTpNumero.Text = "Numero";
            // 
            // lblTpNimi
            // 
            this.lblTpNimi.AutoSize = true;
            this.lblTpNimi.Location = new System.Drawing.Point(43, 438);
            this.lblTpNimi.Name = "lblTpNimi";
            this.lblTpNimi.Size = new System.Drawing.Size(27, 13);
            this.lblTpNimi.TabIndex = 10;
            this.lblTpNimi.Text = "Nimi";
            // 
            // lblTpOsoite
            // 
            this.lblTpOsoite.AutoSize = true;
            this.lblTpOsoite.Location = new System.Drawing.Point(43, 473);
            this.lblTpOsoite.Name = "lblTpOsoite";
            this.lblTpOsoite.Size = new System.Drawing.Size(37, 13);
            this.lblTpOsoite.TabIndex = 11;
            this.lblTpOsoite.Text = "Osoite";
            // 
            // lblTpPtoimipaikka
            // 
            this.lblTpPtoimipaikka.AutoSize = true;
            this.lblTpPtoimipaikka.Location = new System.Drawing.Point(237, 438);
            this.lblTpPtoimipaikka.Name = "lblTpPtoimipaikka";
            this.lblTpPtoimipaikka.Size = new System.Drawing.Size(83, 13);
            this.lblTpPtoimipaikka.TabIndex = 12;
            this.lblTpPtoimipaikka.Text = "Postitoimipaikka";
            // 
            // lblTpPostinumero
            // 
            this.lblTpPostinumero.AutoSize = true;
            this.lblTpPostinumero.Location = new System.Drawing.Point(237, 402);
            this.lblTpPostinumero.Name = "lblTpPostinumero";
            this.lblTpPostinumero.Size = new System.Drawing.Size(65, 13);
            this.lblTpPostinumero.TabIndex = 13;
            this.lblTpPostinumero.Text = "Postinumero";
            // 
            // lblTpSposti
            // 
            this.lblTpSposti.AutoSize = true;
            this.lblTpSposti.Location = new System.Drawing.Point(237, 473);
            this.lblTpSposti.Name = "lblTpSposti";
            this.lblTpSposti.Size = new System.Drawing.Size(60, 13);
            this.lblTpSposti.TabIndex = 14;
            this.lblTpSposti.Text = "Sähköposti";
            // 
            // btnTpMuokkaa
            // 
            this.btnTpMuokkaa.Location = new System.Drawing.Point(566, 451);
            this.btnTpMuokkaa.Name = "btnTpMuokkaa";
            this.btnTpMuokkaa.Size = new System.Drawing.Size(99, 41);
            this.btnTpMuokkaa.TabIndex = 15;
            this.btnTpMuokkaa.Text = "Muokkaa";
            this.btnTpMuokkaa.UseVisualStyleBackColor = true;
            // 
            // btnTpPoista
            // 
            this.btnTpPoista.Location = new System.Drawing.Point(671, 451);
            this.btnTpPoista.Name = "btnTpPoista";
            this.btnTpPoista.Size = new System.Drawing.Size(99, 41);
            this.btnTpPoista.TabIndex = 16;
            this.btnTpPoista.Text = "Poista";
            this.btnTpPoista.UseVisualStyleBackColor = true;
            // 
            // txbTpPuhnro
            // 
            this.txbTpPuhnro.Location = new System.Drawing.Point(515, 402);
            this.txbTpPuhnro.Name = "txbTpPuhnro";
            this.txbTpPuhnro.Size = new System.Drawing.Size(130, 20);
            this.txbTpPuhnro.TabIndex = 17;
            // 
            // lblTpPuhnro
            // 
            this.lblTpPuhnro.AutoSize = true;
            this.lblTpPuhnro.Location = new System.Drawing.Point(432, 402);
            this.lblTpPuhnro.Name = "lblTpPuhnro";
            this.lblTpPuhnro.Size = new System.Drawing.Size(77, 13);
            this.lblTpPuhnro.TabIndex = 18;
            this.lblTpPuhnro.Text = "Puhelinnumero";
            // 
            // btnTpLisaa
            // 
            this.btnTpLisaa.Location = new System.Drawing.Point(671, 402);
            this.btnTpLisaa.Name = "btnTpLisaa";
            this.btnTpLisaa.Size = new System.Drawing.Size(99, 41);
            this.btnTpLisaa.TabIndex = 19;
            this.btnTpLisaa.Text = "Lisää";
            this.btnTpLisaa.UseVisualStyleBackColor = true;
            this.btnTpLisaa.Click += new System.EventHandler(this.BtnTpLisaa_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTpstatuslabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(801, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslTpstatuslabel1
            // 
            this.tslTpstatuslabel1.Name = "tslTpstatuslabel1";
            this.tslTpstatuslabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Toimipisteet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 522);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnTpLisaa);
            this.Controls.Add(this.lblTpPuhnro);
            this.Controls.Add(this.txbTpPuhnro);
            this.Controls.Add(this.btnTpPoista);
            this.Controls.Add(this.btnTpMuokkaa);
            this.Controls.Add(this.lblTpSposti);
            this.Controls.Add(this.lblTpPostinumero);
            this.Controls.Add(this.lblTpPtoimipaikka);
            this.Controls.Add(this.lblTpOsoite);
            this.Controls.Add(this.lblTpNimi);
            this.Controls.Add(this.lblTpNumero);
            this.Controls.Add(this.txbTpSposti);
            this.Controls.Add(this.txbTpPostinumero);
            this.Controls.Add(this.txbTpPtoimipaikka);
            this.Controls.Add(this.txbTpOsoite);
            this.Controls.Add(this.txbTpNimi);
            this.Controls.Add(this.txbTpNumero);
            this.Controls.Add(this.DgwToimipisteet);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Toimipisteet";
            this.Text = "Toimipisteet";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwToimipisteet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ohjeToolStripMenuItem;
        private System.Windows.Forms.DataGridView DgwToimipisteet;
        private System.Windows.Forms.TextBox txbTpNumero;
        private System.Windows.Forms.TextBox txbTpNimi;
        private System.Windows.Forms.TextBox txbTpOsoite;
        private System.Windows.Forms.TextBox txbTpPtoimipaikka;
        private System.Windows.Forms.TextBox txbTpPostinumero;
        private System.Windows.Forms.TextBox txbTpSposti;
        private System.Windows.Forms.Label lblTpNumero;
        private System.Windows.Forms.Label lblTpNimi;
        private System.Windows.Forms.Label lblTpOsoite;
        private System.Windows.Forms.Label lblTpPtoimipaikka;
        private System.Windows.Forms.Label lblTpPostinumero;
        private System.Windows.Forms.Label lblTpSposti;
        private System.Windows.Forms.Button btnTpMuokkaa;
        private System.Windows.Forms.Button btnTpPoista;
        private System.Windows.Forms.TextBox txbTpPuhnro;
        private System.Windows.Forms.Label lblTpPuhnro;
        private System.Windows.Forms.Button btnTpLisaa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslTpstatuslabel1;
    }
}