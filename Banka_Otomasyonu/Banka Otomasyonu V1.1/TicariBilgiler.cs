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
    public partial class TicariBilgiler : Form
    {
        public TicariBilgiler()
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

            if (string.IsNullOrEmpty(txtTelefon.Text))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız");
                return false;
            }

            return true;
        }

        AktifTicariMusteri aktifTicari = new AktifTicariMusteri();

        private void TicariBilgiler_Load(object sender, EventArgs e)
        {
            txtIsim.Text = aktifTicari.AktifMusteriGetir().Ad;
            txtVergiNo.Text = aktifTicari.AktifMusteriGetir().VergiNo.ToString();
            txtTelefon.Text = aktifTicari.AktifMusteriGetir().TelefonNo;
            txtAdres.Text = aktifTicari.AktifMusteriGetir().Adres;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (inputDogrula())
            {
                aktifTicari.AktifMusteriGetir().TelefonNo = txtTelefon.Text;
                txtTelefon.ReadOnly = true;

                MessageBox.Show("Değişiklikler kaydedildi.");
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            txtTelefon.ReadOnly = false;
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)   { }
    }
}
