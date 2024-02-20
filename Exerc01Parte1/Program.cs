namespace Exerc01Parte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo(5);

            double area = circulo.calculararea();
            Console.WriteLine("Area do circulo: " + area);

            double perimetro = circulo.calcularperimetro();
            Console.WriteLine("Perimetro do circulo: " + perimetro);


            Console.ReadLine();
        }
    }
}
