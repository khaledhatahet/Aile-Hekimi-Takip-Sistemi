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
    public partial class Poliklinikİslemleri : Form
    {
        public Poliklinikİslemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PoliklinikEkle poliklinikEkle = new PoliklinikEkle();
            poliklinikEkle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PoliklinikGuncelleme guncelleme = new PoliklinikGuncelleme();
            guncelleme.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PoliklinikGoruntuleme goruntuleme = new PoliklinikGoruntuleme();
            goruntuleme.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PoliklinikSilme silme = new PoliklinikSilme();
            silme.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }
    }
}
