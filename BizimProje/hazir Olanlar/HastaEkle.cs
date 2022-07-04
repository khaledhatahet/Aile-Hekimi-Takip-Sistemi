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
    public partial class HastaEkle : Form
    {
        
        public HastaEkle()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tbHastaTC_TextChanged(object sender, EventArgs e)
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

                string TcNO = tbHastaTC.Text.Trim();
                string Ad = tbHastaAd.Text.Trim();
                string Soyad = tbHastaSoyad.Text.Trim();
                string Anne = tbHastaAnne.Text.Trim();
                string Baba = tbHastaBaba.Text.Trim();
                string Cinsiyet = cbHastaCinsiyet.SelectedItem.ToString();
                string TelefonNo = tbHastaTelefon.Text.Trim();
                string DogumTarihi = dtDogumTarihi.Value.ToString();
                string DogumYeri = tbHastaDogumYeri.Text.Trim();
                string Adres = tbHastaAdres.Text.Trim();
                string HesKodu = tbHastaNot.Text.Trim();
                string KanGrubu = cbHastaKan.SelectedItem.ToString();
                string HastaDoktoru = DoktorSec.SelectedValue.ToString();

                long i;
                long j;
                if (long.TryParse(tbHastaTC.Text.Trim(), out i) == true)
                {
                    TcNO = i.ToString();
                }
                else
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Yazınız.");
                }

                if (TcNO.Length != 11)
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Giriniz.");
                }

                if (long.TryParse(tbHastaTelefon.Text.Trim(), out j) == true)
                {
                    TelefonNo = j.ToString();
                }
                else
                {
                    throw new Exception("Lütfen Geçerli Telefon Numarası Yazınız.");
                }

                if (TelefonNo.Length != 10)
                {
                    throw new Exception("Lütfen Geçerli Telefon Numarası Giriniz.");
                }

                Hasta h = new Hasta();
                h.HastaTcNo1 = TcNO; 
                h.Ad1 = Ad;
                h.Soyad1 = Soyad;
                h.AnneAdi1 = Anne;
                h.BabaAdi1 = Baba;
                h.Cinsiyet1 = Cinsiyet;
                h.TelefonNo1 = TelefonNo;
                h.DogumTarihi1 = DogumTarihi.Substring(0,DogumTarihi.Length-9);
                h.DogumYeri1 = DogumYeri;
                h.Adres1 = Adres;
                h.HESKod1 = HesKodu;
                h.KanGrubu1 = KanGrubu;
                h.DoktorTcNo1 = HastaDoktoru;

                HESkodu hESkodu = new HESkodu();
                hESkodu.HESKod1 = h.HESKod1;
                hESkodu.HesKoduEkle(hESkodu);

                int sonuc = h.HastaEkle(h);

                if (sonuc > 0)
                {
                    lbMesaage.Text = "Hasta Eklendi";
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
            tbHastaTC.Text = "";
            tbHastaAd.Text = "";
            tbHastaSoyad.Text = "";
            tbHastaAnne.Text = "";
            tbHastaBaba.Text = "";
            cbHastaCinsiyet.ResetText();
            tbHastaTelefon.Text = "";
            dtDogumTarihi.ResetText();
            tbHastaDogumYeri.Text = "";
            tbHastaAdres.Text= "";
            tbHastaNot.Text = "";
            cbHastaKan.ResetText();
            DoktorSec.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HastaEkle_Load(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor();
            DataTable dt = new DataTable();
            dt = doktor.ButunDoktorlariGoruntule();
            DoktorSec.DisplayMember = "Ad";
            DoktorSec.ValueMember = "DoktorTcNo";
            DoktorSec.DataSource = dt;

           
        }
    }
}
