using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PetrolOtomasyonSistemi
{
    public partial class ŞubeYonetimi : Form
    {
        private string connectionString = @"Server=DESKTOP-TVLOELV;Database=PetrolOtomasyon;Integrated Security=True"; 

        public ŞubeYonetimi()
        {
            InitializeComponent();
        }

        
        private void ŞubeYonetimi_Load(object sender, EventArgs e)
        {
            
            LoadSubeler();
        }

        
        private void LoadSubeler()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Subeler";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        
        private void btnSubeEkle_Click(object sender, EventArgs e)
        {
            string subeAdi = txtSubeAdi.Text;
            string sehir = txtSehir.Text;
            string ilce = txtIlce.Text;
            string calisanSayisiText = txtCalisanSayisi.Text;

            
            if (string.IsNullOrEmpty(subeAdi) || string.IsNullOrEmpty(sehir) || string.IsNullOrEmpty(ilce) || string.IsNullOrEmpty(calisanSayisiText))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }

            
            int calisanSayisi;
            bool isInteger = int.TryParse(calisanSayisiText, out calisanSayisi);

            if (!isInteger)
            {
                // Hatalı gırıs
                MessageBox.Show("Çalışan sayısı geçerli bir sayı olmalıdır.");
                Console.WriteLine("Hatalı giriş: " + calisanSayisiText); 
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO Subeler (SubeAdi, Sehir, Ilce, CalisanSayisi) VALUES (@SubeAdi, @Sehir, @Ilce, @CalisanSayisi)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SubeAdi", subeAdi);
                    command.Parameters.AddWithValue("@Sehir", sehir);
                    command.Parameters.AddWithValue("@Ilce", ilce);
                    command.Parameters.AddWithValue("@CalisanSayisi", calisanSayisi); 

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Şube başarıyla eklendi.");

                    
                    LoadSubeler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        // sube sılme ıslemı
        private void btnSubeSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string subeId = dataGridView1.SelectedRows[0].Cells["SubeID"].Value.ToString(); 

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        string query = "DELETE FROM Subeler WHERE SubeID = @SubeID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SubeID", subeId);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Şube başarıyla silindi.");

                        
                        LoadSubeler();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silinecek şube seçilmedi.");
            }
        }

        // sube gun. metd.
        private void btnSubeGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string subeId = dataGridView1.SelectedRows[0].Cells["SubeID"].Value.ToString(); 
                string subeAdi = txtSubeAdi.Text;
                string sehir = txtSehir.Text;
                string ilce = txtIlce.Text;
                string calisanSayisiText = txtCalisanSayisi.Text;

                
                if (string.IsNullOrEmpty(subeAdi) || string.IsNullOrEmpty(sehir) || string.IsNullOrEmpty(ilce) || string.IsNullOrEmpty(calisanSayisiText))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!");
                    return;
                }

                
                int calisanSayisi;
                if (!int.TryParse(calisanSayisiText, out calisanSayisi))
                {
                    MessageBox.Show("Çalışan sayısı geçerli bir sayı olmalıdır.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        string query = "UPDATE Subeler SET SubeAdi = @SubeAdi, Sehir = @Sehir, Ilce = @Ilce, CalisanSayisi = @CalisanSayisi WHERE SubeID = @SubeID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SubeAdi", subeAdi);
                        command.Parameters.AddWithValue("@Sehir", sehir);
                        command.Parameters.AddWithValue("@Ilce", ilce);
                        command.Parameters.AddWithValue("@CalisanSayisi", calisanSayisi); 
                        command.Parameters.AddWithValue("@SubeID", subeId);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Şube başarıyla güncellendi.");

                        
                        LoadSubeler();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Güncellenecek şube seçilmedi.");
            }
        }
    }
}
