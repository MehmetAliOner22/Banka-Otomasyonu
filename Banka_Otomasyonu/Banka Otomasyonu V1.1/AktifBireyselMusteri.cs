using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace Banka_Otomasyonu_V1._1
{
    internal class AktifBireyselMusteri : AktifMusteri
    {
        private static BireyselMusteri bireyselMusteri = new BireyselMusteri();
        private Banka banka = new Banka();

        public BireyselMusteri AktifMusteriGetir()
        {
            return bireyselMusteri;
        }

        public bool MusteriKontol(long no)
        {        
            foreach (var musteri in banka.BireyselMusteriListesiniGetir())
            {
                if (musteri.MusteriNo == no || musteri.TCNo == no)
                {
                    bireyselMusteri = musteri;
                    return true;
                }
            }

            MessageBox.Show("Müşteri kaydı bulunamadı.");
            return false;
        }
    }
}
