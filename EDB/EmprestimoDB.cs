using Entities;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Configuration;

namespace EDB
{
    class EmprestimoDB
    {
        private string stringConnection = "Server=localhost;Database=biblioteca;Uid=root;Pwd=;";

        public bool LivroDisponivel(int idlivro)
        {

            try
            {
                using(MySqlConnection connection = new MySqlConnection(stringConnection))
                {
                    connection.Open();

                    string sql = "SELECT COUNT(*) FROM EMPRESTIMOS WHERE IDLIVRO = @IDLIVRO AND DATADEVOLUCAO IS NULL";

                    using(MySqlCommand comando = new MySqlCommand(sql, connection))
                    {
                        comando.Parameters.AddWithValue("@IDLIVRO", idlivro);

                        int retorno = Convert.ToInt32(comando.ExecuteScalar());

                        if (retorno == 0)
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
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
                return false;
            }
        }
        public void FazerEmprestimo(int idLivro, int idUsuario)
        {
            if (!LivroDisponivel(idLivro))
            {
                Console.WriteLine("Livro não disponivel para empréstimo!");
            }
            else
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(stringConnection))
                    {
                        connection.Open();

                        string sql = "INSERT INTO EMPRESTIMOS (IDLIVRO, IDUSUARIO, DATAEMPRESTIMO) VALUES (@IDLIVRO, @IDUSUARIO, @DATAEMPRESTIMO)";

                        using(MySqlCommand comando = new MySqlCommand(sql, connection))
                        {
                            comando.Parameters.AddWithValue("@IDLIVRO", idLivro);
                            comando.Parameters.AddWithValue("@IDUSUARIO", idUsuario);
                            comando.Parameters.AddWithValue("@DATAEMPRESTIMO", DateTime.Now);

                            comando.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                }
            }
        }
        
        public void DevolverLivro(int idlivro)
        {
            try 
            {
                using(MySqlConnection connection = new MySqlConnection(stringConnection))
                {
                    connection.Open();

                    string sql = "UPDATE EMPRESTIMOS SET DATADEVOLUCAO = @DATETIME WHERE IDLIVRO = @IDLIVRO AND DATADEVOLUCAO IS NULL";

                    using(MySqlCommand comando = new MySqlCommand(sql, connection))
                    {
                        comando.Parameters.AddWithValue("@DATETIME", DateTime.Now);
                        comando.Parameters.AddWithValue("@IDLIVRO", idlivro);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        public void ListarEmprestimos()
        {
            try
            {
                using(MySqlConnection connection = new MySqlConnection(stringConnection))
                {
                    connection.Open();

                    string sql = "SELECT E.ID AS CDG, L.TITULO, U.NOME " +
                                 "FROM EMPRESTIMOS E " +
                                 "JOIN LIVROS L ON E.IDLIVRO = L.ID " +
                                 "JOIN USUARIOS U ON E.IDUSUARIO = U.ID";

                    using(MySqlCommand comando = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataReader leitor = comando.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                string idemp = leitor["CDG"].ToString();
                                string titulo = leitor["TITULO"].ToString();
                                string nome = leitor["NOME"].ToString();

                                Console.WriteLine($"Empréstimo {idemp} | Livro: {titulo} | Usuario: {nome}");
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
