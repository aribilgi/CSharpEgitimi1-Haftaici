using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text)) MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);//string.IsNullOrEmpty metodu string bir elemanın null veya boş olup olmadığını kontrol eder
            else if (string.IsNullOrWhiteSpace(txtSifre.Text)) MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);//string.IsNullOrWhiteSpace metodu string bir elemanın null veya boş olup olmadığını ve boşluk karakteri girilip girilmediğini kontrol eder
            else //yani kullanıcı adı ve şifre textbox ları boş değilse aşağıdaki kodları çalıştır
            {
                string veritabanindakiKullanici = "Mesut", veritabanindakiSifre = "123456789";
                if (txtKullaniciAdi.Text == veritabanindakiKullanici && txtSifre.Text == veritabanindakiSifre)//eğer textboxlardan girilen kullanıcı adı ve şifre veritabanındakilerle eşleşiyorsa hoş geldin mesajı ver
                {
                    groupBox1.Visible = false;
                    MessageBox.Show("Hoşgeldin " + txtKullaniciAdi.Text + "\n" + "Şifren : " + txtSifre.Text);
                    this.Hide();
                    Form4 form4 = new Form4();
                    form4.ShowDialog();
                }
                else MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);//giriş başarısızsa uyarı penceresini göster
            }
        }
    }
}
