using System;
using System.Threading;

namespace pjrCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool teste1 = false, teste2;
            string conta = "", op = "", result = "";
            Operacao operar = new Operacao();
            Console.Clear();
            while(teste1 == false){
                Console.Clear();
                teste2 = false;
                Console.WriteLine("----------------------------");
                Console.WriteLine("-       CALCULADORA        -");
                Console.WriteLine("----------------------------");
                Console.WriteLine("\nPara operações básicas ( +, -, / e) escreva a conta com um espaço entre cada caractere e o sinal da operação no meio (ex.: 2 + 1).\nPara fazer a média dos números basta escrevê-los espaçando os caracteres (ex.: 2 2 2)");
                Console.Write("\nEscreva a conta:  ");
                conta =  Console.ReadLine();
                string[] resultado = conta.Split(' ');
                result = operar.calculadora(resultado);
                Console.WriteLine(result);
                while(teste2 == false){
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("\nQuer realizar outra operação? (Para s - sim, n - não)");
                    op = Console.ReadLine();
                    if(op == "s"){
                        teste2 = true;
                    }else{
                        if(op == "n"){
                            Console.Clear();
                            Console.WriteLine("\nAté logo...");
                            Thread.Sleep(1000);
                            teste2 = true;
                            teste1 = true;
                        }else{
                            Console.WriteLine("Opção inválida!");
                        }
                    }
                }
            }
            System.Environment.Exit(0);
        }
    }
}
