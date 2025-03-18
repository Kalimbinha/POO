using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classess.Exercicios_Slide.Encapsulamento
{
    internal class Conta
    {
        private double saldo;
        

        public double Saldo
        {
            get
            {
                return saldo;
            }
        }

        public void Sacar()
        {
            Console.WriteLine("Quanto você deseja sacar?: ");
            int saque = int.Parse(Console.ReadLine());
            
            if (saque <= saldo)
            {
                saldo -= saque;
                Console.WriteLine("Saque realizado com sucesso :D \n Seu saldo atual é: " + saldo);
            }
            else
            {
                Console.WriteLine("Não foi possivel realizar o seu saque :( \n O valor é maior que o saldo em conta " + saldo);
            }
        }

        public Conta(double saldoInicial)
        {
            Console.Clear();
            Console.WriteLine("Sua conta foi instanciada");
            saldo = 1000;
        }
    }
}
