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
            Funcionario F1 = new Funcionario("Pedro", "Fonsceca", 1);
            Funcionario F2 = new Funcionario("Fernando", "Barreto", 2);

            F1.ImprimirFuncionario();
            F2.ImprimirFuncionario();
        }
    }
}
