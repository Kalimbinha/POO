//using System;

//namespace Classess.Lista_1
//{
//    internal class Funcionarios
//    {
//        public string nome;
//        public string CPF;
//        public int salario;
//        public int salarioLiquido;

//        public void CalcularSalarioLiquido()
//        {
//            double desconto = 0;

//            if (salario <= 2000)
//            {
//                desconto = 0;
//            }
//            else if (salario <= 3000)
//            {
//                desconto = salario * 0.075;
//            }
//            else if (salario <= 4000)
//            {
//                desconto = salario * 0.15;
//            }
//            else if (salario <= 5000)
//            {
//                desconto = salario * 0.225;
//            }
//            else
//            {
//                desconto = salario * 0.275;
//            }

//            salarioLiquido = (int)(salario - desconto); 
//        }
//    }
//}
