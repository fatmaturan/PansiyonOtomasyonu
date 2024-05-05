using System; //Genel .NET sınıflarını içerir, temel veri türleri, dizeler, dosya işlemleri gibi işlevleri sağlar.
using System.Data;// Veri tabanı işlemleri için temel sınıflar içerir
using System.Windows.Forms; //Windows tabanlı uygulamaların oluşturulması ve yönetilmesi için kullanılan bir kütüphanedir, form ve kontrolleri içerir.
using System.Data.SqlClient; //SQL Server veritabanına erişim sağlamak için kullanılan özel bir .NET veri sağlayıcısıdır. 
namespace PansiyonOtomasyonu
{
    public partial class FrmAdminGiriş : Form
    {
        public FrmAdminGiriş()
        {
            InitializeComponent(); //inışılazentkompınent
            //formun tasarım dosyasındaki bileşenlerin yüklenmesi ve başlatılması için gereklidir.
            //Bu constructor, form başlatıldığında çalışır ve genellikle formun başlangıç ayarlarını yapmak için kullanılır.

        }
        SqlConnection baglanti = new SqlConnection("Data Source = FATMA; Initial Catalog = UZAY PANSİYON; Integrated Security = True; Encrypt=False");
        //bir SqlConnection nesnesi oluşturarak bir SQL Server veritabanına bağlanmayı sağlar.
        private void buttonGirişYap_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Veritabanı bağlantısını aç
                baglanti.Open();

                // SQL sorgusunu oluştur
                string sql = "SELECT * FROM AdminGiris WHERE Kullanici=@Kullaniciadi AND Şifre=@Şifresi";

                // Parametreleri oluştur
                SqlParameter prm1 = new SqlParameter("Kullaniciadi", txtKullanıcıAdı.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Şifresi", txtŞifre.Text.Trim());

                // SQL komutunu ve parametrelerini tanımla
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                // Verileri çekmek için bir DataTable oluştur
                DataTable dt = new DataTable();

                // Veritabanından verileri çekmek için SqlDataAdapter kullan
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                // Eğer veri varsa
                if (dt.Rows.Count > 0)
                {
                    // Ana formu oluştur ve göster, mevcut formu gizle
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                    this.Hide();
                }
            }
            // Hata durumunda
            catch (Exception)
            {
                // Hata mesajı göster
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void FrmAdminGiriş_Load(object sender, EventArgs e)
        {

        }
    }
} 

