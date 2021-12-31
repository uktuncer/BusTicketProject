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
    public partial class OdemeEkrani : Form
    {
        public OdemeEkrani()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelKartTarih.Text = comboBox1.Text+"/"+ comboBox2.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelKartTarih.Text = comboBox1.Text + "/" + comboBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty || maskedTextBox1.Text == string.Empty || maskedTextBox2.Text == string.Empty)
            {
                MessageBox.Show("Tüm Bilgileri Eksiksiz Şekilde Doldurduğunuza Emin olun.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ödeme Başarıyla Tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MusteriSatis form4 = new MusteriSatis();
                form4.Show();
                this.Hide();

            }
        }
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            LabelKartAdSoyad.Text = textBox3.Text;
        }

        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            LabelKartNo.Text = maskedTextBox1.Text;
        }

        private void maskedTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            LabelKartCvv.Text = maskedTextBox2.Text;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            int ay;
            int yil;
            for (ay=1;ay<13; ay++)
            {
                comboBox1.Items.Add(ay);
            }
            for(yil=21;yil<33; yil++)
            {
                comboBox2.Items.Add(yil);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
