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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void btGiris_Click(object sender, EventArgs e)
        {

            try
            {
                lblMessage.Text = "";
                lblMessage.ForeColor = Color.Black;

                string email = tbEmail.Text.Trim();
                string password = tbPassword.Text.Trim();

                if (string.IsNullOrWhiteSpace(email))
                {
                    lblMessage.Text = "Lütfen Emailinizi Giriniz.";
                    lblMessage.ForeColor = Color.Red;
                    tbEmail.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(password))
                {
                    lblMessage.Text = "Lütfen şifrenizi Giriniz.";
                    lblMessage.ForeColor = Color.Red;
                    tbPassword.Focus();
                    return;
                }
                if (email.Contains("@doktor.com"))
                {
                    Doktor doktor = new Doktor();
                    var sonuc = doktor.Login(email, password);

                    if (sonuc != null)
                    {
                        DoktorEkrani doktorEkrani = new DoktorEkrani(sonuc);
                        ButunHastalar butunHastalar = new ButunHastalar(sonuc);
                        BugunHasta bugunHasta = new BugunHasta(sonuc);
                        KoronaTestSonuc korona = new KoronaTestSonuc(sonuc);
                        RaporOlusturma rapor = new RaporOlusturma(sonuc);
                        doktorEkrani.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblMessage.Text = "Lütfen Geçerli Bilgiler Giriniz.";
                        lblMessage.ForeColor = Color.Red;
                    }
                }
                else if (email.Contains("@sekreter.com"))
                {
                    Sekreter sekreter = new Sekreter();
                    var sonuc = sekreter.Login(email, password);

                    if (sonuc != null)
                    {
                        SekreterEkrani sekreterEkrani = new SekreterEkrani(sonuc);
                        sekreterEkrani.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblMessage.Text = "Lütfen Geçerli Bilgiler Giriniz.";
                        lblMessage.ForeColor = Color.Red;
                    }

                }
                else
                {
                    lblMessage.Text = "Lütfen Geçerli Bilgiler Giriniz.";
                    lblMessage.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                lblMessage.Text = "Bir sıkıntı ile karşılaştık.";
                lblMessage.ForeColor = Color.Red;
            }
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
    
}
