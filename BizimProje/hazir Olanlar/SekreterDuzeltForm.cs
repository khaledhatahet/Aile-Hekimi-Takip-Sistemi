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
    public partial class SekreterDuzeltForm : Form
    {
        public Sekreter sekreter { get; set; }
        public SekreterDuzeltForm()
        {
            InitializeComponent();
        }
        private void SekreterDuzeltForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (sekreter == null)
                {
                    throw new Exception("sekreter Boş");
                }
                tbSekreterTC.Text = sekreter.SekreterTcNo1;
                tbSekreterAd.Text = sekreter.Ad1;
                tbSekreterSoyad.Text = sekreter.Soyad1;
                tbSekreterEmail.Text = sekreter.SekreterEmailHesabi1;
                tbSekreterPassword.Text = sekreter.SekreterPassword1;
                SekreterCinsiyet.Text = sekreter.Cinsiyet1;
                SekreterTelefon.Text = sekreter.TelefonNo1;
                dtDogumTarihi.Text = sekreter.DogumTarihi1;
                tbSekreterDogumYeri.Text = sekreter.DogumYeri1;
                tbSekreterAdres.Text = sekreter.Adres1;
                tbSekreterMesaiSaat.Text = sekreter.SekreterMesaiSaatleri1;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btDoktorGuncelle_Click(object sender, EventArgs e)
        {
           
                try
            {
                if (sekreter == null)
                {
                    throw new Exception("sekreter Boş");

                }
                    sekreter.SekreterTcNo1 = tbSekreterTC.Text.Trim();
                    sekreter.Ad1 = tbSekreterAd.Text.Trim();
                    sekreter.Soyad1 = tbSekreterSoyad.Text.Trim();
                    sekreter.SekreterEmailHesabi1 = tbSekreterEmail.Text.Trim();
                    sekreter.SekreterPassword1 = tbSekreterPassword.Text.Trim();
                    sekreter.Cinsiyet1 = SekreterCinsiyet.Text.Trim();
                    sekreter.TelefonNo1 = SekreterTelefon.Text.Trim();
                    sekreter.DogumTarihi1 = dtDogumTarihi.Value.ToString();
                    sekreter.DogumTarihi1 = sekreter.DogumTarihi1.Substring(0, sekreter.DogumTarihi1.Length - 9);
                    sekreter.DogumYeri1 = tbSekreterDogumYeri.Text.Trim();
                    sekreter.Adres1 = tbSekreterAdres.Text.Trim();
                    sekreter.SekreterMesaiSaatleri1 = tbSekreterMesaiSaat.Text.Trim();

                long i;
                long j;
                if (long.TryParse(tbSekreterTC.Text.Trim(), out i) == true)
                {
                    sekreter.SekreterTcNo1 = i.ToString();
                }
                else
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Yazınız.");
                }

                if (sekreter.SekreterTcNo1.Length != 11)
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Giriniz.");
                }

                if (long.TryParse(SekreterTelefon.Text.Trim(), out j) == true)
                {
                    sekreter.TelefonNo1 = j.ToString();
                }
                else
                {
                    throw new Exception("Lütfen Geçerli Telefon Numarası Yazınız.");
                }

                if (sekreter.TelefonNo1.Length != 10)
                {
                    throw new Exception("Lütfen Geçerli Telefon Numarası Giriniz.");
                }



                int sonuc = sekreter.SekreterDuzenle(sekreter);
                if (sonuc > 0)
                {
                    lbMesaage.Text = "Sekreter Güncellendi";
                    lbMesaage.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                lbMesaage.Text = "Sekreter Güncellenemedi " + ex.Message;
                lbMesaage.ForeColor = Color.Red;

            }
               
        }

        
    }
}
