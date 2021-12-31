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
    public partial class YetkiliSatis : Form
    {
        public YetkiliSatis()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MSI;Initial Catalog=BusTicket;Integrated Security=True");

        private void Form9_Load(object sender, EventArgs e)
        {
            seferListesi();
            TxtSeferNumara.Enabled = false;
            TxtFıyat.Enabled = false;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            ///int secilen = dataGridView1.SelectedCells[0].RowIndex;
            int secilen = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            TxtSeferNumara.Text = Convert.ToString(secilen);
            this.TxtFıyat.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            this.Koltuk_aktif_et();
            SqlDataAdapter da = new SqlDataAdapter("SELECT KOLTUK FROM dbo.TableVoyageDetail Where SEFERNO =" + secilen +";", baglanti);
            Console.WriteLine(secilen);
            DataTable dt = new DataTable();
            
            da.Fill(dt);
            int[] doluKoltuklar = new int[27];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                doluKoltuklar[i] = Convert.ToInt32(dt.Rows[i]["KOLTUK"]);
                if (doluKoltuklar[i] ==1)
                {
                    button45.Enabled = false;
                    button45.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 2)
                {
                    button62.Enabled = false;
                    button62.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 3)
                {
                    button63.Enabled = false;
                    button63.BackColor = Color.Red ;
                }
                if (doluKoltuklar[i] == 4)
                {
                    button59.Enabled = false;
                    button59.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 5)
                {
                    button64.Enabled = false;
                    button64.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 6)
                {
                    button65.Enabled = false;
                    button65.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 7)
                {
                    button60.Enabled = false;
                    button60.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 8)
                {
                    button51.Enabled = false;
                    button51.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 9)
                {
                    button52.Enabled = false;
                    button52.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 10)
                {
                    button61.Enabled = false;
                    button61.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 11)
                {
                    button53.Enabled = false;
                    button53.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 12)
                {
                    button54.Enabled = false;
                    button54.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 13)
                {
                    button55.Enabled = false;
                    button55.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 14)
                {
                    button46.Enabled = false;
                    button46.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 15)
                {
                    button44.Enabled = false;
                    button44.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 16)
                {
                    button57.Enabled = false;
                    button57.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 17)
                {
                    button47.Enabled = false;
                    button47.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] ==18)
                {
                    button48.Enabled = false;
                    button48.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 19)
                {
                    button58.Enabled = false;
                    button58.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 20)
                {
                    button49.Enabled = false;
                    button49.BackColor = Color.Red;
                }
            
                if (doluKoltuklar[i] ==21)
                {
                    button50.Enabled = false;
                    button50.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 22)
                {
                    button56.Enabled = false;
                    button56.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 23)
                {
                    button32.Enabled = false;
                    button32.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 24)
                {
                    button31.Enabled = false;
                    button31.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 25)
                {
                    button33.Enabled = false;
                    button33.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 26)
                {
                    button30.Enabled = false;
                    button30.BackColor = Color.Red;
                }
                if (doluKoltuklar[i] == 27)
                {
                    button28.Enabled = false;
                    button28.BackColor = Color.Red;
                }
                this.Refresh();
            }


        }
        public void Koltuk_aktif_et()
        {

            button45.BackColor = Color.White;

            button62.BackColor = Color.White;

            button63.BackColor = Color.White;

            button59.BackColor = Color.White;

            button64.BackColor = Color.White;

            button65.BackColor = Color.White;

            button60.BackColor = Color.White;

            button51.BackColor = Color.White;
            button52.BackColor = Color.White;
            button61.BackColor = Color.White;
            button53.BackColor = Color.White;
            button54.BackColor = Color.White;
            button55.BackColor = Color.White;
            button46.BackColor = Color.White;
            button44.BackColor = Color.White;
            button57.BackColor = Color.White;
            button47.BackColor = Color.White;
            button48.BackColor = Color.White;
            button58.BackColor = Color.White;
            button49.BackColor = Color.White;
            button56.BackColor = Color.White;
            button56.BackColor = Color.White;
            button32.BackColor = Color.White;
            button31.BackColor = Color.White;
            button33.BackColor = Color.White;
            button30.BackColor = Color.White;
            button28.BackColor = Color.White;


            button28.Enabled = true;
            button30.Enabled = true;
            button33.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button56.Enabled = true;
            button50.Enabled = true;
            button49.Enabled = true;
            button58.Enabled = true;
            button48.Enabled = true;
            button47.Enabled = true;
            button57.Enabled = true;
            button44.Enabled = true;
            button46.Enabled = true;
            button55.Enabled = true;
            button54.Enabled = true;
            button53.Enabled = true;
            button61.Enabled = true;
            button52.Enabled = true;
            button51.Enabled = true;
            button60.Enabled = true;
            button65.Enabled = true;
            button64.Enabled = true;
            button59.Enabled = true;
            button63.Enabled = true;
            button62.Enabled = true;
            button45.Enabled = true;

        }

        public void seferListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TableVoyageInfo", baglanti);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }


        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (TxtSeferNumara.Text == string.Empty || TxtFıyat.Text == string.Empty || TxtKoltukNo.Text == string.Empty || MskYolcuTc.Text == string.Empty)
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

                MessageBox.Show("Nakit Ödeme Başarıyla Alındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            YetkiliMenu form7=new YetkiliMenu();
            form7.Show();
            this.Hide();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "1";
        }

        private void button62_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "2";
        }

        private void button63_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "3";
        }

        private void button59_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "4";
        }

        private void button64_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "5";
        }

        private void button65_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "6";
        }

        private void button60_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "7";
        }

        private void button51_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "8";
        }

        private void button52_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "9";
        }

        private void button61_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "10";
        }

        private void button53_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "11";
        }

        private void button54_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "12";
        }

        private void button55_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "13";
        }

        private void button46_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "14";
        }

        private void button44_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "15";
        }

        private void button57_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "16";
        }

        private void button47_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "17";
        }

        private void button48_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "18";
        }

        private void button58_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "19";
        }

        private void button49_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "20";
        }

        private void button50_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "21";
        }

        private void button56_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "22";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "23";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "24";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "25";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "26";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "27";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TxtFıyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void MskYolcuTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
