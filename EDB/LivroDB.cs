using Entities;
using MySql.Data.MySqlClient;

namespace EDB
{
    class LivroDB
    {
        private static string stringConnection = "Server=localhost;Database=biblioteca;Uid=root;Pwd=;";

        public static void CadastrarLivro(Livro livro)
        {
            try
            {
                using(MySqlConnection connection = new MySqlConnection(stringConnection))
                {
                    connection.Open();

                    string sql = "INSERT INTO LIVROS (Titulo, Autor, Ano) VALUES (@Titulo, @Autor, @Ano)";

                    using(MySqlCommand comando = new MySqlCommand(sql, connection))
                    {
                        comando.Parameters.AddWithValue("@Titulo", livro.Titulo);
                        comando.Parameters.AddWithValue("@Autor", livro.Autor);
                        comando.Parameters.AddWithValue("@Ano", livro.Ano);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        public static void ListarLivros()
        {
            try
            {

                using (MySqlConnection connection = new MySqlConnection(stringConnection))
                {
                    connection.Open();

                    string sql = "SELECT * FROM LIVROS";

                    using(MySqlCommand comando = new MySqlCommand(sql, connection))
                    {
                        using(MySqlDataReader leitor = comando.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                string id = leitor["Id"].ToString();
                                string autor = leitor["Autor"].ToString();
                                string titulo = leitor["Titulo"].ToString();
                                string ano = leitor["Ano"].ToString();

                                Console.WriteLine($"{id} | {titulo} | {autor} | {ano}");
                            }
                        }
                    }

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
