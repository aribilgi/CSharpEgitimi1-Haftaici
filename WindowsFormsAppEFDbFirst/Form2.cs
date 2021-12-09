using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEFDbFirst
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        UrunYonetimiAdoNetEntities urunYonetimi = new UrunYonetimiAdoNetEntities();
        private void Form2_Load(object sender, EventArgs e)
        {
            DgvKategoriler.DataSource = urunYonetimi.Kategorilers.ToList();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            urunYonetimi.Kategorilers.Add(
                new Kategoriler
                {
                    KategoriAdi = TxtKategoriAdi.Text,
                    Durum = Convert.ToBoolean(CbDurum.Checked)
                }
                );
            urunYonetimi.SaveChanges();
            DgvKategoriler.DataSource = urunYonetimi.Kategorilers.ToList();
            MessageBox.Show("Kategori Başarıyla Eklendi");
        }

        private void DgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtKategoriAdi.Text = DgvKategoriler.CurrentRow.Cells[1].Value.ToString();
            CbDurum.Checked = Convert.ToBoolean(DgvKategoriler.CurrentRow.Cells[2].Value);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var kategori = urunYonetimi.Kategorilers.Find(Convert.ToInt32(DgvKategoriler.CurrentRow.Cells[0].Value));
            kategori.KategoriAdi = TxtKategoriAdi.Text;
            kategori.Durum = Convert.ToBoolean(DgvKategoriler.CurrentRow.Cells[2].Value);
            urunYonetimi.SaveChanges();
            DgvKategoriler.DataSource = urunYonetimi.Kategorilers.ToList();
            MessageBox.Show("Kategori Başarıyla Güncellendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var kategori = urunYonetimi.Kategorilers.Find(Convert.ToInt32(DgvKategoriler.CurrentRow.Cells[0].Value)); //Veritabanından silmek istediğimiz ürünü ıd sini yollayarak buluyoruz
                urunYonetimi.Kategorilers.Remove(kategori); //Bulduğumuz ürünü silinmek üzere EF de belirtiyoruz
                urunYonetimi.SaveChanges(); //Ef deki silme işleminin gerçekleşmesini sağlıyoruz
                DgvKategoriler.DataSource = urunYonetimi.Kategorilers.ToList(); //Silme işleminden sonra yeniden ürünleri listeledik
                MessageBox.Show("Kategori Başarıyla Silindi");
            }
        }
    }
}
