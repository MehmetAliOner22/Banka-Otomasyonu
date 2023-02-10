﻿using System;
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
    public partial class TicariHesapSil : Form
    {
        public TicariHesapSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banka banka = new Banka();
            banka.HesapNoTHesapSil(long.Parse(txtNo.Text));
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

        private void TicariHesapSil_Load(object sender, EventArgs e)
        {
            btnHesapSil.Enabled = !string.IsNullOrEmpty(txtNo.Text);
        }
    }
}
