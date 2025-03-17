//Exercício 1
//• Implemente o software a partir do diagrama de classes especificado
//• Considere que o usuário tem um saldo em sua conta, e dinheiro em sua
//carteira
//• O usuário não deve poder sacar mais dinheiro do que possui em sua conta, e
//não deve poder depositar mais dinheiro do que possui em sua carteira

using System;

namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(200);
            Console.WriteLine(conta.Saldo);
            
        }
    }
}