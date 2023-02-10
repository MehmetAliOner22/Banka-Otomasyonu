namespace Banka_Otomasyonu_V1._1
{
    partial class TicariMSilPanel
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSilTur = new System.Windows.Forms.ComboBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.MusteriSil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(261, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Müsteri No / Vergi No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Silme Türü:";
            // 
            // comboSilTur
            // 
            this.comboSilTur.FormattingEnabled = true;
            this.comboSilTur.Items.AddRange(new object[] {
            "Vergi No",
            "Musteri No"});
            this.comboSilTur.Location = new System.Drawing.Point(106, 56);
            this.comboSilTur.Name = "comboSilTur";
            this.comboSilTur.Size = new System.Drawing.Size(121, 21);
            this.comboSilTur.TabIndex = 1;
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNo.Location = new System.Drawing.Point(407, 57);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 22);
            this.txtNo.TabIndex = 2;
            this.txtNo.TextChanged += new System.EventHandler(this.txtNo_TextChanged);
            // 
            // MusteriSil
            // 
            this.MusteriSil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MusteriSil.Location = new System.Drawing.Point(534, 57);
            this.MusteriSil.Name = "MusteriSil";
            this.MusteriSil.Size = new System.Drawing.Size(75, 23);
            this.MusteriSil.TabIndex = 3;
            this.MusteriSil.Text = "Müsteriyi sil";
            this.MusteriSil.UseVisualStyleBackColor = false;
            this.MusteriSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MusteriSil);
            this.panel1.Controls.Add(this.txtNo);
            this.panel1.Controls.Add(this.comboSilTur);
            this.panel1.Location = new System.Drawing.Point(46, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 126);
            this.panel1.TabIndex = 11;
            // 
            // TicariMSilPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(732, 124);
            this.Controls.Add(this.panel1);
            this.Name = "TicariMSilPanel";
            this.Text = "Ticari Musteri Silme Paneli";
            this.Load += new System.EventHandler(this.TicariMSilPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSilTur;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Button MusteriSil;
        private System.Windows.Forms.Panel panel1;
    }
}