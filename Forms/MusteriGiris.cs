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
    public partial class MusteriGiris : Form
    {
        public MusteriGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=MSI;Initial Catalog=BusTicket;Integrated Security=True");
        MusteriSatis ms = new MusteriSatis();
        YetkiliMenu ym = new YetkiliMenu();



        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = (char)42;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM UyeBilgisi where Kuladi='" + textBox1.Text + "' AND Sifre='" + textBox2.Text + "'", baglan);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Hoşgeldiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ms.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Geçersiz Lütfen Tekrar Deneyiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);                  
                }

                baglan.Close();
            }

            else

            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Admin where Kuladi='" + textBox1.Text + "' AND Sifre='" + textBox2.Text + "'", baglan);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Hoş Geldiniz  :  " + textBox1.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Hide();
                    ym.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Geçersiz Lütfen Tekrar Deneyiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);                   
                }

                baglan.Close();

            }





        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyeKayit frm3 = new UyeKayit();
            frm3.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
