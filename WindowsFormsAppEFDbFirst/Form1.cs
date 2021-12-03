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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UrunYonetimiAdoNetEntities urunYonetimi = new UrunYonetimiAdoNetEntities();//Entity Framework ile Crud işlemlerini yapabileceğimiz EF nesnemizi oluşturduk. Bu nesne üzerinde ilgili veritabanı tablolarımızın örneği bulunur ve bu tablolar üzerinden işlemler gerçekleşir.
        private void Form1_Load(object sender, EventArgs e)
        {
            //EF ile Db First olarak proje oluşturma
            /* Öncelikle Db Firs kullanmak için bir veritabanımızın olması gerekir!
             * Solutiona WindowsFormsAppEFDbFirst projesini add new project den ekledik
             * WindowsFormsAppEFDbFirst projemize sağ tıklayıp managa nuget packages menüsüne tıklayıp ilk sekmeden entity yazarak entity framework 6.4.4 sürümünü projeye yükledik (Dikkat!! Entity framework core bu projeye yüklenmez .net core o !)
             * WindowsFormsAppEFDbFirst projemize sağ tıklayıp add new item menüsünden data sekmesindeki Ado.Net Entity data model seçeneğini seçip Modelimize bir isim verip ilerledik.
             * Sonraki sekmede DbFirst seçeneğini seçtik ve ileri dedik
             * Sonraki sekmede hangi veritabanına bağlanacağımızı ayarladığımız sql server bağlantı ekranında mssql local db olan adresi girip refresh diyerek bu serverdaki ilgili veritabanımızı seçip kaydet diyerek pencereyi kapattık.
             * Önümüze açılan yeni pencerede Veritabanı tablolarımız geldi ve bu ekrandayken ctrl + s ile kaydederek modelimizi oluşturduk.
             */
            DGVUrunListesi.DataSource = urunYonetimi.Products.ToList();
        }

        private void DGVUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtUrunAdi.Text = DGVUrunListesi.CurrentRow.Cells[1].Value.ToString();
            TxtUrunFiyati.Text = DGVUrunListesi.CurrentRow.Cells[2].Value.ToString();
            TxtStokMiktari.Text = DGVUrunListesi.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            urunYonetimi.Products.Add(
                new Product
                {
                    UrunAdi = TxtUrunAdi.Text,
                    StokMiktari = Convert.ToInt32(TxtStokMiktari.Text),
                    UrunFiyati = Convert.ToDecimal(TxtUrunFiyati.Text)
                }
                );
            var islemSonucu = urunYonetimi.SaveChanges();//SaveChanges metodu yukardaki products tablosu üzerine eklenen ürünün veritabanına kaydedilmesini sağlar ve int türünde etkilenen kayıt sayısını döndürür

            if (islemSonucu > 0)
            {
                DGVUrunListesi.DataSource = urunYonetimi.Products.ToList();
                MessageBox.Show("Ürün Başarıyla Eklendi");
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var urun = urunYonetimi.Products.Find(Convert.ToInt32(DGVUrunListesi.CurrentRow.Cells[0].Value));
            urun.StokMiktari = Convert.ToInt32(TxtStokMiktari.Text);
            urun.UrunAdi = TxtUrunAdi.Text;
            urun.UrunFiyati = Convert.ToDecimal(TxtUrunFiyati.Text);

            var islemSonucu = urunYonetimi.SaveChanges();//SaveChanges metodu yukardaki products tablosu üzerine eklenen ürünün veritabanına kaydedilmesini sağlar ve int türünde etkilenen kayıt sayısını döndürür

            if (islemSonucu > 0)
            {
                DGVUrunListesi.DataSource = urunYonetimi.Products.ToList();
                MessageBox.Show("Ürün Başarıyla Güncellendi");
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var urun = urunYonetimi.Products.Find(Convert.ToInt32(DGVUrunListesi.CurrentRow.Cells[0].Value)); //Veritabanından silmek istediğimiz ürünü ıd sini yollayarak buluyoruz
                urunYonetimi.Products.Remove(urun); //Bulduğumuz ürünü silinmek üzere EF de belirtiyoruz
                urunYonetimi.SaveChanges(); //Ef deki silme işleminin gerçekleşmesini sağlıyoruz
                DGVUrunListesi.DataSource = urunYonetimi.Products.ToList(); //Silme işleminden sonra yeniden ürünleri listeledik
                MessageBox.Show("Ürün Başarıyla Silindi");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            //DGVUrunListesi.DataSource = urunYonetimi.Products.Where(u => u.UrunAdi == txtAra.Text).ToList(); //u => u. ifadesine lambda expression denir
            DGVUrunListesi.DataSource = urunYonetimi.Products.Where(u => u.UrunAdi.Contains(txtAra.Text)).ToList(); // Ef deki Contains metodu ile txtara textbox ından girilen değeri içeren tüm ürünleri listeledik
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DGVUrunListesi.DataSource = urunYonetimi.Products.Where(u => u.UrunAdi.Contains(txtAra.Text)).ToList();
        }
    }
}
