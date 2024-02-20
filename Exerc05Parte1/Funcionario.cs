using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc05Parte1
{
    internal class Funcionario
    {

        public string Nome { get; set; }
        public double Salario { get; set; }
        public string Cargo { get; set; }

        public double Beneficio { get; set; }

        public Funcionario(string nome, double salario, string cargo, double beneficio)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
            Beneficio = beneficio;
        }

        public double CalcularImpostos()
        {
            return Salario * 0.1;
        }


        public double CalcularSalarioLiquido()
        {
            double salarioLiquido = Salario - CalcularImpostos() + Beneficio;
            return salarioLiquido;
        }


        public void ImprimirDados()
        {
            double salarioLiquido = CalcularSalarioLiquido();
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salario: {Salario}");
            Console.WriteLine($"Beneficio: {Beneficio}");
            Console.WriteLine($"Salario Liquido: {salarioLiquido}");

        }
    }
}
