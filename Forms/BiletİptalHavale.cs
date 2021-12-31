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
    public partial class BiletİptalHavale : Form
    {
        public BiletİptalHavale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==String.Empty || textBox2.Text==String.Empty || maskedTextBox1.Text == String.Empty)
            {
                MessageBox.Show("Tüm Bilgileri Eksiksiz Şekilde Doldurduğunuza Emin olun.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Havale / Eft işlemi gerçekleşmiştir. .", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BiletIptal biletIptal = new BiletIptal();
                biletIptal.Show();
                this.Hide();
            }
            
        }

        private void BiletİptalHavale_Load(object sender, EventArgs e)
        {

        }
    }
}
