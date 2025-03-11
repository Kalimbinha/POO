using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classess.Exercicios_Slide
{
    internal class Carros
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public int Velocidade { get; set; }
        public string Placa { get; set; }
        public int Marcha { get; set; } // A marcha atual do carro

        public Carros()
        {
            // Inicializa com marcha 1
            Marcha = 1;
        }

        public void Acelerar()
        {
            Velocidade += 5; // Acelera 5 km/h por vez
            Console.WriteLine($"Velocidade: {Velocidade} KM/h");
        }

        public void Desacelerar()
        {
            Velocidade -= 5; // Desacelera 5 km/h por vez, mas não pode ir abaixo de 0
            if (Velocidade < 0) Velocidade = 0;
            Console.WriteLine($"Velocidade: {Velocidade} KM/h");
        }

        public void VerificarMudancaDeMarcha()
        {
            // A cada 20 KM/h, verificar se é necessário mudar de marcha
            if (Velocidade >= 20 * Marcha)
            {
                if (Marcha > 1 && Velocidade <= 20 * Marcha)
                {
                    // Se a velocidade for menor que o valor correspondente à marcha anterior, diminui a marcha
                    Marcha--;
                    Console.WriteLine($"Mudando para a marcha {Marcha}.");
                }
                else if (Marcha < 5 && Velocidade >= 20 * (Marcha + 1))
                {
                    // Se a velocidade atingir a condição para subir uma marcha
                    Marcha++;
                    Console.WriteLine($"Mudando para a marcha {Marcha}.");
                }
                
               
                Console.WriteLine($"A marcha {Marcha} está adequada para a velocidade {Velocidade}.");
                
            }
        }
    }
 }


