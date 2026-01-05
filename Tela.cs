using EDB;
using Entities;

namespace BibliotecaV2
{
    public class Tela
    {
        public static void TelaInicio()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("------------BIBLIOTECA------------");
            Console.WriteLine("==================================");
            Console.WriteLine("1- CADASTRAR USUARIO");
            Console.WriteLine("2- CADASTRAR LIVRO");
            Console.WriteLine("3- LISTAR LIVROS");
            Console.WriteLine("4- FAZER EMPRÉSTIMO");
            Console.WriteLine("5- FAZER DEVOLUÇÃO");
            Console.WriteLine("6- LISTAR EMPRESTIMOS");
            Console.WriteLine("7- LISTAR USUARIOS");
            Console.WriteLine("0- SAIR");
            Console.WriteLine("==================================");
            Console.Write("ESCOLHA UMA OPÇÃO: ");
        }

        public static void Opcao(string n)
        {
            switch (n)
            {
                case "0":
                    Console.WriteLine("Finalizando o programa...");
                    return;
                case "1":
                    TelaCadastrarUsuario();
                    break;
                case "2":
                    TelaCadastrarLivro();
                    break;
                case "3":
                    LivroDB.ListarLivros();
                    break;
                case "4":
                    TelaFazerEmprestimo();
                    break;
                case "5":
                    TelaFazerDevolucao();
                    break;
                case "6":
                    EmprestimoDB.ListarEmprestimos();
                    break;
                case "7":
                    UsuarioDB.ListarUsuarios();
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }

        public static void TelaFazerDevolucao()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("==== DEVOLUÇÃO ====");
                Console.Write("ID do Livro: ");
                int id = int.Parse(Console.ReadLine());
                EmprestimoDB.DevolverLivro(id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        public static void TelaFazerEmprestimo()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("==== NOVO EMPRESTIMO ====");
                Console.Write("ID do Usuario: ");
                int idusuario = int.Parse(Console.ReadLine());
                Console.Write("ID do Livro: ");
                int idlivro = int.Parse(Console.ReadLine());

                Emprestimo emprestimo = new Emprestimo(idusuario, idlivro);
                EmprestimoDB.FazerEmprestimo(emprestimo.IdUsuario, emprestimo.IdLivro);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        public static void TelaCadastrarLivro()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("==== NOVO LIVRO ====");
                Console.Write("Titulo: ");
                string titulo = Console.ReadLine();
                Console.Write("Autor: ");
                string autor = Console.ReadLine();
                Console.Write("Ano de publicação: ");
                int ano = int.Parse(Console.ReadLine());

                Livro livro = new Livro(titulo, autor, ano);
                LivroDB.CadastrarLivro(livro);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        public static void TelaCadastrarUsuario()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("==== NOVO USUARIO ====");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                Usuario usuario = new Usuario(nome, idade);
                UsuarioDB.AdicionarUsuario(usuario);
            }catch(Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
