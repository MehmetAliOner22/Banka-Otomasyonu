using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Banka_Otomasyonu_V1._1
{
    internal class TicariHesap : Hesap
    {
        private AktifTicariMusteri aktifMusteri = new AktifTicariMusteri();
        private Banka banka = new Banka();

        public override void ParaCek(int nHesap, decimal tutar)
        {
            int hesapSayac = 1;

            foreach (var musteri in banka.TicariMusteriListesiniGetir())
            {
                if (aktifMusteri.AktifMusteriGetir().MusteriNo == musteri.MusteriNo)
                {
                    if (musteri.Hesaplar[nHesap].Bakiye >= tutar)
                    {
                        musteri.Hesaplar[nHesap].Bakiye -= tutar;
                        musteri.ToplamBakiye -= tutar;
                        banka.ToplamGiderHesapla(tutar);
                        IslemBilgileri islemBilgileri = new IslemBilgileri("Para Çekme", DateTime.Now, tutar);
                        musteri.Hesaplar[nHesap].IslemGecmisi.Add(islemBilgileri);
                        MessageBox.Show("Çekme İşlemi Başarılı");
                        return;
                    }
                    else
                    {
                        foreach (var hesap in musteri.Hesaplar)
                        {
                            if (hesap.Bakiye >= tutar)
                            {
                                hesap.Bakiye -= tutar;
                                musteri.ToplamBakiye -= tutar;
                                banka.ToplamGiderHesapla(tutar);
                                IslemBilgileri islemBilgileri = new IslemBilgileri("Para Çekme", DateTime.Now, tutar);
                                hesap.IslemGecmisi.Add(islemBilgileri);
                                MessageBox.Show("Çekme İşlemi Başarılı" + "\r\nSeçilen hesabın bakiyesi yetersiz olduğu için çekim işlemi "
                                                + hesapSayac + " nolu hesap kullanılarak gerçekleştirildi.");
                                return;
                            }

                            hesapSayac++;
                        }

                        MessageBox.Show("Hesap bakiyeleriniz bu tutarı çekmek için yetersiz.");
                        return;
                    }
                }
            }
        }

        public override void ParaYatir(int nHesap, decimal tutar)
        {
            foreach (var musteri in banka.TicariMusteriListesiniGetir())
            {
                if (aktifMusteri.AktifMusteriGetir().MusteriNo == musteri.MusteriNo)
                {
                    musteri.Hesaplar[nHesap].Bakiye += tutar;
                    musteri.ToplamBakiye += tutar;
                    banka.ToplamGelirHesapla(tutar);
                    IslemBilgileri islemBilgileri = new IslemBilgileri("Para Yatırma", DateTime.Now, tutar);
                    aktifMusteri.AktifMusteriGetir().Hesaplar[nHesap].IslemGecmisi.Add(islemBilgileri);
                    MessageBox.Show("Yatırma İşlemi Başarılı");
                }
            }
        }

        IslemBilgileri aliciIslemBilgileri;
        IslemBilgileri gondericiIslemBilgileri;

        public override void BireyseleHavaleYap(int gonderenHesap, long aliciHesap, decimal tutar)
        {
            if (aktifMusteri.AktifMusteriGetir().Hesaplar[gonderenHesap].Bakiye >= tutar)
            {
                foreach (var musteri in banka.BireyselMusteriListesiniGetir())
                {
                    foreach (var hesap in musteri.Hesaplar)
                    {
                        if (aliciHesap == hesap.HesapNo)
                        {
                            aktifMusteri.AktifMusteriGetir().Hesaplar[gonderenHesap].Bakiye -= tutar;
                            aktifMusteri.AktifMusteriGetir().ToplamBakiye -= tutar;
                            hesap.Bakiye += tutar;
                            musteri.ToplamBakiye += tutar;
                            aliciIslemBilgileri = new IslemBilgileri("Gelen Havale", DateTime.Now,
                                                                           aktifMusteri.AktifMusteriGetir().Ad,
                                                                           musteri.Ad, tutar);
                            hesap.IslemGecmisi.Add(aliciIslemBilgileri);

                            gondericiIslemBilgileri = new IslemBilgileri("Giden Havale", DateTime.Now,
                                                                           aktifMusteri.AktifMusteriGetir().Ad,
                                                                           musteri.Ad, tutar);

                            aktifMusteri.AktifMusteriGetir().Hesaplar[gonderenHesap].IslemGecmisi.Add(gondericiIslemBilgileri);
                        }
                    }
                }
                
                MessageBox.Show("Havale gerçekleştirildi.");
                return;
            }

            MessageBox.Show("Bakiyeniz yetersiz.");
            return;
        }


        public override void TicariyeHavaleYap(int gonderenHesap, long aliciHesap, decimal tutar)
        {
            if (aktifMusteri.AktifMusteriGetir().Hesaplar[gonderenHesap].Bakiye >= tutar)
            {
                foreach (var musteri in banka.TicariMusteriListesiniGetir())
                {
                    foreach (var hesap in musteri.Hesaplar)
                    {
                        if (aliciHesap == hesap.HesapNo)
                        {
                            aktifMusteri.AktifMusteriGetir().Hesaplar[gonderenHesap].Bakiye -= tutar;
                            aktifMusteri.AktifMusteriGetir().ToplamBakiye -= tutar;
                            hesap.Bakiye += tutar;
                            musteri.ToplamBakiye += tutar;
                            aliciIslemBilgileri = new IslemBilgileri("Gelen Havale", DateTime.Now,
                                                                           aktifMusteri.AktifMusteriGetir().Ad,
                                                                           musteri.Ad, tutar);
                            hesap.IslemGecmisi.Add(aliciIslemBilgileri);

                            gondericiIslemBilgileri = new IslemBilgileri("Giden Havale", DateTime.Now,
                                                                            aktifMusteri.AktifMusteriGetir().Ad,
                                                                            musteri.Ad, tutar);

                            aktifMusteri.AktifMusteriGetir().Hesaplar[gonderenHesap].IslemGecmisi.Add(gondericiIslemBilgileri);
                        }
                    }
                }

                MessageBox.Show("Havale gerçekleştirildi.");
                return;
            }

            MessageBox.Show("Bakiyeniz yetersiz.");
            return;
        }

        public override void HesaplarArasiTransfer(int gonderenHesap, int aliciHesap, decimal tutar)
        {
            if(aktifMusteri.AktifMusteriGetir().Hesaplar[gonderenHesap].Bakiye >= tutar)
            {
                aktifMusteri.AktifMusteriGetir().Hesaplar[gonderenHesap].Bakiye -= tutar;
                aktifMusteri.AktifMusteriGetir().Hesaplar[aliciHesap].Bakiye += tutar;

                IslemBilgileri islemBilgileri1 = new IslemBilgileri("Hesaplar Arası" + "\n" + " Gelen Transfer", DateTime.Now, tutar);
                aktifMusteri.AktifMusteriGetir().Hesaplar[aliciHesap].IslemGecmisi.Add(islemBilgileri1);

                IslemBilgileri islemBilgileri2 = new IslemBilgileri("Hesaplar Arası" + "\n" + " Giden Transfer", DateTime.Now, tutar);
                aktifMusteri.AktifMusteriGetir().Hesaplar[gonderenHesap].IslemGecmisi.Add(islemBilgileri2);

                MessageBox.Show("Transfer gerçekleştirildi.");
                return;
            }

            MessageBox.Show("Bakiye yetersiz.");
            return;
        }
    }
}