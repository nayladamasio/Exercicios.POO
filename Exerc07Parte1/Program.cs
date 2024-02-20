namespace Exerc07Parte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo(5, 2, 6);

            if (triangulo1.Valido())
            {
                Console.WriteLine("E um triangulo valido.");
                Console.WriteLine("Area do triangulo: " + triangulo1.CalcularArea());
            }
            else
            {
                Console.WriteLine("Triangulo invalido.");

            }
        }
    }
}
