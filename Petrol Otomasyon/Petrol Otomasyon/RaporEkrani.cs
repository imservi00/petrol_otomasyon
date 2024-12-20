using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Petrol_Otomasyon
{
    public partial class RaporEkrani : Form
    {
        private string connectionString = @"Server=DESKTOP-TVLOELV;Database=PetrolOtomasyon;Integrated Security=True";

        public RaporEkrani()
        {
            InitializeComponent();
        }

        private void RaporEkrani_Load(object sender, EventArgs e)
        {
            LoadYakıtTalepleri();
            LoadIslemler();
            LoadSubePerformanslari();
        }

        private void LoadYakıtTalepleri()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM YakıtTalep";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewYakıtTalepleri.DataSource = dt;
            }
        }

        private void LoadIslemler()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Islemler";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewIslemler.DataSource = dt;
            }
        }

        private void LoadSubePerformanslari()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT s.SubeAdi, COUNT(i.IslemID) AS ToplamIslem, SUM(i.Miktar) AS ToplamMiktar
                FROM Subeler s
                LEFT JOIN Islemler i ON s.SubeID = i.SubeID
                GROUP BY s.SubeAdi";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSubePerformans.DataSource = dt;
            }
        }
    }
}
