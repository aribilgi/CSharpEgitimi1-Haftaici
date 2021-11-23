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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            //trackbar kontrolü değer artış ya da azalış işlemleri yaptırmamızı sağlar
            trackBar1.Minimum = 10;//trackbar ın en küçük değeri 10 olsun
            trackBar1.Maximum = 25;//trackbar ın alacağı en büyük değer
            trackBar1.TickFrequency = 2;//trackbar da gösterilecek çizgi sayısı
            textBox1.Text = "trackBar kullanımı";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Tahoma", trackBar1.Value);
        }
    }
}
