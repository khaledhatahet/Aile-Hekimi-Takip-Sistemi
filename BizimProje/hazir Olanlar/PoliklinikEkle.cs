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
    public partial class PoliklinikEkle : Form
    {
        public PoliklinikEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                lbMesaage.Text = "";
                string PoliklinikNo = tbPoliklinikNO.Text.Trim();
                string kat = tbKat.Text.Trim();
                string PoliklinikAd = tbPoliklinikAdi.Text.Trim();

                Poliklinik p = new Poliklinik();
                p.PoliklinikNO1 = PoliklinikNo;
                p.BulunduguKat1 = kat;
                p.PoliklinikAdi1 = PoliklinikAd;

                int sonuc = p.PoliklinikEkle(p);

                if (sonuc > 0)
                {
                    lbMesaage.Text = "poliklinik Eklendi";
                    lbMesaage.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                lbMesaage.Text = ex.Message;
                lbMesaage.ForeColor = Color.Red;
                
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbPoliklinikNO.Text = "";
            tbKat.Text = "";
            tbPoliklinikAdi.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
