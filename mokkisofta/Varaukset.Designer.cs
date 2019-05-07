namespace mokkisofta
{
    partial class Varaukset
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
            this.tslTpstatuslabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnVarLisaa = new System.Windows.Forms.Button();
            this.btnVarPoista = new System.Windows.Forms.Button();
            this.btnVarMuokkaa = new System.Windows.Forms.Button();
            this.lblVarAlkupvm = new System.Windows.Forms.Label();
            this.lblVarPvm = new System.Windows.Forms.Label();
            this.lblVarVahvistuspvm = new System.Windows.Forms.Label();
            this.lblVarToimipiste = new System.Windows.Forms.Label();
            this.lblVarAsiakas = new System.Windows.Forms.Label();
            this.DgwVaraukset = new System.Windows.Forms.DataGridView();
            this.ohjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cboxVarAsiakas = new System.Windows.Forms.ComboBox();
            this.cboxVarToimipiste = new System.Windows.Forms.ComboBox();
            this.dtVarPvm = new System.Windows.Forms.DateTimePicker();
            this.dtVarVahvistuspvm = new System.Windows.Forms.DateTimePicker();
            this.dtVarAlkupvm = new System.Windows.Forms.DateTimePicker();
            this.lblVarLoppupvm = new System.Windows.Forms.Label();
            this.dtVarLoppupvm = new System.Windows.Forms.DateTimePicker();
            this.btnVarPeruuta = new System.Windows.Forms.Button();
            this.btnVarTallenna = new System.Windows.Forms.Button();
            this.btnVarauksenPalvelut = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwVaraukset)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tslTpstatuslabel1
            // 
            this.tslTpstatuslabel1.Name = "tslTpstatuslabel1";
            this.tslTpstatuslabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTpstatuslabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(905, 22);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnVarLisaa
            // 
            this.btnVarLisaa.Location = new System.Drawing.Point(726, 415);
            this.btnVarLisaa.Name = "btnVarLisaa";
            this.btnVarLisaa.Size = new System.Drawing.Size(99, 41);
            this.btnVarLisaa.TabIndex = 10;
            this.btnVarLisaa.Text = "Lisää";
            this.btnVarLisaa.UseVisualStyleBackColor = true;
            this.btnVarLisaa.Click += new System.EventHandler(this.BtnVarLisaa_Click);
            // 
            // btnVarPoista
            // 
            this.btnVarPoista.Location = new System.Drawing.Point(726, 464);
            this.btnVarPoista.Name = "btnVarPoista";
            this.btnVarPoista.Size = new System.Drawing.Size(99, 41);
            this.btnVarPoista.TabIndex = 12;
            this.btnVarPoista.Text = "Poista";
            this.btnVarPoista.UseVisualStyleBackColor = true;
            this.btnVarPoista.Click += new System.EventHandler(this.BtnVarPoista_Click);
            // 
            // btnVarMuokkaa
            // 
            this.btnVarMuokkaa.Location = new System.Drawing.Point(621, 464);
            this.btnVarMuokkaa.Name = "btnVarMuokkaa";
            this.btnVarMuokkaa.Size = new System.Drawing.Size(99, 41);
            this.btnVarMuokkaa.TabIndex = 11;
            this.btnVarMuokkaa.Text = "Muokkaa";
            this.btnVarMuokkaa.UseVisualStyleBackColor = true;
            this.btnVarMuokkaa.Click += new System.EventHandler(this.BtnVarMuokkaa_Click);
            // 
            // lblVarAlkupvm
            // 
            this.lblVarAlkupvm.AutoSize = true;
            this.lblVarAlkupvm.Location = new System.Drawing.Point(265, 457);
            this.lblVarAlkupvm.Name = "lblVarAlkupvm";
            this.lblVarAlkupvm.Size = new System.Drawing.Size(51, 13);
            this.lblVarAlkupvm.TabIndex = 34;
            this.lblVarAlkupvm.Text = "Alku pvm";
            // 
            // lblVarPvm
            // 
            this.lblVarPvm.AutoSize = true;
            this.lblVarPvm.Location = new System.Drawing.Point(265, 402);
            this.lblVarPvm.Name = "lblVarPvm";
            this.lblVarPvm.Size = new System.Drawing.Size(64, 13);
            this.lblVarPvm.TabIndex = 33;
            this.lblVarPvm.Text = "Varattu pvm";
            // 
            // lblVarVahvistuspvm
            // 
            this.lblVarVahvistuspvm.AutoSize = true;
            this.lblVarVahvistuspvm.Location = new System.Drawing.Point(265, 430);
            this.lblVarVahvistuspvm.Name = "lblVarVahvistuspvm";
            this.lblVarVahvistuspvm.Size = new System.Drawing.Size(76, 13);
            this.lblVarVahvistuspvm.TabIndex = 32;
            this.lblVarVahvistuspvm.Text = "Vahvistus pvm";
            // 
            // lblVarToimipiste
            // 
            this.lblVarToimipiste.AutoSize = true;
            this.lblVarToimipiste.Location = new System.Drawing.Point(12, 441);
            this.lblVarToimipiste.Name = "lblVarToimipiste";
            this.lblVarToimipiste.Size = new System.Drawing.Size(54, 13);
            this.lblVarToimipiste.TabIndex = 31;
            this.lblVarToimipiste.Text = "Toimipiste";
            // 
            // lblVarAsiakas
            // 
            this.lblVarAsiakas.AutoSize = true;
            this.lblVarAsiakas.Location = new System.Drawing.Point(12, 406);
            this.lblVarAsiakas.Name = "lblVarAsiakas";
            this.lblVarAsiakas.Size = new System.Drawing.Size(44, 13);
            this.lblVarAsiakas.TabIndex = 30;
            this.lblVarAsiakas.Text = "Asiakas";
            // 
            // DgwVaraukset
            // 
            this.DgwVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwVaraukset.Location = new System.Drawing.Point(32, 45);
            this.DgwVaraukset.Name = "DgwVaraukset";
            this.DgwVaraukset.Size = new System.Drawing.Size(792, 333);
            this.DgwVaraukset.TabIndex = 22;
            // 
            // ohjeToolStripMenuItem
            // 
            this.ohjeToolStripMenuItem.Name = "ohjeToolStripMenuItem";
            this.ohjeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ohjeToolStripMenuItem.Text = "Ohje";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.ohjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cboxVarAsiakas
            // 
            this.cboxVarAsiakas.FormattingEnabled = true;
            this.cboxVarAsiakas.Location = new System.Drawing.Point(79, 399);
            this.cboxVarAsiakas.Name = "cboxVarAsiakas";
            this.cboxVarAsiakas.Size = new System.Drawing.Size(152, 21);
            this.cboxVarAsiakas.TabIndex = 2;
            // 
            // cboxVarToimipiste
            // 
            this.cboxVarToimipiste.FormattingEnabled = true;
            this.cboxVarToimipiste.Location = new System.Drawing.Point(79, 434);
            this.cboxVarToimipiste.Name = "cboxVarToimipiste";
            this.cboxVarToimipiste.Size = new System.Drawing.Size(152, 21);
            this.cboxVarToimipiste.TabIndex = 3;
            // 
            // dtVarPvm
            // 
            this.dtVarPvm.Location = new System.Drawing.Point(354, 399);
            this.dtVarPvm.Name = "dtVarPvm";
            this.dtVarPvm.Size = new System.Drawing.Size(200, 20);
            this.dtVarPvm.TabIndex = 6;
            // 
            // dtVarVahvistuspvm
            // 
            this.dtVarVahvistuspvm.Location = new System.Drawing.Point(354, 425);
            this.dtVarVahvistuspvm.Name = "dtVarVahvistuspvm";
            this.dtVarVahvistuspvm.Size = new System.Drawing.Size(200, 20);
            this.dtVarVahvistuspvm.TabIndex = 7;
            // 
            // dtVarAlkupvm
            // 
            this.dtVarAlkupvm.Location = new System.Drawing.Point(354, 451);
            this.dtVarAlkupvm.Name = "dtVarAlkupvm";
            this.dtVarAlkupvm.Size = new System.Drawing.Size(200, 20);
            this.dtVarAlkupvm.TabIndex = 8;
            // 
            // lblVarLoppupvm
            // 
            this.lblVarLoppupvm.AutoSize = true;
            this.lblVarLoppupvm.Location = new System.Drawing.Point(265, 478);
            this.lblVarLoppupvm.Name = "lblVarLoppupvm";
            this.lblVarLoppupvm.Size = new System.Drawing.Size(60, 13);
            this.lblVarLoppupvm.TabIndex = 46;
            this.lblVarLoppupvm.Text = "Loppu pvm";
            // 
            // dtVarLoppupvm
            // 
            this.dtVarLoppupvm.Location = new System.Drawing.Point(354, 477);
            this.dtVarLoppupvm.Name = "dtVarLoppupvm";
            this.dtVarLoppupvm.Size = new System.Drawing.Size(200, 20);
            this.dtVarLoppupvm.TabIndex = 9;
            // 
            // btnVarPeruuta
            // 
            this.btnVarPeruuta.Location = new System.Drawing.Point(621, 511);
            this.btnVarPeruuta.Name = "btnVarPeruuta";
            this.btnVarPeruuta.Size = new System.Drawing.Size(99, 41);
            this.btnVarPeruuta.TabIndex = 13;
            this.btnVarPeruuta.Text = "Peruuta";
            this.btnVarPeruuta.UseVisualStyleBackColor = true;
            this.btnVarPeruuta.Click += new System.EventHandler(this.BtnVarPeruuta_Click);
            // 
            // btnVarTallenna
            // 
            this.btnVarTallenna.Location = new System.Drawing.Point(726, 511);
            this.btnVarTallenna.Name = "btnVarTallenna";
            this.btnVarTallenna.Size = new System.Drawing.Size(99, 41);
            this.btnVarTallenna.TabIndex = 14;
            this.btnVarTallenna.Text = "Tallenna";
            this.btnVarTallenna.UseVisualStyleBackColor = true;
            this.btnVarTallenna.Click += new System.EventHandler(this.BtnVarTallenna_Click);
            // 
            // btnVarauksenPalvelut
            // 
            this.btnVarauksenPalvelut.Location = new System.Drawing.Point(50, 511);
            this.btnVarauksenPalvelut.Name = "btnVarauksenPalvelut";
            this.btnVarauksenPalvelut.Size = new System.Drawing.Size(99, 41);
            this.btnVarauksenPalvelut.TabIndex = 47;
            this.btnVarauksenPalvelut.Text = "Varauksen Palvelut";
            this.btnVarauksenPalvelut.UseVisualStyleBackColor = true;
            this.btnVarauksenPalvelut.Click += new System.EventHandler(this.btnVarauksenPalvelut_Click);
            // 
            // Varaukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 610);
            this.Controls.Add(this.btnVarauksenPalvelut);
            this.Controls.Add(this.btnVarPeruuta);
            this.Controls.Add(this.btnVarTallenna);
            this.Controls.Add(this.dtVarLoppupvm);
            this.Controls.Add(this.lblVarLoppupvm);
            this.Controls.Add(this.dtVarAlkupvm);
            this.Controls.Add(this.dtVarVahvistuspvm);
            this.Controls.Add(this.dtVarPvm);
            this.Controls.Add(this.cboxVarToimipiste);
            this.Controls.Add(this.cboxVarAsiakas);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnVarLisaa);
            this.Controls.Add(this.btnVarPoista);
            this.Controls.Add(this.btnVarMuokkaa);
            this.Controls.Add(this.lblVarAlkupvm);
            this.Controls.Add(this.lblVarPvm);
            this.Controls.Add(this.lblVarVahvistuspvm);
            this.Controls.Add(this.lblVarToimipiste);
            this.Controls.Add(this.lblVarAsiakas);
            this.Controls.Add(this.DgwVaraukset);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Varaukset";
            this.Text = "Varaukset";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwVaraukset)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel tslTpstatuslabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnVarLisaa;
        private System.Windows.Forms.Button btnVarPoista;
        private System.Windows.Forms.Button btnVarMuokkaa;
        private System.Windows.Forms.Label lblVarAlkupvm;
        private System.Windows.Forms.Label lblVarPvm;
        private System.Windows.Forms.Label lblVarVahvistuspvm;
        private System.Windows.Forms.Label lblVarToimipiste;
        private System.Windows.Forms.Label lblVarAsiakas;
        private System.Windows.Forms.DataGridView DgwVaraukset;
        private System.Windows.Forms.ToolStripMenuItem ohjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cboxVarAsiakas;
        private System.Windows.Forms.ComboBox cboxVarToimipiste;
        private System.Windows.Forms.DateTimePicker dtVarPvm;
        private System.Windows.Forms.DateTimePicker dtVarVahvistuspvm;
        private System.Windows.Forms.DateTimePicker dtVarAlkupvm;
        private System.Windows.Forms.Label lblVarLoppupvm;
        private System.Windows.Forms.DateTimePicker dtVarLoppupvm;
        private System.Windows.Forms.Button btnVarPeruuta;
        private System.Windows.Forms.Button btnVarTallenna;
        private System.Windows.Forms.Button btnVarauksenPalvelut;
    }
}