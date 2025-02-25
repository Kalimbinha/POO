//Exercício 3
//• Faça um programa que simula a movimentação de um carro.
//• Toda vez que o carro acelerar, aumente sua velocidade
//• Toda vez que o carro frear, diminua sua velocidade
//• Crie diferentes tipos de instâncias de carros
//• Os carros devem acelerar em velocidades diferentes
//• Se um carro ultrapassar o limite de 80 Km/h, deve ser impresso uma multa
//de R$ 5 para cada km excedido, apresentando a placa do carro, o modelo, e
//sua cor

//using System;

//namespace Classess.Exercicios_Slide
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int contVermelho = 0, contVerde = 0, contAzul = 0;

//            Carros carro = new Carros();

//            Random rnd = new Random();

//            Dictionary<int, Action> actions = new Dictionary<int, Action>
//            {
//               { 0, () => { carro.cor = "vermelho"; contVermelho++; } },
//               { 1, () => { carro.cor = "verde"; contVerde++; } },
//               { 2, () => { carro.cor = "azul"; contAzul++; } }
//            };

//            for (int i = 0; i < 1000; i++)
//            {

//                int valor = rnd.Next(3);

//                actions[valor]();

//                Console.WriteLine(carro.cor);
//            }

//            Console.WriteLine($"O número de vermelhos é: {contVermelho}, de verdes: {contVerde}, e de azuis: {contAzul}");
//        }
//    }
//}
