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
    public partial class TicariHesaplarArasıTransfer : Form
    {
        public TicariHesaplarArasıTransfer()
        {
            InitializeComponent();
        }

        public bool InputDogrula()
        {
            if(cbAliciHesap.SelectedIndex == cbGonderenHesap.SelectedIndex)
            {
                MessageBox.Show("Aynı hesaba transfer gerçekleştiremezsiniz.");
                return false;
            }

            if (string.IsNullOrEmpty(txtTransferTutar.Text) || cbGonderenHesap.SelectedIndex == -1 || cbAliciHesap.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return false;
            }

            if (!decimal.TryParse(txtTransferTutar.Text, out _))
            {
                MessageBox.Show("Lütfen girdiğiniz bilgileri kontrol edin.");
                return false;
            }

            if (Convert.ToDecimal(txtTransferTutar.Text) <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz.");
                return false;
            }

            return true;
        }

        AktifTicariMusteri aktifTicari = new AktifTicariMusteri();
        Banka banka = new Banka();

        private void panel1_Paint(object sender, PaintEventArgs e)    {   }

        private void TicariHesaplarArasıTransfer_Load(object sender, EventArgs e)
        {         

            int sayac = 1;

            foreach (var musteri in banka.TicariMusteriListesiniGetir())
            {
                if (musteri.MusteriNo == aktifTicari.AktifMusteriGetir().MusteriNo)
                {
                    foreach (var hesap in musteri.Hesaplar)
                    {
                        cbGonderenHesap.Items.Add("Hesap" + sayac.ToString());
                        cbAliciHesap.Items.Add("Hesap" + sayac.ToString());
                        sayac++;
                    }
                }
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (InputDogrula())
            {
                int gonderenHesap = cbGonderenHesap.SelectedIndex;
                int aliciHesap = cbAliciHesap.SelectedIndex;
                decimal tutar = Convert.ToDecimal(txtTransferTutar.Text);

                TicariHesap ticariHesap = new TicariHesap();
                ticariHesap.HesaplarArasiTransfer(gonderenHesap, aliciHesap, tutar);      
            }
        }
    }
}
