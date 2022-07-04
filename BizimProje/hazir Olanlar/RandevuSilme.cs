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
    public partial class RandevuSilme : Form
    {
        public RandevuSilme()
        {
            InitializeComponent();
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
                Randevu randevu = new Randevu();

                dataGridView1.Columns.Clear();
                if (tbarama.Text == "")
                {
                    dataGridView1.DataSource = randevu.ButunRandevulariGoruntule();
                    DataGridViewImageColumn d = new DataGridViewImageColumn();
                    d.HeaderText = "Sil";
                    d.Name = "btSil";
                    d.Image = Properties.Resources.icons8_delete_16;
                    dataGridView1.Columns.Insert(0, d);

                }

                long i;
                if (long.TryParse(tbarama.Text.Trim(), out i) == true)
                {
                    tbarama.Text = i.ToString();
                }
                else
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Yazınız.");
                }

                if (tbarama.Text.Length != 11)
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Giriniz.");
                }


                dataGridView1.DataSource = randevu.TC_ile_arama(tbarama.Text.Trim());
                //if (tbarama.Text == "")
                //{
                //    dataGridView1.DataSource = randevu.ButunRandevulariGoruntule();

                //}

                DataGridViewImageColumn data = new DataGridViewImageColumn();
                data.HeaderText = "Sil";
                data.Name = "btSil";
                data.Image = Properties.Resources.icons8_delete_16;
                dataGridView1.Columns.Insert(0, data);
            }
            catch (Exception ex)
            {

                lbMessage.Text = ex.Message;
                lbMessage.ForeColor = Color.Red;

            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbMessage.Text = "";

                if (e.ColumnIndex == 0)
                {
                    var sonuc = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Randevu Silme Mesajı",
                    MessageBoxButtons.YesNo);
                    if (sonuc == DialogResult.Yes)
                    {
                        //string TCNo = dataGridView1.Rows[e.RowIndex].Cells["HastaTcNo"].Value.ToString();
                        int RandevuNo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["RandevuNo"].Value.ToString());


                        Randevu randevu = new Randevu();

                        int s = randevu.RandevuSilme(RandevuNo);

                        if (s > 0)
                        {
                            lbMessage.Text = "Randevu Silindi";
                            lbMessage.ForeColor = Color.Green;
                        }
                    }
                }
            }
            catch (Exception)
            {

                lbMessage.Text = "Bir Sıkıntı İle Karşılaştık.";
                lbMessage.ForeColor = Color.Red;
            }
        }

        private void RandevuSilme_Load(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu();
            dataGridView1.DataSource = randevu.ButunRandevulariGoruntule();
            DataGridViewImageColumn data = new DataGridViewImageColumn();
            data.HeaderText = "Sil";
            data.Name = "btSil";
            data.Image = Properties.Resources.icons8_delete_16;
            dataGridView1.Columns.Insert(0, data);
        }
    }
}
