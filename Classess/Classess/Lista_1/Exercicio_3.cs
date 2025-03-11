//Exercício 2
//A faculdade Canses ainda utiliza papel e caneta para realizar o cálculo do aluno matriculado
//em uma disciplina, e lhe contratou para criar um programa que automatize isso. Porém,
//cada disciplina possui uma nota diferente para aprovação. Enquanto em Algoritmos o aluno
//só precisa da nota 5 para ser aprovado, em Cálculo, o aluno precisa da nota 7.
//Crie um programa onde seja possível cadastrar alunos em uma disciplina. Deve ser
//possível realizar a média da disciplina, e checar se um aluno está aprovado ou não em uma
//determinada disciplina. Garanta que seja possível imprimir uma relação dos nomes dos
//alunos, suas notas na disciplina e se ele está aprovado ou não.

using System;
using System.Collections.Generic;

namespace Classess.Lista_1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Funcionarios> funcionarios = new List<Funcionarios>();

            funcionarios.Add(new Funcionarios { nome = "Fernando Barreto Silva", CPF = "928.109.283.00", salario = 1200 });
            funcionarios.Add(new Funcionarios { nome = "Isadora Oliveira Marques", CPF = "928.109.283.00", salario = 2200 });
            funcionarios.Add(new Funcionarios { nome = "Pedro Fonseca", CPF = "928.109.283.00", salario = 3200 });
            funcionarios.Add(new Funcionarios { nome = "William Takarashi", CPF = "928.109.283.00", salario = 4200 });
            funcionarios.Add(new Funcionarios { nome = "Felipe Souza", CPF = "928.109.283.00", salario = 5200 });

            double totalSalarioBruto = 0, totalDescontado = 0, totalSalarioLiquido = 0;

            foreach (var funcionario in funcionarios)
            {

                funcionario.CalcularSalarioLiquido();
                double desconto = funcionario.salario - funcionario.salarioLiquido;

                totalSalarioBruto += funcionario.salario;
                totalDescontado += desconto;
                totalSalarioLiquido += funcionario.salarioLiquido;

                Console.WriteLine($"Nome: {funcionario.nome}");
                Console.WriteLine($"CPF: {funcionario.CPF}");
                Console.WriteLine($"Salário Bruto: R$ {funcionario.salario:F2}");
                Console.WriteLine($"Desconto: R$ {desconto:F2}");
                Console.WriteLine($"Salário Líquido: R$ {funcionario.salarioLiquido:F2}");

            }

            Console.WriteLine($"Total Salário Bruto: R$ {totalSalarioBruto:F2}");
            Console.WriteLine($"Total Descontado: R$ {totalDescontado:F2}");
            Console.WriteLine($"Total Salário Líquido: R$ {totalSalarioLiquido:F2}");
        }
    }
}