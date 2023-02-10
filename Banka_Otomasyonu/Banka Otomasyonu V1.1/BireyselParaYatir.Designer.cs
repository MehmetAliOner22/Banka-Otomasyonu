namespace Banka_Otomasyonu_V1._1
{
    partial class BireyselParaYatir
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
            this.btnYatir = new System.Windows.Forms.Button();
            this.cbAliciHesap = new System.Windows.Forms.ComboBox();
            this.txtYatıralacakTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnYatir);
            this.panel1.Controls.Add(this.cbAliciHesap);
            this.panel1.Controls.Add(this.txtYatıralacakTutar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(40, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 404);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alıcı Hesap";
            // 
            // btnYatir
            // 
            this.btnYatir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYatir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYatir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYatir.Location = new System.Drawing.Point(302, 259);
            this.btnYatir.Name = "btnYatir";
            this.btnYatir.Size = new System.Drawing.Size(78, 33);
            this.btnYatir.TabIndex = 3;
            this.btnYatir.Text = "Yatır";
            this.btnYatir.UseVisualStyleBackColor = false;
            this.btnYatir.Click += new System.EventHandler(this.btnYatir_Click);
            // 
            // cbAliciHesap
            // 
            this.cbAliciHesap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAliciHesap.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAliciHesap.FormattingEnabled = true;
            this.cbAliciHesap.Location = new System.Drawing.Point(229, 122);
            this.cbAliciHesap.Name = "cbAliciHesap";
            this.cbAliciHesap.Size = new System.Drawing.Size(151, 31);
            this.cbAliciHesap.TabIndex = 1;
            // 
            // txtYatıralacakTutar
            // 
            this.txtYatıralacakTutar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYatıralacakTutar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYatıralacakTutar.Location = new System.Drawing.Point(229, 193);
            this.txtYatıralacakTutar.Name = "txtYatıralacakTutar";
            this.txtYatıralacakTutar.Size = new System.Drawing.Size(151, 30);
            this.txtYatıralacakTutar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yatırılacak Tutar";
            // 
            // BireyselParaYatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(512, 404);
            this.Controls.Add(this.panel1);
            this.Name = "BireyselParaYatir";
            this.Text = "Bireysel Para Yatır";
            this.Load += new System.EventHandler(this.BireyselParaYatir_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYatir;
        private System.Windows.Forms.ComboBox cbAliciHesap;
        private System.Windows.Forms.TextBox txtYatıralacakTutar;
        private System.Windows.Forms.Label label2;
    }
}