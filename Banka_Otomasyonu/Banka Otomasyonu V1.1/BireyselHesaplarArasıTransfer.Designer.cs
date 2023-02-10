namespace Banka_Otomasyonu_V1._1
{
    partial class BireyselHesaplarArasıTransfer
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
            this.btnTransfer = new System.Windows.Forms.Button();
            this.cbGonderenHesap = new System.Windows.Forms.ComboBox();
            this.txtTransferTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAliciHesap = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbAliciHesap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTransfer);
            this.panel1.Controls.Add(this.cbGonderenHesap);
            this.panel1.Controls.Add(this.txtTransferTutar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(38, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 449);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gönderen Hesap";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(314, 295);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(85, 41);
            this.btnTransfer.TabIndex = 15;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // cbGonderenHesap
            // 
            this.cbGonderenHesap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGonderenHesap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGonderenHesap.FormattingEnabled = true;
            this.cbGonderenHesap.Location = new System.Drawing.Point(248, 118);
            this.cbGonderenHesap.Name = "cbGonderenHesap";
            this.cbGonderenHesap.Size = new System.Drawing.Size(151, 29);
            this.cbGonderenHesap.TabIndex = 13;
            // 
            // txtTransferTutar
            // 
            this.txtTransferTutar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransferTutar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferTutar.Location = new System.Drawing.Point(248, 235);
            this.txtTransferTutar.Name = "txtTransferTutar";
            this.txtTransferTutar.Size = new System.Drawing.Size(151, 29);
            this.txtTransferTutar.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Transfer Edilecek Tutar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Alıcı Hesap";
            // 
            // cbAliciHesap
            // 
            this.cbAliciHesap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAliciHesap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAliciHesap.FormattingEnabled = true;
            this.cbAliciHesap.Location = new System.Drawing.Point(248, 174);
            this.cbAliciHesap.Name = "cbAliciHesap";
            this.cbAliciHesap.Size = new System.Drawing.Size(151, 29);
            this.cbAliciHesap.TabIndex = 18;
            // 
            // BireyselHesaplarArasıTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.panel1);
            this.Name = "BireyselHesaplarArasıTransfer";
            this.Text = "Hesaplarım Arası Transfer";
            this.Load += new System.EventHandler(this.BireyselHesaplarArasıTransfer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.ComboBox cbGonderenHesap;
        private System.Windows.Forms.TextBox txtTransferTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAliciHesap;
    }
}