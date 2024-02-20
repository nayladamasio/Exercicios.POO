using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc04Parte1
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public double[] Notas { get; set; }

        public Aluno(string nome, int matricula, double[] notas)
        {
            Nome = nome;
            Matricula = matricula;
            Notas = notas;

        }

        public double CalcularMedia()
        {
            return Notas.Any() ? Notas.Average() : 0;
        }

        public string Verificarsituacao()
        {
            double media = CalcularMedia();
            return media >= 7.0 ? "Aprovado" : "Reprovado";

        }
    }
}
