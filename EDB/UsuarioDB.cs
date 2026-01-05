using Entities;
using MySql.Data.MySqlClient;

namespace EDB
{
    class UsuarioDB
    {
        private static string stringConnection = "Server=localhost;Database=biblioteca;Uid=root;Pwd=;";

        public static void AdicionarUsuario(Usuario usuario)
        {
            try
            {
                using(MySqlConnection connection = new MySqlConnection(stringConnection))
                {
                    connection.Open();

                    string sql = "INSERT INTO USUARIOS (Nome, Idade) VALUES (@Nome, @Idade)";

                    using(MySqlCommand comando = new MySqlCommand(sql, connection))
                    {
                        comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                        comando.Parameters.AddWithValue("@Idade", usuario.Idade);

                        comando.ExecuteNonQuery();
                    }

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        public static void ListarUsuarios()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(stringConnection))
                {
                    connection.Open();

                    string sql = "SELECT * FROM USUARIOS";

                    using (MySqlCommand comando = new MySqlCommand(sql, connection))
                    {

                        using (MySqlDataReader leitor = comando.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                string nome = leitor["Nome"].ToString();
                                string idade = leitor["Idade"].ToString();
                                string id = leitor["Id"].ToString();

                                Console.WriteLine(id + " | " + nome + " | " + idade + " anos");
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

    }
}
