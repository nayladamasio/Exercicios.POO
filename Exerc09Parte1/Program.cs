namespace Exerc09Parte1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Paciente paciente1 = new Paciente("Pedro", 32);
            paciente1.AdicionarConsulta("Consulta Clinico Geral - 04/02/2024");
            paciente1.AdicionarConsulta("Consulta Clinico Geral - 09/04/2024");
            paciente1.AdicionarConsulta("Consulta Clinico Geral - 25/06/2024");
            paciente1.ExibirConsulta();

            Paciente paciente2 = new Paciente("Joao", 24);
            paciente2.AdicionarConsulta("Consulta Dermatologista - 06/08/2024");
            paciente2.AdicionarConsulta("Consulta Clinico Geral - 24/11/2024");
            paciente2.AdicionarConsulta("Consulta Dermatologista - 18/12/2024");
            paciente2.ExibirConsulta();
        }
    }
}
