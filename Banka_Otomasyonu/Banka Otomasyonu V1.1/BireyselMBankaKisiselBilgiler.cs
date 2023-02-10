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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Banka_Otomasyonu_V1._1
{
    public partial class BireyselMBankaKisiselBilgiler : Form
    {
        public BireyselMBankaKisiselBilgiler()
        {
            InitializeComponent();


            txtIsim.ReadOnly = true;
            txtSoyIsim.ReadOnly = true;
            txtTelefon.ReadOnly = true;
            txtAdres.ReadOnly = true;
            txtEposta.ReadOnly = true;
            button1.Enabled = !string.IsNullOrEmpty(comboAraTur.Text) && !string.IsNullOrEmpty(txtNo.Text) && !string.IsNullOrEmpty(txtIsim.Text) && !string.IsNullOrEmpty(txtSoyIsim.Text) && !string.IsNullOrEmpty(txtTelefon.Text) && !string.IsNullOrEmpty(txtEposta.Text) && !string.IsNullOrEmpty(txtAdres.Text);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Banka banka= new Banka();
            BireyselMusteri bireyselMusteri = new BireyselMusteri();

                if (string.IsNullOrEmpty(comboAraTur.Text))
                {
                    MessageBox.Show("Lütfen arama türü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (string.IsNullOrEmpty(txtNo.Text))
                    { 
                        MessageBox.Show("Lütfen aramamız için numara giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                         bireyselMusteri = banka.BireyselBankaKişiselBilgilerGetir(long.Parse(txtNo.Text), comboAraTur.Text);

                            if (bireyselMusteri != null)
                            {
                               txtIsim.Text = bireyselMusteri.Ad;
                               txtSoyIsim.Text = bireyselMusteri.Soyad;
                               txtTelefon.Text = bireyselMusteri.TelefonNo;
                               txtEposta.Text = bireyselMusteri.Eposta;
                               txtAdres.Text = bireyselMusteri.Adres;

                               txtNo.ReadOnly = true;
                               comboAraTur.Enabled = false;
                               txtIsim.ReadOnly = false;
                               txtSoyIsim.ReadOnly = false;
                               txtTelefon.ReadOnly = false;
                               txtAdres.ReadOnly = false;
                               txtEposta.ReadOnly = false;

                            }
                            else
                            {
                                MessageBox.Show("Lütfen geçerli numara giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                    }
                }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banka banka = new Banka();
            BireyselMusteri bireyselMusteri = new BireyselMusteri();

            bireyselMusteri.Ad = txtIsim.Text;
            bireyselMusteri.Soyad = txtSoyIsim.Text;
            bireyselMusteri.TelefonNo = txtTelefon.Text;
            bireyselMusteri.Eposta = txtEposta.Text;
            bireyselMusteri.Adres = txtAdres.Text;
            banka.BireyselBankaKişiselBilgilerGuncelle(long.Parse(txtNo.Text), comboAraTur.Text, bireyselMusteri);

            txtNo.ReadOnly = false;
            comboAraTur.Enabled = true;

        }
        private void comboAraTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrEmpty(comboAraTur.Text) && !string.IsNullOrEmpty(txtNo.Text) && !string.IsNullOrEmpty(txtIsim.Text) && !string.IsNullOrEmpty(txtSoyIsim.Text) && !string.IsNullOrEmpty(txtTelefon.Text) && !string.IsNullOrEmpty(txtEposta.Text) && !string.IsNullOrEmpty(txtAdres.Text);
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {

            long value;
            if (!long.TryParse(txtNo.Text, out value))
            {
                txtNo.Text = string.Empty;
            }

            button1.Enabled = !string.IsNullOrEmpty(comboAraTur.Text) && !string.IsNullOrEmpty(txtNo.Text) && !string.IsNullOrEmpty(txtIsim.Text) && !string.IsNullOrEmpty(txtSoyIsim.Text) && !string.IsNullOrEmpty(txtTelefon.Text) && !string.IsNullOrEmpty(txtEposta.Text) && !string.IsNullOrEmpty(txtAdres.Text);
        }

        private void txtIsim_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrEmpty(comboAraTur.Text) && !string.IsNullOrEmpty(txtNo.Text) && !string.IsNullOrEmpty(txtIsim.Text) && !string.IsNullOrEmpty(txtSoyIsim.Text) && !string.IsNullOrEmpty(txtTelefon.Text) && !string.IsNullOrEmpty(txtEposta.Text) && !string.IsNullOrEmpty(txtAdres.Text);
        }

        private void txtSoyIsim_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrEmpty(comboAraTur.Text) && !string.IsNullOrEmpty(txtNo.Text) && !string.IsNullOrEmpty(txtIsim.Text) && !string.IsNullOrEmpty(txtSoyIsim.Text) && !string.IsNullOrEmpty(txtTelefon.Text) && !string.IsNullOrEmpty(txtEposta.Text) && !string.IsNullOrEmpty(txtAdres.Text);
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrEmpty(comboAraTur.Text) && !string.IsNullOrEmpty(txtNo.Text) && !string.IsNullOrEmpty(txtIsim.Text) && !string.IsNullOrEmpty(txtSoyIsim.Text) && !string.IsNullOrEmpty(txtTelefon.Text) && !string.IsNullOrEmpty(txtEposta.Text) && !string.IsNullOrEmpty(txtAdres.Text);
        }

        private void txtEposta_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrEmpty(comboAraTur.Text) && !string.IsNullOrEmpty(txtNo.Text) && !string.IsNullOrEmpty(txtIsim.Text) && !string.IsNullOrEmpty(txtSoyIsim.Text) && !string.IsNullOrEmpty(txtTelefon.Text) && !string.IsNullOrEmpty(txtEposta.Text) && !string.IsNullOrEmpty(txtAdres.Text);
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrEmpty(comboAraTur.Text) && !string.IsNullOrEmpty(txtNo.Text) && !string.IsNullOrEmpty(txtIsim.Text) && !string.IsNullOrEmpty(txtSoyIsim.Text) && !string.IsNullOrEmpty(txtTelefon.Text) && !string.IsNullOrEmpty(txtEposta.Text) && !string.IsNullOrEmpty(txtAdres.Text);
        }

        private void txtIsim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoyIsim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
