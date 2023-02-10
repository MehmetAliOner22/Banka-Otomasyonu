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
    public partial class BireyselHesapSil : Form
    {
        public BireyselHesapSil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Banka banka = new Banka();
            banka.HesapNoBHesapSil(long.Parse(txtNo.Text));
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            btnHesapSil.Enabled = !string.IsNullOrEmpty(txtNo.Text);

            long value;
            if (!long.TryParse(txtNo.Text, out value))
            {
                txtNo.Text = string.Empty;
            }
        }

        private void BireyselHesapSil_Load(object sender, EventArgs e)
        {
            btnHesapSil.Enabled = !string.IsNullOrEmpty(txtNo.Text);
        }
    }
}
