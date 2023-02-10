namespace Banka_Otomasyonu_V1._1
{
    partial class BireyselParaCek
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
            this.btnCek = new System.Windows.Forms.Button();
            this.cbKullanilacakHesap = new System.Windows.Forms.ComboBox();
            this.txtCekilecekTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCek);
            this.panel1.Controls.Add(this.cbKullanilacakHesap);
            this.panel1.Controls.Add(this.txtCekilecekTutar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(38, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 444);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanılacak Hesap";
            // 
            // btnCek
            // 
            this.btnCek.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCek.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCek.Location = new System.Drawing.Point(313, 267);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(83, 33);
            this.btnCek.TabIndex = 3;
            this.btnCek.Text = "Para Çek";
            this.btnCek.UseVisualStyleBackColor = false;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // cbKullanilacakHesap
            // 
            this.cbKullanilacakHesap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKullanilacakHesap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKullanilacakHesap.FormattingEnabled = true;
            this.cbKullanilacakHesap.Location = new System.Drawing.Point(245, 134);
            this.cbKullanilacakHesap.Name = "cbKullanilacakHesap";
            this.cbKullanilacakHesap.Size = new System.Drawing.Size(151, 29);
            this.cbKullanilacakHesap.TabIndex = 1;
            // 
            // txtCekilecekTutar
            // 
            this.txtCekilecekTutar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCekilecekTutar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCekilecekTutar.Location = new System.Drawing.Point(245, 207);
            this.txtCekilecekTutar.Name = "txtCekilecekTutar";
            this.txtCekilecekTutar.Size = new System.Drawing.Size(151, 29);
            this.txtCekilecekTutar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Çekilecek Tutar";
            // 
            // BireyselParaCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(520, 445);
            this.Controls.Add(this.panel1);
            this.Name = "BireyselParaCek";
            this.Text = "Bireysel Para Çek";
            this.Load += new System.EventHandler(this.BireyselParaCek_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.ComboBox cbKullanilacakHesap;
        private System.Windows.Forms.TextBox txtCekilecekTutar;
        private System.Windows.Forms.Label label2;
    }
}