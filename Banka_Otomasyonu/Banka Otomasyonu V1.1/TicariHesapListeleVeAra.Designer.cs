namespace Banka_Otomasyonu_V1._1
{
    partial class TicariHesapListeleVeAra
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
            this.listTicariH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.btnHesapAra = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.listTicariH)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listTicariH
            // 
            this.listTicariH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTicariH.Location = new System.Drawing.Point(3, 57);
            this.listTicariH.Name = "listTicariH";
            this.listTicariH.Size = new System.Drawing.Size(785, 286);
            this.listTicariH.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Hesap No:";
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNo.Location = new System.Drawing.Point(114, 16);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 22);
            this.txtNo.TabIndex = 1;
            this.txtNo.TextChanged += new System.EventHandler(this.txtNo_TextChanged);
            // 
            // btnHesapAra
            // 
            this.btnHesapAra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHesapAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapAra.Location = new System.Drawing.Point(234, 12);
            this.btnHesapAra.Name = "btnHesapAra";
            this.btnHesapAra.Size = new System.Drawing.Size(99, 27);
            this.btnHesapAra.TabIndex = 2;
            this.btnHesapAra.Text = "Hesap Ara";
            this.btnHesapAra.UseVisualStyleBackColor = false;
            this.btnHesapAra.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.listTicariH);
            this.panel1.Controls.Add(this.btnHesapAra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNo);
            this.panel1.Location = new System.Drawing.Point(50, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 346);
            this.panel1.TabIndex = 33;
            // 
            // TicariHesapListeleVeAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(893, 347);
            this.Controls.Add(this.panel1);
            this.Name = "TicariHesapListeleVeAra";
            this.Text = "Ticari Hesap Listele Ve Ara Panel";
            this.Load += new System.EventHandler(this.TicariHesapListeleVeAra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listTicariH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listTicariH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Button btnHesapAra;
        private System.Windows.Forms.Panel panel1;
    }
}