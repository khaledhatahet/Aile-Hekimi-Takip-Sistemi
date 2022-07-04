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
    public partial class RaporOlusturma : Form
    {
        public Doktor Doktor { get; set; }
        public RaporOlusturma( Doktor d)
        {
            InitializeComponent();
            Doktor = d;
        }

        private void RaporOlusturma_Load(object sender, EventArgs e)
        {
            RaporText.AppendText("  \n");
            RaporText.AppendText("   Hasta Bilgisi: " + "\n\n");
            RaporText.AppendText("   Kimlik Numarası : " + "" + "\n\n");
            RaporText.AppendText("   Hasta Adı : " + "\t" + "\n\n");
            RaporText.AppendText("   Baba Adı : " + "\n\n");
            RaporText.AppendText("   Rapor No : " + "\n\n");
            RaporText.AppendText("   Baba Adı : " + "\n\n");
            RaporText.AppendText("   Doğum Tarihi : " + "\n\n");
            RaporText.AppendText("   Doğum Yeri : " + "\n\n");
            RaporText.AppendText("   Rapor Veriliş Tarihi : " + "\n\n");
            RaporText.AppendText("   Son Geçerlilik Tarihi : " + "\n\n");
            RaporText.AppendText("   Doktor Bilgisi : " + "\n\n");
            RaporText.AppendText("   Poliklinik No : " + "\n\n");
            RaporText.AppendText("   Doktor Adı : " + "\n\n");
            RaporText.AppendText("   Not : " + "\t"+ "\n");

        }

        private void tbTcNo_TextChanged(object sender, EventArgs e)
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
                string tc = tbTcNo.Text.Trim();
                string SonTarih = dtpSonGecerlilikTarihi.Value.ToString();
                string not = tbNot.Text.Trim();

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

                Randevu randevu = new Randevu();
                if (randevu.HastaninDoktorunuBul(tc) == Doktor.DoktorTcNo1)
                {
                    Rapor rapor = new Rapor();
                    Hasta hasta = new Hasta();
                    rapor.HastaTcNo1 = tc;
                    hasta = rapor.HastaninBilgileriniBul(rapor.HastaTcNo1);
                    rapor.RaporOlusturmaTarihi1 = DateTime.Today.ToString();
                    rapor.SonGecerlilikTarihi1 = SonTarih;
                    rapor.RaporNot1 = not;
                    Doktor doktor = new Doktor();
                    doktor = rapor.HastaninDoktorununBilgileriniBul(rapor.HastaTcNo1);
                    rapor.DoktorTcNo1 = doktor.DoktorTcNo1;

                    int sonuc = rapor.RaporOlustur(rapor);
                    if (sonuc > 0)
                    {
                        lbMesaage.Text = "Rapor Oluşturuldu";
                        lbMesaage.ForeColor = Color.Green;
                    }
                    rapor.RaporNo1 = rapor.RaporNoBul(rapor);

                    RaporText.Clear();
                    RaporText.AppendText("  \n\n");
                    RaporText.AppendText("   Rapor No : " + "\t" + $"{rapor.RaporNo1}" + "\n\n");
                    RaporText.AppendText("   Hasta Bilgisi: " + "\n\n");
                    RaporText.AppendText("   Kimlik Numarası : " + "\t" + $"{rapor.HastaTcNo1}" + "\n\n");
                    RaporText.AppendText("   Hasta Adı : " + "\t" + $"{hasta.Ad1} {hasta.Soyad1}" + "\n\n");
                    RaporText.AppendText("   Baba Adı : " + "\t" + $"{hasta.BabaAdi1}" + "\n\n");
                    RaporText.AppendText("   Anne Adı : " + "\t" + $"{hasta.AnneAdi1}" + "\n\n");
                    RaporText.AppendText("   Doğum Tarihi : " + "\t" + $"{hasta.DogumTarihi1}" + "\n\n");
                    RaporText.AppendText("   Doğum Yeri : " + "\t" + $"{hasta.DogumYeri1}" + "\n\n");
                    RaporText.AppendText("   Rapor Veriliş Tarihi : " + "\t" + $"{rapor.RaporOlusturmaTarihi1}" + "\n\n");
                    RaporText.AppendText("   Son Geçerlilik Tarihi : " + "\t" + $"{rapor.SonGecerlilikTarihi1}" + "\n\n");
                    RaporText.AppendText("   Doktor Bilgisi : " + "\n\n");
                    RaporText.AppendText("   Poliklinik No : " + "\t" + $"{doktor.PoliklinikNO1}" + "\n\n");
                    RaporText.AppendText("   Doktor Adı : " + "\t" + $"{doktor.Ad1} {doktor.Soyad1}" + "\n\n");
                    RaporText.AppendText("   Not : " + "\t" + $"{not}" + "\n");

                }
                else
                {
                    MessageBox.Show("Lütfen Size Ait Bir hastanın Tc Numarasını Giriniz.");
                }


            }
            catch (Exception ex)
            {
                lbMesaage.Text = ex.Message;
                lbMesaage.ForeColor = Color.Red;

            }
            

        }

        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {

                Bitmap bitmap = new Bitmap(RaporText.Width, RaporText.Height);
                RaporText.DrawToBitmap(bitmap, new Rectangle(0, 0, RaporText.Width, RaporText.Height));
                e.Graphics.DrawImage(bitmap, 0, 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                printDialog1.Document = printDocument1;
                if(printDialog1.ShowDialog()== DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
