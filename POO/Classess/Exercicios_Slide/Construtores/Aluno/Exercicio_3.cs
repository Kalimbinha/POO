//Exercício 3
//• Crie uma classe Aluno, com o nome do aluno e sua nota
//• Crie uma array com 10 posições, mas crie apenas 9 instâncias de aluno 
//dentro dela (deixando uma das posições vazias)
//• Calcule a média das notas dos alunos. Lembre-se de evitar que seja gerado 
//um erro ao acessar uma instância nula de aluno

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classess.Exercicios_Slide.Construtores.Aluno
{
    internal class Exercicio_3
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[10]
               {
                new Aluno("Ana", 8.5),
                new Aluno("Bruno", 7.2),
                new Aluno("Carlos", 6.8),
                new Aluno("Daniela", 9.0),
                new Aluno("Eduardo", 5.5),
                new Aluno("Fernanda", 7.8),
                new Aluno("Gabriel", 8.1),
                new Aluno("Helena", 9.5),
                new Aluno("Igor", 6.3),
                null
               };

            double somaNotas = 0;
            int quantidadeAlunos = 0;

            // Percorrendo o array e ignorando posições nulas
            foreach (var aluno in alunos)
            {
                if (aluno != null)
                {
                    somaNotas += aluno.Nota;
                    quantidadeAlunos++;
                }
            }

            // Calculando a média
            double media = (quantidadeAlunos > 0) ? (somaNotas / quantidadeAlunos) : 0;

            Console.WriteLine($"A média das notas dos alunos é: {media:F2}");
            Console.ReadKey();
        }
    }
}
