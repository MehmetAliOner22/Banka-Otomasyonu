namespace Banka_Otomasyonu_V1._1
{
    partial class TicariHavaleYap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlici = new System.Windows.Forms.TextBox();
            this.cbGonderenHesap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHavale = new System.Windows.Forms.Button();
            this.txtGonderilecekTutar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAlici);
            this.panel1.Controls.Add(this.cbGonderenHesap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnHavale);
            this.panel1.Controls.Add(this.txtGonderilecekTutar);
            this.panel1.Location = new System.Drawing.Point(46, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 451);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gönderen Hesap";
            // 
            // txtAlici
            // 
            this.txtAlici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlici.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlici.Location = new System.Drawing.Point(253, 184);
            this.txtAlici.Name = "txtAlici";
            this.txtAlici.Size = new System.Drawing.Size(151, 29);
            this.txtAlici.TabIndex = 2;
            // 
            // cbGonderenHesap
            // 
            this.cbGonderenHesap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGonderenHesap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGonderenHesap.FormattingEnabled = true;
            this.cbGonderenHesap.Location = new System.Drawing.Point(253, 117);
            this.cbGonderenHesap.Name = "cbGonderenHesap";
            this.cbGonderenHesap.Size = new System.Drawing.Size(151, 29);
            this.cbGonderenHesap.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Alıcı Hesap No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Gönderilecek  Tutar";
            // 
            // btnHavale
            // 
            this.btnHavale.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHavale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHavale.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHavale.Location = new System.Drawing.Point(320, 312);
            this.btnHavale.Name = "btnHavale";
            this.btnHavale.Size = new System.Drawing.Size(84, 37);
            this.btnHavale.TabIndex = 4;
            this.btnHavale.Text = "Gönder";
            this.btnHavale.UseVisualStyleBackColor = false;
            this.btnHavale.Click += new System.EventHandler(this.btnHavale_Click);
            // 
            // txtGonderilecekTutar
            // 
            this.txtGonderilecekTutar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGonderilecekTutar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGonderilecekTutar.Location = new System.Drawing.Point(253, 252);
            this.txtGonderilecekTutar.Name = "txtGonderilecekTutar";
            this.txtGonderilecekTutar.Size = new System.Drawing.Size(151, 29);
            this.txtGonderilecekTutar.TabIndex = 3;
            // 
            // TicariHavaleYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.panel1);
            this.Name = "TicariHavaleYap";
            this.Text = "Ticari Havale Yap";
            this.Load += new System.EventHandler(this.TicariHavaleYap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlici;
        private System.Windows.Forms.ComboBox cbGonderenHesap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHavale;
        private System.Windows.Forms.TextBox txtGonderilecekTutar;
    }
}