using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace Banka_Otomasyonu_V1._1
{
    internal class AktifTicariMusteri : AktifMusteri
    {
        private static TicariMusteri TicariMusteri = new TicariMusteri();
        private Banka banka = new Banka();

        public TicariMusteri AktifMusteriGetir()
        {
            return TicariMusteri;
        }

        public bool MusteriKontol(long no)
        {
            foreach (var musteri in banka.TicariMusteriListesiniGetir())
            {
                if (musteri.MusteriNo == no)
                {
                    TicariMusteri = musteri;
                    return true;
                }
            }

            MessageBox.Show("Müşteri kaydı bulunamadı.");
            return false;
        }
    }
}
