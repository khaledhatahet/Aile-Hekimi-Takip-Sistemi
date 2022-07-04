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
    public partial class DoktorDuzelt : Form
    {
        public DoktorDuzelt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor();

            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = doktor.Ad_ile_arama(tbarama.Text.Trim());

            DataGridViewImageColumn data = new DataGridViewImageColumn();
            data.HeaderText = "Düzelt";
            data.Name = "btDuzelt";
            data.Image = Properties.Resources.icons8_edit_16;
            dataGridView1.Columns.Insert(0, data);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbMessage.Text = "";

                if (e.ColumnIndex == 0)
                {
                    string DoktorTc = dataGridView1.Rows[e.RowIndex].Cells["DoktorTcNo"].Value.ToString();
                    string DoktorAd = dataGridView1.Rows[e.RowIndex].Cells["Ad"].Value.ToString();
                    string DoktorSoyad = dataGridView1.Rows[e.RowIndex].Cells["Soyad"].Value.ToString();
                    string Email = dataGridView1.Rows[e.RowIndex].Cells["EmailHesabi"].Value.ToString();
                    string password = dataGridView1.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                    string Cinsiyet = dataGridView1.Rows[e.RowIndex].Cells["Cinsiyet"].Value.ToString();
                    string TelefonNo = dataGridView1.Rows[e.RowIndex].Cells["TelefonNo"].Value.ToString();
                    string DogumTarihi = dataGridView1.Rows[e.RowIndex].Cells["DogumTarihi"].Value.ToString();
                    string DogumYeri = dataGridView1.Rows[e.RowIndex].Cells["DogumYeri"].Value.ToString();
                    string Adres = dataGridView1.Rows[e.RowIndex].Cells["Adres"].Value.ToString();
                    string MesaiSaatleri = dataGridView1.Rows[e.RowIndex].Cells["MesaiSaatleri"].Value.ToString();
                    string PoliklinikNo = dataGridView1.Rows[e.RowIndex].Cells["PoliklinikNO"].Value.ToString();

                    Doktor doktor = new Doktor();
                    doktor.DoktorTcNo1 = DoktorTc;
                    doktor.Ad1 = DoktorAd;
                    doktor.Soyad1 = DoktorSoyad;
                    doktor.EmailHesabi1 = Email;
                    doktor.Password1 = password;
                    doktor.Cinsiyet1 = Cinsiyet;
                    doktor.TelefonNo1 = TelefonNo;
                    doktor.DogumTarihi1 = DogumTarihi;
                    doktor.DogumYeri1 = DogumYeri;
                    doktor.Adres1 = Adres;
                    doktor.MesaiSaatleri1 = MesaiSaatleri;
                    doktor.PoliklinikNO1 = PoliklinikNo;

                    DoktorBilgileriniDuzeltForm duzelt = new DoktorBilgileriniDuzeltForm();
                    duzelt.doktor = doktor;
                    duzelt.ShowDialog();
                }
            }
            catch (Exception)
            {

                lbMessage.Text = "Bir Sıkıntı İle Karşılaştık.";
                lbMessage.ForeColor = Color.Red;
            }
        }

        private void DoktorDuzelt_Load(object sender, EventArgs e)
        {
           
        }
    }
    
}
