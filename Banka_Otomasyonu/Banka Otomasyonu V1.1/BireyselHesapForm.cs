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
    public partial class BireyselHesapForm : Form
    {
        public BireyselHesapForm()
        {
            InitializeComponent();
        }

        public static char HesapNo { get; set; }
        public int tiklamaSayisi = 0;

        public char HesapNoGetir()
        {
            return HesapNo;
        }

        AktifBireyselMusteri aktifMusteri = new AktifBireyselMusteri();

        private void BireyselHesapForm_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.SteelBlue;

            BireyselMusteri bireyselMusteri = new BireyselMusteri();

            Banka banka = new Banka();

            int sayac = 1;

            DataTable table = new DataTable();

            table.Columns.Add("HesapNo", typeof(long));
            table.Columns.Add("Açılma Tarihi", typeof(DateTime));
            table.Columns.Add("Bakiye", typeof(string));

            foreach (var musteri in banka.BireyselMusteriListesiniGetir())
            {
                if (aktifMusteri.AktifMusteriGetir().MusteriNo == musteri.MusteriNo || aktifMusteri.AktifMusteriGetir().TCNo == musteri.TCNo)
                {
                    foreach (var hesap in musteri.Hesaplar)
                    {
                        ToolStripButton button = new ToolStripButton();

                        button.Text = "Hesap" + sayac.ToString();
                        sayac++;

                        hesapOzetiToolStripMenuItem.DropDownItems.Add(button);

                        table.Rows.Add(hesap.HesapNo, hesap.HesapAcilmaTarihi, hesap.Bakiye + " TL");

                        gridHesapBilgi.DataSource = table;

                        foreach (DataGridViewColumn column in gridHesapBilgi.Columns)
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    }

                    labelMusteriIsim.Text = "Hoşgeldin " + musteri.Ad;
                    labelMusteriNo.Text = musteri.MusteriNo.ToString();
                    labelToplamBakiye.Text = musteri.ToplamBakiye.ToString() + " TL";
                }
            }
        }

        private void paraYatırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BireyselParaYatir paraYatir = new BireyselParaYatir();
            paraYatir.Show();
        }

        private void paraÇekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BireyselParaCek paraCek = new BireyselParaCek();
            paraCek.Show();
        }

        private void havaleYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BireyselHavaleYap haveleYap = new BireyselHavaleYap();
            haveleYap.Show();
        }

        private void hesapOzetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tiklamaSayisi++;

            if(tiklamaSayisi == 1)
            {
                hesapOzetiToolStripMenuItem.DropDownItemClicked += GetIndex;
                hesapOzetiToolStripMenuItem.DropDownItemClicked += DropDownItemClicked;
            }
        }

        void GetIndex(object sender, ToolStripItemClickedEventArgs e)
        {
            string hesapIsim = e.ClickedItem.Text;
            HesapNo = hesapIsim[hesapIsim.Length - 1];
            hesapOzetiToolStripMenuItem.DropDownItemClicked -= GetIndex;
        }

        private void DropDownItemClicked(object sender, EventArgs e)
        {
            BireyselHesapOzet hesapOzet = new BireyselHesapOzet();
            hesapOzet.Show();
            tiklamaSayisi = 0;

            hesapOzetiToolStripMenuItem.DropDownItemClicked -= DropDownItemClicked;
        }

        private void kişiselBilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BireyselKisiselBilgiler kisiselBilgiler = new BireyselKisiselBilgiler();
            kisiselBilgiler.Show();
        }

        private void ekranıYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BireyselMusteriGirisi bireyselGiris = new BireyselMusteriGirisi(aktifMusteri.AktifMusteriGetir().MusteriNo, "1234");
            this.Close();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void işlemlerToolStripMenuItem_Click(object sender, EventArgs e)  {  }

        private void hesaplarımArasıTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BireyselHesaplarArasıTransfer transfer = new BireyselHesaplarArasıTransfer();
            transfer.Show();
        }
    }
}
