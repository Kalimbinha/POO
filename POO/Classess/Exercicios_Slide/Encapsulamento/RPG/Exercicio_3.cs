//Implemente um software que simula um jogo de RPG
//• Crie uma classe Personagem, que possui HP, ataque e defesa
//• Um Personagem deve poder atacar um Personagem
//• Ao atacar um personagem, deve-se gerar dano no personagem atacado 
//através da seguinte formula:
//HPatacado = HPatacado - (Ataqueatacante - Defesaatacado)
//• Não deve ser possível atacar um personagem que está com o HP igual ou 
//menor a 0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classess.Exercicios_Slide.Encapsulamento.RPG
{
    internal class Exercicio_3
    {
        static void Main(string[] args)
        {
            Personagem guerreiro = new Personagem("Guerreiro", 100, 30, 10);
            Personagem mago = new Personagem("Mago", 80, 25, 5);

            // Exibindo status inicial
            guerreiro.ExibirStatus();
            mago.ExibirStatus();

            Console.WriteLine();

            // Simulando ataques
            guerreiro.Atacar(mago);
            mago.Atacar(guerreiro);

            Console.WriteLine();

            // Exibindo status após os ataques
            guerreiro.ExibirStatus();
            mago.ExibirStatus();

            Console.ReadKey();

        }
    }
}
