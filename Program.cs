using MySql.Data.MySqlClient;

namespace BibliotecaV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringConnection = "Server=localhost;Database=biblioteca;Uid=root;Pwd=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(stringConnection))
                {
                    connection.Open();
                    Console.WriteLine("Conexão aprovada!");
                    Console.WriteLine("Versão: " + connection.ServerVersion);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
