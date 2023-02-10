using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyonu_V1._1
{
    internal class IslemBilgileri
    {
        public string IslemAdi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public decimal IslemTutari { get; set; }
        public string Gonderici { get; set; }
        public string Alici { get; set; }

        public IslemBilgileri(string islemAdi, DateTime islemTarihi, decimal islemTutari)
        {
            IslemAdi = islemAdi;
            IslemTarihi = islemTarihi;
            IslemTutari = islemTutari;
        }

        public IslemBilgileri(string islemAdi, DateTime islemTarihi, string gonderici, string alici, decimal islemTutari)
        {
            IslemAdi = islemAdi;
            IslemTarihi = islemTarihi;
            Gonderici = gonderici;
            Alici = alici;
            IslemTutari = islemTutari;

        }
    }
}
