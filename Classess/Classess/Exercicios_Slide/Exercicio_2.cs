//Exercício 2: faça 1000 instâncias de
//carros, e atribua uma cor aleatória
//para cada um (entre vermelho,
//verde e azul). Depois, exiba a
//quantidade de cada uma das cores.

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

//            for (int i = 0; i < 1000; i++) {
                
//                int valor = rnd.Next(3);

//                actions[valor]();

//                Console.WriteLine(carro.cor);
//            }

//            Console.WriteLine($"O número de vermelhos é: {contVermelho}, de verdes: {contVerde}, e de azuis: {contAzul}");
//        }
//    }
//}