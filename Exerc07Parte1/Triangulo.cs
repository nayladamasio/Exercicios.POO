using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc07Parte1
{
    internal class Triangulo
    {
        public double LadoA;
        public double LadoB;
        public double LadoC;

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        public bool Valido()
        {
            return LadoA + LadoB > LadoC && LadoA + LadoC > LadoB && LadoB + LadoC > LadoA;
        }

        public double CalcularArea()
        {
            double semiPerimetro = (LadoA + LadoB + LadoC) / 2;
            return Math.Sqrt(semiPerimetro * (semiPerimetro - LadoA) * (semiPerimetro - LadoB) * (semiPerimetro - LadoC));
        }
    }
}
