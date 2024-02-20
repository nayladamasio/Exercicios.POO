using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc09Parte1
{
    internal class Paciente
    {
        private string Nome { get; set; }
        private int Idade { get; set; }
        private List<string> HistoricoConsultas;

        public Paciente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            HistoricoConsultas = new List<string>();
        }
        public void AdicionarConsulta(string consulta)
        {
            HistoricoConsultas.Add(consulta);
        }

        public void ExibirConsulta()
        {
            if (HistoricoConsultas.Count > 0)
            {
                Console.WriteLine($"Historico de consultas para o paciente {Nome}:");
                for (int i = 0; i < HistoricoConsultas.Count; i++)
                {
                    Console.WriteLine($"Consulta {i + 1}: {HistoricoConsultas[i]}");
                }
            }
            else
            {
                Console.WriteLine("Nao ha consultas registradas para esse paciente.");
            }
        }
    }
}
