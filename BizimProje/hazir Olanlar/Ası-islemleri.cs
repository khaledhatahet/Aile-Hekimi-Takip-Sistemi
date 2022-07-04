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
    public partial class Asiislemleri : Form
    {
        public Asiislemleri()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btAra_Click(object sender, EventArgs e)
        {
            AsiEkleme asiEkleme = new AsiEkleme();
            asiEkleme.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AsiArama asiArama = new AsiArama();
            asiArama.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AsiSilme asiSilme = new AsiSilme();
            asiSilme.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AsiDuzeltme asiDuzeltme = new AsiDuzeltme();
            asiDuzeltme.ShowDialog();
        }
    }
}
