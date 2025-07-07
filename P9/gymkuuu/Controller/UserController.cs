using gymkuuu.Models;
using MySql.Data.MySqlClient;

namespace gymkuuu.Controllers
{
    public class LoginController
    {
        private Koneksi koneksi = new Koneksi();

        public bool Login(string email, string password)
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE email = @email AND password = @pw";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@pw", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            return reader.Read(); // true jika login sukses
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kesalahan login: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
