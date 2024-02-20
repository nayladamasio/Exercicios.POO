using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc03Parte1
{
    internal class Retangulo
    {
        private double largura;
        private double altura;

        public Retangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public double calculararea()
        {
            return largura * altura;
        }

        public double calcularperimetro()
        {
            return 2 * (largura + altura);
        }
    }
}
