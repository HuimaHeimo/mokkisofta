namespace mokkisofta
{
    partial class Tietoa
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
            this.lblTekijat = new System.Windows.Forms.Label();
            this.mstripTietoa = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msohjeSulje = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripTietoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTekijat
            // 
            this.lblTekijat.AutoSize = true;
            this.lblTekijat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTekijat.Location = new System.Drawing.Point(12, 53);
            this.lblTekijat.Name = "lblTekijat";
            this.lblTekijat.Size = new System.Drawing.Size(121, 112);
            this.lblTekijat.TabIndex = 1;
            this.lblTekijat.Text = "Tekijät:\r\n\r\nAltti Fihlman\r\nJani Tuomainen\r\nJanne Saarelainen\r\nSanttu Toivanen\r\nTa" +
    "rmo Savolainen";
            // 
            // mstripTietoa
            // 
            this.mstripTietoa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem});
            this.mstripTietoa.Location = new System.Drawing.Point(0, 0);
            this.mstripTietoa.Name = "mstripTietoa";
            this.mstripTietoa.Size = new System.Drawing.Size(557, 24);
            this.mstripTietoa.TabIndex = 2;
            this.mstripTietoa.Text = "menuStrip2";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msohjeSulje});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // msohjeSulje
            // 
            this.msohjeSulje.Name = "msohjeSulje";
            this.msohjeSulje.Size = new System.Drawing.Size(180, 22);
            this.msohjeSulje.Text = "Sulje";
            // 
            // Tietoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 463);
            this.Controls.Add(this.lblTekijat);
            this.Controls.Add(this.mstripTietoa);
            this.Name = "Tietoa";
            this.Text = "Tietoa ohjelmasta";
            this.mstripTietoa.ResumeLayout(false);
            this.mstripTietoa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTekijat;
        private System.Windows.Forms.MenuStrip mstripTietoa;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msohjeSulje;
    }
}