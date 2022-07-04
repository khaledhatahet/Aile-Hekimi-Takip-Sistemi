using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BizimProje
{
    public partial class PoliklinikGoruntuleme : Form
    {
        public PoliklinikGoruntuleme()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Poliklinik poliklinik = new Poliklinik();
            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = poliklinik.Ad_ile_arama(tbarama.Text.Trim());
        }
    }
}
