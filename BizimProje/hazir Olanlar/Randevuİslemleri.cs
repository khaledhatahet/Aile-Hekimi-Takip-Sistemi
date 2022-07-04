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
    public partial class Randevuİslemleri : Form
    {
        public Randevuİslemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandevuOlustur randevuOlustur = new RandevuOlustur();
            randevuOlustur.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandeveGuncelleme guncelleme = new RandeveGuncelleme();
            guncelleme.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RandevuSilme silme = new RandevuSilme();
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
