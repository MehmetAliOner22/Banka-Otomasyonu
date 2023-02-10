using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace Banka_Otomasyonu_V1._1
{
    public partial class TicariHavaleYap : Form
    {
        public TicariHavaleYap()
        {
            InitializeComponent();
        }

        Banka banka = new Banka();
        AktifTicariMusteri aktifTicari = new AktifTicariMusteri();

        public bool KendiHesabiMi(long aliciHesap)
        {
            foreach (var hesap in aktifTicari.AktifMusteriGetir().Hesaplar)
            {
                if (hesap.HesapNo == aliciHesap)
                {
                    return true;
                }
            }

            return false;
        }

        public bool InputDogrula()
        {
            if (string.IsNullOrEmpty(txtAlici.Text) || string.IsNullOrEmpty(txtGonderilecekTutar.Text) || cbGonderenHesap.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return false;
            }

            if (!decimal.TryParse(txtGonderilecekTutar.Text, out _))
            {
                MessageBox.Show("Lütfen girdiğiniz bilgileri kontrol edin.");
                return false;
            }        

            if (Convert.ToDecimal(txtGonderilecekTutar.Text) <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz.");
                return false;
            }

            try
            {
                Convert.ToInt64(txtAlici.Text);
                return true;

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen girdiğiniz bilgileri kontrol edin.");
                return false;
            }
        }

        public string MusteriTurunuBelirle(long hesapNo)
        {
            if (hesapNo >= 500000000)
            {
                return "Ticari";
            }

            return "Bireysel";
        }
        private void TicariHavaleYap_Load(object sender, EventArgs e)
        {
            int sayac = 1;

            foreach (var musteri in banka.TicariMusteriListesiniGetir())
            {
                if (musteri.MusteriNo == aktifTicari.AktifMusteriGetir().MusteriNo)
                {
                    foreach (var hesap in musteri.Hesaplar)
                    {
                        cbGonderenHesap.Items.Add("Hesap" + sayac.ToString());
                        sayac++;
                    }
                }
            }
        }

        private void btnHavale_Click(object sender, EventArgs e)
        {
            if (InputDogrula())
            {
                int gonderenHesap = cbGonderenHesap.SelectedIndex;
                long aliciHesap = Convert.ToInt64(txtAlici.Text);
                decimal tutar = Convert.ToDecimal(txtGonderilecekTutar.Text);

                if (MusteriTurunuBelirle(aliciHesap) == "Ticari")
                {
                    if (KendiHesabiMi(aliciHesap))
                    {
                        MessageBox.Show("Kendi hesabınıza transfer yapmak için \"Hesaplar Arası Transfer\" işlemini kullanınız.");
                        return;
                    }

                    foreach (var musteri in banka.TicariMusteriListesiniGetir())
                    {
                        foreach (var hesaplar in musteri.Hesaplar)
                        {
                            if (hesaplar.HesapNo == aliciHesap)
                            {
                                TicariHesap ticari = new TicariHesap();
                                ticari.TicariyeHavaleYap(gonderenHesap, aliciHesap, tutar);
                                return;
                            }
                        }
                    }
                }

                else if (MusteriTurunuBelirle(aliciHesap) == "Bireysel")
                {
                   foreach (var musteri in banka.BireyselMusteriListesiniGetir())
                    {
                        foreach (var hesaplar in musteri.Hesaplar)
                        {
                            if (hesaplar.HesapNo == aliciHesap)
                            {
                                TicariHesap ticari = new TicariHesap();
                                ticari.BireyseleHavaleYap(gonderenHesap, aliciHesap, tutar);
                                return;
                            }
                        }
                    }
                }

                MessageBox.Show("Alıcı hesap kaydı bulunamadı.");
            }
        }
    }
}
