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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raportit));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ohjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietoaOhjelmastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnRptTulosta = new System.Windows.Forms.Button();
            this.chrRptChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rdbRptRajaatoimipisteeseen = new System.Windows.Forms.RadioButton();
            this.rdbRajaaPalvelu = new System.Windows.Forms.RadioButton();
            this.rdbRajaaAsiakas = new System.Windows.Forms.RadioButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ohjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRaportit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrRptChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.ohjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 24);
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
            // dgwRaportit
            // 
            this.dgwRaportit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRaportit.Location = new System.Drawing.Point(12, 27);
            this.dgwRaportit.Name = "dgwRaportit";
            this.dgwRaportit.Size = new System.Drawing.Size(543, 376);
            this.dgwRaportit.TabIndex = 2;
            // 
            // btnRptHae
            // 
            this.btnRptHae.Location = new System.Drawing.Point(941, 409);
            this.btnRptHae.Name = "btnRptHae";
            this.btnRptHae.Size = new System.Drawing.Size(99, 41);
            this.btnRptHae.TabIndex = 11;
            this.btnRptHae.Text = "Hae";
            this.btnRptHae.UseVisualStyleBackColor = true;
            this.btnRptHae.Click += new System.EventHandler(this.BtnRptHae_Click);
            // 
            // cbxRptToimipiste
            // 
            this.cbxRptToimipiste.Enabled = false;
            this.cbxRptToimipiste.FormattingEnabled = true;
            this.cbxRptToimipiste.Location = new System.Drawing.Point(709, 420);
            this.cbxRptToimipiste.Name = "cbxRptToimipiste";
            this.cbxRptToimipiste.Size = new System.Drawing.Size(121, 21);
            this.cbxRptToimipiste.TabIndex = 12;
            this.cbxRptToimipiste.Text = "Kaikki";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Toimipiste : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Palvelu :";
            // 
            // cbxRptPalvelut
            // 
            this.cbxRptPalvelut.Enabled = false;
            this.cbxRptPalvelut.FormattingEnabled = true;
            this.cbxRptPalvelut.Location = new System.Drawing.Point(709, 447);
            this.cbxRptPalvelut.Name = "cbxRptPalvelut";
            this.cbxRptPalvelut.Size = new System.Drawing.Size(121, 21);
            this.cbxRptPalvelut.TabIndex = 14;
            this.cbxRptPalvelut.Text = "Kaikki";
            // 
            // dtpRptAlku
            // 
            this.dtpRptAlku.Location = new System.Drawing.Point(709, 501);
            this.dtpRptAlku.Name = "dtpRptAlku";
            this.dtpRptAlku.Size = new System.Drawing.Size(200, 20);
            this.dtpRptAlku.TabIndex = 16;
            this.dtpRptAlku.Value = new System.DateTime(2019, 4, 25, 0, 0, 0, 0);
            // 
            // dtpRptLoppu
            // 
            this.dtpRptLoppu.Location = new System.Drawing.Point(709, 527);
            this.dtpRptLoppu.Name = "dtpRptLoppu";
            this.dtpRptLoppu.Size = new System.Drawing.Size(200, 20);
            this.dtpRptLoppu.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Raportin alku pvä :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Raportin loppu pvä :";
            // 
            // btnRptTyhjenna
            // 
            this.btnRptTyhjenna.Location = new System.Drawing.Point(941, 456);
            this.btnRptTyhjenna.Name = "btnRptTyhjenna";
            this.btnRptTyhjenna.Size = new System.Drawing.Size(99, 41);
            this.btnRptTyhjenna.TabIndex = 20;
            this.btnRptTyhjenna.Text = "Tyhjennä";
            this.btnRptTyhjenna.UseVisualStyleBackColor = true;
            this.btnRptTyhjenna.Click += new System.EventHandler(this.BtnRptTyhjenna_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Asiakkas :";
            // 
            // cbxRptAsiakkaat
            // 
            this.cbxRptAsiakkaat.Enabled = false;
            this.cbxRptAsiakkaat.FormattingEnabled = true;
            this.cbxRptAsiakkaat.Location = new System.Drawing.Point(709, 474);
            this.cbxRptAsiakkaat.Name = "cbxRptAsiakkaat";
            this.cbxRptAsiakkaat.Size = new System.Drawing.Size(121, 21);
            this.cbxRptAsiakkaat.TabIndex = 21;
            this.cbxRptAsiakkaat.Text = "Kaikki";
            // 
            // btnRptTulosta
            // 
            this.btnRptTulosta.Location = new System.Drawing.Point(941, 503);
            this.btnRptTulosta.Name = "btnRptTulosta";
            this.btnRptTulosta.Size = new System.Drawing.Size(99, 41);
            this.btnRptTulosta.TabIndex = 25;
            this.btnRptTulosta.Text = "Tulosta";
            this.btnRptTulosta.UseVisualStyleBackColor = true;
            this.btnRptTulosta.Click += new System.EventHandler(this.BtnRptTulosta_Click);
            // 
            // chrRptChart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chrRptChart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrRptChart1.Legends.Add(legend1);
            this.chrRptChart1.Location = new System.Drawing.Point(561, 27);
            this.chrRptChart1.Name = "chrRptChart1";
            this.chrRptChart1.Size = new System.Drawing.Size(479, 376);
            this.chrRptChart1.TabIndex = 26;
            this.chrRptChart1.Text = "chart1";
            // 
            // rdbRptRajaatoimipisteeseen
            // 
            this.rdbRptRajaatoimipisteeseen.AutoSize = true;
            this.rdbRptRajaatoimipisteeseen.Location = new System.Drawing.Point(836, 421);
            this.rdbRptRajaatoimipisteeseen.Name = "rdbRptRajaatoimipisteeseen";
            this.rdbRptRajaatoimipisteeseen.Size = new System.Drawing.Size(99, 17);
            this.rdbRptRajaatoimipisteeseen.TabIndex = 30;
            this.rdbRptRajaatoimipisteeseen.TabStop = true;
            this.rdbRptRajaatoimipisteeseen.Text = "Rajaa toimipiste";
            this.rdbRptRajaatoimipisteeseen.UseVisualStyleBackColor = true;
            this.rdbRptRajaatoimipisteeseen.CheckedChanged += new System.EventHandler(this.RdbRptRajaatoimipisteeseen_CheckedChanged);
            // 
            // rdbRajaaPalvelu
            // 
            this.rdbRajaaPalvelu.AutoSize = true;
            this.rdbRajaaPalvelu.Location = new System.Drawing.Point(836, 448);
            this.rdbRajaaPalvelu.Name = "rdbRajaaPalvelu";
            this.rdbRajaaPalvelu.Size = new System.Drawing.Size(90, 17);
            this.rdbRajaaPalvelu.TabIndex = 31;
            this.rdbRajaaPalvelu.TabStop = true;
            this.rdbRajaaPalvelu.Text = "Rajaa palvelu";
            this.rdbRajaaPalvelu.UseVisualStyleBackColor = true;
            this.rdbRajaaPalvelu.CheckedChanged += new System.EventHandler(this.RdbRajaaPalvelu_CheckedChanged);
            // 
            // rdbRajaaAsiakas
            // 
            this.rdbRajaaAsiakas.AutoSize = true;
            this.rdbRajaaAsiakas.Location = new System.Drawing.Point(836, 475);
            this.rdbRajaaAsiakas.Name = "rdbRajaaAsiakas";
            this.rdbRajaaAsiakas.Size = new System.Drawing.Size(92, 17);
            this.rdbRajaaAsiakas.TabIndex = 32;
            this.rdbRajaaAsiakas.TabStop = true;
            this.rdbRajaaAsiakas.Text = "Rajaa asiakas";
            this.rdbRajaaAsiakas.UseVisualStyleBackColor = true;
            this.rdbRajaaAsiakas.CheckedChanged += new System.EventHandler(this.RdbRajaaAsiakas_CheckedChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // ohjeToolStripMenuItem1
            // 
            this.ohjeToolStripMenuItem1.Name = "ohjeToolStripMenuItem1";
            this.ohjeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ohjeToolStripMenuItem1.Text = "Ohje";
            this.ohjeToolStripMenuItem1.Click += new System.EventHandler(this.OhjeToolStripMenuItem1_Click);
            // 
            // Raportit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 561);
            this.Controls.Add(this.rdbRajaaAsiakas);
            this.Controls.Add(this.rdbRajaaPalvelu);
            this.Controls.Add(this.rdbRptRajaatoimipisteeseen);
            this.Controls.Add(this.chrRptChart1);
            this.Controls.Add(this.btnRptTulosta);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1068, 600);
            this.MinimumSize = new System.Drawing.Size(1068, 600);
            this.Name = "Raportit";
            this.Text = "Raportit";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRaportit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrRptChart1)).EndInit();
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
        private System.Windows.Forms.Button btnRptTulosta;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrRptChart1;
        private System.Windows.Forms.RadioButton rdbRptRajaatoimipisteeseen;
        private System.Windows.Forms.RadioButton rdbRajaaPalvelu;
        private System.Windows.Forms.RadioButton rdbRajaaAsiakas;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem tietoaOhjelmastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ohjeToolStripMenuItem1;
    }
}