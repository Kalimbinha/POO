////Exercício 1
////Uma empresa precisa calcular os salários de seus funcionários. Sabe-se que um
////funcionário possui um nome, cpf e salário. Um funcionário também tem seu salário líquido,
////que se baseia no seu salário, descontando impostos, a partir do valor do salário do
////funcionário:
////-Até R$ 2000: sem descontos
////- De R$ 2000,01 a R$ 3000: 7,5 %
////-De R$ 3000,01 a R$ 4000: 15 %
////-De R$ 4000,01 a R$ 5000: 22,5 %
////-Acima de R$ 5000,01: 27,5 %
////A empresa quer poder calcular o total do pagamento no mês. No relatório, deve estar
////contido o pagamento para cada funcionário, incluindo o salário bruto, a quantidade
////descontada, e o salário líquido. No final, deve ser apresentado o total do salário bruto dos
////funcionários, o total descontado, e o total do salário líquido.

//using System;
//using System.Collections.Generic;

//namespace Classess.Lista_1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
           
//            List<Funcionarios> funcionarios = new List<Funcionarios>();

//            funcionarios.Add(new Funcionarios { nome = "Fernando Barreto Silva", CPF = "928.109.283.00", salario = 1200 });
//            funcionarios.Add(new Funcionarios { nome = "Isadora Oliveira Marques", CPF = "928.109.283.00", salario = 2200 });
//            funcionarios.Add(new Funcionarios { nome = "Pedro Fonseca", CPF = "928.109.283.00", salario = 3200 });
//            funcionarios.Add(new Funcionarios { nome = "William Takarashi", CPF = "928.109.283.00", salario = 4200 });
//            funcionarios.Add(new Funcionarios { nome = "Felipe Souza", CPF = "928.109.283.00", salario = 5200 });

//            double totalSalarioBruto = 0,totalDescontado = 0,totalSalarioLiquido = 0;

//            foreach (var funcionario in funcionarios)
//            {
                
//                funcionario.CalcularSalarioLiquido();
//                double desconto = funcionario.salario - funcionario.salarioLiquido;

//                totalSalarioBruto += funcionario.salario;
//                totalDescontado += desconto;
//                totalSalarioLiquido += funcionario.salarioLiquido;

//                Console.WriteLine($"Nome: {funcionario.nome}");
//                Console.WriteLine($"CPF: {funcionario.CPF}");
//                Console.WriteLine($"Salário Bruto: R$ {funcionario.salario:F2}");
//                Console.WriteLine($"Desconto: R$ {desconto:F2}");
//                Console.WriteLine($"Salário Líquido: R$ {funcionario.salarioLiquido:F2}");

//            }

//            Console.WriteLine($"Total Salário Bruto: R$ {totalSalarioBruto:F2}");
//            Console.WriteLine($"Total Descontado: R$ {totalDescontado:F2}");
//            Console.WriteLine($"Total Salário Líquido: R$ {totalSalarioLiquido:F2}");
//        }
//    }
//}


