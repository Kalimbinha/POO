//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Classess.Exercicios_Slide.Encapsulamento.RPG
//{
//    internal class Personagem
//    {
//        public string Nome { get; private set; }
//        public int HP { get; private set; }
//        public int Ataque { get; private set; }
//        public int Defesa { get; private set; }

//        public Personagem(string nome, int hp, int ataque, int defesa)
//        {
//            Nome = nome;
//            HP = hp;
//            Ataque = ataque;
//            Defesa = defesa;
//        }

//        public void Atacar(Personagem alvo)
//        {
//            if (HP <= 0)
//            {
//                Console.WriteLine($"{Nome} não pode atacar, pois está sem HP!");
//                return;
//            }

//            if (alvo.HP <= 0)
//            {
//                Console.WriteLine($"{alvo.Nome} já está derrotado!");
//                return;
//            }

//            int dano = Ataque - alvo.Defesa;
//            if (dano < 0) dano = 0; 

//            alvo.ReceberDano(dano);

//            Console.WriteLine($"{Nome} atacou {alvo.Nome} causando {dano} de dano!");
//        }

//        private void ReceberDano(int dano)
//        {
//            HP -= dano;
//            if (HP < 0) HP = 0;
//        }

//        public void ExibirStatus()
//        {
//            Console.WriteLine($"{Nome} - HP: {HP} | Ataque: {Ataque} | Defesa: {Defesa}");
//        }
//    }
//}

