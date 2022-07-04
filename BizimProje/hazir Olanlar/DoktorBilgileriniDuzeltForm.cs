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
    public partial class DoktorBilgileriniDuzeltForm : Form
    {
        public Doktor doktor { get; set; }

        public DoktorBilgileriniDuzeltForm()
        {
            InitializeComponent();
        }

        private void DoktorBilgileriniDuzeltForm_Load(object sender, EventArgs e)
        {
            try
            {
                Poliklinik poliklinik = new Poliklinik();

                DataTable dt = new DataTable();
                dt = poliklinik.ButunPoliklinikleriGoruntule();
                PoliklinikSec.DisplayMember = "PoliklinikNO";
                PoliklinikSec.ValueMember = "PoliklinikNO";
                PoliklinikSec.DataSource = dt;

                if (doktor == null)
                {
                    throw new Exception("Doktor Boş");
                }
                tbDoktorTC.Text = doktor.DoktorTcNo1;
                tbDoktorAd.Text = doktor.Ad1;
                tbDoktorSoyad.Text = doktor.Soyad1;
                tbDoktorEmail.Text = doktor.EmailHesabi1;
                tbDoktorPassword.Text = doktor.Password1;
                DoktorCinsiyet.Text = doktor.Cinsiyet1;
                tbDoktorTelefon.Text = doktor.TelefonNo1;
                dtDogumTarihi.Text = doktor.DogumTarihi1;
                tbDoktorDogumYeri.Text = doktor.DogumYeri1;
                tbDoktorAdres.Text = doktor.Adres1;
                tbDoktorMesaiSaat.Text = doktor.MesaiSaatleri1;
                PoliklinikSec.SelectedValue = doktor.PoliklinikNO1;

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
                if (doktor == null)
                {
                    throw new Exception("Doktor Boş");

                }
                doktor.DoktorTcNo1 = tbDoktorTC.Text.Trim();
                doktor.Ad1 = tbDoktorAd.Text.Trim();
                doktor.Soyad1 = tbDoktorSoyad.Text.Trim();
                doktor.EmailHesabi1 = tbDoktorEmail.Text.Trim();
                doktor.Password1 = tbDoktorPassword.Text.Trim();
                doktor.Cinsiyet1 = DoktorCinsiyet.Text.Trim();
                doktor.TelefonNo1 = tbDoktorTelefon.Text.Trim();
                doktor.DogumTarihi1 = dtDogumTarihi.Value.ToString();
                doktor.DogumTarihi1 = doktor.DogumTarihi1.Substring(0, doktor.DogumTarihi1.Length - 9);
                doktor.DogumYeri1 = tbDoktorDogumYeri.Text.Trim();
                doktor.Adres1 = tbDoktorAdres.Text.Trim();
                doktor.MesaiSaatleri1 = tbDoktorMesaiSaat.Text.Trim();
                doktor.PoliklinikNO1 = PoliklinikSec.SelectedValue.ToString();

                Poliklinik poliklinik = new Poliklinik();
                string[] dizi = new string[100];
                dizi = poliklinik.PoliklinikDoluKontrol(doktor.PoliklinikNO1);
                for (int p = 0; p < dizi.Length; p++)
                {
                    if (dizi[p] == doktor.PoliklinikNO1)
                    {
                        throw new Exception("Bu Poliklinik Dolu");
                    }
                }

                long i;
                long j;
                if (long.TryParse(tbDoktorTC.Text.Trim(), out i) == true)
                {
                    doktor.DoktorTcNo1 = i.ToString();
                }
                else
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Yazınız.");
                }

                if (doktor.DoktorTcNo1.Length != 11)
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Giriniz.");
                }

                if (long.TryParse(tbDoktorTelefon.Text.Trim(), out j) == true)
                {
                    doktor.TelefonNo1 = j.ToString();
                }
                else
                {
                    throw new Exception("Lütfen Geçerli Telefon Numarası Yazınız.");
                }

                if (doktor.TelefonNo1.Length != 10)
                {
                    throw new Exception("Lütfen Geçerli Telefon Numarası Giriniz.");
                }

                int sonuc = doktor.DoktorDuzenle(doktor);
                if (sonuc > 0)
                {
                    lbMesaage.Text = "Doktor Güncellendi";
                    lbMesaage.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                lbMesaage.Text = "Doktor Güncellenemedi " + ex.Message;
                lbMesaage.ForeColor = Color.Red;

            }
        }
    }
}
