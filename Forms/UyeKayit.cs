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
    public partial class UyeKayit : Form
    {
        public UyeKayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=BusTicket;Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty
            || maskedTextBox1.Text == string.Empty || maskedTextBox2.Text == string.Empty || textBox7.Text == string.Empty 
            || maskedTextBox3.Text == string.Empty || textBox8.Text == string.Empty || textBox7.Text != textBox8.Text )

            { MessageBox.Show("Tüm Bilgileri Eksiksiz Şekilde Doldurduğunuza Emin olun.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); } 
            
            else { 

            baglanti.Open();

            SqlCommand komut = new SqlCommand("INSERT INTO UyeBilgisi (AD,SOYAD,EMAIL,TELEFON,CINSIYET,DOGUMTARIHI,TC,Sifre,SEHIR,Kuladi) VALUES" +
                 "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti);

            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p5", comboBox1.Text);
            komut.Parameters.AddWithValue("@p6", maskedTextBox3.Text);
            komut.Parameters.AddWithValue("@p7", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@p10", textBox4.Text);
            komut.Parameters.AddWithValue("@p8", textBox7.Text);
            komut.Parameters.AddWithValue("@p9", comboBox2.Text);


            komut.ExecuteNonQuery();
            baglanti.Close();
                MessageBox.Show("Kaydınız Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
    
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                button1.Enabled = false;
            }
            else
                button1.Enabled = true;
        }
 
        private void label11_Click(object sender, EventArgs e)
        {

        }

      

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriGiris m=new MusteriGiris();
            m.Show();
            this.Hide();

        }

        private void UyeKayit_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox7.PasswordChar = (char)42;
            textBox8.PasswordChar = (char)42;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

