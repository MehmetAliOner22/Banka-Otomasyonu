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
    public partial class TicariHesapListeleVeAra : Form
    {
        public TicariHesapListeleVeAra()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void TicariHesapListeleVeAra_Load(object sender, EventArgs e)
        {
            btnHesapAra.Enabled = !string.IsNullOrEmpty(txtNo.Text);

            Banka banka = new Banka();
            banka.TicariHListele(listTicariH);
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
        private void button2_Click_1(object sender, EventArgs e)
        {
            try { 
            Banka banka = new Banka();
            banka.HesapNoTicariHAra(long.Parse(txtNo.Text), listTicariH);
            }
            catch 
            {
                MessageBox.Show("Hesap Numarası geçersiz. Geçerli bir hesap numarası geriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

    }
}
