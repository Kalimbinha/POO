using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classess.Exercicios_Slide.Construtores.Triangulo
{
    internal class Retangulo
    {
        private double altura;
        private double largura;

        public double Altura
        {
            get
            {
                return altura;
            }
        }

        public double Largura
        {
            get
            {
                return largura;
            }
        }

        public Retangulo(double altura, double largura)
        {
            this.altura = altura;
            this.largura = largura;
        }

        public void Area()
        {
            double area = altura * largura;
            Console.WriteLine("A area é: " + area);
        }

        public void Perimetro()
        {
            double perimetro = 2 * (altura * largura);
            Console.WriteLine("A perimetro é: " + perimetro);
        }

    }
}
