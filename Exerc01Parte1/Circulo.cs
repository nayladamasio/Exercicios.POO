using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc01Parte1
{
    internal class Circulo
    {
        private double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
        }

        public double calculararea()
        {
            return Math.PI * raio * raio;
        }

        public double calcularperimetro()
        {
            return 2 * Math.PI * raio;
        }

    }
}
