using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPim.Model
{
    public class UserRepo
    {
        private string connectionString;

        public UserRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public bool AutenticaUsu(string email, string senha)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM usuarios WHERE email = @email AND senha = @senha AND ativo = 1";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    using SqlDataReader reader = cmd.ExecuteReader();
                    {
                        if (reader.Read())
                        {
                            int administrador = Convert.ToInt32(reader["administrador"]);

                            if (administrador == 1)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
                return false;
                
            }
        }
    }
}