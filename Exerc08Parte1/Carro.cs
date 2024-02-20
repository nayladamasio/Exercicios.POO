using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc08Parte1
{
    internal class Carro
    {
        public string Marca;
        public string Modelo;
        public int VelocidadeAtual;

        public Carro(string marca, string modelo, int velocidadeAtual)
        {
            Marca = marca;
            Modelo = modelo;
            VelocidadeAtual = velocidadeAtual;
        }

        public void Acelerar(int incremento)
        {
            VelocidadeAtual += incremento;
        }

        public void Frear(int decremento)
        {
            VelocidadeAtual -= decremento;

            if (VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
            }
        }
        public void Imprimirvelocidadeatual()
        {
            Console.WriteLine($"Velocidade atual do {Marca} {Modelo}: {VelocidadeAtual} km/h");
        }

    }
}
