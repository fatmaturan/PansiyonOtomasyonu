using System;

using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace PansiyonOtomasyonu
{
    public partial class FrmMüşteriler : Form
    {
        public FrmMüşteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=FATMA;Initial Catalog=\"UZAY PANSİYON\";Integrated Security=True;Encrypt=False");
        private void verilergoster()
        {
            listView1.Items.Clear();//her çağırdığında temizle

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MüşteriEkle ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["GirişTarihi"].ToString());
                ekle.SubItems.Add(oku["ÇıkışTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }
        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBoxCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            msdTxtTel.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtKimlikNO.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtÜcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpGiriş.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpÇıkış.Text = listView1.SelectedItems[0].SubItems[10].Text;



        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtOdaNo.Text))
                return;

            baglanti.Open();
            // İlgili odaya ait tablo ismi tablo numarasından üretiliyor.
            SqlCommand komut1 = new SqlCommand($"delete from Oda{TxtOdaNo.Text}", baglanti);
            komut1.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand($"delete from MüşteriEkle where OdaNo = {TxtOdaNo.Text}", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
            //müşteri sildğimizde veri tabanında açtığımız isim soyisim tablosundaki verileri siliyor

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Clear();
            TxtSoyad.Clear();
            comboBoxCinsiyet.Text = "";
            msdTxtTel.Clear();
            TxtMail.Clear();
            TxtKimlikNO.Clear();
            TxtOdaNo.Clear();
            TxtÜcret.Clear();
            dtpGiriş.Text = "";
            dtpÇıkış.Text = "";

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MüşteriEkle set Ad='" + TxtAd.Text + "',Soyad='" + TxtSoyad.Text + "',Cinsiyet='" + comboBoxCinsiyet.Text + "',Telefon='" + msdTxtTel.Text + "',Mail='" + TxtMail.Text + "',TC='" + TxtKimlikNO.Text + "',OdaNo='" + TxtOdaNo.Text + "',Ücret='" + TxtÜcret.Text + "',GirişTarihi='" + dtpGiriş.Value.ToString("yyyy-MM-dd") + "',ÇıkışTarihi='" + dtpÇıkış.Value.ToString("yyyy-MM-dd") + "'where Musteriid=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();//her çağırdığında temizle

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MüşteriEkle where Ad like '%" +textBox1.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["GirişTarihi"].ToString());
                ekle.SubItems.Add(oku["ÇıkışTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }

        private void FrmMüşteriler_Load(object sender, EventArgs e)
        {

        }
    }
    }


