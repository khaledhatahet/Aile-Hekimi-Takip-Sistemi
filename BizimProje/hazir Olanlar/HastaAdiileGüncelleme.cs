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
    public partial class HastaDuzelt : Form
    {
        public HastaDuzelt()
        {
            InitializeComponent();
        }

        private void tbad_TextChanged(object sender, EventArgs e)
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
            Hasta hasta = new Hasta();

            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = hasta.Ad_ile_arama(tbarama.Text.Trim());

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
                    string HastaTc = dataGridView1.Rows[e.RowIndex].Cells["HastaTcNo"].Value.ToString();
                    string Ad = dataGridView1.Rows[e.RowIndex].Cells["Ad"].Value.ToString();
                    string Soyad = dataGridView1.Rows[e.RowIndex].Cells["Soyad"].Value.ToString();
                    string anne = dataGridView1.Rows[e.RowIndex].Cells["AnneAdi"].Value.ToString();
                    string baba = dataGridView1.Rows[e.RowIndex].Cells["BabaAdi"].Value.ToString();
                    string Cinsiyet = dataGridView1.Rows[e.RowIndex].Cells["Cinsiyet"].Value.ToString();
                    string TelefonNo = dataGridView1.Rows[e.RowIndex].Cells["TelefonNo"].Value.ToString();
                    string DogumTarihi = dataGridView1.Rows[e.RowIndex].Cells["DogumTarihi"].Value.ToString();
                    string DogumYeri = dataGridView1.Rows[e.RowIndex].Cells["DogumYeri"].Value.ToString();
                    string Adres = dataGridView1.Rows[e.RowIndex].Cells["Adres"].Value.ToString();
                    string KanGrubu = dataGridView1.Rows[e.RowIndex].Cells["KanGrubu"].Value.ToString();
                    string HesKodu = dataGridView1.Rows[e.RowIndex].Cells["HESKod"].Value.ToString();
                    string DoktorTC = dataGridView1.Rows[e.RowIndex].Cells["DoktorTcNo"].Value.ToString();


                    Hasta hasta = new Hasta();

                    hasta.HastaTcNo1 = HastaTc;
                    hasta.Ad1 = Ad;
                    hasta.Soyad1 = Soyad;
                    hasta.AnneAdi1 = anne;
                    hasta.BabaAdi1 = baba;
                    hasta.Cinsiyet1 = Cinsiyet;
                    hasta.TelefonNo1 = TelefonNo;
                    hasta.DogumTarihi1 = DogumTarihi;
                    hasta.DogumYeri1 = DogumYeri;
                    hasta.Adres1 = Adres;
                    hasta.KanGrubu1 = KanGrubu;
                    hasta.HESKod1 = HesKodu;
                    hasta.DoktorTcNo1 = DoktorTC;

                    HastaBilgileriniDuzeltForm duzelt = new HastaBilgileriniDuzeltForm();
                    duzelt.hasta = hasta;
                    duzelt.ShowDialog();
                }
            }
            catch (Exception)
            {

                lbMessage.Text = "Bir Sıkıntı İle Karşılaştık.";
                lbMessage.ForeColor = Color.Red;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
