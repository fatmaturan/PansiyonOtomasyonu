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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PansiyonOtomasyonu
{
    public partial class FrmGelirFider : Form
    {
        public FrmGelirFider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = FATMA; Initial Catalog = UZAY PANSİYON; Integrated Security = True; Encrypt=False");

     
          

         

        private void FrmGelirFider_Load(object sender, EventArgs e)
        {
            //Kasadaki toplam tutar.
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ücret) as toplam from MüşteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();

            }
            baglanti.Close();
            //Gıdalar

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Gıda) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                LblAlinanUrunler.Text = oku2["toplam2"].ToString();

            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(İçecek) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LblAlinanUrunler2.Text = oku3["toplam3"].ToString();

            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Atıştırmalık) as toplam4 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                LblAlinanUrunler3.Text = oku4["toplam4"].ToString();

            }
            baglanti.Close();

            //Elektrik
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Elektrik) as toplam4 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                LblFaturalar.Text = oku5["toplam4"].ToString();

            }
            baglanti.Close();


            //Su
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select sum(Su) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                LblFaturalar2.Text = oku6["toplam5"].ToString();

            }
            baglanti.Close();



            //Internet
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select sum(İnternet) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                LblFaturalar3.Text = oku7["toplam6"].ToString();

            }
            baglanti.Close();


        }

        private void BtnHesapla_Click_1(object sender, EventArgs e)
        {
            int personel = Convert.ToInt16(textBox1.Text);
            LblPersonelMaas.Text = (personel * 10000).ToString();
            int sonuc = 0;
            sonuc = Convert.ToInt32(LblKasaToplam.Text) -
                (Convert.ToInt32(LblPersonelMaas.Text) +
                Convert.ToInt32(LblAlinanUrunler.Text) +
                Convert.ToInt32(LblAlinanUrunler2.Text) +
                Convert.ToInt32(LblAlinanUrunler3.Text) +
                Convert.ToInt32(LblFaturalar.Text) +
                Convert.ToInt32(LblFaturalar2.Text) +
                Convert.ToInt32(LblFaturalar3.Text));

            LblSonuc.Text = sonuc.ToString();
        }
    }
    }


    

