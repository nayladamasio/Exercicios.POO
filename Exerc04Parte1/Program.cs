namespace Exerc04Parte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Maria", 789, [6.2, 7.8, 9.1]);

            Console.WriteLine($"Nome: {aluno1.Nome}");
            Console.WriteLine($"Matricula: {aluno1.Matricula}");
            Console.WriteLine($"Notas: {string.Join(", ", aluno1.Notas)}");
            Console.WriteLine($"Media: {aluno1.CalcularMedia()}");
            Console.WriteLine($"Situacao: {aluno1.Verificarsituacao()}");

            Console.ReadLine();
        }
    }
}
