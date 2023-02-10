using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyonu_V1._1
{
    internal abstract class Musteri
    {
        public long MusteriNo { get; set; }
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string TelefonNo { get; set; }
        public DateTime KayitTarihi { get; set; }
        public decimal ToplamBakiye { get; set; } = 0;
        public List<Hesap> Hesaplar { get; set; } = new List<Hesap>();
    }
}
