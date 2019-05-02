namespace mokkisofta
{
    partial class Raportit
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
            this.dgwRaportit = new System.Windows.Forms.DataGridView();
            this.btnRptHae = new System.Windows.Forms.Button();
            this.cbxRptToimipiste = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxRptPalvelut = new System.Windows.Forms.ComboBox();
            this.dtpRptAlku = new System.Windows.Forms.DateTimePicker();
            this.dtpRptLoppu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRptTyhjenna = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxRptAsiakkaat = new System.Windows.Forms.ComboBox();
            this.btnRptLataa = new System.Windows.Forms.Button();
            this.btnRptTallenna = new System.Windows.Forms.Button();
            this.btnRptTulosta = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRaportit)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.ohjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
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
            // dgwRaportit
            // 
            this.dgwRaportit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRaportit.Location = new System.Drawing.Point(12, 27);
            this.dgwRaportit.Name = "dgwRaportit";
            this.dgwRaportit.Size = new System.Drawing.Size(860, 376);
            this.dgwRaportit.TabIndex = 2;
            // 
            // btnRptHae
            // 
            this.btnRptHae.Location = new System.Drawing.Point(668, 409);
            this.btnRptHae.Name = "btnRptHae";
            this.btnRptHae.Size = new System.Drawing.Size(99, 41);
            this.btnRptHae.TabIndex = 11;
            this.btnRptHae.Text = "Hae";
            this.btnRptHae.UseVisualStyleBackColor = true;
            // 
            // cbxRptToimipiste
            // 
            this.cbxRptToimipiste.FormattingEnabled = true;
            this.cbxRptToimipiste.Location = new System.Drawing.Point(155, 420);
            this.cbxRptToimipiste.Name = "cbxRptToimipiste";
            this.cbxRptToimipiste.Size = new System.Drawing.Size(121, 21);
            this.cbxRptToimipiste.TabIndex = 12;
            this.cbxRptToimipiste.Text = "Kaikki";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hae raportit toimipisteestä : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Hae raportit palvelusta :";
            // 
            // cbxRptPalvelut
            // 
            this.cbxRptPalvelut.FormattingEnabled = true;
            this.cbxRptPalvelut.Location = new System.Drawing.Point(155, 447);
            this.cbxRptPalvelut.Name = "cbxRptPalvelut";
            this.cbxRptPalvelut.Size = new System.Drawing.Size(121, 21);
            this.cbxRptPalvelut.TabIndex = 14;
            this.cbxRptPalvelut.Text = "Kaikki";
            // 
            // dtpRptAlku
            // 
            this.dtpRptAlku.Location = new System.Drawing.Point(407, 422);
            this.dtpRptAlku.Name = "dtpRptAlku";
            this.dtpRptAlku.Size = new System.Drawing.Size(200, 20);
            this.dtpRptAlku.TabIndex = 16;
            this.dtpRptAlku.Value = new System.DateTime(2019, 4, 25, 0, 0, 0, 0);
            // 
            // dtpRptLoppu
            // 
            this.dtpRptLoppu.Location = new System.Drawing.Point(407, 448);
            this.dtpRptLoppu.Name = "dtpRptLoppu";
            this.dtpRptLoppu.Size = new System.Drawing.Size(200, 20);
            this.dtpRptLoppu.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Raportin alku pvä :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Raportin loppu pvä :";
            // 
            // btnRptTyhjenna
            // 
            this.btnRptTyhjenna.Location = new System.Drawing.Point(773, 409);
            this.btnRptTyhjenna.Name = "btnRptTyhjenna";
            this.btnRptTyhjenna.Size = new System.Drawing.Size(99, 41);
            this.btnRptTyhjenna.TabIndex = 20;
            this.btnRptTyhjenna.Text = "Tyhjennä";
            this.btnRptTyhjenna.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Hae raportit asiakkaasta :";
            // 
            // cbxRptAsiakkaat
            // 
            this.cbxRptAsiakkaat.FormattingEnabled = true;
            this.cbxRptAsiakkaat.Location = new System.Drawing.Point(155, 474);
            this.cbxRptAsiakkaat.Name = "cbxRptAsiakkaat";
            this.cbxRptAsiakkaat.Size = new System.Drawing.Size(121, 21);
            this.cbxRptAsiakkaat.TabIndex = 21;
            this.cbxRptAsiakkaat.Text = "Kaikki";
            // 
            // btnRptLataa
            // 
            this.btnRptLataa.Location = new System.Drawing.Point(773, 456);
            this.btnRptLataa.Name = "btnRptLataa";
            this.btnRptLataa.Size = new System.Drawing.Size(99, 41);
            this.btnRptLataa.TabIndex = 24;
            this.btnRptLataa.Text = "Lataa";
            this.btnRptLataa.UseVisualStyleBackColor = true;
            // 
            // btnRptTallenna
            // 
            this.btnRptTallenna.Location = new System.Drawing.Point(668, 456);
            this.btnRptTallenna.Name = "btnRptTallenna";
            this.btnRptTallenna.Size = new System.Drawing.Size(99, 41);
            this.btnRptTallenna.TabIndex = 23;
            this.btnRptTallenna.Text = "Tallenna";
            this.btnRptTallenna.UseVisualStyleBackColor = true;
            // 
            // btnRptTulosta
            // 
            this.btnRptTulosta.Location = new System.Drawing.Point(773, 503);
            this.btnRptTulosta.Name = "btnRptTulosta";
            this.btnRptTulosta.Size = new System.Drawing.Size(99, 41);
            this.btnRptTulosta.TabIndex = 25;
            this.btnRptTulosta.Text = "Tulosta";
            this.btnRptTulosta.UseVisualStyleBackColor = true;
            // 
            // Raportit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnRptTulosta);
            this.Controls.Add(this.btnRptLataa);
            this.Controls.Add(this.btnRptTallenna);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxRptAsiakkaat);
            this.Controls.Add(this.btnRptTyhjenna);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpRptLoppu);
            this.Controls.Add(this.dtpRptAlku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxRptPalvelut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxRptToimipiste);
            this.Controls.Add(this.btnRptHae);
            this.Controls.Add(this.dgwRaportit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Raportit";
            this.Text = "Raportit";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRaportit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ohjeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgwRaportit;
        private System.Windows.Forms.Button btnRptHae;
        private System.Windows.Forms.ComboBox cbxRptToimipiste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxRptPalvelut;
        private System.Windows.Forms.DateTimePicker dtpRptAlku;
        private System.Windows.Forms.DateTimePicker dtpRptLoppu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRptTyhjenna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxRptAsiakkaat;
        private System.Windows.Forms.Button btnRptLataa;
        private System.Windows.Forms.Button btnRptTallenna;
        private System.Windows.Forms.Button btnRptTulosta;
    }
}