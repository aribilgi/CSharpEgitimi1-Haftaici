using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppEFCodeFirst.Entities;

namespace WindowsFormsAppEFCodeFirst
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        UrunDbContext context = new UrunDbContext();
        private void Form2_Load(object sender, EventArgs e)
        {
            DgvKategoriler.DataSource = context.Kategoriler.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            context.Kategoriler.Add(new Kategori { Durum = CbDurum.Checked, KategoriAdi = TxtKategoriAdi.Text });
            context.SaveChanges();
            DgvKategoriler.DataSource = context.Kategoriler.ToList();
            MessageBox.Show("Kategori Eklendi!");
        }

        private void DgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtKategoriAdi.Text = DgvKategoriler.CurrentRow.Cells[1].Value.ToString();
            CbDurum.Checked = Convert.ToBoolean(DgvKategoriler.CurrentRow.Cells[2].Value);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var kategori = context.Kategoriler.Find(Convert.ToInt32(DgvKategoriler.CurrentRow.Cells[0].Value));
            kategori.KategoriAdi = TxtKategoriAdi.Text;
            kategori.Durum = Convert.ToBoolean(CbDurum.Checked);
            context.SaveChanges();
            DgvKategoriler.DataSource = context.Kategoriler.ToList();
            MessageBox.Show("Kategori Başarıyla Güncellendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var kategori = context.Kategoriler.Find(Convert.ToInt32(DgvKategoriler.CurrentRow.Cells[0].Value));
                context.Kategoriler.Remove(kategori);
                context.SaveChanges();
                DgvKategoriler.DataSource = context.Kategoriler.ToList();
                MessageBox.Show("Kategori Başarıyla Silindi");
            }
        }
    }
}
