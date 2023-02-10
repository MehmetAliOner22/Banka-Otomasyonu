using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace Banka_Otomasyonu_V1._1
{
    internal abstract class Hesap
    {
        public long HesapNo { get; set; }
        public long MusteriNo { get; set; }
        public DateTime HesapAcilmaTarihi { get; set; }
        public decimal Bakiye { get; set; } = 0;
        public List<IslemBilgileri> IslemGecmisi { get; set; } = new List<IslemBilgileri>();

        public abstract void ParaYatir(int nHesap, decimal tutar);

        public abstract void ParaCek(int nHesap, decimal tutar);

        public abstract void BireyseleHavaleYap(int gonderenHesap, long aliciHesap, decimal tutar);

        public abstract void TicariyeHavaleYap(int gonderenHesap, long aliciHesap, decimal tutar);

        public abstract void HesaplarArasiTransfer(int gonderenHesap, int aliciHesap, decimal tutar);
    }
}
