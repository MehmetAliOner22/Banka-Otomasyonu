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
    public partial class BireyselParaYatir : Form
    {
        public BireyselParaYatir()
        {
            InitializeComponent();
        }

        public bool InputDogrula()
        {
            if (string.IsNullOrEmpty(txtYatıralacakTutar.Text) || cbAliciHesap.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return false;
            }

            if (!decimal.TryParse(txtYatıralacakTutar.Text, out _))
            {
                MessageBox.Show("Lütfen girdiğiniz bilgileri kontrol edin.");
                return false;
            }

            if (Convert.ToDecimal(txtYatıralacakTutar.Text) <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz.");
                return false;
            }

            return true;
        }

        private void btnYatir_Click(object sender, EventArgs e)
        {
            if (InputDogrula())
            {
                int secilenHesap = cbAliciHesap.SelectedIndex;
                decimal tutar = Convert.ToDecimal(txtYatıralacakTutar.Text);

                BireyselHesap bireyselHesap = new BireyselHesap();
                bireyselHesap.ParaYatir(secilenHesap, tutar);
            }
        }

        private void BireyselParaYatir_Load(object sender, EventArgs e)
        {
            Banka banka = new Banka();

            int sayac = 1;

            AktifBireyselMusteri aktifBireysel = new AktifBireyselMusteri();

            foreach (var musteri in banka.BireyselMusteriListesiniGetir())
            {
                if (musteri.MusteriNo == aktifBireysel.AktifMusteriGetir().MusteriNo || musteri.TCNo == aktifBireysel.AktifMusteriGetir().TCNo)
                {
                    foreach (var hesap in musteri.Hesaplar)
                    {
                        cbAliciHesap.Items.Add("Hesap" + sayac.ToString());
                        sayac++;
                    }
                }
            }
        }
    }
}
