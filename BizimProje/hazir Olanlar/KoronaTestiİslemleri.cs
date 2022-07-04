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
    public partial class KoronaTestiİslemleri : Form
    {
        public KoronaTestiİslemleri()
        {
            InitializeComponent();
        }

        private void KoronaTestiİslemleri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KoronaDuzelt koronaDuzelt = new KoronaDuzelt();
            koronaDuzelt.ShowDialog();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    KoronaTestSonuc koronaTestSonuc = new KoronaTestSonuc();
        //    koronaTestSonuc.ShowDialog();
        //}

        private void button7_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestYaptirma testYaptirma = new TestYaptirma();
            testYaptirma.ShowDialog();
        }
    }
}
