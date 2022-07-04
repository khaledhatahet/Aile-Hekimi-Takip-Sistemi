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
    public partial class Doktorİslemleri : Form
    {
        public Doktorİslemleri()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoktorEkle doktorEkle = new DoktorEkle();
            doktorEkle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoktorDuzelt duzelt = new DoktorDuzelt();
            duzelt.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoktorSil doktorSil = new DoktorSil();
            doktorSil.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }
    }
}
