using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=percobaan;User ID=root;Password=;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string id = txtKode.Text;
            string nama = txtNama.Text;

            if (id != "")
            {
                InsertBarang(id, nama);
                bersih();
            }
            else
            {
                MessageBox.Show("ID tidak boleh kosong");
            }
        }

        private void btnGanti_Click(object sender, EventArgs e)
        {
            string id = txtKode.Text;
            string nama = txtNama.Text;

            if (id != "")
            {
                UpdateBarang(id, nama);
                bersih();
            }
            else
            {
                MessageBox.Show("ID tidak boleh kosong");
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string id = txtKode.Text;

            if (id != "")
            {
                DeleteBarang(id);
                bersih();
            }
            else
            {
                MessageBox.Show("ID tidak boleh kosong");
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cek apakah baris yang diklik valid
            if (e.RowIndex >= 0)
            {
                // Ambil baris yang diklik
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Menampilkan data dari baris yang dipilih ke TextBox
                txtKode.Text = row.Cells["idbarang"].Value.ToString();
                txtNama.Text = row.Cells["namabarang"].Value.ToString();
            }
        }

        private void InsertBarang(string id, string nama)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO barang (idbarang, namabarang) VALUES (@id, @nama)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Tersimpan");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // READ
        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM barang";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt; // Bind data ke DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // UPDATE
        private void UpdateBarang(string id, string nama)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE barang SET namabarang = @nama WHERE idbarang = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Terupdate");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // DELETE
        private void DeleteBarang(string id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM barang WHERE idbarang = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Terhapus");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bersih() {
            txtKode.Clear();
            txtNama.Clear();
        }
    }
}
