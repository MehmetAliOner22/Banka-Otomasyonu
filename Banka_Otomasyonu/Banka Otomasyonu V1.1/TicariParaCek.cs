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
    public partial class TicariParaCek : Form
    {
        public TicariParaCek()
        {
            InitializeComponent();
        }

        public bool InputDogrula()
        {
            if (string.IsNullOrEmpty(txtCekilecekTutar.Text) || cbKullanilacakHesap.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return false;
            }

            if (!decimal.TryParse(txtCekilecekTutar.Text, out _))
            {
                MessageBox.Show("Lütfen girdiğiniz bilgileri kontrol edin.");
                return false;
            }     

            if (Convert.ToDecimal(txtCekilecekTutar.Text) <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz.");
                return false;
            }

            return true;
        }

        private void TicariParaCek_Load(object sender, EventArgs e)
        {
            Banka banka = new Banka();

            int sayac = 1;

            AktifTicariMusteri aktifTicari = new AktifTicariMusteri();

            foreach (var musteri in banka.TicariMusteriListesiniGetir())
            {
                if (musteri.MusteriNo == aktifTicari.AktifMusteriGetir().MusteriNo)
                {
                    foreach (var hesap in musteri.Hesaplar)
                    {
                        cbKullanilacakHesap.Items.Add("Hesap" + sayac.ToString());
                        sayac++;
                    }
                }
            }
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            if (InputDogrula())
            {
                int secilenHesap = cbKullanilacakHesap.SelectedIndex;
                decimal tutar = Convert.ToDecimal(txtCekilecekTutar.Text);

                TicariHesap ticariHesap = new TicariHesap();
                ticariHesap.ParaCek(secilenHesap, tutar);
            }
        }
    }
}
