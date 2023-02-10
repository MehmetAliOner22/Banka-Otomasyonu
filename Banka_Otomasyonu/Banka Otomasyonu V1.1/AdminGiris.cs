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
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
              if((Convert.ToInt32(txtID.Text) == 1234) && (Convert.ToInt32(txtSifre.Text) == 1234))
              { 
                  AdminPaneli AP = new AdminPaneli();
                  AP.Show();
              }
              else
              {
                  lblText.Text = "Yanlış ID veya Şifre";
              }
            }
            catch
            {
                lblText.Text = "Boş alanlar var";
            }
        }
    }
}
