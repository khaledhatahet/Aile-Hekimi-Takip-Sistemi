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
    public partial class BugunHasta : Form
    {
        public Doktor Doktor { get; set; }
        public BugunHasta(Doktor doktor)
        {
            InitializeComponent();
            Doktor = doktor;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu();
            string[] dizi = new string[100];
            dataGridView1.DataSource = randevu.BugunOlanRandevulariBul1(dizi,Doktor.DoktorTcNo1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string tc = tbarama.Text;


                Randevu randevu = new Randevu();
                Hasta hasta = new Hasta();
                long i;
                if (long.TryParse(tc.Trim(), out i) == true)
                {
                    tc = i.ToString();
                }
                else
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Yazınız.");
                }

                if (tc.Length != 11)
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Giriniz.");
                }
                if (tbarama.Text == "")
                {
                    string[] dizi = new string[100];
                    dataGridView1.DataSource = randevu.BugunOlanRandevulariBul1(dizi, Doktor.DoktorTcNo1);

                }
                if (randevu.HastaninDoktorunuBul(tc) == Doktor.DoktorTcNo1)
                {

                    dataGridView1.DataSource = hasta.TCNo_ile_arama(tc);

                }
                else
                {
                    MessageBox.Show("Lütfen Geçerli Tc Numarası Giriniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            
        }
    }
}
