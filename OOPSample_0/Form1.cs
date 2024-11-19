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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //List<Kategori> kategoriler = new List<Kategori>();

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Kategori k = new Kategori();
            k.Isim = TxtIsim.Text;
            LstKategoriler.Items.Add(k);
            //kategoriler.Add(k);
        }

        private void LstKategoriler_Click(object sender, EventArgs e)
        {
            if(LstKategoriler.SelectedItem != null)
            {
               LblKategori.Text =  (LstKategoriler.SelectedItem as Kategori).Isim;
            }

           
        }

        private void BtnForm2_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2(kategoriler);
            //f2.ShowDialog();

            Form2 f2 = new Form2(LstKategoriler.Items);
            f2.ShowDialog();


        
        }
    }
}
