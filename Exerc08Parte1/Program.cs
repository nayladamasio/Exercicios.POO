namespace Exerc08Parte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro("Honda", "Civic", 0);

            carro1.Acelerar(60);

            carro1.Imprimirvelocidadeatual();

            carro1.Frear(20);

            carro1.Imprimirvelocidadeatual();

            Console.ReadLine();
        }
    }
}
