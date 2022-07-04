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
    public partial class TestYaptirma : Form
    {
        public TestYaptirma()
        {
            InitializeComponent();
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string tc = tbTCNo.Text.Trim();
                string tarih = dateTimePicker1.Value.ToString();

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
                if(tc == "")
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Giriniz.");
                }

                Korona_Testi korona = new Korona_Testi();
                korona.HastaTcNo1 = tc;
                korona.TestTarihiVeSaati1 = tarih;

                int sonuc = korona.RandevuOlustur(korona);

                if (sonuc > 0)
                {
                    lbMesaage.Text = "Randevu Oluşturuldu";
                    lbMesaage.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                lbMesaage.Text = ex.Message;
                lbMesaage.ForeColor = Color.Red;

            }
        }
    }
}
