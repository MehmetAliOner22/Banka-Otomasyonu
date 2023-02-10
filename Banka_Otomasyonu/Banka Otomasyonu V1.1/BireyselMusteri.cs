using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyonu_V1._1
{
    internal class BireyselMusteri : Musteri
    {
        public string Soyad { get; set; }
        public long TCNo { get; set; }
        public string Eposta { get; set; }
        public decimal GunlukCekilenPara { get; set; } = 0;
        public DateTime SonParaCekmeTarihi { get; set; }

        public BireyselMusteri() { }

        public BireyselMusteri(long TCNo, long musteriNo, string ad, string soyad, string adres, string telefonNo, DateTime kayitTarihi)
        {
            this.TCNo = TCNo;
            MusteriNo = musteriNo;
            Ad = ad;
            Soyad = soyad;
            Adres = adres;
            TelefonNo = telefonNo;
            KayitTarihi = kayitTarihi;
        }

        public BireyselMusteri(long TCNo, long musteriNo, string ad, string soyad, string adres, string telefonNo, DateTime kayitTarihi, string eposta)
        {
            this.TCNo = TCNo;
            MusteriNo = musteriNo;
            Ad = ad;
            Soyad = soyad;
            Adres = adres;
            TelefonNo = telefonNo;
            KayitTarihi = kayitTarihi;
            Eposta = eposta;
        }
    }
}
