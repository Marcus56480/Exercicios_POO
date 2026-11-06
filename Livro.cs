namespace Exercicio_POO
{
    public class Livro 
    {
        public string? Nome { get; set; }
        public string? Autor { get; set; }
        public int numeroPaginas { get; set; }

        public Livro()
        {
            Nome = "Não Informado";
            Autor = "Não Informado";
            numeroPaginas = 0;
        }

        public Livro(string? Titulo)
        {
            Nome = Titulo;
        }

        public Livro(string? Titulo, string? autor)
        {
            Nome = Titulo;
            Autor = autor;
        }

        public Livro(string? Titulo, string? autor, int numPaginas)
        {
            Nome = Titulo;
            Autor = autor;
            numeroPaginas = numPaginas;
        }


    }
}