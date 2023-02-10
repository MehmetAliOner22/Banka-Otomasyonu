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
    public partial class BireyselMusteriSilPaneli : Form
    {
        public BireyselMusteriSilPaneli()
        {
            InitializeComponent();

            comboSilTur.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Banka banka = new Banka();
            if (comboSilTur.Text == "Musteri No")
            {
                banka.MusteriNoBMusteriSil(Convert.ToInt64(txtNo.Text));
            }
            else if (comboSilTur.Text == "TC No")
            {
                banka.TCNoBMusteriSil(Convert.ToInt64(txtNo.Text));
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir silme türü giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            MusteriSil.Enabled = !string.IsNullOrEmpty(txtNo.Text);

            long value;
            if (!long.TryParse(txtNo.Text, out value))
            {
                txtNo.Text = string.Empty;
            }
        }

        private void BireyselMusteriSilPaneli_Load(object sender, EventArgs e)
        {
            MusteriSil.Enabled = !string.IsNullOrEmpty(txtNo.Text);
        }
    }
}
