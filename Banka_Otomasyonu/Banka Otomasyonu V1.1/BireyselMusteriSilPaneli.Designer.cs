namespace Banka_Otomasyonu_V1._1
{
    partial class BireyselMusteriSilPaneli
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
            this.MusteriSil = new System.Windows.Forms.Button();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.MNo = new System.Windows.Forms.Label();
            this.comboSilTur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MusteriSil
            // 
            this.MusteriSil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MusteriSil.Location = new System.Drawing.Point(522, 67);
            this.MusteriSil.Name = "MusteriSil";
            this.MusteriSil.Size = new System.Drawing.Size(75, 23);
            this.MusteriSil.TabIndex = 3;
            this.MusteriSil.Text = "Müsteriyi sil";
            this.MusteriSil.UseVisualStyleBackColor = false;
            this.MusteriSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNo.Location = new System.Drawing.Point(404, 67);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 22);
            this.txtNo.TabIndex = 2;
            this.txtNo.TextChanged += new System.EventHandler(this.txtNo_TextChanged);
            // 
            // MNo
            // 
            this.MNo.AutoSize = true;
            this.MNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MNo.Location = new System.Drawing.Point(324, 67);
            this.MNo.Name = "MNo";
            this.MNo.Size = new System.Drawing.Size(74, 16);
            this.MNo.TabIndex = 2;
            this.MNo.Text = "Müsteri No:";
            // 
            // comboSilTur
            // 
            this.comboSilTur.FormattingEnabled = true;
            this.comboSilTur.Items.AddRange(new object[] {
            "Musteri No",
            "TC No"});
            this.comboSilTur.Location = new System.Drawing.Point(160, 66);
            this.comboSilTur.Name = "comboSilTur";
            this.comboSilTur.Size = new System.Drawing.Size(121, 21);
            this.comboSilTur.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Müsteri No / TC No:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MusteriSil);
            this.panel1.Controls.Add(this.comboSilTur);
            this.panel1.Controls.Add(this.txtNo);
            this.panel1.Controls.Add(this.MNo);
            this.panel1.Location = new System.Drawing.Point(49, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 154);
            this.panel1.TabIndex = 5;
            // 
            // BireyselMusteriSilPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(726, 149);
            this.Controls.Add(this.panel1);
            this.Name = "BireyselMusteriSilPaneli";
            this.Text = "Bireysel Musteri Sil Paneli";
            this.Load += new System.EventHandler(this.BireyselMusteriSilPaneli_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MusteriSil;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label MNo;
        private System.Windows.Forms.ComboBox comboSilTur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}