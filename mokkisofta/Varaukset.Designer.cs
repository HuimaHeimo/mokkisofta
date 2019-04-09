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
            this.btnVarLisää = new System.Windows.Forms.Button();
            this.btnVarPoista = new System.Windows.Forms.Button();
            this.btnVarMuokkaa = new System.Windows.Forms.Button();
            this.lblVarAlkupvm = new System.Windows.Forms.Label();
            this.lblVarPvm = new System.Windows.Forms.Label();
            this.lblVarVahvistuspvm = new System.Windows.Forms.Label();
            this.lblVarToimipiste = new System.Windows.Forms.Label();
            this.lblVarAsiakas = new System.Windows.Forms.Label();
            this.txbVarNumero = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ohjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTpNumero = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cboxVarAsiakas = new System.Windows.Forms.ComboBox();
            this.cboxVarToimipiste = new System.Windows.Forms.ComboBox();
            this.dtVarPvm = new System.Windows.Forms.DateTimePicker();
            this.dtVarVahvistuspvm = new System.Windows.Forms.DateTimePicker();
            this.dtVarAlkupvm = new System.Windows.Forms.DateTimePicker();
            this.lblVarLoppupvm = new System.Windows.Forms.Label();
            this.dtVarLoppupvm = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(801, 22);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnVarLisää
            // 
            this.btnVarLisää.Location = new System.Drawing.Point(671, 402);
            this.btnVarLisää.Name = "btnVarLisää";
            this.btnVarLisää.Size = new System.Drawing.Size(99, 41);
            this.btnVarLisää.TabIndex = 39;
            this.btnVarLisää.Text = "Lisää";
            this.btnVarLisää.UseVisualStyleBackColor = true;
            // 
            // btnVarPoista
            // 
            this.btnVarPoista.Location = new System.Drawing.Point(671, 451);
            this.btnVarPoista.Name = "btnVarPoista";
            this.btnVarPoista.Size = new System.Drawing.Size(99, 41);
            this.btnVarPoista.TabIndex = 36;
            this.btnVarPoista.Text = "Poista";
            this.btnVarPoista.UseVisualStyleBackColor = true;
            // 
            // btnVarMuokkaa
            // 
            this.btnVarMuokkaa.Location = new System.Drawing.Point(566, 451);
            this.btnVarMuokkaa.Name = "btnVarMuokkaa";
            this.btnVarMuokkaa.Size = new System.Drawing.Size(99, 41);
            this.btnVarMuokkaa.TabIndex = 35;
            this.btnVarMuokkaa.Text = "Muokkaa";
            this.btnVarMuokkaa.UseVisualStyleBackColor = true;
            // 
            // lblVarAlkupvm
            // 
            this.lblVarAlkupvm.AutoSize = true;
            this.lblVarAlkupvm.Location = new System.Drawing.Point(237, 457);
            this.lblVarAlkupvm.Name = "lblVarAlkupvm";
            this.lblVarAlkupvm.Size = new System.Drawing.Size(51, 13);
            this.lblVarAlkupvm.TabIndex = 34;
            this.lblVarAlkupvm.Text = "Alku pvm";
            // 
            // lblVarPvm
            // 
            this.lblVarPvm.AutoSize = true;
            this.lblVarPvm.Location = new System.Drawing.Point(237, 402);
            this.lblVarPvm.Name = "lblVarPvm";
            this.lblVarPvm.Size = new System.Drawing.Size(64, 13);
            this.lblVarPvm.TabIndex = 33;
            this.lblVarPvm.Text = "Varattu pvm";
            // 
            // lblVarVahvistuspvm
            // 
            this.lblVarVahvistuspvm.AutoSize = true;
            this.lblVarVahvistuspvm.Location = new System.Drawing.Point(237, 430);
            this.lblVarVahvistuspvm.Name = "lblVarVahvistuspvm";
            this.lblVarVahvistuspvm.Size = new System.Drawing.Size(76, 13);
            this.lblVarVahvistuspvm.TabIndex = 32;
            this.lblVarVahvistuspvm.Text = "Vahvistus pvm";
            // 
            // lblVarToimipiste
            // 
            this.lblVarToimipiste.AutoSize = true;
            this.lblVarToimipiste.Location = new System.Drawing.Point(43, 473);
            this.lblVarToimipiste.Name = "lblVarToimipiste";
            this.lblVarToimipiste.Size = new System.Drawing.Size(54, 13);
            this.lblVarToimipiste.TabIndex = 31;
            this.lblVarToimipiste.Text = "Toimipiste";
            // 
            // lblVarAsiakas
            // 
            this.lblVarAsiakas.AutoSize = true;
            this.lblVarAsiakas.Location = new System.Drawing.Point(43, 438);
            this.lblVarAsiakas.Name = "lblVarAsiakas";
            this.lblVarAsiakas.Size = new System.Drawing.Size(44, 13);
            this.lblVarAsiakas.TabIndex = 30;
            this.lblVarAsiakas.Text = "Asiakas";
            // 
            // txbVarNumero
            // 
            this.txbVarNumero.Location = new System.Drawing.Point(93, 402);
            this.txbVarNumero.Name = "txbVarNumero";
            this.txbVarNumero.Size = new System.Drawing.Size(58, 20);
            this.txbVarNumero.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 330);
            this.dataGridView1.TabIndex = 22;
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
            // lblTpNumero
            // 
            this.lblTpNumero.AutoSize = true;
            this.lblTpNumero.Location = new System.Drawing.Point(43, 402);
            this.lblTpNumero.Name = "lblTpNumero";
            this.lblTpNumero.Size = new System.Drawing.Size(44, 13);
            this.lblTpNumero.TabIndex = 29;
            this.lblTpNumero.Text = "Numero";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.ohjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cboxVarAsiakas
            // 
            this.cboxVarAsiakas.FormattingEnabled = true;
            this.cboxVarAsiakas.Location = new System.Drawing.Point(93, 435);
            this.cboxVarAsiakas.Name = "cboxVarAsiakas";
            this.cboxVarAsiakas.Size = new System.Drawing.Size(121, 21);
            this.cboxVarAsiakas.TabIndex = 41;
            // 
            // cboxVarToimipiste
            // 
            this.cboxVarToimipiste.FormattingEnabled = true;
            this.cboxVarToimipiste.Location = new System.Drawing.Point(93, 470);
            this.cboxVarToimipiste.Name = "cboxVarToimipiste";
            this.cboxVarToimipiste.Size = new System.Drawing.Size(121, 21);
            this.cboxVarToimipiste.TabIndex = 42;
            // 
            // dtVarPvm
            // 
            this.dtVarPvm.Location = new System.Drawing.Point(326, 399);
            this.dtVarPvm.Name = "dtVarPvm";
            this.dtVarPvm.Size = new System.Drawing.Size(200, 20);
            this.dtVarPvm.TabIndex = 43;
            // 
            // dtVarVahvistuspvm
            // 
            this.dtVarVahvistuspvm.Location = new System.Drawing.Point(326, 425);
            this.dtVarVahvistuspvm.Name = "dtVarVahvistuspvm";
            this.dtVarVahvistuspvm.Size = new System.Drawing.Size(200, 20);
            this.dtVarVahvistuspvm.TabIndex = 44;
            // 
            // dtVarAlkupvm
            // 
            this.dtVarAlkupvm.Location = new System.Drawing.Point(326, 451);
            this.dtVarAlkupvm.Name = "dtVarAlkupvm";
            this.dtVarAlkupvm.Size = new System.Drawing.Size(200, 20);
            this.dtVarAlkupvm.TabIndex = 45;
            // 
            // lblVarLoppupvm
            // 
            this.lblVarLoppupvm.AutoSize = true;
            this.lblVarLoppupvm.Location = new System.Drawing.Point(237, 478);
            this.lblVarLoppupvm.Name = "lblVarLoppupvm";
            this.lblVarLoppupvm.Size = new System.Drawing.Size(60, 13);
            this.lblVarLoppupvm.TabIndex = 46;
            this.lblVarLoppupvm.Text = "Loppu pvm";
            // 
            // dtVarLoppupvm
            // 
            this.dtVarLoppupvm.Location = new System.Drawing.Point(326, 477);
            this.dtVarLoppupvm.Name = "dtVarLoppupvm";
            this.dtVarLoppupvm.Size = new System.Drawing.Size(200, 20);
            this.dtVarLoppupvm.TabIndex = 47;
            // 
            // Varaukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 522);
            this.Controls.Add(this.dtVarLoppupvm);
            this.Controls.Add(this.lblVarLoppupvm);
            this.Controls.Add(this.dtVarAlkupvm);
            this.Controls.Add(this.dtVarVahvistuspvm);
            this.Controls.Add(this.dtVarPvm);
            this.Controls.Add(this.cboxVarToimipiste);
            this.Controls.Add(this.cboxVarAsiakas);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnVarLisää);
            this.Controls.Add(this.btnVarPoista);
            this.Controls.Add(this.btnVarMuokkaa);
            this.Controls.Add(this.lblVarAlkupvm);
            this.Controls.Add(this.lblVarPvm);
            this.Controls.Add(this.lblVarVahvistuspvm);
            this.Controls.Add(this.lblVarToimipiste);
            this.Controls.Add(this.lblVarAsiakas);
            this.Controls.Add(this.txbVarNumero);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTpNumero);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Varaukset";
            this.Text = "Varaukset";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel tslTpstatuslabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnVarLisää;
        private System.Windows.Forms.Button btnVarPoista;
        private System.Windows.Forms.Button btnVarMuokkaa;
        private System.Windows.Forms.Label lblVarAlkupvm;
        private System.Windows.Forms.Label lblVarPvm;
        private System.Windows.Forms.Label lblVarVahvistuspvm;
        private System.Windows.Forms.Label lblVarToimipiste;
        private System.Windows.Forms.Label lblVarAsiakas;
        private System.Windows.Forms.TextBox txbVarNumero;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem ohjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.Label lblTpNumero;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cboxVarAsiakas;
        private System.Windows.Forms.ComboBox cboxVarToimipiste;
        private System.Windows.Forms.DateTimePicker dtVarPvm;
        private System.Windows.Forms.DateTimePicker dtVarVahvistuspvm;
        private System.Windows.Forms.DateTimePicker dtVarAlkupvm;
        private System.Windows.Forms.Label lblVarLoppupvm;
        private System.Windows.Forms.DateTimePicker dtVarLoppupvm;
    }
}