using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classess.Exercicios_Slide.Construtores.Funcionarios
{
    internal class Funcionario
    {
        private string nome;
        private string sobrenome;
        private int id;

        public string Nome
        {
            get
            {
                return nome;
            }
        }
        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
        }
        public int ID
        {
            get
            {
                return id;
            }
        }

        public Funcionario(string nome, string sobrenome, int id)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.id = id; 
        }

        public void ImprimirFuncionario()
        {
            Console.WriteLine($"{Nome} {Sobrenome} | {ID}");
        }
    }
}
