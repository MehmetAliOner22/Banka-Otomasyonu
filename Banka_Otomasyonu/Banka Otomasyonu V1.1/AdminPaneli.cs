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
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }
        
        private void musteriİslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void musteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ticariMusteriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TicariMusteriEkle TME = new TicariMusteriEkle();
            TME.Show();
        }

        private void bireyselMusteriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BireyselMusteriEkle BME = new BireyselMusteriEkle();
            BME.Show();
        }

        private void musteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ticariMusteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicariMusteriListele TML = new TicariMusteriListele();  
            TML.Show();
        }

        private void bireyselMusteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BireyselMusterileriListeleVeAra BML = new BireyselMusterileriListeleVeAra();
            BML.Show();
        }

        private void musteriNumarasiIleAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tCNoIleAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminPaneli_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.SteelBlue;

            Banka banka = new Banka();
            banka.BankaBilgiListele(dataGridBankaBilgi);
        }

        private void pencereyiGizleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void musteriAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void bireyselMusteriToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TicariMSilPanel TMSP = new TicariMSilPanel();
            TMSP.Show();
        }

        private void ticariMusteriToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BireyselMusteriSilPaneli BMSP = new BireyselMusteriSilPaneli();
            BMSP.Show();
        }

        private void ticariHesapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicariHesapListeleVeAra THLVA = new TicariHesapListeleVeAra();
            THLVA.Show();
        }

        private void bireyselHesapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BireyselHesapListeleVeAra BHLVA = new BireyselHesapListeleVeAra();
            BHLVA.Show();
        }

        private void ticariHesapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TicariHesapEkle THE = new TicariHesapEkle();
            THE.Show();
        }

        private void bireyselHesapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BireyselHesapEkle BHE = new BireyselHesapEkle();
            BHE.Show();
        }

        private void bireyselMusteriToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BireyselHesapSil BHS = new BireyselHesapSil();  
            BHS.Show();
        }

        private void ticariMusteriToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TicariHesapSil THS = new TicariHesapSil();
            THS.Show();
        }

        private void eskiyeDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void programıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bireyselMüsteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankaBireyselKisiselBilgiler BBKB = new BankaBireyselKisiselBilgiler();
            BBKB.Show();
        }

        private void ticariMüsteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankaTicariKişiselBilgiler BTKB = new BankaTicariKişiselBilgiler();
            BTKB.Show();
        }

        private void bireyselHesapToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Banka_Bireysel_Hesap_Ozet BBHO = new Banka_Bireysel_Hesap_Ozet();
            BBHO.Show();
        }

        private void ticariHesapToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Banka_Ticari_Hesap_Ozet BTHO = new Banka_Ticari_Hesap_Ozet();
            BTHO.Show();    
        }
    }
}
