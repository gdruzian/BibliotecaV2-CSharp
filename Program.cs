using MySql.Data.MySqlClient;

namespace BibliotecaV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tela.TelaInicio();
            }
            catch (Exception e)
            {
                Console.WriteLine();
            }
        }
    }
}
