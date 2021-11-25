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
    }
}
