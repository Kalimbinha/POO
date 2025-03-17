using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
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

        public Conta(double saldoInicial)
        {
            Console.Clear();
            Console.WriteLine("Sua conta foi instanciada");
            saldo = saldoInicial;
        }
    }
}
