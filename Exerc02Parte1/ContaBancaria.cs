using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc02Parte1
{
    internal class ContaBancaria
    {

        private int numeroconta;
        private string nometitular;
        private double saldo;

        public ContaBancaria(int numeroconta, string nometitular, double saldo)
        {
            this.numeroconta = numeroconta;
            this.nometitular = nometitular;
            this.saldo = saldo;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Deposito de {valor} realizado com sucesso. Novo saldo: {saldo}");
            }
            else
            {
                Console.WriteLine("O valor do deposito deve ser maior que zero.");
            }

        }

        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso. Novo saldo: {saldo}");
            }
            else if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser maior que zero.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
        }

        public double consultarsaldo()
        {
            return saldo;
        }
    }
}
