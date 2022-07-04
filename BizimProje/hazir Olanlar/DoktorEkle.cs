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
    public partial class DoktorEkle : Form
    {
        public DoktorEkle()
        {
            InitializeComponent();
        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {
            Poliklinik poliklinik = new Poliklinik();

            DataTable dt = new DataTable();
            dt = poliklinik.ButunPoliklinikleriGoruntule();
            PoliklinikSec.DisplayMember = "PoliklinikNO";
            PoliklinikSec.ValueMember = "PoliklinikNO";
            PoliklinikSec.DataSource = dt;
        }

        private void tbDoktorTC_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btLogut_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void btDoktorEkle_Click(object sender, EventArgs e)
        {
            try
            {
                lbMesaage.Text = "";

                string TcNO = tbDoktorTC.Text.Trim();
                string Ad = tbDoktorAd.Text.Trim();
                string Soyad = tbDoktorSoyad.Text.Trim();
                string EMail = tbDoktorEmail.Text.Trim();
                string Sifre = tbDoktorPassword.Text.Trim();
                string Cinsiyet = cbDoktorCinsiyet.SelectedItem.ToString();
                string TelefonNo = tbDoktorTelefon.Text.Trim();
                string DogumTarihi = dtDogumTarihi.Value.ToString();
                string DogumYeri = tbDoktorDogumYeri.Text.Trim();
                string Adres = tbDoktorAdres.Text.Trim();
                string MesaiSaatleri = tbDoktorMesaiSaat.Text.Trim();
                string PoliklinikNo = PoliklinikSec.SelectedValue.ToString();
                Poliklinik poliklinik = new Poliklinik();
                string[] dizi = new string[100];
                dizi = poliklinik.PoliklinikDoluKontrol(PoliklinikNo);
                for (int p = 0; p < dizi.Length; p++) {
                    if (dizi[p] == PoliklinikNo)
                    {
                        throw new Exception("Bu Poliklinik Dolu");
                    }
                }
                long i;
                long j;
                if (long.TryParse(tbDoktorTC.Text.Trim(), out i) == true)
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

                if (long.TryParse(tbDoktorTelefon.Text.Trim(), out j) == true)
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

                if (tbDoktorEmail.Text.Trim().Contains("@doktor.com"))
                {

                    Doktor d = new Doktor();
                    d.DoktorTcNo1 = TcNO;
                    d.Ad1 = Ad;
                    d.Soyad1 = Soyad;
                    d.EmailHesabi1 = EMail;
                    d.Password1 = Sifre;
                    d.Cinsiyet1 = Cinsiyet;
                    d.TelefonNo1 = TelefonNo;
                    d.DogumTarihi1 = DogumTarihi.Substring(0, DogumTarihi.Length - 9);
                    d.DogumYeri1 = DogumYeri;
                    d.Adres1 = Adres;
                    d.MesaiSaatleri1 = MesaiSaatleri;
                    d.PoliklinikNO1 = PoliklinikNo;

                    int sonuc = d.DoktorEkle(d);
                    if (sonuc > 0)
                    {
                        lbMesaage.Text = "Doktor Eklendi";
                        lbMesaage.ForeColor = Color.Green;
                    }

                }
                else
                {
                    lbMesaage.Text = "Lütfen @doktor.com uzantılı email yazınız.";
                    EMail = "";

                }
            }
            catch (Exception ex)
            {
                lbMesaage.Text = ex.Message;
                lbMesaage.ForeColor = Color.Red;
                
            }
           

        }

        private void btDoktorTemizle_Click(object sender, EventArgs e)
        {
            tbDoktorTC.Text = "";
            tbDoktorAd.Text = "";
            tbDoktorSoyad.Text = "";
            tbDoktorEmail.Text = "";
            tbDoktorPassword.Text = "";
            cbDoktorCinsiyet.ResetText();
            tbDoktorTelefon.ResetText();
            dtDogumTarihi.Text = "";
            tbDoktorDogumYeri.Text = "";
            tbDoktorAdres.Text = "";
            tbDoktorMesaiSaat.Text = "";
            PoliklinikSec.ResetText();
        }

        private void btDoktorİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
