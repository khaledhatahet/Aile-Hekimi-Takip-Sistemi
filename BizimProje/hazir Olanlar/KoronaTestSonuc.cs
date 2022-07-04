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
    public partial class KoronaTestSonuc : Form
    {
        public Doktor doktor { get; set; }
        public KoronaTestSonuc(Doktor d)
        {
            InitializeComponent();
            doktor = d;
        }

        public KoronaTestSonuc()
        {
        }

        private void KoronaTestSonuc_Load(object sender, EventArgs e)
        {

        }

        private void tbTCNo_TextChanged(object sender, EventArgs e)
        {
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
                Korona_Testi korona_Testi = new Korona_Testi();
                Randevu randevu = new Randevu();
                dataGridView1.Columns.Clear();

                long i;
                if (long.TryParse(tbTc.Text.Trim(), out i) == true)
                {
                    tbTc.Text = i.ToString();
                }
                else
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Yazınız.");
                }

                if (tbTc.Text.Length != 11)
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Giriniz.");
                }

                if (randevu.HastaninDoktorunuBul(tbTc.Text.Trim()) == doktor.DoktorTcNo1)
                {

                    dataGridView1.DataSource = korona_Testi.TC_ile_arama(tbTc.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Lütfen Size Ait Bir hastanın Tc Numarasını Giriniz.");
                }
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
                label1.ForeColor = Color.Red;
                
            }
           
            
        }
    }
}
