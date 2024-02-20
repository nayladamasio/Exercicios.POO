namespace Exerc03Parte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura = 5;
            double largura = 2;

            Retangulo retangulo = new Retangulo(5, 2);

            double area = retangulo.calculararea();
            double perimetro = retangulo.calcularperimetro();

            Console.WriteLine("A area do retangulo: " + area);
            Console.WriteLine("Perimetro do retangulo: " + perimetro);

            Console.ReadLine();
        }
    }
}
