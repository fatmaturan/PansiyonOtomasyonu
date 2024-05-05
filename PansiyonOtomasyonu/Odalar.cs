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
    public partial class Odalar : Form
    {
        

        public Odalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=FATMA;Initial Catalog=\"UZAY PANSİYON\";Integrated Security=True;Encrypt=False");

        private void button101_Click(object sender, EventArgs e)
        {

        }

        private void Odalar_Load(object sender, EventArgs e)
        {//oda 101
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
                button101.Enabled = false;
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
                button102.Enabled = false;
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
                button103.Enabled = false;
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
                button104.Enabled = false;
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
                button105.Enabled = false;
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
                button106.Enabled = false;
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
                button107.Enabled = false;
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
                button108.Enabled = false;
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
                button109.Enabled = false;
            }

        }
    }
}
