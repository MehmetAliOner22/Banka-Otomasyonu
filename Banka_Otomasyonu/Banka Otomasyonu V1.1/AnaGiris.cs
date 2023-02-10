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
    public partial class AnaGiris : Form
    {
        public AnaGiris()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            AdminGiris AG = new AdminGiris();
            AG.Show();
        }
        private void btnMusteriGirisi_Click(object sender, EventArgs e)
        {
            MusteriGirisi musteriGirisi = new MusteriGirisi();
            musteriGirisi.Show();
        }

        private void AnaGiris_Load(object sender, EventArgs e)
        {

            notifyIcon1.BalloonTipTitle = "Hoşgeldiniz";
            notifyIcon1.BalloonTipText = " ";
            notifyIcon1.ShowBalloonTip(1000);
        }
    }
}
