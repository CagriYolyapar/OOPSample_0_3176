namespace OOPSample_0
{
    partial class Form1
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
            this.LstKategoriler = new System.Windows.Forms.ListBox();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.LblKategori = new System.Windows.Forms.Label();
            this.BtnForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstKategoriler
            // 
            this.LstKategoriler.FormattingEnabled = true;
            this.LstKategoriler.ItemHeight = 16;
            this.LstKategoriler.Location = new System.Drawing.Point(137, 60);
            this.LstKategoriler.Name = "LstKategoriler";
            this.LstKategoriler.Size = new System.Drawing.Size(417, 372);
            this.LstKategoriler.TabIndex = 0;
            this.LstKategoriler.Click += new System.EventHandler(this.LstKategoriler_Click);
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(13, 60);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(100, 22);
            this.TxtIsim.TabIndex = 1;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(13, 115);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(100, 23);
            this.BtnEkle.TabIndex = 2;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // LblKategori
            // 
            this.LblKategori.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblKategori.Location = new System.Drawing.Point(134, 473);
            this.LblKategori.Name = "LblKategori";
            this.LblKategori.Size = new System.Drawing.Size(455, 53);
            this.LblKategori.TabIndex = 3;
            // 
            // BtnForm2
            // 
            this.BtnForm2.Location = new System.Drawing.Point(669, 493);
            this.BtnForm2.Name = "BtnForm2";
            this.BtnForm2.Size = new System.Drawing.Size(75, 23);
            this.BtnForm2.TabIndex = 4;
            this.BtnForm2.Text = "Form2";
            this.BtnForm2.UseVisualStyleBackColor = true;
            this.BtnForm2.Click += new System.EventHandler(this.BtnForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 548);
            this.Controls.Add(this.BtnForm2);
            this.Controls.Add(this.LblKategori);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.LstKategoriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstKategoriler;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label LblKategori;
        private System.Windows.Forms.Button BtnForm2;
    }
}

