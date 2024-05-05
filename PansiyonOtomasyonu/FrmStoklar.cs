using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PansiyonOtomasyonu
{
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=FATMA;Initial Catalog=\"UZAY PANSİYON\";Integrated Security=True;Encrypt=False");
       private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gıda"].ToString();
                ekle.SubItems.Add(oku["İçecek"].ToString());
                ekle.SubItems.Add(oku["Atıştırmalık"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Faturalar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Elektrik"].ToString();
                ekle.SubItems.Add(oku["Su"].ToString());
                ekle.SubItems.Add(oku["İnternet"].ToString());
                listView2.Items.Add(ekle);

            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar(Gıda,İçecek,Atıştırmalık) values('" + textBoxGıda.Text + "','" + textBoxİcecek.Text + "','" + textBoxAtistirmalik.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

         private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Faturalar(Elektrik,Su,İnternet) values('" + textBoxelektrik.Text + "','" + textBoxSu.Text + "','" + textBoxİnternet.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler2();
        }
    }
}
