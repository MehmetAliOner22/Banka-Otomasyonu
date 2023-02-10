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
    public partial class TicariHesapEkle : Form
    {
        public TicariHesapEkle()
        {
            InitializeComponent();

            comboEkleTur.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random randomGenerator = new Random();
            
            TicariHesap ticariH = new TicariHesap();
            ticariH.HesapNo = randomGenerator.Next(500000000, 999999999);
            ticariH.HesapAcilmaTarihi = DateTime.Now;

            Banka banka = new Banka();
            if (comboEkleTur.Text == "Vergi No")
            {
                banka.VergiNoTicariHEkle(long.Parse(txtNo.Text), ticariH);
            }
            else if (comboEkleTur.Text == "Musteri No")
            {
                banka.MusteriNoTicariHEkle(long.Parse(txtNo.Text), ticariH);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir ekleme türü giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void TicariHesapEkle_Load(object sender, EventArgs e)
        {
            btnEkle.Enabled = !string.IsNullOrEmpty(txtNo.Text);
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {
           btnEkle.Enabled = !string.IsNullOrEmpty(txtNo.Text);

            long value;
            if (!long.TryParse(txtNo.Text, out value))
            {
                txtNo.Text = string.Empty;
            }
        }
    }
}
