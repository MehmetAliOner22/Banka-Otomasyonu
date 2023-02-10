using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Banka_Otomasyonu_V1._1
{
    public partial class BireyselHesapOzet : Form
    { 
        public BireyselHesapOzet()
        {
            InitializeComponent();
        }

        BireyselHesapForm hesapForm = new BireyselHesapForm();
        AktifBireyselMusteri aktifBireysel = new AktifBireyselMusteri();
        private DateTime baslangicTarihi;
        private DateTime bitisTarihi;

        private bool InputDogrula()
        {
            if(string.IsNullOrEmpty(txtBaslangicTarihi.Text) || string.IsNullOrEmpty(txtBitisTarihi.Text))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                return false;
            }

            return true;
        }

        private void InputuTariheDonustur()
        {
            string format = "dd.MM.yyyy";
            CultureInfo culture = CultureInfo.CreateSpecificCulture("tr-TR");
            baslangicTarihi = DateTime.ParseExact(txtBaslangicTarihi.Text, format, culture);
            bitisTarihi = DateTime.ParseExact(txtBitisTarihi.Text, format, culture);
        }

        private void gridHesapOzet_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void BireyselHesapOzet_Load(object sender, EventArgs e)
        {

            int hesapNo = (int)Char.GetNumericValue(hesapForm.HesapNoGetir());
            labelHesapAdi.Text = "Hesap No: " + aktifBireysel.AktifMusteriGetir().Hesaplar[hesapNo - 1].HesapNo.ToString();
            labelBakiye.Text = "Bakiye: " + aktifBireysel.AktifMusteriGetir().Hesaplar[hesapNo - 1].Bakiye.ToString() + " TL";
            
            foreach (DataGridViewColumn column in gridHesapOzet.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            gridHesapOzet.DataSource = null;

            int hesapNo = (int)Char.GetNumericValue(hesapForm.HesapNoGetir());        

            if (InputDogrula())
            {
                try
                {
                    InputuTariheDonustur();
                }
                catch 
                {
                    MessageBox.Show("Tarihleri doğru formatta girdiğinizden emin olun.");
                    return;
                }

                DataTable table = new DataTable();

                table.Columns.Add("İşlem Adı", typeof(string));
                table.Columns.Add("İşlem Tarihi", typeof(DateTime));
                table.Columns.Add("İşlem Tutarı", typeof(string));
                table.Columns.Add("Gönderen", typeof(string));
                table.Columns.Add("Alıcı", typeof(string));

                foreach (var islem in aktifBireysel.AktifMusteriGetir().Hesaplar[hesapNo - 1].IslemGecmisi)
                {
                    if (baslangicTarihi <= islem.IslemTarihi && bitisTarihi >= islem.IslemTarihi)
                    {
                        table.Rows.Add(islem.IslemAdi, islem.IslemTarihi, islem.IslemTutari.ToString() + " TL", islem.Gonderici, islem.Alici);
                        gridHesapOzet.DataSource = table;
                    }
                }

                foreach (DataGridViewColumn column in gridHesapOzet.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
    }
}
