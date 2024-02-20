using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc10Parte1
{
    internal class Livro
    {
        public string Titulo;
        public string Autor;
        public int NumerodePaginas;
        public bool Disponivel;

        public Livro(string titulo, string autor, int numerodePaginas)
        {
            Titulo = titulo;
            Autor = autor;
            NumerodePaginas = numerodePaginas;
            Disponivel = true;
        }

        public void Emprestarlivro()
        {
            if (Disponivel)
            {
                Disponivel = false;
                Console.WriteLine("Livro emprestado com sucesso.");
            }
            else
            {
                Console.WriteLine("O livro nao esta disponivel no momento.");
            }
        }
        public void DevolverLivro()
        {
            Disponivel = true;
            Console.WriteLine("Livro devolvido com sucesso!");

        }
        public bool EstaDisponivel()
        {
            return Disponivel;
        }

        public void InformacoesLivro()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Número de Páginas: " + NumerodePaginas);
            Console.WriteLine("Disponível: " + (Disponivel ? "Sim" : "Não"));

        }
    }
}
