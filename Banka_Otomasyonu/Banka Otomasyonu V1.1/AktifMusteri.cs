using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyonu_V1._1
{
    internal abstract class AktifMusteri
    {
        private static string Sifre { get; set; } = "1234";

        public bool SifreKontrol(string sifre)
        {
            if (sifre == Sifre)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Şifre hatalı");
                return false;
            }
        }
    }
}
