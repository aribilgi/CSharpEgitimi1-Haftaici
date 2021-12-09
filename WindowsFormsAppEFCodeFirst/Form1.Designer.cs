
namespace WindowsFormsAppEFCodeFirst
{
    partial class Form1
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
            this.DGVUrunListesi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TxtStokMiktari = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUrunFiyati = new System.Windows.Forms.TextBox();
            this.TxtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUrunListesi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVUrunListesi
            // 
            this.DGVUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUrunListesi.Location = new System.Drawing.Point(12, 12);
            this.DGVUrunListesi.Name = "DGVUrunListesi";
            this.DGVUrunListesi.RowHeadersWidth = 51;
            this.DGVUrunListesi.RowTemplate.Height = 24;
            this.DGVUrunListesi.Size = new System.Drawing.Size(776, 207);
            this.DGVUrunListesi.TabIndex = 2;
            this.DGVUrunListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUrunListesi_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.TxtStokMiktari);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtUrunFiyati);
            this.groupBox1.Controls.Add(this.TxtUrunAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 213);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Kayıt Sistemi";
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(213, 174);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 23);
            this.BtnSil.TabIndex = 8;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(111, 174);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(96, 23);
            this.BtnGuncelle.TabIndex = 7;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(30, 174);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 23);
            this.BtnKaydet.TabIndex = 6;
            this.BtnKaydet.Text = "Ekle";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtStokMiktari
            // 
            this.TxtStokMiktari.Location = new System.Drawing.Point(131, 135);
            this.TxtStokMiktari.Name = "TxtStokMiktari";
            this.TxtStokMiktari.Size = new System.Drawing.Size(100, 22);
            this.TxtStokMiktari.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stok Miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Fiyatı";
            // 
            // TxtUrunFiyati
            // 
            this.TxtUrunFiyati.Location = new System.Drawing.Point(131, 91);
            this.TxtUrunFiyati.Name = "TxtUrunFiyati";
            this.TxtUrunFiyati.Size = new System.Drawing.Size(100, 22);
            this.TxtUrunFiyati.TabIndex = 2;
            // 
            // TxtUrunAdi
            // 
            this.TxtUrunAdi.Location = new System.Drawing.Point(131, 45);
            this.TxtUrunAdi.Name = "TxtUrunAdi";
            this.TxtUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.TxtUrunAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(525, 237);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(419, 237);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 22);
            this.txtAra.TabIndex = 5;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVUrunListesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUrunListesi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVUrunListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtStokMiktari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUrunFiyati;
        private System.Windows.Forms.TextBox TxtUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
    }
}

