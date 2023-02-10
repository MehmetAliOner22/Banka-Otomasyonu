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
    public partial class BireyselMusteriGirisi : Form
    {
        public BireyselMusteriGirisi(long musteriNo, string sifre)
        {
            InitializeComponent();

            txtNo.Text = musteriNo.ToString();
            txtSifre.Text = sifre;
            this.Show();
            btnGiris.PerformClick();
        }

        public BireyselMusteriGirisi()
        {
            InitializeComponent();       
        }

        public bool InputDogrula()
        {
            if (string.IsNullOrEmpty(txtNo.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return false;
            }

            try
            {
                Convert.ToInt64(txtNo.Text);

                return true;

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen girdiğiniz bilgileri kontrol edin.");
                return false;
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            AktifBireyselMusteri aktifMusteri = new AktifBireyselMusteri();

            if (InputDogrula() && aktifMusteri.MusteriKontol(Convert.ToInt64(txtNo.Text)) && aktifMusteri.SifreKontrol(txtSifre.Text))
            {
                BireyselHesapForm hesap = new BireyselHesapForm();
                hesap.Show();
                this.Hide();
            }
        }
    }
}
