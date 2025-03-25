//Exercício 1
//• Crie um programa que possui uma classe Funcionario
//• Crie atributos privados para nome, sobrenome e salário mensal
//• Crie um método público que imprime o nome, sobrenome e o salário 
//anual do funcionário
//• Crie duas instâncias de Funcionario, com salários diferentes, e chame o 
//método para impressão de seu salário anual

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classess.Exercicios_Slide.Construtores.Funcionarios
{
    internal class Execicio_1
    {
        static void Main(string[] args)
        {
            Funcionario F1 = new Funcionario("Pedro", "Fonsceca", 2800);
            Funcionario F2 = new Funcionario("Fernando", "Barreto", 1200);

            F1.ImprimirFuncionario();
            F2.ImprimirFuncionario();

            F1.SalarioAnual();
            F2.SalarioAnual();
        }
    }
}
