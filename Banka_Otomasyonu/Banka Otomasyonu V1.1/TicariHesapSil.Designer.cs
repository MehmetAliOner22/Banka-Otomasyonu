namespace Banka_Otomasyonu_V1._1
{
    partial class TicariHesapSil
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
            this.MNo = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.btnHesapSil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MNo
            // 
            this.MNo.AutoSize = true;
            this.MNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MNo.Location = new System.Drawing.Point(32, 60);
            this.MNo.Name = "MNo";
            this.MNo.Size = new System.Drawing.Size(69, 16);
            this.MNo.TabIndex = 5;
            this.MNo.Text = "Hesap No";
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNo.Location = new System.Drawing.Point(107, 57);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 22);
            this.txtNo.TabIndex = 1;
            this.txtNo.TextChanged += new System.EventHandler(this.txtNo_TextChanged);
            // 
            // btnHesapSil
            // 
            this.btnHesapSil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHesapSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapSil.Location = new System.Drawing.Point(225, 53);
            this.btnHesapSil.Name = "btnHesapSil";
            this.btnHesapSil.Size = new System.Drawing.Size(88, 29);
            this.btnHesapSil.TabIndex = 2;
            this.btnHesapSil.Text = "Hesap Sil";
            this.btnHesapSil.UseVisualStyleBackColor = false;
            this.btnHesapSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.MNo);
            this.panel1.Controls.Add(this.btnHesapSil);
            this.panel1.Controls.Add(this.txtNo);
            this.panel1.Location = new System.Drawing.Point(46, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 138);
            this.panel1.TabIndex = 6;
            // 
            // TicariHesapSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(447, 133);
            this.Controls.Add(this.panel1);
            this.Name = "TicariHesapSil";
            this.Text = "Hesap Sil Panel";
            this.Load += new System.EventHandler(this.TicariHesapSil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MNo;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Button btnHesapSil;
        private System.Windows.Forms.Panel panel1;
    }
}