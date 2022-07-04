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
    public partial class SekreterDuzelt : Form
    {
        public SekreterDuzelt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sekreter sekreter = new Sekreter();

            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = sekreter.Ad_ile_arama(tbarama.Text.Trim());

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
                    string SekreterTc = dataGridView1.Rows[e.RowIndex].Cells["SekreterTcNo"].Value.ToString();
                    string SekreterAd = dataGridView1.Rows[e.RowIndex].Cells["Ad"].Value.ToString();
                    string SekreterSoyad = dataGridView1.Rows[e.RowIndex].Cells["Soyad"].Value.ToString();
                    string Email = dataGridView1.Rows[e.RowIndex].Cells["EmailHesabi"].Value.ToString();
                    string password = dataGridView1.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                    string Cinsiyet = dataGridView1.Rows[e.RowIndex].Cells["Cinsiyet"].Value.ToString();
                    string TelefonNo = dataGridView1.Rows[e.RowIndex].Cells["TelefonNo"].Value.ToString();
                    string DogumTarihi = dataGridView1.Rows[e.RowIndex].Cells["DogumTarihi"].Value.ToString();
                    string DogumYeri = dataGridView1.Rows[e.RowIndex].Cells["DogumYeri"].Value.ToString();
                    string Adres = dataGridView1.Rows[e.RowIndex].Cells["Adres"].Value.ToString();
                    string MesaiSaatleri = dataGridView1.Rows[e.RowIndex].Cells["MesaiSaatleri"].Value.ToString();

                    Sekreter sekreter = new Sekreter();
                    sekreter.SekreterTcNo1 = SekreterTc;
                    sekreter.Ad1 = SekreterAd;
                    sekreter.Soyad1 = SekreterSoyad;
                    sekreter.SekreterEmailHesabi1 = Email;
                    sekreter.SekreterPassword1 = password;
                    sekreter.Cinsiyet1 = Cinsiyet;
                    sekreter.TelefonNo1 = TelefonNo;
                    sekreter.DogumTarihi1 = DogumTarihi;
                    sekreter.DogumYeri1 = DogumYeri;
                    sekreter.Adres1 = Adres;
                    sekreter.SekreterMesaiSaatleri1 = MesaiSaatleri;

                    SekreterDuzeltForm duzelt = new SekreterDuzeltForm();
                    duzelt.sekreter = sekreter;
                    duzelt.ShowDialog();
                }
            }
            catch (Exception)
            {

                lbMessage.Text = "Bir Sıkıntı İle Karşılaştık.";
                lbMessage.ForeColor = Color.Red;
            }
        }
    }
}
