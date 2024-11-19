using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample_0.Models
{
    public class Urun
    {
       
        public string Isim { get; set; }
        public decimal Fiyat { get; set; }
        public Kategori Kategori { get; set; }

        public string BilgiGoster()
        {
            return $"{Isim}..{Fiyat:C2}..Kategorisi => {Kategori.Isim}";
        }

    }
}
