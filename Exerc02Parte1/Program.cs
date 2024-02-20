namespace Exerc02Parte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria(141516, "Ana", 1000);

            Console.WriteLine("Saldo inicial: " + conta.consultarsaldo());

            conta.Depositar(300);
            conta.Sacar(100);
            conta.Sacar(1500);
            conta.Sacar(0);

            Console.WriteLine("Saldo atualizado: " + conta.consultarsaldo());

            Console.ReadLine();
        }
    }
}
