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
    public partial class BiletIptal : Form
    {
        public BiletIptal()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=BusTicket;Integrated Security=True");

        void biletListesi()
        {
            SqlDataAdapter da=new SqlDataAdapter("SELECT * FROM TableVoyageDetail", baglanti);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            biletListesi();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != String.Empty)
            {

                baglanti.Open();

                SqlCommand cmdsil = new SqlCommand("DELETE FROM TableVoyageDetail WHERE BILETID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);

                cmdsil.ExecuteNonQuery();

                Form11_Load(sender, e);

                if (radioButton1.Checked == true) {
                    MessageBox.Show("Bilet iptali başarılı şekilde kaydedildi . Ücreti nakit olarak iade ediniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    YetkiliMenu yetkili = new YetkiliMenu();
                    yetkili.Show();
                    this.Hide();
                }
                if (radioButton2.Checked == true) {
                    
                    BiletİptalHavale b=new BiletİptalHavale();
                    b.Show();
                    this.Hide();
                }

                

                baglanti.Close();
            } else {
                MessageBox.Show("Bilet ID Giriniz .", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YetkiliMenu frm7= new YetkiliMenu();
            frm7.Show();
            this.Hide();
        }

   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TableVoyageDetail WHERE BILETID like '"+textBox1.Text +"%'or YOLCUTC like '"+textBox1.Text+"%'", baglanti);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            dataGridView1.DataSource = dt2;
            baglanti.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
