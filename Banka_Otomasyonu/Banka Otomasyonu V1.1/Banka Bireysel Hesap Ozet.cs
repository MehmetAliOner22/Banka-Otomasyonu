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
    public partial class Banka_Bireysel_Hesap_Ozet : Form
    {
        public Banka_Bireysel_Hesap_Ozet()
        {
            InitializeComponent();

            btnListele.Enabled = !string.IsNullOrEmpty(txtHesapNo.Text) && !string.IsNullOrEmpty(txtBitisTarihi.Text) && !string.IsNullOrEmpty(txtBaslangicTarihi.Text);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
            Banka banka = new Banka();
            banka.BireyselHesapOzetleriGetir(txtBaslangicTarihi.Text, txtBitisTarihi.Text, long.Parse(txtHesapNo.Text), gridHesapOzet);
            }
            catch
            {
                MessageBox.Show(" Bilgileri doğru girdiğinizden emin olun ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtHesapNo_TextChanged(object sender, EventArgs e)
        {
            long value;
            if (!long.TryParse(txtHesapNo.Text, out value))
            {
                txtHesapNo.Text = string.Empty;
            }

            btnListele.Enabled = !string.IsNullOrEmpty(txtHesapNo.Text) && !string.IsNullOrEmpty(txtBitisTarihi.Text) && !string.IsNullOrEmpty(txtBaslangicTarihi.Text);
        }

        private void txtBaslangicTarihi_TextChanged(object sender, EventArgs e)
        {
            btnListele.Enabled = !string.IsNullOrEmpty(txtHesapNo.Text) && !string.IsNullOrEmpty(txtBitisTarihi.Text) && !string.IsNullOrEmpty(txtBaslangicTarihi.Text);
        }

        private void txtBitisTarihi_TextChanged(object sender, EventArgs e)
        {
            btnListele.Enabled = !string.IsNullOrEmpty(txtHesapNo.Text) && !string.IsNullOrEmpty(txtBitisTarihi.Text) && !string.IsNullOrEmpty(txtBaslangicTarihi.Text);
        }
    }
}
