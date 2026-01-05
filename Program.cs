namespace BibliotecaV2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string opcao = "10";

            do
            {
                try
                {
                    Tela.TelaInicio();

                    opcao = Console.ReadLine();

                    Tela.Opcao(opcao);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                    Console.WriteLine("Pressione enter para voltar");
                    Console.ReadLine();
                }
            } while (opcao != "0");
        }
    }
}
