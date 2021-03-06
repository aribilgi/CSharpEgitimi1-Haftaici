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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        KategoriDal kategoriDal = new KategoriDal();
        private void Form2_Load(object sender, EventArgs e)
        {
            DgvKategoriler.DataSource = kategoriDal.GetAllDataTable();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            kategoriDal.Add(
                new Kategori
                {
                    KategoriAdi = TxtKategoriAdi.Text,
                    Durum = Convert.ToBoolean(CbDurum.Checked)
                }
                );
            DgvKategoriler.DataSource = kategoriDal.GetAllDataTable();
            MessageBox.Show("Kategori Başarıyla Eklendi");
        }

        private void DgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtKategoriAdi.Text = DgvKategoriler.CurrentRow.Cells[1].Value.ToString();
            CbDurum.Checked = Convert.ToBoolean(DgvKategoriler.CurrentRow.Cells[2].Value);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            kategoriDal.Update(
                new Kategori
                {
                    Id = Convert.ToInt32(DgvKategoriler.CurrentRow.Cells[0].Value),
                    KategoriAdi = TxtKategoriAdi.Text,
                    Durum = CbDurum.Checked
                }
                );
            DgvKategoriler.DataSource = kategoriDal.GetAllDataTable();
            MessageBox.Show("Kategori Başarıyla Güncellendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                kategoriDal.Delete(Convert.ToInt32(DgvKategoriler.CurrentRow.Cells[0].Value));
                DgvKategoriler.DataSource = kategoriDal.GetAllDataTable();
                MessageBox.Show("Kategori Başarıyla Silindi");
            }
        }
    }
}
