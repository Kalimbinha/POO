////Implemente um software que simula um jogo de RPG
////• Crie uma classe Personagem, que possui HP, ataque e defesa
////• Um Personagem deve poder atacar um Personagem
////• Ao atacar um personagem, deve-se gerar dano no personagem atacado 
////através da seguinte formula:
////HPatacado = HPatacado - (Ataqueatacante - Defesaatacado)
////• Não deve ser possível atacar um personagem que está com o HP igual ou 
////menor a 0

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Classess.Exercicios_Slide.Encapsulamento.RPG
//{
//    internal class Exercicio_3
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Digite o nome do seu guerreiro: ");
//            string per1 = Console.ReadLine();

//            Console.WriteLine("Digite do guerreiro que vai enfrenta-lo: ");
//            string per2 = Console.ReadLine();


//            Personagem P1 = new Personagem(per1, 100, 30, 10);
//            Personagem P2 = new Personagem(per2, 80, 25, 5);

//            // Exibindo status inicial
//            P1.ExibirStatus();
//            P2.ExibirStatus();

//            Console.WriteLine();

//            // Simulando ataques
//            P1.Atacar(P2);
//            P2.Atacar(P1);

//            Console.WriteLine();

//            // Exibindo status após os ataques
//            P1.ExibirStatus();
//            P2.ExibirStatus();

//            Console.ReadKey();

//        }
//    }
//}
