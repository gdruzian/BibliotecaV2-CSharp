namespace BibliotecaV2
{
    class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Usuario()
        {

        }
        public Usuario(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return "["+Id+"] " +  Nome + ", " + Idade + " anos";
        }
    }
}
