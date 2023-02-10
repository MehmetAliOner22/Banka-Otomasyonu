using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyonu_V1._1
{
    public partial class BireyselKisiselBilgiler : Form
    {
        public BireyselKisiselBilgiler()
        {
            InitializeComponent();
        }

        public bool inputDogrula()
        {
            if (!long.TryParse(txtTelefon.Text, out _))
            {
                MessageBox.Show("Lütfen girdiğiniz bilgileri kontrol edin.");
                return false;
            }

            if (string.IsNullOrEmpty(txtEposta.Text) || string.IsNullOrEmpty(txtTelefon.Text))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız");
                return false;
            }

            return true;
        }

        AktifBireyselMusteri aktifMusteri = new AktifBireyselMusteri();
        private void KisiselBilgiler_Load(object sender, EventArgs e)
        {
            txtIsim.Text = aktifMusteri.AktifMusteriGetir().Ad;
            txtSoyisim.Text = aktifMusteri.AktifMusteriGetir().Soyad;
            txtTelefon.Text = aktifMusteri.AktifMusteriGetir().TelefonNo;
            txtEposta.Text = aktifMusteri.AktifMusteriGetir().Eposta;
            txtAdres.Text = aktifMusteri.AktifMusteriGetir().Adres;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (inputDogrula())
            {
                aktifMusteri.AktifMusteriGetir().TelefonNo = txtTelefon.Text;
                aktifMusteri.AktifMusteriGetir().Eposta = txtEposta.Text;
                txtTelefon.ReadOnly = true;
                txtEposta.ReadOnly = true;

                MessageBox.Show("Değişiklikler kaydedildi.");
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            txtTelefon.ReadOnly = false;
            txtEposta.ReadOnly = false;
        }
    }
}
