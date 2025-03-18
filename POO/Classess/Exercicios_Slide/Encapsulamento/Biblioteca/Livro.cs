using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classess.Exercicios_Slide.Encapsulamento.Biblioteca
{
    internal class Livro
    {
        private string Titulo;
        private string Autor;
        private int Ano;

        public string titulo
        {
            get
            {
                return Titulo;
            }
        }

        public string autor
        {
            get
            {
                return Autor;
            }
        }

        public int ano
        {
            get
            {
                return Ano;
            }
        }
    }
}
