using System.Data.SqlClient;

namespace Petrol_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;


            string adminKullaniciAdi = "admin";
            string adminSifre = "admin123";
            string subeYoneticiKullaniciAdi = "subeyonetici";
            string subeYoneticiSifre = "sube456";
            string pompaciKullaniciAdi = "pompaci";
            string pompaciSifre = "pompa789";


            if (kullaniciAdi == adminKullaniciAdi && sifre == adminSifre)
            {

                YöneticiEkrani yöneticiFormu = new YöneticiEkrani();
                yöneticiFormu.Show();
                this.Hide();
            }
            else if (kullaniciAdi == subeYoneticiKullaniciAdi && sifre == subeYoneticiSifre)
            {

                SubeYoneticiEkrani subeFormu = new SubeYoneticiEkrani();
                subeFormu.Show();
                this.Hide();
            }

            else
            {

                MessageBox.Show("Kullanýcý adý veya þifre hatalý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
