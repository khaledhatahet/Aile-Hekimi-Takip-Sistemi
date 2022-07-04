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
    public partial class SekreterEkrani : Form
    {
        public kisi calisan { get; set; }

        public SekreterEkrani(kisi k)
        {
            InitializeComponent();
            calisan = k;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hastaİslemleri hastaİslemleri = new Hastaİslemleri();
            hastaİslemleri.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doktorİslemleri doktorİslemleri = new Doktorİslemleri();
            doktorİslemleri.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Poliklinikİslemleri poliklinikİslemleri = new Poliklinikİslemleri();
            poliklinikİslemleri.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Asiislemleri asiislemleri = new Asiislemleri();
            asiislemleri.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KoronaTestiİslemleri koronaTestiİslemleri = new KoronaTestiİslemleri();
            koronaTestiİslemleri.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Randevuİslemleri randevuİslemleri = new Randevuİslemleri();
            randevuİslemleri.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void Sekreterİslemleri_Click(object sender, EventArgs e)
        {
            Sekreterİslemleri sekreter = new Sekreterİslemleri();
            sekreter.ShowDialog();
        }

        private void SekreterEkrani_Load(object sender, EventArgs e)
        {
            try
            {
                if (calisan != null)
                {
                    lbWelcome.Text = calisan.Ad1 + " " + calisan.Soyad1;

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
