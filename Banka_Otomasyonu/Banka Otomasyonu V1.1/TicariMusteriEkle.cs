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
    public partial class TicariMusteriEkle : Form
    {
        public TicariMusteriEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random randomGenerator = new Random();
            TicariMusteri ticariM = new TicariMusteri(long.Parse(txtVergiNo.Text),
                                                      randomGenerator.Next(100000000, 1000000000),
                                                      txtAd.Text,
                                                      txtAdres.Text,
                                                      txtTelNo.Text,
                                                      DateTime.Now);

            Banka banka = new Banka();
            banka.TMusteriEkle(long.Parse(txtVergiNo.Text), ticariM);
        }

        private void txtVergiNo_TextChanged(object sender, EventArgs e)
        {
            ekle.Enabled = !string.IsNullOrEmpty(txtVergiNo.Text) && !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTelNo.Text);

            long value;
            if (!long.TryParse(txtVergiNo.Text, out value))
            {
                txtVergiNo.Text = string.Empty;
            }
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            ekle.Enabled = !string.IsNullOrEmpty(txtVergiNo.Text) && !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTelNo.Text);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            ekle.Enabled = !string.IsNullOrEmpty(txtVergiNo.Text) && !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTelNo.Text);

        }

        private void txtTelNo_TextChanged(object sender, EventArgs e)
        {
            ekle.Enabled = !string.IsNullOrEmpty(txtVergiNo.Text) && !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTelNo.Text);

        }

        private void TicariMusteriEkle_Load(object sender, EventArgs e)
        {
            ekle.Enabled = !string.IsNullOrEmpty(txtVergiNo.Text) && !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTelNo.Text);

        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
