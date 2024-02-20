namespace Exerc05Parte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario("Mateus", 1800, "Analista", 300);

            funcionario.ImprimirDados();

            Console.ReadLine();

        }
    }
}
