using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace Banka_Otomasyonu_V1._1
{
    internal class BireyselHesap : Hesap
    {

        private Banka banka = new Banka();

        private AktifBireyselMusteri aktifMusteri = new AktifBireyselMusteri();

        private bool GunlukLimitKontrol(decimal tutar)
        {
            if (aktifMusteri.AktifMusteriGetir().GunlukCekilenPara + tutar <= 750)
            {
                return true;
            }
            MessageBox.Show("Günlük çekim limitiniz nedeniyle işlem gerçekleştirilemiyor.");
            return false;
        }

        private void GunlukLimitSıfırla()
        {
            if (DateTime.Now.Day != aktifMusteri.AktifMusteriGetir().SonParaCekmeTarihi.Day)
            {
                aktifMusteri.AktifMusteriGetir().GunlukCekilenPara = 0;
            }
        }

        public override void ParaCek(int nHesap, decimal tutar)
        {
            int hesapSayac = 1;

            GunlukLimitSıfırla();

            foreach (var musteri in banka.BireyselMusteriListesiniGetir())
            {
                if (aktifMusteri.AktifMusteriGetir().MusteriNo == musteri.MusteriNo || aktifMusteri.AktifMusteriGetir().TCNo == musteri.TCNo)
                {
                    if (!GunlukLimitKontrol(tutar))
                    {
                        return;
                    }

                    if (musteri.Hesaplar[nHesap].Bakiye >= tutar)
                    {
                        musteri.Hesaplar[nHesap].Bakiye -= tutar;
                        musteri.ToplamBakiye -= tutar;
                        banka.ToplamGiderHesapla(tutar);
                        musteri.GunlukCekilenPara += tutar;
                        musteri.SonParaCekmeTarihi = DateTime.Now;
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
                                musteri.GunlukCekilenPara += tutar;
                                musteri.SonParaCekmeTarihi = DateTime.Now;
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
            foreach (var musteri in banka.BireyselMusteriListesiniGetir())
            {
                if (aktifMusteri.AktifMusteriGetir().MusteriNo == musteri.MusteriNo || aktifMusteri.AktifMusteriGetir().TCNo == musteri.TCNo)
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

        decimal sonTutar;
        IslemBilgileri aliciIslemBilgileri;
        IslemBilgileri gondericiIslemBilgileri;

        public override void BireyseleHavaleYap(int gonderenHesap, long aliciHesap, decimal tutar)
        {
            sonTutar = tutar + (tutar * 2) / 100;

            if (aktifMusteri.AktifMusteriGetir().Hesaplar[gonderenHesap].Bakiye >= sonTutar)
            {              
                foreach (var musteri in banka.BireyselMusteriListesiniGetir())
                {
                    foreach (var hesap in musteri.Hesaplar)
                    {
                        if (aliciHesap == hesap.HesapNo)
                        {
                            aktifMusteri.AktifMusteriGetir().Hesaplar[gonderenHesap].Bakiye -= sonTutar;
                            aktifMusteri.AktifMusteriGetir().ToplamBakiye -= sonTutar;
                            hesap.Bakiye += tutar;
                            musteri.ToplamBakiye += tutar;
                            aliciIslemBilgileri = new IslemBilgileri("Gelen Havale", DateTime.Now,
                                                                           aktifMusteri.AktifMusteriGetir().Ad + " " + aktifMusteri.AktifMusteriGetir().Soyad,
                                                                           musteri.Ad + " " + musteri.Soyad, tutar);
                            hesap.IslemGecmisi.Add(aliciIslemBilgileri);

                            gondericiIslemBilgileri = new IslemBilgileri("Giden Havale", DateTime.Now,
                                                                           aktifMusteri.AktifMusteriGetir().Ad + " " + aktifMusteri.AktifMusteriGetir().Soyad,
                                                                           musteri.Ad + " " + musteri.Soyad, sonTutar);

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
            decimal sonTutar = tutar + (tutar * 2) / 100;

            if (aktifMusteri.AktifMusteriGetir().Hesaplar[gonderenHesap].Bakiye >= sonTutar)
            {
                foreach (var musteri in banka.TicariMusteriListesiniGetir())
                {
                    foreach (var hesap in musteri.Hesaplar)
                    {
                        if (aliciHesap == hesap.HesapNo)
                        {
                            aktifMusteri.AktifMusteriGetir().Hesaplar[gonderenHesap].Bakiye -= sonTutar;
                            aktifMusteri.AktifMusteriGetir().ToplamBakiye -= sonTutar;
                            hesap.Bakiye += tutar;
                            musteri.ToplamBakiye += tutar;
                            aliciIslemBilgileri = new IslemBilgileri("Gelen Havale", DateTime.Now,
                                                                           aktifMusteri.AktifMusteriGetir().Ad + " " + aktifMusteri.AktifMusteriGetir().Soyad,
                                                                           musteri.Ad, tutar);
                            hesap.IslemGecmisi.Add(aliciIslemBilgileri);

                            gondericiIslemBilgileri = new IslemBilgileri("Giden Havale", DateTime.Now,
                                                                            aktifMusteri.AktifMusteriGetir().Ad + " " + aktifMusteri.AktifMusteriGetir().Soyad,
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
