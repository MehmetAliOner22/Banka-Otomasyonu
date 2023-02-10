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
    public partial class TicariMusteriListele : Form
    {
        public TicariMusteriListele()
        {
            InitializeComponent();

            comboAraTur.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void TicariMusteriListele_Load(object sender, EventArgs e)
        {
            MusteriAra.Enabled = !string.IsNullOrEmpty(txtNo.Text);

            Banka banka = new Banka();
             banka.TicariMListele(listTicariM);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Banka banka = new Banka();
                if (comboAraTur.Text == "Vergi No")
                {
                    banka.VergiNoTicariMAra(Convert.ToInt64(txtNo.Text), listTicariM);
                }
                else if (comboAraTur.Text == "Musteri No")
                {
                    banka.MusteriNoTicariMAra(Convert.ToInt64(txtNo.Text), listTicariM);
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
