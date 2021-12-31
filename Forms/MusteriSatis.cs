using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketProject
{
    public partial class MusteriSatis : Form
    {

       
        public MusteriSatis()
        {
            InitializeComponent();
        }
    

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=BusTicket;Integrated Security=True");

        private void Form4_Load_1(object sender, EventArgs e)
        {
            seferListesi();
            TxtSeferNumara.Enabled = false;
            TxtFıyat.Enabled = false;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            //TxtSeferNumara.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            //TxtFıyat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            TxtSeferNumara.Text = Convert.ToString(secilen);
            this.TxtFıyat.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);

            this.Koltuk_aktif_et();
            SqlDataAdapter da = new SqlDataAdapter("SELECT KOLTUK FROM dbo.TableVoyageDetail Where SEFERNO =" + secilen + ";", baglanti);
            Console.WriteLine(secilen);
            DataTable dt = new DataTable();

            da.Fill(dt);
            int[] doluKoltuklar = new int[27];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                doluKoltuklar[i] = Convert.ToInt32(dt.Rows[i]["KOLTUK"]);
                if (doluKoltuklar[i] == 1)
                {
                    button6.Enabled = false;
                    button6.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 2)
                {
                    button36.Enabled = false;
                    button36.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 3)
                {
                    button35.Enabled = false;
                    button35.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 4)
                {
                    button42.Enabled = false;
                    button42.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 5)
                {
                    button34.Enabled = false;
                    button34.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 6)
                {
                    button29.Enabled = false;
                    button29.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 7)
                {
                    button40.Enabled = false;
                    button40.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 8)
                {
                    button12.Enabled = false;
                    button12.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 9)
                {
                    button11.Enabled = false;
                    button11.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 10)
                {
                    button38.Enabled = false;
                    button38.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 11)
                {
                    button10.Enabled = false;
                    button10.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 12)
                {
                    button9.Enabled = false;
                    button9.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 13)
                {
                    button8.Enabled = false;
                    button8.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 14)
                {
                    button20.Enabled = false;
                    button20.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 15)
                {
                    button25.Enabled = false;
                    button25.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 16)
                {
                    button4.Enabled = false;
                    button4.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 17)
                {
                    button16.Enabled = false;
                    button16.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 18)
                {
                    button15.Enabled = false;
                    button15.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 19)
                {
                    button2.Enabled = false;
                    button2.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 20)
                {
                    button14.Enabled = false;
                    button14.BackColor = Color.Red;
                }

                if (doluKoltuklar[i] == 21)
                {
                    button13.Enabled = false;
                    button13.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 22)
                {
                    button5.Enabled = false;
                    button5.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 23)
                {
                    button3.Enabled = false;
                    button3.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 24)
                {
                    button7.Enabled = false;
                    button7.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 25)
                {
                    button1.Enabled = false;
                    button1.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 26)
                {
                    button17.Enabled = false;
                    button17.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 27)
                {
                    button18.Enabled = false;
                    button18.BackColor = Color.Red;
                }
                this.Refresh();
            }
        }
        public void Koltuk_aktif_et()
        {

            button6.BackColor = Color.White;

            button36.BackColor = Color.White;

            button35.BackColor = Color.White;

            button42.BackColor = Color.White;

            button34.BackColor = Color.White;

            button29.BackColor = Color.White;

            button40.BackColor = Color.White;

            button12.BackColor = Color.White;
            button11.BackColor = Color.White;
            button38.BackColor = Color.White;
            button10.BackColor = Color.White;
            button9.BackColor = Color.White;
            button8.BackColor = Color.White;
            button20.BackColor = Color.White;
            button25.BackColor = Color.White;
            button4.BackColor = Color.White;
            button16.BackColor = Color.White;
            button15.BackColor = Color.White;
            button2.BackColor = Color.White;
            button14.BackColor = Color.White;
            button13.BackColor = Color.White;
            button5.BackColor = Color.White;
            button3.BackColor = Color.White;
            button7.BackColor = Color.White;
            button1.BackColor = Color.White;
            button17.BackColor = Color.White;
            button18.BackColor = Color.White;


            button6.Enabled = true;
            button36.Enabled = true;
            button35.Enabled = true;
            button42.Enabled = true;
            button34.Enabled = true;
            button29.Enabled = true;
            button40.Enabled = true;
            button12.Enabled = true;
            button11.Enabled = true;
            button38.Enabled = true;
            button10.Enabled = true;
            button9.Enabled = true;
            button8.Enabled = true;
            button20.Enabled = true;
            button25.Enabled = true;
            button4.Enabled = true;
            button16.Enabled = true;
            button15.Enabled = true;
            button2.Enabled = true;
            button14.Enabled = true;
            button13.Enabled = true;
            button5.Enabled = true;
            button3.Enabled = true;
            button7.Enabled = true;
            button1.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;

        }

    

        public void seferListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TableVoyageInfo", baglanti);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

     

        private void BtnRezervasyon_Click(object sender, EventArgs e)
        {
            if (TxtSeferNumara.Text == string.Empty || TxtKoltukNo.Text == string.Empty || TxtFıyat.Text == string.Empty || MskYolcuTc.Text == string.Empty)
            {
                MessageBox.Show("Tüm Bilgileri Eksiksiz Şekilde Doldurduğunuza Emin olun.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO TableVoyageDetail (SEFERNO,FIYATx,YOLCUTC,KOLTUK,OdemeBilgisi) VALUES" +
                    "(@p1,@p2,@p3,@p4,@p5)", baglanti);

                komut.Parameters.AddWithValue("@p1", TxtSeferNumara.Text);
                komut.Parameters.AddWithValue("@p2", TxtFıyat.Text);
                komut.Parameters.AddWithValue("@p3", MskYolcuTc.Text);
                komut.Parameters.AddWithValue("@p4", TxtKoltukNo.Text);
                komut.Parameters.AddWithValue("@p5", "ÖDENDİ");

                komut.ExecuteNonQuery();
                baglanti.Close();


                OdemeEkrani frm8 = new OdemeEkrani();
                frm8.Show();
                this.Hide();
            }
        }
        private void YenidenRenklendir()
        {
            foreach(Control item in groupBox1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.Green;
                }
            }
        }
        private void DoluKoltuk(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand verioku = new SqlCommand("SELECT * FROM TableVoyageDetail WHERE SEFERNO  ", baglanti);
            SqlDataReader read = verioku.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if(item is Button)
                    {
                        if (read["KOLTUK"].ToString() == item.Text)
                        {
                            item.BackColor = Color.Red;
                        }
                        }
                }
            }
            read.Close();
            baglanti.Close();
        }


        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void button6_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "1";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "2";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "3";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "4";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "5";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "6";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "9";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "10";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "11";
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "12";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "13";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "14";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "15";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "16";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "17";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "18";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "19";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "20";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "21";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "22";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "23";

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "24";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "25";
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "26";
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "27";
        }
        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

       

        private void button27_Click(object sender, EventArgs e)
        {
            MusteriGiris frm2= new MusteriGiris();
            frm2.Show();
            this.Hide();
        }

        private void TxtKoltukNo_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
