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
    public partial class BireyselMusterileriListeleVeAra : Form
    {
        public BireyselMusterileriListeleVeAra()
        {
            InitializeComponent();

            comboAraTur.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BireyselMusterileriListeleVeAra_Load(object sender, EventArgs e)
        {
            MusteriAra.Enabled = !string.IsNullOrEmpty(txtNo.Text);

            Banka banka = new Banka();
            banka.BireyselMListele(listBireyselM);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            Banka banka = new Banka();
            if (comboAraTur.Text == "Musteri No")
            {
                banka.MusteriNoBireyselMAra(Convert.ToInt64(txtNo.Text),listBireyselM);
            }
            else if (comboAraTur.Text == "TC No")
            {
                banka.TCNoBireyselMAra(Convert.ToInt64(txtNo.Text), listBireyselM);
            }
            else 
            {
                MessageBox.Show("Lütfen geçerli bir arama türü giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
            catch 
            {
                MessageBox.Show("Lütfen geçerli değerler giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            MusteriAra.Enabled = !string.IsNullOrEmpty(txtNo.Text);

            long value;
            if (!long.TryParse(txtNo.Text, out value))
            {
                txtNo.Text = string.Empty;
            }
        }

        private void comboAraTur_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
