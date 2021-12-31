using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BusTicketProject
{
    public partial class SeferKayit : Form
    {
        public SeferKayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=BusTicket;Integrated Security=True");

       
       


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

      

        public void button1_Click(object sender, EventArgs e)
        {
            if (tarih.Text == string.Empty || saat.Text == string.Empty || TxtFiyat.Text == string.Empty)
            {
                MessageBox.Show("Tüm Bilgileri Eksiksiz Şekilde Doldurduğunuza Emin olun.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO TableVoyageInfo (kalkıs,varıs,tarıh,saat,fıyat) VALUES (@p1,@p2,@p3,@p4,@p5)", baglanti);
                komut.Parameters.AddWithValue("@p1", comboBox1.Text);
                komut.Parameters.AddWithValue("@p2", comboBox2.Text);
                komut.Parameters.AddWithValue("@p3", tarih.Text);
                komut.Parameters.AddWithValue("@p4", saat.Text);
                komut.Parameters.AddWithValue("@p5", TxtFiyat.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Sefer Sisteme Başarılı Şekilde Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            YetkiliMenu form7= new YetkiliMenu();
            form7.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtKalkıs_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SeferKayit_Load(object sender, EventArgs e)
        {

        }

        private void MskTarihh_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
