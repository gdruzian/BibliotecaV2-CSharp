using Entities;
using MySql.Data.MySqlClient;

namespace EDB
{
    class EmprestimoDB
    {
        private string stringConnection = "Server=localhost;Database=biblioteca;Uid=root;Pwd=;";

        public void CadastrarEmprestimo(int idLivro, int idUsuario)
        {
            try
            {
                using(MySqlConnection connection = new MySqlConnection(stringConnection))
                {
                    connection.Open();



                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

        }

    }
}
