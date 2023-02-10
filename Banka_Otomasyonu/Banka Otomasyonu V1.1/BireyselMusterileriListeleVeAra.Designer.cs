namespace Banka_Otomasyonu_V1._1
{
    partial class BireyselMusterileriListeleVeAra
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.MusteriAra = new System.Windows.Forms.Button();
            this.listBireyselM = new System.Windows.Forms.DataGridView();
            this.comboAraTur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.listBireyselM)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(247, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Müşteri No / TC No:";
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNo.Location = new System.Drawing.Point(376, 18);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 22);
            this.txtNo.TabIndex = 2;
            this.txtNo.TextChanged += new System.EventHandler(this.txtNo_TextChanged);
            // 
            // MusteriAra
            // 
            this.MusteriAra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MusteriAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriAra.Location = new System.Drawing.Point(504, 14);
            this.MusteriAra.Name = "MusteriAra";
            this.MusteriAra.Size = new System.Drawing.Size(99, 27);
            this.MusteriAra.TabIndex = 3;
            this.MusteriAra.Text = "Müsteri Ara";
            this.MusteriAra.UseVisualStyleBackColor = false;
            this.MusteriAra.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBireyselM
            // 
            this.listBireyselM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBireyselM.Location = new System.Drawing.Point(3, 53);
            this.listBireyselM.Name = "listBireyselM";
            this.listBireyselM.Size = new System.Drawing.Size(877, 264);
            this.listBireyselM.TabIndex = 16;
            // 
            // comboAraTur
            // 
            this.comboAraTur.FormattingEnabled = true;
            this.comboAraTur.Items.AddRange(new object[] {
            "Musteri No",
            "TC No"});
            this.comboAraTur.Location = new System.Drawing.Point(103, 19);
            this.comboAraTur.Name = "comboAraTur";
            this.comboAraTur.Size = new System.Drawing.Size(121, 21);
            this.comboAraTur.TabIndex = 1;
            this.comboAraTur.SelectedIndexChanged += new System.EventHandler(this.comboAraTur_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Arama Türü:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MusteriAra);
            this.panel1.Controls.Add(this.comboAraTur);
            this.panel1.Controls.Add(this.txtNo);
            this.panel1.Controls.Add(this.listBireyselM);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(43, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 323);
            this.panel1.TabIndex = 19;
            // 
            // BireyselMusterileriListeleVeAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(977, 319);
            this.Controls.Add(this.panel1);
            this.Name = "BireyselMusterileriListeleVeAra";
            this.Text = "Bireysel Musterileri Listele Ve Ara Paneli";
            this.Load += new System.EventHandler(this.BireyselMusterileriListeleVeAra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBireyselM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Button MusteriAra;
        private System.Windows.Forms.DataGridView listBireyselM;
        private System.Windows.Forms.ComboBox comboAraTur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}