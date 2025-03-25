using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Classess.Exercicios_Slide.Construtores.Funcionarios
{
    internal class Funcionario
    {
        private string nome;
        private string sobrenome;
        private int salario;

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
        public int Salario
        {
            get
            {
                return salario;
            }
        }

        public Funcionario(string nome, string sobrenome, int salario)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.salario = salario; 
        }

        public void ImprimirFuncionario()
        {
            Console.WriteLine($"{Nome} {Sobrenome} | {salario} ");
        }

        public void SalarioAnual()
        {
            double salarioAnual = salario * 12;
            Console.WriteLine("Salario anual:" + salarioAnual);
        }
    }
}
