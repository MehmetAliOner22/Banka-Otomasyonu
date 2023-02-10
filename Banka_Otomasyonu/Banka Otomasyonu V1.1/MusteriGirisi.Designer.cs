namespace Banka_Otomasyonu_V1._1
{
    partial class MusteriGirisi
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
            this.btnTicari = new System.Windows.Forms.Button();
            this.btnBireysel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnTicari);
            this.panel1.Controls.Add(this.btnBireysel);
            this.panel1.Location = new System.Drawing.Point(42, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 191);
            this.panel1.TabIndex = 0;
            // 
            // btnTicari
            // 
            this.btnTicari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicari.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicari.Location = new System.Drawing.Point(194, 73);
            this.btnTicari.Name = "btnTicari";
            this.btnTicari.Size = new System.Drawing.Size(119, 45);
            this.btnTicari.TabIndex = 3;
            this.btnTicari.Text = "Ticari";
            this.btnTicari.UseVisualStyleBackColor = true;
            this.btnTicari.Click += new System.EventHandler(this.btnTicari_Click);
            // 
            // btnBireysel
            // 
            this.btnBireysel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBireysel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBireysel.Location = new System.Drawing.Point(33, 73);
            this.btnBireysel.Name = "btnBireysel";
            this.btnBireysel.Size = new System.Drawing.Size(119, 45);
            this.btnBireysel.TabIndex = 2;
            this.btnBireysel.Text = "Bireysel";
            this.btnBireysel.UseVisualStyleBackColor = true;
            this.btnBireysel.Click += new System.EventHandler(this.btnBireysel_Click);
            // 
            // MusteriGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(422, 190);
            this.Controls.Add(this.panel1);
            this.Name = "MusteriGirisi";
            this.Text = "Müşteri Girişi";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTicari;
        private System.Windows.Forms.Button btnBireysel;
    }
}