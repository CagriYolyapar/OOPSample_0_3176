using OOPSample_0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOPSample_0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(ListBox.ObjectCollection kategoriler)
        {
            InitializeComponent();

        

            foreach (Kategori item in kategoriler)
            {
                CmbKategoriler.Items.Add(item);
            }
        }

        public Form2(List<Kategori> kategoriler)
        {
            InitializeComponent();
            foreach (Kategori item in kategoriler)
            {
                CmbKategoriler.Items.Add(item);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void CmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CmbKategoriler.SelectedItem != null)
            {
                LblKategori.Text = (CmbKategoriler.SelectedItem as Kategori).Isim;
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {

            if(CmbKategoriler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen önce kategori seciniz");
            }
            else
            {
                try
                {
                    Urun u = new Urun();
                    u.Isim = TxtIsim.Text;
                    u.Fiyat = Convert.ToDecimal(TxtFiyat.Text);
                    u.Kategori = CmbKategoriler.SelectedItem as Kategori;
                    (CmbKategoriler.SelectedItem as Kategori).Urunler.Add(u);
                    LstUrunler.Items.Add(u);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
          
           
        }

        private void LstUrunler_Click(object sender, EventArgs e)
        {
            if(LstUrunler.SelectedItem != null)
            {
                LblUrun.Text = (LstUrunler.SelectedItem as Urun).BilgiGoster();
            }
        }
    }
}
