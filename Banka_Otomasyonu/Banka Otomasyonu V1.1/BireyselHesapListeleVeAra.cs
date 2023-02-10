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
    public partial class BireyselHesapListeleVeAra : Form
    {
        public BireyselHesapListeleVeAra()
        {
            InitializeComponent();
        }

        private void BireyselHesapListeleVeAra_Load(object sender, EventArgs e)
        {
            btnHesapAra.Enabled = !string.IsNullOrEmpty(txtNo.Text);

            Banka banka = new Banka();
            banka.BireyselHListele(gridBireyselHesap);
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            btnHesapAra.Enabled = !string.IsNullOrEmpty(txtNo.Text);


            long value;
            if (!long.TryParse(txtNo.Text, out value))
            {
                txtNo.Text = string.Empty;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Banka banka = new Banka();
                banka.HesapNoBireyselHAra(long.Parse(txtNo.Text), gridBireyselHesap);
            }
            catch
            {
                MessageBox.Show("Hesap Numarası geçersiz. Geçerli bir hesap numarası geriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
