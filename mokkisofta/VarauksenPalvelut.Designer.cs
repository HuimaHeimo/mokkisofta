﻿namespace mokkisofta
{
    partial class VarauksenPalvelut
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
            this.lvlVarPalLukumaara = new System.Windows.Forms.Label();
            this.txbVarPalLukumaara = new System.Windows.Forms.TextBox();
            this.lblVarPalPalvelu = new System.Windows.Forms.Label();
            this.cboxVarPalPalvelu = new System.Windows.Forms.ComboBox();
            this.btnVarPalPeruuta = new System.Windows.Forms.Button();
            this.btnVarPalTallenna = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslTpstatuslabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnVarPalLisaa = new System.Windows.Forms.Button();
            this.btnVarPalPoista = new System.Windows.Forms.Button();
            this.btnVarPalMuokkaa = new System.Windows.Forms.Button();
            this.dgwVarauksenPalvelut = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ohjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietoaOhjelmastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ohjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVarauksenPalvelut)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvlVarPalLukumaara
            // 
            this.lvlVarPalLukumaara.AutoSize = true;
            this.lvlVarPalLukumaara.Location = new System.Drawing.Point(63, 462);
            this.lvlVarPalLukumaara.Name = "lvlVarPalLukumaara";
            this.lvlVarPalLukumaara.Size = new System.Drawing.Size(62, 26);
            this.lvlVarPalLukumaara.TabIndex = 74;
            this.lvlVarPalLukumaara.Text = "Palvelujen  \r\nlukumäärä";
            // 
            // txbVarPalLukumaara
            // 
            this.txbVarPalLukumaara.Location = new System.Drawing.Point(152, 459);
            this.txbVarPalLukumaara.MaxLength = 4;
            this.txbVarPalLukumaara.Name = "txbVarPalLukumaara";
            this.txbVarPalLukumaara.Size = new System.Drawing.Size(152, 20);
            this.txbVarPalLukumaara.TabIndex = 54;
            this.txbVarPalLukumaara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbVarPalLukumaara_KeyPress);
            // 
            // lblVarPalPalvelu
            // 
            this.lblVarPalPalvelu.AutoSize = true;
            this.lblVarPalPalvelu.Location = new System.Drawing.Point(63, 413);
            this.lblVarPalPalvelu.Name = "lblVarPalPalvelu";
            this.lblVarPalPalvelu.Size = new System.Drawing.Size(42, 13);
            this.lblVarPalPalvelu.TabIndex = 73;
            this.lblVarPalPalvelu.Text = "Palvelu";
            // 
            // cboxVarPalPalvelu
            // 
            this.cboxVarPalPalvelu.FormattingEnabled = true;
            this.cboxVarPalPalvelu.Location = new System.Drawing.Point(152, 410);
            this.cboxVarPalPalvelu.Name = "cboxVarPalPalvelu";
            this.cboxVarPalPalvelu.Size = new System.Drawing.Size(152, 21);
            this.cboxVarPalPalvelu.TabIndex = 53;
            // 
            // btnVarPalPeruuta
            // 
            this.btnVarPalPeruuta.Location = new System.Drawing.Point(432, 495);
            this.btnVarPalPeruuta.Name = "btnVarPalPeruuta";
            this.btnVarPalPeruuta.Size = new System.Drawing.Size(99, 41);
            this.btnVarPalPeruuta.TabIndex = 62;
            this.btnVarPalPeruuta.Text = "Peruuta";
            this.btnVarPalPeruuta.UseVisualStyleBackColor = true;
            this.btnVarPalPeruuta.Click += new System.EventHandler(this.BtnVarPalPeruuta_Click);
            // 
            // btnVarPalTallenna
            // 
            this.btnVarPalTallenna.Location = new System.Drawing.Point(537, 495);
            this.btnVarPalTallenna.Name = "btnVarPalTallenna";
            this.btnVarPalTallenna.Size = new System.Drawing.Size(99, 41);
            this.btnVarPalTallenna.TabIndex = 63;
            this.btnVarPalTallenna.Text = "Tallenna";
            this.btnVarPalTallenna.UseVisualStyleBackColor = true;
            this.btnVarPalTallenna.Click += new System.EventHandler(this.BtnVarPalTallenna_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTpstatuslabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 549);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(704, 22);
            this.statusStrip1.TabIndex = 71;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslTpstatuslabel1
            // 
            this.tslTpstatuslabel1.Name = "tslTpstatuslabel1";
            this.tslTpstatuslabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btnVarPalLisaa
            // 
            this.btnVarPalLisaa.Location = new System.Drawing.Point(537, 399);
            this.btnVarPalLisaa.Name = "btnVarPalLisaa";
            this.btnVarPalLisaa.Size = new System.Drawing.Size(99, 41);
            this.btnVarPalLisaa.TabIndex = 59;
            this.btnVarPalLisaa.Text = "Lisää";
            this.btnVarPalLisaa.UseVisualStyleBackColor = true;
            this.btnVarPalLisaa.Click += new System.EventHandler(this.BtnVarPalLisaa_Click);
            // 
            // btnVarPalPoista
            // 
            this.btnVarPalPoista.Location = new System.Drawing.Point(537, 448);
            this.btnVarPalPoista.Name = "btnVarPalPoista";
            this.btnVarPalPoista.Size = new System.Drawing.Size(99, 41);
            this.btnVarPalPoista.TabIndex = 61;
            this.btnVarPalPoista.Text = "Poista";
            this.btnVarPalPoista.UseVisualStyleBackColor = true;
            this.btnVarPalPoista.Click += new System.EventHandler(this.BtnVarPalPoista_Click);
            // 
            // btnVarPalMuokkaa
            // 
            this.btnVarPalMuokkaa.Location = new System.Drawing.Point(432, 448);
            this.btnVarPalMuokkaa.Name = "btnVarPalMuokkaa";
            this.btnVarPalMuokkaa.Size = new System.Drawing.Size(99, 41);
            this.btnVarPalMuokkaa.TabIndex = 60;
            this.btnVarPalMuokkaa.Text = "Muokkaa";
            this.btnVarPalMuokkaa.UseVisualStyleBackColor = true;
            this.btnVarPalMuokkaa.Click += new System.EventHandler(this.BtnVarPalMuokkaa_Click);
            // 
            // dgwVarauksenPalvelut
            // 
            this.dgwVarauksenPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVarauksenPalvelut.Location = new System.Drawing.Point(32, 45);
            this.dgwVarauksenPalvelut.Name = "dgwVarauksenPalvelut";
            this.dgwVarauksenPalvelut.Size = new System.Drawing.Size(604, 333);
            this.dgwVarauksenPalvelut.TabIndex = 65;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.ohjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 64;
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
            // poistuToolStripMenuItem
            // 
            this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            this.poistuToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.poistuToolStripMenuItem.Text = "Poistu";
            this.poistuToolStripMenuItem.Click += new System.EventHandler(this.poistuToolStripMenuItem_Click);
            // 
            // ohjeToolStripMenuItem
            // 
            this.ohjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tietoaOhjelmastaToolStripMenuItem,
            this.ohjeToolStripMenuItem1});
            this.ohjeToolStripMenuItem.Name = "ohjeToolStripMenuItem";
            this.ohjeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ohjeToolStripMenuItem.Text = "Ohje";
            // 
            // tietoaOhjelmastaToolStripMenuItem
            // 
            this.tietoaOhjelmastaToolStripMenuItem.Name = "tietoaOhjelmastaToolStripMenuItem";
            this.tietoaOhjelmastaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tietoaOhjelmastaToolStripMenuItem.Text = "Tietoa ohjelmasta";
            this.tietoaOhjelmastaToolStripMenuItem.Click += new System.EventHandler(this.tietoaOhjelmastaToolStripMenuItem_Click);
            // 
            // ohjeToolStripMenuItem1
            // 
            this.ohjeToolStripMenuItem1.Name = "ohjeToolStripMenuItem1";
            this.ohjeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ohjeToolStripMenuItem1.Text = "Ohje";
            this.ohjeToolStripMenuItem1.Click += new System.EventHandler(this.OhjeToolStripMenuItem1_Click);
            // 
            // VarauksenPalvelut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 571);
            this.Controls.Add(this.lvlVarPalLukumaara);
            this.Controls.Add(this.txbVarPalLukumaara);
            this.Controls.Add(this.lblVarPalPalvelu);
            this.Controls.Add(this.cboxVarPalPalvelu);
            this.Controls.Add(this.btnVarPalPeruuta);
            this.Controls.Add(this.btnVarPalTallenna);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnVarPalLisaa);
            this.Controls.Add(this.btnVarPalPoista);
            this.Controls.Add(this.btnVarPalMuokkaa);
            this.Controls.Add(this.dgwVarauksenPalvelut);
            this.Controls.Add(this.menuStrip1);
            this.Name = "VarauksenPalvelut";
            this.Text = "Varauksen Palvelut";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVarauksenPalvelut)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvlVarPalLukumaara;
        private System.Windows.Forms.TextBox txbVarPalLukumaara;
        private System.Windows.Forms.Label lblVarPalPalvelu;
        private System.Windows.Forms.ComboBox cboxVarPalPalvelu;
        private System.Windows.Forms.Button btnVarPalPeruuta;
        private System.Windows.Forms.Button btnVarPalTallenna;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslTpstatuslabel1;
        private System.Windows.Forms.Button btnVarPalLisaa;
        private System.Windows.Forms.Button btnVarPalPoista;
        private System.Windows.Forms.Button btnVarPalMuokkaa;
        private System.Windows.Forms.DataGridView dgwVarauksenPalvelut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ohjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietoaOhjelmastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ohjeToolStripMenuItem1;
    }
}