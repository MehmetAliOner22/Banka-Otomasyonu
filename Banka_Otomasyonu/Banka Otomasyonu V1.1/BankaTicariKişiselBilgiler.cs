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
    public partial class BankaTicariKişiselBilgiler : Form
    {
        public BankaTicariKişiselBilgiler()
        {
            InitializeComponent();

            comboAraTur.DropDownStyle = ComboBoxStyle.DropDownList;

            txtIsim.ReadOnly = true;
            txtTelefon.ReadOnly = true;
            txtAdres.ReadOnly = true;
            button1.Enabled = !string.IsNullOrEmpty(comboAraTur.Text) && !string.IsNullOrEmpty(txtNo.Text) && !string.IsNullOrEmpty(txtIsim.Text) && !string.IsNullOrEmpty(txtTelefon.Text) && !string.IsNullOrEmpty(txtAdres.Text);

        }

        private void BankaTicariKişiselBilgiler_Load(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            Banka banka = new Banka();
            TicariMusteri ticariMusteri = new TicariMusteri();

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
                    ticariMusteri = banka.TicariBankaKişiselBilgilerGetir(long.Parse(txtNo.Text), comboAraTur.Text);

                    if (ticariMusteri != null)
                    {
                        txtIsim.Text = ticariMusteri.Ad;
                        txtTelefon.Text = ticariMusteri.TelefonNo;
                        txtAdres.Text = ticariMusteri.Adres;

                        txtNo.ReadOnly = true;
                        comboAraTur.Enabled = false;
                        txtIsim.ReadOnly = false;
                        txtTelefon.ReadOnly = false;
                        txtAdres.ReadOnly = false;

                    }
                    else
                    {
                        MessageBox.Show("Lütfen geçerli numara giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrEmpty(comboAraTur.Text) && !string.IsNullOrEmpty(txtNo.Text) && !string.IsNullOrEmpty(txtIsim.Text) && !string.IsNullOrEmpty(txtTelefon.Text) && !string.IsNullOrEmpty(txtAdres.Text);


            long value;
            if (!long.TryParse(txtNo.Text, out value))
            {
                txtNo.Text = string.Empty;
            }
        }

        private void comboAraTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrEmpty(comboAraTur.Text) && !string.IsNullOrEmpty(txtNo.Text) && !string.IsNullOrEmpty(txtIsim.Text) && !string.IsNullOrEmpty(txtTelefon.Text) && !string.IsNullOrEmpty(txtAdres.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banka banka = new Banka();
            TicariMusteri ticariMusteri = new TicariMusteri();

            ticariMusteri.Ad = txtIsim.Text;
            ticariMusteri.TelefonNo = txtTelefon.Text;
            ticariMusteri.Adres = txtAdres.Text;
            banka.TicariBankaKişiselBilgilerGuncelle(long.Parse(txtNo.Text), comboAraTur.Text, ticariMusteri);

            txtNo.ReadOnly = false;
            comboAraTur.Enabled = true;
            txtIsim.ReadOnly = true;
            txtTelefon.ReadOnly = true;
            txtAdres.ReadOnly = true;
        }

        private void txtIsim_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrEmpty(comboAraTur.Text) && !string.IsNullOrEmpty(txtNo.Text) && !string.IsNullOrEmpty(txtIsim.Text) && !string.IsNullOrEmpty(txtTelefon.Text) && !string.IsNullOrEmpty(txtAdres.Text);
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrEmpty(comboAraTur.Text) && !string.IsNullOrEmpty(txtNo.Text) && !string.IsNullOrEmpty(txtIsim.Text) && !string.IsNullOrEmpty(txtTelefon.Text) && !string.IsNullOrEmpty(txtAdres.Text);
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrEmpty(comboAraTur.Text) && !string.IsNullOrEmpty(txtNo.Text) && !string.IsNullOrEmpty(txtIsim.Text) && !string.IsNullOrEmpty(txtTelefon.Text) && !string.IsNullOrEmpty(txtAdres.Text);
        }

        private void txtIsim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
