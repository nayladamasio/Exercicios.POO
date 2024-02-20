namespace Exerc06Parte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto("Chapeu", 35.00, 2);

            Console.WriteLine($"Produto: " + produto1.Nomeproduto);
            Console.WriteLine($"Preco: R$" + produto1.Preco);
            Console.WriteLine($"Quantidade Estoque: " + produto1.QuantidadeEstoque);
            Console.WriteLine($"Valor total em estoque: R$" + produto1.ValorTotalEstoque());

            if (produto1.Disponivel())
            {
                Console.WriteLine("Produto Disponivel.");
            }
            else
            {
                Console.WriteLine("Produto Nao Disponivel.");

            }
        }
    }
}
