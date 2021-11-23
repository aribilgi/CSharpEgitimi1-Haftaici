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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Increment : Aşağı yukarı oklar ile sayıların artma ve azalma adımlarını belirler
            if (numericUpDown1.Value >= 1) label1.Font = new Font("Arial", (float)numericUpDown1.Value);
            else MessageBox.Show("Font Boyutu 1 den küçük olamaz!");
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                domainUpDown1.Items.Add(FontFamily.Families[i].Name);
            }
            domainUpDown1.Wrap = true;//liste sonunda başa dön
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            //domainUpDown kontrolü içerisinde string ifadelerden oluşan liste tutar ve oklarla bu değerler arasında dolaşmamızı sağlar
            //try catch bloğu programlamada hata yakalamak için kullanılan yöntemdir
            try//try ile çalıştırılacak kod denenir, çalışırsa bu bloktaki kodlar yürütülür
            {
                textBox1.Font = new Font(domainUpDown1.SelectedItem.ToString(), (float)numericUpDown1.Value);
            }
            catch (Exception)//try kısmındaki kodlarda hata oluşursa catch bloğu devreye girer ve hata oluştuğunda yapılacak işlemlerin kodu buraya yazılır
            {
                domainUpDown1.SelectedIndex++;//try kısmındaki kodlarda hata oluşursa domainUpDown1 elemanının değerini bir sonrakine geçir
            }
        }
    }
}
