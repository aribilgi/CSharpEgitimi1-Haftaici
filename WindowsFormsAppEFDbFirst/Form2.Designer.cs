
namespace WindowsFormsAppEFDbFirst
{
    partial class Form2
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
            this.DgvKategoriler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.CbDurum = new System.Windows.Forms.CheckBox();
            this.TxtKategoriAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKategoriler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvKategoriler
            // 
            this.DgvKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvKategoriler.Location = new System.Drawing.Point(12, 12);
            this.DgvKategoriler.Name = "DgvKategoriler";
            this.DgvKategoriler.RowHeadersWidth = 51;
            this.DgvKategoriler.RowTemplate.Height = 24;
            this.DgvKategoriler.Size = new System.Drawing.Size(776, 224);
            this.DgvKategoriler.TabIndex = 1;
            this.DgvKategoriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvKategoriler_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.CbDurum);
            this.groupBox1.Controls.Add(this.TxtKategoriAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Bilgileri";
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(197, 144);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 23);
            this.BtnSil.TabIndex = 5;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(106, 144);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(85, 23);
            this.BtnGuncelle.TabIndex = 4;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(25, 144);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 23);
            this.BtnKaydet.TabIndex = 3;
            this.BtnKaydet.Text = "Ekle";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // CbDurum
            // 
            this.CbDurum.AutoSize = true;
            this.CbDurum.Location = new System.Drawing.Point(154, 98);
            this.CbDurum.Name = "CbDurum";
            this.CbDurum.Size = new System.Drawing.Size(72, 21);
            this.CbDurum.TabIndex = 2;
            this.CbDurum.Text = "Durum";
            this.CbDurum.UseVisualStyleBackColor = true;
            // 
            // TxtKategoriAdi
            // 
            this.TxtKategoriAdi.Location = new System.Drawing.Point(154, 46);
            this.TxtKategoriAdi.Name = "TxtKategoriAdi";
            this.TxtKategoriAdi.Size = new System.Drawing.Size(100, 22);
            this.TxtKategoriAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvKategoriler);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvKategoriler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvKategoriler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.CheckBox CbDurum;
        private System.Windows.Forms.TextBox TxtKategoriAdi;
        private System.Windows.Forms.Label label1;
    }
}