//Exercício 1
//• Implemente o software a partir do diagrama de classes especificado
//• Considere que o usuário tem um saldo em sua conta, e dinheiro em sua
//carteira
//• O usuário não deve poder sacar mais dinheiro do que possui em sua conta, e
//não deve poder depositar mais dinheiro do que possui em sua carteira

using System;

namespace Classess.Exercicios_Slide.Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite quando você tem na sua carteira: ");
            int valor = int.Parse(Console.ReadLine());
            Carteira dinheiro = new Carteira(valor);
           
            Conta conta = new Conta(valor);
            Console.WriteLine(conta.Saldo);

            conta.Sacar();

        }
    }
}