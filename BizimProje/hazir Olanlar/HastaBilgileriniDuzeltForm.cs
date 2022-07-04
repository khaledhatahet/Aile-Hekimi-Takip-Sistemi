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
    public partial class HastaBilgileriniDuzeltForm : Form
    {
        public Hasta hasta { get; set; }
        public HastaBilgileriniDuzeltForm()
        {
            InitializeComponent();
        }

        private void HastaBilgileriniDuzeltForm_Load(object sender, EventArgs e)
        {
            try
            {
                Doktor doktor = new Doktor();
                DataTable dt = new DataTable();
                dt = doktor.ButunDoktorlariGoruntule();
                DoktorSec.DisplayMember = "Ad";
                DoktorSec.ValueMember = "DoktorTcNo";
                DoktorSec.DataSource = dt;

               

                if (hasta == null)
                {
                    throw new Exception("Hasta Boş");
                }
                tbHastaTC.Text = hasta.HastaTcNo1;
                tbHastaAd.Text = hasta.Ad1;
                tbHastaSoyad.Text = hasta.Soyad1;
                tbHastaAnne.Text = hasta.AnneAdi1;
                tbHastaBaba.Text = hasta.BabaAdi1;
                HastaCinsiyet.Text = hasta.Cinsiyet1;
                tbHastaTelefon.Text = hasta.TelefonNo1;
                dtDogumTarihi.Text = hasta.DogumTarihi1;
                tbHastaDogumYeri.Text = hasta.DogumYeri1;
                tbHastaAdres.Text = hasta.Adres1;
                tbHastaNot.Text = hasta.HESKod1;
                cbHastaKan.SelectedItem = hasta.KanGrubu1;
                DoktorSec.SelectedValue = hasta.DoktorTcNo1;

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
                if (hasta == null)
                {
                    throw new Exception("Hasta Boş");

                }
                hasta.HastaTcNo1 = tbHastaTC.Text.Trim();
                hasta.Ad1 = tbHastaAd.Text.Trim();
                hasta.Soyad1 = tbHastaSoyad.Text.Trim();
                hasta.AnneAdi1 = tbHastaAnne.Text.Trim();
                hasta.BabaAdi1 = tbHastaBaba.Text.Trim();
                hasta.Cinsiyet1 = HastaCinsiyet.Text.Trim();
                hasta.TelefonNo1 = tbHastaTelefon.Text.Trim();
                hasta.DogumTarihi1 = dtDogumTarihi.Value.ToString();
                hasta.DogumTarihi1 = hasta.DogumTarihi1.Substring(0, hasta.DogumTarihi1.Length - 9);
                hasta.DogumYeri1 = tbHastaDogumYeri.Text.Trim();
                hasta.Adres1 = tbHastaAdres.Text.Trim();
                hasta.HESKod1 = tbHastaNot.Text.Trim();
                hasta.KanGrubu1 = cbHastaKan.SelectedItem.ToString();
                hasta.DoktorTcNo1 = DoktorSec.SelectedValue.ToString();

                long i;
                long j;
                if (long.TryParse(tbHastaTC.Text.Trim(), out i) == true)
                {
                    hasta.HastaTcNo1 = i.ToString();
                }
                else
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Yazınız.");
                }

                if (hasta.HastaTcNo1.Length != 11)
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Giriniz.");
                }

                if (long.TryParse(tbHastaTelefon.Text.Trim(), out j) == true)
                {
                    hasta.TelefonNo1 = j.ToString();
                }
                else
                {
                    throw new Exception("Lütfen Geçerli Telefon Numarası Yazınız.");
                }

                if (hasta.TelefonNo1.Length != 10)
                {
                    throw new Exception("Lütfen Geçerli Telefon Numarası Giriniz.");
                }

                HESkodu hESkodu = new HESkodu();
                hESkodu.HESKod1 = hasta.HESKod1;
                if (!hESkodu.HesKoduArama(hESkodu.HESKod1))
                {
                    hESkodu.HesKoduEkle(hESkodu);

                }


                int sonuc = hasta.HastaDuzenle(hasta);
                if (sonuc > 0)
                {
                    lbMesaage.Text = "Hasta Güncellendi";
                    lbMesaage.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                lbMesaage.Text = "Hasta Güncellenemedi " +ex.Message;
                lbMesaage.ForeColor = Color.Red;

            }
        }

        private void cbHastaCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
