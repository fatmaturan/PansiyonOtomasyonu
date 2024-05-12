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

namespace PansiyonOtomasyonu
{
    public partial class FrmMüsteriEkle : Form
    {
        public FrmMüsteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = FATMA; Initial Catalog = UZAY PANSİYON; Integrated Security = True; Encrypt=False");



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 

            TxtOdaNo.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102(Ad,Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button101_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TxtOdaNo.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda101(Ad,Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button103_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TxtOdaNo.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103(Ad,Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button104_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TxtOdaNo.Text = "104";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104(Ad,Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button105_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TxtOdaNo.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105(Ad,Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button106_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TxtOdaNo.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106(Ad,Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button107_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TxtOdaNo.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107(Ad,Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button108_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TxtOdaNo.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda108(Ad,Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button109_Click(object sender, EventArgs e)
        {// tm olduy
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TxtOdaNo.Text = "109";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109(Ad,Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);// ODALAR KISMINDAKİ GROUPBOXIN BUTTONUNA TIKLAYINCA DİREKT ODA NUMARASI MÜŞTERİ BİLGİSİNE GİRER
            komut.ExecuteNonQuery();
            baglanti.Close();
        }//nasıl sence göz yoruyormu // güzel

        private void buttonDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir");
        }

        private void buttonBoş_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMüsteriEkle_Load(object sender, EventArgs e)
        {
            
            //oda 101
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                button101.Text = oku1["Ad"].ToString() + " " + oku1["Soyad"].ToString();

            }
            baglanti.Close();
            if (button101.Text != "101")
            {
                button101.BackColor = Color.PaleVioletRed;
            }

            //oda102

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                button102.Text = oku2["Ad"].ToString() + " " + oku2["Soyad"].ToString();

            }
            baglanti.Close();
            if (button102.Text != "102")
            {
                button102.BackColor = Color.PaleVioletRed;
            }

            //oda103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                button103.Text = oku3["Ad"].ToString() + " " + oku3["Soyad"].ToString();

            }
            baglanti.Close();
            if (button103.Text != "103")
            {
                button103.BackColor = Color.PaleVioletRed;
            }
            //oda104
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                button104.Text = oku4["Ad"].ToString() + " " + oku4["Soyad"].ToString();

            }
            baglanti.Close();
            if (button104.Text != "104")
            {
                button104.BackColor = Color.PaleVioletRed;
            }
            //oda105
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                button105.Text = oku5["Ad"].ToString() + " " + oku5["Soyad"].ToString();

            }
            baglanti.Close();
            if (button105.Text != "105")
            {
                button105.BackColor = Color.PaleVioletRed;
            }
            //oda106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                button106.Text = oku6["Ad"].ToString() + " " + oku6["Soyad"].ToString();

            }
            baglanti.Close();
            if (button106.Text != "106")
            {
                button106.BackColor = Color.PaleVioletRed;
            }


            //Oda107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                button107.Text = oku7["Ad"].ToString() + " " + oku7["Soyad"].ToString();

            }
            baglanti.Close();
            if (button107.Text != "107")
            {
                button107.BackColor = Color.PaleVioletRed;
            }

            //oda108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                button108.Text = oku8["Ad"].ToString() + " " + oku8["Soyad"].ToString();

            }
            baglanti.Close();
            if (button108.Text != "108")
            {
                button108.BackColor = Color.PaleVioletRed;
            }

            //oda109
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                button109.Text = oku9["Ad"].ToString() + " " + oku9["Soyad"].ToString();

            }
            baglanti.Close();
            if (button109.Text != "109")
            {
                button109.BackColor = Color.PaleVioletRed;
            }

        }


        private void dtpÇıkış_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;

            DateTime KüçükTarih = Convert.ToDateTime(dtpGiriş.Text);
            DateTime BüyükTarih = Convert.ToDateTime(dtpÇıkış.Text);
            TimeSpan Sonuc;
            Sonuc = BüyükTarih - KüçükTarih;
            label1.Text = Sonuc.TotalDays.ToString();
            Ucret = Convert.ToInt32(label1.Text) * 3000;
            TxtÜcret.Text = Ucret.ToString();

        }

        private void buttonKaydet_Click(object sender, EventArgs e)

        {

            // İlgili oda numarası ve tarih aralığı için sorgu yaparak doluluk kontrolü yapılacak
            string odaNo = TxtOdaNo.Text;
            string girisTarihi = dtpGiriş.Value.ToString("yyyy-MM-dd");
            string cikisTarihi = dtpÇıkış.Value.ToString("yyyy-MM-dd");

            baglanti.Open();
            SqlCommand dolulukSorgusu = new SqlCommand("SELECT COUNT(*) FROM MüşteriEkle WHERE OdaNo = @OdaNo AND ((@GirişTarihi BETWEEN GirişTarihi AND ÇıkışTarihi) OR (@ÇıkışTarihi BETWEEN GirişTarihi AND ÇıkışTarihi))", baglanti);
            dolulukSorgusu.Parameters.AddWithValue("@OdaNo", odaNo);
            dolulukSorgusu.Parameters.AddWithValue("@GirişTarihi", girisTarihi);
            dolulukSorgusu.Parameters.AddWithValue("@ÇıkışTarihi", cikisTarihi);

            int dolulukSayisi = (int)dolulukSorgusu.ExecuteScalar();
            baglanti.Close();
        
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text) || string.IsNullOrEmpty(comboBoxCinsiyet.Text) || string.IsNullOrEmpty(msdTxtTel.Text) || string.IsNullOrEmpty(TxtMail.Text) || string.IsNullOrEmpty(TxtKimlikNO.Text) || string.IsNullOrEmpty(TxtOdaNo.Text) || string.IsNullOrEmpty(TxtÜcret.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }//eksik bilgi girilince uyarı verme mesajı
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO MüşteriEkle (Ad, Soyad, Cinsiyet, Telefon, Mail, TC, OdaNo, Ücret, GirişTarihi, ÇıkışTarihi) VALUES (@Ad, @Soyad, @Cinsiyet, @Telefon, @Mail, @TC, @OdaNo, @Ücret, @GirişTarihi, @ÇıkışTarihi)", baglanti);
                komut.Parameters.AddWithValue("@Ad", TxtAd.Text);
                komut.Parameters.AddWithValue("@Soyad", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", comboBoxCinsiyet.Text);
                komut.Parameters.AddWithValue("@Telefon", msdTxtTel.Text);
                komut.Parameters.AddWithValue("@Mail", TxtMail.Text);
                komut.Parameters.AddWithValue("@TC", TxtKimlikNO.Text);
                komut.Parameters.AddWithValue("@OdaNo", TxtOdaNo.Text);
                komut.Parameters.AddWithValue("@Ücret", TxtÜcret.Text);
                komut.Parameters.AddWithValue("@GirişTarihi", dtpGiriş.Value);
                komut.Parameters.AddWithValue("@ÇıkışTarihi", dtpÇıkış.Value);
                //komut.Parameters.AddWithValue(...);: SQL sorgusunda kullanılacak parametreler eklenir.
                //Parametreler, kullanıcı girdileri veya başka kaynaklardan alınan değerleri temsil eder.
                //Bu yöntem, SQL Injection saldırılarına karşı koruma sağlar.

                if (komut.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Müşteri Kaydı Yapıldı");
                }
                else
                {
                    MessageBox.Show("Müşteri Kaydı Yapılamadı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)

        {

        }
    }
}
