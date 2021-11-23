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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // tabControl1.SelectedTab aktif olan sekme sayfasını belirler
            // tabControl1.SelectedIndex aktif olan sekme sayfasının indisini belirler
            // tabpages sekme sayfalarının eklendiği düzenlendiği ve silindiği penceredir
            tabControl1.SelectedIndex = 2;//form açılırken açık gelecek sekme olarak en sondaki sekmeyi aç
        }
    }
}
