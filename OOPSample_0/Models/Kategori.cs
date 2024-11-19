using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample_0.Models
{
    public class Kategori
    {
        public Kategori()
        {
            Urunler = new List<Urun>();
        }
        public string Isim { get; set; }
        public List<Urun> Urunler { get; set; }

    }
}
