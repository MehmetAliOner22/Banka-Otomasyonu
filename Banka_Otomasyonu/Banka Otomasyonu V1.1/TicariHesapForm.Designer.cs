namespace Banka_Otomasyonu_V1._1
{
    partial class TicariHesapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelToplamBakiye = new System.Windows.Forms.Label();
            this.labelMusteriNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMusteriIsim = new System.Windows.Forms.Label();
            this.gridHesapBilgi = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraYatırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraÇekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.havaleYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesaplarımArasıTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapOzetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticariBilgilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekranıYenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHesapBilgi)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.labelToplamBakiye);
            this.panel1.Controls.Add(this.labelMusteriNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelMusteriIsim);
            this.panel1.Controls.Add(this.gridHesapBilgi);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(49, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 506);
            this.panel1.TabIndex = 3;
            // 
            // labelToplamBakiye
            // 
            this.labelToplamBakiye.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToplamBakiye.Location = new System.Drawing.Point(359, 120);
            this.labelToplamBakiye.Name = "labelToplamBakiye";
            this.labelToplamBakiye.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelToplamBakiye.Size = new System.Drawing.Size(240, 25);
            this.labelToplamBakiye.TabIndex = 6;
            this.labelToplamBakiye.Text = "label1";
            this.labelToplamBakiye.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMusteriNo
            // 
            this.labelMusteriNo.AutoSize = true;
            this.labelMusteriNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMusteriNo.Location = new System.Drawing.Point(123, 121);
            this.labelMusteriNo.Name = "labelMusteriNo";
            this.labelMusteriNo.Size = new System.Drawing.Size(54, 21);
            this.labelMusteriNo.TabIndex = 5;
            this.labelMusteriNo.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Müşteri No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 69);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bakiye";
            // 
            // labelMusteriIsim
            // 
            this.labelMusteriIsim.AutoSize = true;
            this.labelMusteriIsim.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMusteriIsim.Location = new System.Drawing.Point(28, 69);
            this.labelMusteriIsim.Name = "labelMusteriIsim";
            this.labelMusteriIsim.Size = new System.Drawing.Size(61, 25);
            this.labelMusteriIsim.TabIndex = 1;
            this.labelMusteriIsim.Text = "label1";
            // 
            // gridHesapBilgi
            // 
            this.gridHesapBilgi.AllowUserToAddRows = false;
            this.gridHesapBilgi.AllowUserToDeleteRows = false;
            this.gridHesapBilgi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridHesapBilgi.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridHesapBilgi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridHesapBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridHesapBilgi.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridHesapBilgi.Location = new System.Drawing.Point(22, 177);
            this.gridHesapBilgi.Name = "gridHesapBilgi";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridHesapBilgi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridHesapBilgi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridHesapBilgi.Size = new System.Drawing.Size(577, 298);
            this.gridHesapBilgi.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraYatırToolStripMenuItem,
            this.paraÇekToolStripMenuItem,
            this.havaleYapToolStripMenuItem,
            this.hesaplarımArasıTransferToolStripMenuItem,
            this.hesapOzetiToolStripMenuItem,
            this.ticariBilgilerToolStripMenuItem,
            this.ekranıYenileToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            this.işlemlerToolStripMenuItem.Click += new System.EventHandler(this.işlemlerToolStripMenuItem_Click);
            // 
            // paraYatırToolStripMenuItem
            // 
            this.paraYatırToolStripMenuItem.Name = "paraYatırToolStripMenuItem";
            this.paraYatırToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.paraYatırToolStripMenuItem.Text = "Para Yatır";
            this.paraYatırToolStripMenuItem.Click += new System.EventHandler(this.paraYatırToolStripMenuItem_Click);
            // 
            // paraÇekToolStripMenuItem
            // 
            this.paraÇekToolStripMenuItem.Name = "paraÇekToolStripMenuItem";
            this.paraÇekToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.paraÇekToolStripMenuItem.Text = "Para Çek";
            this.paraÇekToolStripMenuItem.Click += new System.EventHandler(this.paraÇekToolStripMenuItem_Click);
            // 
            // havaleYapToolStripMenuItem
            // 
            this.havaleYapToolStripMenuItem.Name = "havaleYapToolStripMenuItem";
            this.havaleYapToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.havaleYapToolStripMenuItem.Text = "Havale Yap";
            this.havaleYapToolStripMenuItem.Click += new System.EventHandler(this.havaleYapToolStripMenuItem_Click);
            // 
            // hesaplarımArasıTransferToolStripMenuItem
            // 
            this.hesaplarımArasıTransferToolStripMenuItem.Name = "hesaplarımArasıTransferToolStripMenuItem";
            this.hesaplarımArasıTransferToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.hesaplarımArasıTransferToolStripMenuItem.Text = "Hesaplar Arası Transfer";
            this.hesaplarımArasıTransferToolStripMenuItem.Click += new System.EventHandler(this.hesaplarımArasıTransferToolStripMenuItem_Click);
            // 
            // hesapOzetiToolStripMenuItem
            // 
            this.hesapOzetiToolStripMenuItem.Name = "hesapOzetiToolStripMenuItem";
            this.hesapOzetiToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.hesapOzetiToolStripMenuItem.Text = "Hesap Özeti";
            this.hesapOzetiToolStripMenuItem.Click += new System.EventHandler(this.hesapOzetiToolStripMenuItem_Click_1);
            this.hesapOzetiToolStripMenuItem.MouseHover += new System.EventHandler(this.hesapOzetiToolStripMenuItem_Click_1);
            // 
            // ticariBilgilerToolStripMenuItem
            // 
            this.ticariBilgilerToolStripMenuItem.Name = "ticariBilgilerToolStripMenuItem";
            this.ticariBilgilerToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ticariBilgilerToolStripMenuItem.Text = "Bilgiler";
            this.ticariBilgilerToolStripMenuItem.Click += new System.EventHandler(this.kişiselBilgilerToolStripMenuItem_Click);
            // 
            // ekranıYenileToolStripMenuItem
            // 
            this.ekranıYenileToolStripMenuItem.Name = "ekranıYenileToolStripMenuItem";
            this.ekranıYenileToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ekranıYenileToolStripMenuItem.Text = "Ekranı Yenile";
            this.ekranıYenileToolStripMenuItem.Click += new System.EventHandler(this.ekranıYenileToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // TicariHesapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 506);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "TicariHesapForm";
            this.Text = "Ticari Hesap Form";
            this.Load += new System.EventHandler(this.TicariHesapForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHesapBilgi)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelToplamBakiye;
        private System.Windows.Forms.Label labelMusteriNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMusteriIsim;
        private System.Windows.Forms.DataGridView gridHesapBilgi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraYatırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraÇekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem havaleYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapOzetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticariBilgilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekranıYenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesaplarımArasıTransferToolStripMenuItem;
    }
}