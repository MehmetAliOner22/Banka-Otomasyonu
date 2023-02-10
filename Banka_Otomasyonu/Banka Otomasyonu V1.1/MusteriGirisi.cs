using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyonu_V1._1
{
    public partial class MusteriGirisi : Form
    {
        public MusteriGirisi()
        {
            InitializeComponent();
        }

        private void btnBireysel_Click(object sender, EventArgs e)
        {
            BireyselMusteriGirisi bireyselGiris = new BireyselMusteriGirisi();
            bireyselGiris.Show();
            this.Hide();
        }

        private void btnTicari_Click(object sender, EventArgs e)
        {
            TicariMusteriGiris ticariGiris = new TicariMusteriGiris();
            ticariGiris.Show();
            this.Hide();
        }
    }
}
