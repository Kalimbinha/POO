using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classess.Exercicios_Slide.Construtores.Aluno
{
    internal class Aluno
    {
        private string nome;
        private double nota;

        public string Nome
        {
            get { return nome; }
        }

        public double Nota
        {
            get { return nota; }
        }

        public Aluno(string nome, double nota)
        {
            this.nome = nome;
            this.nota = nota;
        }

    }
}
