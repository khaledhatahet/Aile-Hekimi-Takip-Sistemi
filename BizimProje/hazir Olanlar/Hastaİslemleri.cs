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
    public partial class Hastaİslemleri : Form
    {
        public Hastaİslemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaEkle hastaEkle = new HastaEkle();
            hastaEkle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HastaSil form = new HastaSil();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastaDuzelt hasta = new HastaDuzelt();
            hasta.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }
    }
}
