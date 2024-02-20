namespace Exerc10Parte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro("A Culpa é das Estrelas", " John Green", 285);
            Livro livro2 = new Livro("Romeu e Julieta", "William Shakespeare", 1452);

            Console.WriteLine("Informações do Livro 1:");
            livro1.InformacoesLivro();

            Console.WriteLine("\nInformações do Livro 2:");
            livro2.InformacoesLivro();

            Console.WriteLine("\nEmprestando o Livro 1...");
            livro1.Emprestarlivro();

            Console.WriteLine("\nVerificando disponibilidade do Livro 1:");
            Console.WriteLine("Está disponível? " + livro1.EstaDisponivel());

            Console.WriteLine("\nDevolvendo o Livro 1...");
            livro1.DevolverLivro();

            Console.WriteLine("\nVerificando disponibilidade do Livro 1 novamente:");
            Console.WriteLine("Está disponível? " + livro1.EstaDisponivel());
        }
    }
}
