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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("İki tarih arasında " + (dateTimePicker2.Value - dateTimePicker1.Value).Days.ToString() + " gün"); //ekrandaki textBox a 2 dateTimePicker arasındaki gün farkını yazdır
        }
    }
}
