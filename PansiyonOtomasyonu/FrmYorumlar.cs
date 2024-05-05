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

namespace PansiyonOtomasyonu
{
    public partial class FrmYorumlar : Form
    {
        public FrmYorumlar()
        {
            InitializeComponent();
        }
        // lokaldeki veri tabanını dışa açma, sunucu gibi kullanma vb

        // veritabanını x oluşturdu. bana da veritabanını üreten scripti gönderdi. ben de lokal sunucumda onu çalıştırıp veritabanını oluş
        SqlConnection baglanti = new SqlConnection("Data Source = FATMA; Initial Catalog = UZAY PANSİYON; Integrated Security = True; Encrypt=False");

        private void verilergoster()
        {
            listView1.Items.Clear();//her çağırdığında temizle

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MüşteriYorumları ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesajid"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
                

                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MüşteriYorumları(AdSoyad,Mesaj) values('" + textBox1.Text + "','" + richTextBox1.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        private void FrmYorumlar_Load(object sender, EventArgs e)
        {
            verilergoster();
        }
        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text =listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
