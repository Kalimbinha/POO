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

        // Método para acelerar
        public void Acelerar()
        {
            Velocidade += 5;
            Console.WriteLine($"Você acelerou! Velocidade atual: {Velocidade} KM/h.");
        }

        // Método para desacelerar
        public void Desacelerar()
        {
            Velocidade -= 5;
            if (Velocidade < 0) Velocidade = 0;
            Console.WriteLine($"Você desacelerou! Velocidade atual: {Velocidade} KM/h.");
        }
    }
}
