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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Banka_Otomasyonu_V1._1
{
    public partial class BireyselMusteriEkle : Form
    {
        public BireyselMusteriEkle()
        {
            InitializeComponent();
        }

        private void BireyselMusteriEkle_Load(object sender, EventArgs e)
        {
            ekle.Enabled = !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtTCNo.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTelNo.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtEPosta.Text == null) 
            {
                 Random randomGenerator = new Random();
                 BireyselMusteri bireyselM = new BireyselMusteri(long.Parse(txtTCNo.Text),
                                                                 randomGenerator.Next(100000000, 1000000000),
                                                                 txtAd.Text,
                                                                 txtSoyad.Text,
                                                                 txtAdres.Text,
                                                                 txtTelNo.Text,
                                                                 DateTime.Now);

                 Banka banka = new Banka();
                 banka.BMusteriEkle(long.Parse(txtTCNo.Text), bireyselM);
            }
            else 
            {
                Random randomGenerator = new Random();
                BireyselMusteri bireyselM = new BireyselMusteri(long.Parse(txtTCNo.Text),
                                                                randomGenerator.Next(100000000, 1000000000),
                                                                txtAd.Text,
                                                                txtSoyad.Text,
                                                                txtAdres.Text,
                                                                txtTelNo.Text,
                                                                DateTime.Now,
                                                                txtEPosta.Text);

                Banka banka = new Banka();
                banka.BMusteriEkle(long.Parse(txtTCNo.Text),bireyselM);
            }
            
        }

        private void txtTCNo_TextChanged(object sender, EventArgs e)
        {
            ekle.Enabled = !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtTCNo.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTelNo.Text);


            long value;
            if (!long.TryParse(txtTCNo.Text, out value))
            {
                txtTCNo.Text = string.Empty;
            }
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            ekle.Enabled = !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtTCNo.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTelNo.Text);
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            ekle.Enabled = !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtTCNo.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTelNo.Text);
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            ekle.Enabled = !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtTCNo.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTelNo.Text);

        }

        private void txtTelNo_TextChanged(object sender, EventArgs e)
        {
            ekle.Enabled = !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtTCNo.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTelNo.Text);

        }
    }
}
