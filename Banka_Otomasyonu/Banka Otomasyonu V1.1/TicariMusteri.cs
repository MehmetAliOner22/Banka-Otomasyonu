using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyonu_V1._1
{
    internal class TicariMusteri : Musteri
    {
        public long VergiNo { get; set; }
        public TicariMusteri() { }
        public TicariMusteri(long vergiNo, long musteriNo, string ad, string adres, string telefonNo, DateTime kayitTarihi)
        {
            VergiNo = vergiNo;
            MusteriNo = musteriNo;
            Ad = ad;
            Adres = adres;
            TelefonNo = telefonNo;
            KayitTarihi = kayitTarihi;
        }
    }
}
