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
    public partial class Sekreterİslemleri : Form
    {
        public Sekreterİslemleri()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SekreterEkle sekreterEkle = new SekreterEkle();
            sekreterEkle.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SekreterDuzelt sekreterDuzelt = new SekreterDuzelt();
            sekreterDuzelt.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SekreterSil sekreterSil = new SekreterSil();
            sekreterSil.ShowDialog();
        }
    }
}
