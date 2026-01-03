namespace Entities
{
    class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }

        public Livro()
        {

        }
        public Livro(string titulo, string autor, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
        }

        public override string ToString()
        {
            return Titulo;
        }
    }
}
