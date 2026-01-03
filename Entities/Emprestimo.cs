using System.Data;

namespace Entities
{
    class Emprestimo
    {
        public int Id { get; private set; }
        public int IdUsuario { get; private set; }
        public int IdLivro { get; private set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFinal { get; set; }

        public Emprestimo()
        {

        }

        public Emprestimo(int idusuario, int idlivro)
        {
            IdLivro = idlivro;
            IdUsuario = idusuario;
            DataInicio = DateTime.Now;
            DataFinal = null;
        }

    }
}
