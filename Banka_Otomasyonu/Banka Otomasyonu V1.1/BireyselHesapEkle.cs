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
    public partial class BireyselHesapEkle : Form
    {
        public BireyselHesapEkle()
        {
            InitializeComponent();

            comboEkleTur.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Random randomGenerator = new Random();

            BireyselHesap bireyselH = new BireyselHesap();
            bireyselH.HesapNo = randomGenerator.Next(100000000, 499999999);
            bireyselH.HesapAcilmaTarihi = DateTime.Now;

            Banka banka = new Banka();
            /* txtNo.Text*/
            if (comboEkleTur.Text == "TC No")
            {
                banka.TCNoBireyselHEkle(long.Parse(txtNo.Text), bireyselH);
            }
            else if (comboEkleTur.Text == "Musteri No")
            {
                banka.MusteriNoBireyselHEkle(long.Parse(txtNo.Text), bireyselH);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir ekleme türü giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BireyselHesapEkle_Load(object sender, EventArgs e)
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
