using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketProject
{
    public partial class YetkiliMenu : Form
    {
        public YetkiliMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeferKayit frm1= new SeferKayit(); 
            frm1.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MusteriGiris frm6=new MusteriGiris();
            frm6.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            YetkiliSatis form9=new YetkiliSatis();
            form9.Show();
            this.Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BiletIptal form11=new BiletIptal();
            form11.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RezervasyonAnaEkran m=new RezervasyonAnaEkran();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
