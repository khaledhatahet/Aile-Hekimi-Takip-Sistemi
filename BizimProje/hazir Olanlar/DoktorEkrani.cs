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
    public partial class DoktorEkrani : Form
    {
        public Doktor calisan { get; set; }
        public DoktorEkrani(Doktor k)
        {
            InitializeComponent();
            calisan = k;
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            BugunHasta bugunHasta = new BugunHasta(calisan);
            bugunHasta.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButunHastalar butunHastalar = new ButunHastalar(calisan);
            butunHastalar.ShowDialog();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            KoronaTestSonuc koronaTestSonuc = new KoronaTestSonuc(calisan);
            koronaTestSonuc.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RaporOlusturma raporOlusturma = new RaporOlusturma(calisan);
            raporOlusturma.ShowDialog();
        }

        private void DoktorEkrani_Load(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }
    }
}
