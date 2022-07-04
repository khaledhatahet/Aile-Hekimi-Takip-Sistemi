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
    public partial class SekreterEkle : Form
    {
        public SekreterEkle()
        {
            InitializeComponent();
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

                string TcNO = tbSekreterTC.Text.Trim();
                string Ad = tbSekreterAd.Text.Trim();
                string Soyad = tbSekreterSoyad.Text.Trim();
                string EMail = tbSekreterEmail.Text.Trim();
                string Sifre = tbSekreterPassword.Text.Trim();
                string Cinsiyet = cbSekreterCinsiyet.SelectedItem.ToString();
                string TelefonNo = SekreterTelefon.Text.Trim();
                string DogumTarihi = dtDogumTarihi.Value.ToString();
                string DogumYeri = tbSekreterDogumYeri.Text.Trim();
                string Adres = tbSekreterAdres.Text.Trim();
                string MesaiSaatleri = tbSekreterMesaiSaat.Text.Trim();

                long i;
                long j;
                if (long.TryParse(tbSekreterTC.Text.Trim(), out i) == true)
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

                if (long.TryParse(SekreterTelefon.Text.Trim(), out j) == true)
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

                if (tbSekreterEmail.Text.Trim().Contains("@sekreter.com"))
                {
                    Sekreter s = new Sekreter();
                s.SekreterTcNo1 = TcNO;
                s.Ad1 = Ad;
                s.Soyad1 = Soyad;
                s.SekreterEmailHesabi1 = EMail;
                s.SekreterPassword1 = Sifre;
                s.Cinsiyet1 = Cinsiyet;
                s.TelefonNo1 = TelefonNo;
                s.DogumTarihi1 = DogumTarihi.Substring(0, DogumTarihi.Length - 9);
                s.DogumYeri1 = DogumYeri;
                s.Adres1 = Adres;
                s.SekreterMesaiSaatleri1 = MesaiSaatleri;

                int sonuc = s.SekreterEkle(s);
                if (sonuc > 0)
                {
                    lbMesaage.Text = "Sekreter Eklendi";
                    lbMesaage.ForeColor = Color.Green;
                }
                }
                else
                {
                    lbMesaage.Text = "Lütfen @sekreter.com uzantılı email yazınız.";
                    EMail = "";

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
            tbSekreterTC.Text = "";
            tbSekreterAd.Text = "";
            tbSekreterSoyad.Text = "";
            tbSekreterEmail.Text = "";
            tbSekreterPassword.Text = "";
            cbSekreterCinsiyet.ResetText();
            SekreterTelefon.Text = "";
            dtDogumTarihi.ResetText();
            tbSekreterDogumYeri.Text = "";
            tbSekreterAdres.Text = "";
            tbSekreterMesaiSaat.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
