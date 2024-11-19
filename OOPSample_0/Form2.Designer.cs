namespace OOPSample_0
{
    partial class Form2
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
            this.LstUrunler = new System.Windows.Forms.ListBox();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.CmbKategoriler = new System.Windows.Forms.ComboBox();
            this.LblKategori = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.LblUrun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstUrunler
            // 
            this.LstUrunler.FormattingEnabled = true;
            this.LstUrunler.ItemHeight = 16;
            this.LstUrunler.Location = new System.Drawing.Point(238, 45);
            this.LstUrunler.Name = "LstUrunler";
            this.LstUrunler.Size = new System.Drawing.Size(342, 308);
            this.LstUrunler.TabIndex = 0;
            this.LstUrunler.Click += new System.EventHandler(this.LstUrunler_Click);
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(22, 55);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(100, 22);
            this.TxtIsim.TabIndex = 1;
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(22, 112);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(100, 22);
            this.TxtFiyat.TabIndex = 1;
            // 
            // CmbKategoriler
            // 
            this.CmbKategoriler.FormattingEnabled = true;
            this.CmbKategoriler.Location = new System.Drawing.Point(22, 176);
            this.CmbKategoriler.Name = "CmbKategoriler";
            this.CmbKategoriler.Size = new System.Drawing.Size(121, 24);
            this.CmbKategoriler.TabIndex = 2;
            this.CmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.CmbKategoriler_SelectedIndexChanged);
            // 
            // LblKategori
            // 
            this.LblKategori.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblKategori.Location = new System.Drawing.Point(19, 242);
            this.LblKategori.Name = "LblKategori";
            this.LblKategori.Size = new System.Drawing.Size(145, 25);
            this.LblKategori.TabIndex = 3;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(12, 317);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 4;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // LblUrun
            // 
            this.LblUrun.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblUrun.Location = new System.Drawing.Point(235, 377);
            this.LblUrun.Name = "LblUrun";
            this.LblUrun.Size = new System.Drawing.Size(356, 64);
            this.LblUrun.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.LblUrun);
            this.Controls.Add(this.LblKategori);
            this.Controls.Add(this.CmbKategoriler);
            this.Controls.Add(this.TxtFiyat);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.LstUrunler);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstUrunler;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.ComboBox CmbKategoriler;
        private System.Windows.Forms.Label LblKategori;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label LblUrun;
    }
}