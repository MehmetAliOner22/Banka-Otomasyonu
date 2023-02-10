using Banka_Otomasyonu_V1._1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    internal class Banka
    {
        public static decimal ToplamPara { get; set; }
        public static decimal Gelir { get; set; }
        public static decimal Gider { get; set; }

        public static List<BireyselMusteri> BireyselMusteri = new List<BireyselMusteri>();
        public static List<TicariMusteri> TicariMusteri = new List<TicariMusteri>();

        public Banka() { }

        public List<BireyselMusteri> BireyselMusteriListesiniGetir()
        {
            return BireyselMusteri;
        }

        public List<TicariMusteri> TicariMusteriListesiniGetir()
        {
            return TicariMusteri;
        }
        public void BankaBilgiListele(DataGridView datagrid)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ToplamPara", typeof(decimal));
            table.Columns.Add("Gelir", typeof(decimal));
            table.Columns.Add("Gider", typeof(decimal));

            table.Rows.Add(ToplamPara, Gelir, Gider);
               
            datagrid.DataSource = table;
        }
        public void ToplamGelirHesapla(decimal GelirHesapHareketi) 
        { 
            Gelir += GelirHesapHareketi;
            ToplamParaHesapla();
        }

        public void ToplamGiderHesapla(decimal GiderHesapHareketi) 
        { 
            Gider += GiderHesapHareketi;
            ToplamParaHesapla();
        } 

        public void ToplamParaHesapla() 
        { 
            ToplamPara = Gelir - Gider; 
        }
        
        public void TMusteriEkle(long VergiNo, TicariMusteri ticariMusteri)
        {
            int sayac = 0;

            foreach (var musteri in TicariMusteri)
            {
                if (musteri.VergiNo == VergiNo)
                {
                    sayac++;
                }
            }
            if(sayac == 0)
            {
                TicariMusteri.Add(ticariMusteri);
                MessageBox.Show("Müşterinizin Kaydı Yapıldı\r\nMüşteri No: " + ticariMusteri.MusteriNo, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Bu Vergi numarasına ait bir müşteri bulunmakta", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void BMusteriEkle(long TCNo, BireyselMusteri bireyselMusteri)
        {
            int sayac = 0;

            foreach (var musteri in BireyselMusteri)
            {
                if (musteri.TCNo == TCNo)
                {
                    sayac++;
                }
            }
            if (sayac == 0)
            {
                BireyselMusteri.Add(bireyselMusteri);
                MessageBox.Show("Müşterinizin Kaydı Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu TC numarasına ait bir müşteri bulunmakta", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void TicariMListele(DataGridView datagrid)
        {
            datagrid.DataSource = TicariMusteri;
        }

        public void BireyselMListele(DataGridView datagrid)
        {
            datagrid.DataSource = BireyselMusteri;
        }
        public void TicariHListele(DataGridView datagrid)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Musteri No", typeof(long));
            table.Columns.Add("Hesap No", typeof(long));
            table.Columns.Add("Bakiye", typeof(string)); ;
            table.Columns.Add("KayitTarihi", typeof(string));

            foreach (var musteri in TicariMusteri)
            {
                foreach (var hesap in musteri.Hesaplar)
                {
                    table.Rows.Add(musteri.MusteriNo, hesap.HesapNo, hesap.Bakiye, hesap.HesapAcilmaTarihi);
                }
            }
            datagrid.DataSource = table;
        }
        public void BireyselHListele(DataGridView datagrid)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Musteri No", typeof(long));
            table.Columns.Add("Hesap No", typeof(long));
            table.Columns.Add("Bakiye", typeof(string)); ;
            table.Columns.Add("KayitTarihi", typeof(string));

            foreach (var musteri in BireyselMusteri)
            {
                foreach (var hesap in musteri.Hesaplar)
                {
                    table.Rows.Add(musteri.MusteriNo, hesap.HesapNo, hesap.Bakiye, hesap.HesapAcilmaTarihi);
                }
            }
            datagrid.DataSource = table;
        }
        public int VergiNoTMusteriSil(long VergiNo)
        {
            foreach (var musteri in TicariMusteri)
            {
                if (musteri.VergiNo == VergiNo)
                {
                    int index = TicariMusteri.IndexOf(musteri);
                    if (index >= 0)
                    {
                        if (musteri.ToplamBakiye == 0)
                        {
                            TicariMusteri.RemoveAt(index);
                            MessageBox.Show("Müşteriniz başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return 0;
                        }else 
                        {
                            MessageBox.Show("Müsterinin silinmesi için hesaplarında para olmaması gerekiyor \nBakiye:" + musteri.ToplamBakiye.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return 0;
                        }
                    }
                }
            }
            MessageBox.Show(VergiNo.ToString() + " Vergi Numaralı kayıt yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 0;
        }
        public int MusteriNoTMusteriSil(long MusteriNo)
        {
            foreach (var musteri in TicariMusteri)
            {
                if (musteri.MusteriNo == MusteriNo)
                {
                    int index = TicariMusteri.IndexOf(musteri);
                    if (index >= 0)
                    {
                        if (musteri.ToplamBakiye == 0)
                        {
                            TicariMusteri.RemoveAt(index);
                            MessageBox.Show("Müşteriniz başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return 0;
                        }
                        else
                        {
                            MessageBox.Show("Müsterinin silinmesi için hesaplarında para olmaması gerekiyor \nBakiye:" + musteri.ToplamBakiye.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return 0;
                        }
                    }
                }
            }
            MessageBox.Show(MusteriNo.ToString() + " Musteri Numaralı kayıt yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 0;
        }
        public int TCNoBMusteriSil(long TCNo)
        {
            foreach (var musteri in BireyselMusteri)
            {
                if (musteri.TCNo == TCNo)
                {
                    int index = BireyselMusteri.IndexOf(musteri);
                    if (index >= 0)
                    {
                        if (musteri.ToplamBakiye == 0)
                        {
                            BireyselMusteri.RemoveAt(index);
                            MessageBox.Show("Müşteriniz başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return 0;
                        }
                        else
                        {
                            MessageBox.Show("Müsterinin silinmesi için hesaplarında para olmaması gerekiyor \nBakiye:" + musteri.ToplamBakiye.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return 0;
                        }
                    }
                }
            }
            MessageBox.Show(TCNo.ToString() + " TC Numaralı kayıt yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 0;
        }
        public int MusteriNoBMusteriSil(long MusteriNo)
        {
            foreach (var musteri in BireyselMusteri)
            {
                if (musteri.MusteriNo == MusteriNo)
                {
                    int index = BireyselMusteri.IndexOf(musteri);
                    if (index >= 0)
                    {
                        if (musteri.ToplamBakiye == 0)
                        {
                            BireyselMusteri.RemoveAt(index);
                            MessageBox.Show("Müşteriniz başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return 0;
                        }
                        else
                        {
                            MessageBox.Show("Müsterinin silinmesi için hesaplarında para olmaması gerekiyor \nBakiye:" + musteri.ToplamBakiye.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return 0;
                        }
                    }
                }
            }
            MessageBox.Show(MusteriNo.ToString() + " Musteri Numaralı kayıt yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 0;
        }
        public int HesapNoBHesapSil(long HesapNo)
        {
            foreach (var musteri in BireyselMusteri)
            {
                for (int i = musteri.Hesaplar.Count - 1; i >= 0; i--)
                {
                    if (musteri.Hesaplar[i].HesapNo == HesapNo)
                    {
                        if (musteri.Hesaplar[i].Bakiye == 0)
                        {
                            musteri.Hesaplar.RemoveAt(i);
                            MessageBox.Show("Hesap başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return 0;
                        }
                        else
                        {
                            MessageBox.Show("Hesabın silinmesi için hesapta para olmaması gerekiyor \nBakiye:" + musteri.ToplamBakiye.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return 0;
                        }
                    }
                }
            }
            MessageBox.Show(HesapNo.ToString() + " Hesap Numaralı kayıt yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 0;
        }
        public int HesapNoTHesapSil(long HesapNo)
        {

            foreach (var musteri in TicariMusteri)
            {
                for (int i = musteri.Hesaplar.Count - 1; i >= 0; i--)
                {
                    if (musteri.Hesaplar[i].HesapNo == HesapNo)
                    {
                        if (musteri.Hesaplar[i].Bakiye == 0)
                        {
                            musteri.Hesaplar.RemoveAt(i);
                            MessageBox.Show("Hesap başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return 0;
                        }
                        else
                        {
                            MessageBox.Show("Hesabın silinmesi için hesapta para olmaması gerekiyor \nBakiye:" + musteri.ToplamBakiye.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return 0;
                        }
                    }
                }
            }
            MessageBox.Show(HesapNo.ToString() + " Hesap Numaralı kayıt yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 0;
        }
        public int TCNoBireyselMAra(long TCNo, DataGridView datagrid)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MusteriNo", typeof(long));
            table.Columns.Add("TCNo", typeof(string));
            table.Columns.Add("Ad", typeof(string));
            table.Columns.Add("Soyad", typeof(string));
            table.Columns.Add("Adres", typeof(string));
            table.Columns.Add("TelefonNo", typeof(string));
            table.Columns.Add("ToplamBakiye", typeof(string));
            table.Columns.Add("KayitTarihi", typeof(string));

            foreach (var musteri in BireyselMusteri)
            {
                if (musteri.TCNo == TCNo)
                {
                    table.Rows.Add(musteri.MusteriNo, musteri.TCNo, musteri.Ad, musteri.Soyad, musteri.Adres, musteri.TelefonNo, musteri.ToplamBakiye, musteri.KayitTarihi);
                    datagrid.DataSource = table;
                    return 0;
                }
            }
            MessageBox.Show(TCNo.ToString() + " TC Numaralı kayıt yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return 0;
        }
        public int MusteriNoBireyselMAra(long MusteriNo, DataGridView datagrid)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MusteriNo", typeof(long));
            table.Columns.Add("TCNo", typeof(string));
            table.Columns.Add("Ad", typeof(string));
            table.Columns.Add("Soyad", typeof(string));
            table.Columns.Add("Adres", typeof(string));
            table.Columns.Add("TelefonNo", typeof(string));
            table.Columns.Add("ToplamBakiye", typeof(string));
            table.Columns.Add("KayitTarihi", typeof(string));

            foreach (var musteri in BireyselMusteri)
            {
                if (musteri.MusteriNo == MusteriNo)
                {
                    table.Rows.Add(musteri.MusteriNo, musteri.TCNo, musteri.Ad, musteri.Soyad, musteri.Adres, musteri.TelefonNo, musteri.ToplamBakiye, musteri.KayitTarihi);
                    datagrid.DataSource = table;
                    return 0;
                }
            }
            MessageBox.Show(MusteriNo.ToString() + " Musteri Numaralı kayıt yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return 0;
        }
        public int VergiNoTicariMAra(long VergiNo, DataGridView datagrid)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MusteriNo", typeof(long));
            table.Columns.Add("VergiNo", typeof(string));
            table.Columns.Add("Ad", typeof(string));
            table.Columns.Add("Adres", typeof(string));
            table.Columns.Add("TelefonNo", typeof(string));
            table.Columns.Add("ToplamBakiye", typeof(string));
            table.Columns.Add("KayitTarihi", typeof(string));

            foreach (var musteri in TicariMusteri)
            {
                if (musteri.VergiNo == VergiNo)
                {
                    table.Rows.Add(musteri.MusteriNo, musteri.VergiNo, musteri.Ad, musteri.Adres, musteri.TelefonNo, musteri.ToplamBakiye, musteri.KayitTarihi);
                    datagrid.DataSource = table;
                    return 0;
                }
            }
            MessageBox.Show(VergiNo.ToString() + " Vergi Numaralı kayıt yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return 0;
        }
        public int MusteriNoTicariMAra(long MusteriNo, DataGridView datagrid)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MusteriNo", typeof(long));
            table.Columns.Add("VergiNo", typeof(string));
            table.Columns.Add("Ad", typeof(string));
            table.Columns.Add("Adres", typeof(string));
            table.Columns.Add("TelefonNo", typeof(string));
            table.Columns.Add("ToplamBakiye", typeof(string));
            table.Columns.Add("KayitTarihi", typeof(string));

            foreach (var musteri in TicariMusteri)
            {
                if (musteri.MusteriNo == MusteriNo)
                {
                    table.Rows.Add(musteri.MusteriNo, musteri.VergiNo, musteri.Ad, musteri.Adres, musteri.TelefonNo, musteri.ToplamBakiye, musteri.KayitTarihi);
                    datagrid.DataSource = table;
                    return 0;
                }
            }
            MessageBox.Show(MusteriNo.ToString() + " Musteri Numaralı kayıt yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 0;
        }

        public int VergiNoTicariHEkle(long VergiNo, TicariHesap TicariH)
        {
            foreach (var musteri in TicariMusteri)
            {
                if (musteri.VergiNo == VergiNo)
                {
                    musteri.Hesaplar.Add(TicariH);
                    MessageBox.Show("Hesabınızın Kaydı Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }
            }
            MessageBox.Show(VergiNo.ToString() + " Vergi Numaralı müşteri kaydı yok", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 0;
        }
        public int MusteriNoTicariHEkle(long MusteriNo, TicariHesap TicariH)
        {
            foreach (var musteri in TicariMusteri)
            {
                if (musteri.MusteriNo == MusteriNo)
                {
                    musteri.Hesaplar.Add(TicariH);
                    MessageBox.Show("Hesabınızın Kaydı Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }
            }
            MessageBox.Show(MusteriNo.ToString() + " Musteri Numaralı müşteri kaydı yok", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 0;
        }
        public int TCNoBireyselHEkle(long TCNo, BireyselHesap BireyselH)
        {
            foreach (var musteri in BireyselMusteri)
            {
                if (musteri.TCNo == TCNo)
                {
                    musteri.Hesaplar.Add(BireyselH);
                    MessageBox.Show("Hesabınızın Kaydı Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }
            }
            MessageBox.Show(TCNo.ToString() + " TC Numaralı müşteri kaydı yok", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 0;
        }
        public int MusteriNoBireyselHEkle(long MusteriNo, BireyselHesap BireyselH)
        {
            foreach (var musteri in BireyselMusteri)
            {
                if (musteri.MusteriNo == MusteriNo)
                {
                    musteri.Hesaplar.Add(BireyselH);
                    MessageBox.Show("Hesabınızın Kaydı Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }
            }
            MessageBox.Show(MusteriNo.ToString() + " Musteri Numaralı müşteri kaydı yok", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 0;
        }
        public int HesapNoTicariHAra(long HesapNo, DataGridView datagrid)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Hesap No", typeof(long));
            table.Columns.Add("Bakiye", typeof(string)); ;
            table.Columns.Add("KayitTarihi", typeof(string));

            foreach (var musteri in TicariMusteri)
            {
                foreach (var hesap in musteri.Hesaplar)
                {
                    if (hesap.HesapNo == HesapNo)
                    {
                        table.Rows.Add(hesap.HesapNo, hesap.Bakiye, hesap.HesapAcilmaTarihi);
                        datagrid.DataSource = table;
                        return 0;
                    }
                }
            }
            MessageBox.Show(HesapNo.ToString() + " Hesap Numaralı kayıt yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 0;
        }
        public int HesapNoBireyselHAra(long HesapNo, DataGridView datagrid)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Hesap No", typeof(long));
            table.Columns.Add("Bakiye", typeof(string)); ;
            table.Columns.Add("KayitTarihi", typeof(string));

            foreach (var musteri in BireyselMusteri)
            {
                foreach (var hesap in musteri.Hesaplar)
                {
                    if (hesap.HesapNo == HesapNo)
                    {
                        table.Rows.Add(hesap.HesapNo, hesap.Bakiye, hesap.HesapAcilmaTarihi);
                        datagrid.DataSource = table;
                        return 0;
                    }
                }
            }
            MessageBox.Show(HesapNo.ToString() + " Hesap Numaralı kayıt yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 0;
        }

        public void BireyselBankaKişiselBilgilerGuncelle(long No, string aramaTur, BireyselMusteri BMusteri)
        {
            if (aramaTur == "Musteri No")
            {
                foreach (var bireyselMusteri in BireyselMusteri)
                {

                    if (bireyselMusteri.MusteriNo == No)
                    {
                        bireyselMusteri.Ad = BMusteri.Ad;
                        bireyselMusteri.Soyad = BMusteri.Soyad;
                        bireyselMusteri.Adres = BMusteri.Adres;
                        bireyselMusteri.Eposta = BMusteri.Eposta;
                        bireyselMusteri.TelefonNo = BMusteri.TelefonNo;
                        MessageBox.Show("Müşteri bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            if (aramaTur == "TC No")
            {
                foreach (var bireyselMusteri in BireyselMusteri)
                {
                    if (bireyselMusteri.TCNo == No)
                    {
                        bireyselMusteri.Ad = BMusteri.Ad;
                        bireyselMusteri.Soyad = BMusteri.Soyad;
                        bireyselMusteri.Adres = BMusteri.Adres;
                        bireyselMusteri.Eposta = BMusteri.Eposta;
                        bireyselMusteri.TelefonNo = BMusteri.TelefonNo;
                        MessageBox.Show("Müşteri bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        public BireyselMusteri BireyselBankaKişiselBilgilerGetir(long No, string aramaTur)
        {
            if (aramaTur == "Musteri No")
            {
                foreach (var bireyselMusteri in BireyselMusteri)
                {

                    if (bireyselMusteri.MusteriNo == No)
                    {
                        return bireyselMusteri;
                    }
                }
            }
            if (aramaTur == "TC No")
            {
                foreach (var bireyselMusteri in BireyselMusteri)
                {
                    if (bireyselMusteri.TCNo == No)
                    {
                        return bireyselMusteri;
                    }
                }
            }
            return null;
        }
        public void TicariBankaKişiselBilgilerGuncelle(long No, string aramaTur, TicariMusteri TMusteri)
        {
            if (aramaTur == "Musteri No")
            {
                foreach (var ticariMusteri in TicariMusteri)
                {

                    if (ticariMusteri.MusteriNo == No)
                    {
                        ticariMusteri.Ad = TMusteri.Ad;
                        ticariMusteri.Adres = TMusteri.Adres;
                        ticariMusteri.TelefonNo = TMusteri.TelefonNo;
                        MessageBox.Show("Müşteri bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            if (aramaTur == "Vergi No")
            {
                foreach (var ticariMusteri in TicariMusteri)
                {
                    if (ticariMusteri.VergiNo == No)
                    {
                        ticariMusteri.Ad = TMusteri.Ad;
                        ticariMusteri.Adres = TMusteri.Adres;
                        ticariMusteri.TelefonNo = TMusteri.TelefonNo;
                        MessageBox.Show("Müşteri bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        public TicariMusteri TicariBankaKişiselBilgilerGetir(long No, string aramaTur)
        {
            if (aramaTur == "Musteri No")
            {
                foreach (var ticariMusteri in TicariMusteri)
                {

                    if (ticariMusteri.MusteriNo == No)
                    {
                        return ticariMusteri;
                    }
                }
            }
            if (aramaTur == "Vergi No")
            {
                foreach (var ticariMusteri in TicariMusteri)
                {

                    if (ticariMusteri.VergiNo == No)
                    {
                        return ticariMusteri;
                    }
                }
            }
            return null;
        }
        public void BireyselHesapOzetleriGetir(string baslangicTarihi,string bitisTarihi ,long hesapNo, DataGridView datagrid)
        {
            datagrid.DataSource = null;
            int sayac = 0;
            string format = "dd.MM.yyyy";
            CultureInfo culture = CultureInfo.CreateSpecificCulture("tr-TR");
            DateTime baslangic = DateTime.ParseExact(baslangicTarihi, format, culture);
            DateTime bitis = DateTime.ParseExact(bitisTarihi, format, culture);

            DataTable table = new DataTable();

            table.Columns.Add("İşlem Adı", typeof(string));
            table.Columns.Add("İşlem Tarihi", typeof(DateTime));
            table.Columns.Add("İşlem Tutarı", typeof(string));
            table.Columns.Add("Gönderen", typeof(string));
            table.Columns.Add("Alıcı", typeof(string));

            foreach (var musteri in BireyselMusteri)
            {
                foreach (var hesap in musteri.Hesaplar)
                {
                    if (hesap.HesapNo == hesapNo)
                    {
                        sayac++;
                        foreach (var islem in hesap.IslemGecmisi)
                        {
                            if (baslangic <= islem.IslemTarihi && bitis >= islem.IslemTarihi)
                            {
                                table.Rows.Add(islem.IslemAdi, islem.IslemTarihi, islem.IslemTutari.ToString() + " TL", islem.Gonderici, islem.Alici);
                                datagrid.DataSource = table;
                            }
                        }
                    }
                }
            }
            if (sayac == 0)
            {
                MessageBox.Show("Hesap bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            foreach (DataGridViewColumn column in datagrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        public void TicariHesapOzetleriGetir(string baslangicTarihi, string bitisTarihi, long hesapNo, DataGridView datagrid)
        {
            datagrid.DataSource = null;
            int sayac = 0;
            string format = "dd.MM.yyyy";
            CultureInfo culture = CultureInfo.CreateSpecificCulture("tr-TR");
            DateTime baslangic = DateTime.ParseExact(baslangicTarihi, format, culture);
            DateTime bitis = DateTime.ParseExact(bitisTarihi, format, culture);

            DataTable table = new DataTable();

            table.Columns.Add("İşlem Adı", typeof(string));
            table.Columns.Add("İşlem Tarihi", typeof(DateTime));
            table.Columns.Add("İşlem Tutarı", typeof(string));
            table.Columns.Add("Gönderen", typeof(string));
            table.Columns.Add("Alıcı", typeof(string));

            foreach (var musteri in TicariMusteri)
            {
                foreach (var hesap in musteri.Hesaplar)
                {
                    if (hesap.HesapNo == hesapNo)
                    {
                        sayac++;
                        foreach (var islem in hesap.IslemGecmisi)
                        {
                            if (baslangic <= islem.IslemTarihi && bitis >= islem.IslemTarihi)
                            {
                                table.Rows.Add(islem.IslemAdi, islem.IslemTarihi, islem.IslemTutari.ToString() + " TL", islem.Gonderici, islem.Alici);
                                datagrid.DataSource = table;
                            }
                        }
                    }
                }
            }
            if(sayac == 0)
            {
                MessageBox.Show("Hesap bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            foreach (DataGridViewColumn column in datagrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
