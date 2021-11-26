using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            DGVUrunListesi.DataSource = productDal.GetAllDataTable(); //GetAll();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            productDal.Add(
                new Product
                {
                    UrunAdi = TxtUrunAdi.Text,
                    StokMiktari = Convert.ToInt32(TxtStokMiktari.Text),
                    UrunFiyati = Convert.ToDecimal(TxtUrunFiyati.Text)
                }
                );
            DGVUrunListesi.DataSource = productDal.GetAll();
            MessageBox.Show("Ürün Başarıyla Eklendi");
        }

        private void DGVUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtUrunAdi.Text = DGVUrunListesi.CurrentRow.Cells[1].Value.ToString();
            TxtUrunFiyati.Text = DGVUrunListesi.CurrentRow.Cells[2].Value.ToString();
            TxtStokMiktari.Text = DGVUrunListesi.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            productDal.Update(
                new Product
                {
                    Id = Convert.ToInt32(DGVUrunListesi.CurrentRow.Cells[0].Value),
                    UrunAdi = TxtUrunAdi.Text,
                    StokMiktari = Convert.ToInt32(TxtStokMiktari.Text),
                    UrunFiyati = Convert.ToDecimal(TxtUrunFiyati.Text)
                }
                );
            DGVUrunListesi.DataSource = productDal.GetAll();
            MessageBox.Show("Ürün Başarıyla Güncellendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                productDal.Delete(Convert.ToInt32(DGVUrunListesi.CurrentRow.Cells[0].Value));
                DGVUrunListesi.DataSource = productDal.GetAll();
                MessageBox.Show("Ürün Başarıyla Silindi");
            }
        }
    }
}
