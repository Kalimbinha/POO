////Exercício 4
////• Usando o exercício 3, adicione a possibilidade de mudar de marcha no carro
////• Um carro comum só pode ter 5 marchas (vamos ignorar a ré)
////• a cada 20 Km/h em sua velocidade, deve ser avisado que é necessário
////mudar de marcha
////• Deve ser necessário avançar de marcha progressivamente (só deve ser
////possível ir da 1 para a 2, e nunca da 1 para a 3, por exemplo)
////• Reflita sobre as possibilidades e limites do programa, além das
////responsabilidades de métodos e classes

//using System;
//using System.Collections.Generic;

//namespace Classess.Exercicios_Slide
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Criação de uma instância de carros
//            Carros carro = new Carros();

//            // Menu de seleção de carro
//            Console.WriteLine("Selecione o Número do carro que você deseja utilizar: ");
//            Console.WriteLine("1 - Ferrari, vermelha, 33KM");
//            Console.WriteLine("2 - Kwid, verde, 1KM");
//            Console.WriteLine("3 - Fusca, azul, 5KM");

//            // Dicionário com as ações para cada carro
//            Dictionary<int, Tuple<Action, Action, Action, Action>> actions = new Dictionary<int, Tuple<Action, Action, Action, Action>>()
//            {
//                { 1, Tuple.Create(
//                    new Action(() => { carro.Cor = "vermelha"; }),
//                    new Action(() => { carro.Nome = "Ferrari"; }),
//                    new Action(() => { carro.Velocidade = 33; }),
//                    new Action(() => { carro.Placa = "ABC-1234"; })
//                )},

//                { 2, Tuple.Create(
//                    new Action(() => { carro.Cor = "verde"; }),
//                    new Action(() => { carro.Nome = "Kwid"; }),
//                    new Action(() => { carro.Velocidade = 1; }),
//                    new Action(() => { carro.Placa = "XYZ-5678"; })
//                )},

//                { 3, Tuple.Create(
//                    new Action(() => { carro.Cor = "azul"; }),
//                    new Action(() => { carro.Nome = "Fusca"; }),
//                    new Action(() => { carro.Velocidade = 5; }),
//                    new Action(() => { carro.Placa = "DEF-9101"; })
//                )}
//            };

//            // Solicita a seleção do carro
//            int selectedCar = int.Parse(Console.ReadLine());
//            var selectedActions = actions[selectedCar];

//            // Executa as ações do carro selecionado
//            selectedActions.Item1(); // Definir cor
//            selectedActions.Item2(); // Definir nome
//            selectedActions.Item3(); // Definir velocidade inicial
//            selectedActions.Item4(); // Definir placa do carro

//            Console.WriteLine($"Você escolheu o carro: {carro.Nome}, {carro.Cor}, {carro.Velocidade} KM/h.");

//            Console.WriteLine("Pressione as teclas 'Up' para acelerar e 'Down' para desacelerar.");

//            // Loop para simular aceleração e desaceleração
//            while (true)
//            {
//                var key = Console.ReadKey(intercept: true);
//                Console.Clear();
//                if (key.Key == ConsoleKey.UpArrow)
//                {
//                    Console.WriteLine("Você pressionou a tecla UP.");
//                    carro.Acelerar();
//                }
//                else if (key.Key == ConsoleKey.DownArrow)
//                {
//                    Console.WriteLine("Você pressionou a tecla DOWN.");
//                    carro.Desacelerar();
//                }
//                else if (key.Key == ConsoleKey.Escape)
//                {
//                    break;
//                }

//                // Verifica a necessidade de trocar de marcha
//                carro.VerificarMudancaDeMarcha();

//                // Verifica se a velocidade excedeu o limite de 80 km/h
//                if (carro.Velocidade > 80)
//                {
//                    double multa = (carro.Velocidade - 80) * 5;
//                    Console.WriteLine($"Multa: R${multa:F2} pela velocidade excedente!");
//                    Console.WriteLine($"Carro: {carro.Nome}, Placa: {carro.Placa}, Cor: {carro.Cor}, Velocidade: {carro.Velocidade} KM/h");
//                }
//            }
//        }
//    }

//}


