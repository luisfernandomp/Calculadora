using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pjrCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool teste1 = false, teste2 = false;
            string conta = "", op = "", result = "";
            Operacao operar = new Operacao();
            Console.Clear();
            while(teste1 == false){
                teste2 = false;
                Console.WriteLine("----------------------------");
                Console.WriteLine("-         CALCULADORA      -");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Para operações básicas ( +, -, / e) escreva a conta com um espaço entre cada caractere (ex.: 2 + 1), e para fazer a média dos números basta escrevê - los com espaço (ex.: 2 2 2)");
                Console.Write("\nEscreva a conta:  ");
                conta =  Console.ReadLine();
                string[] resultado = conta.Split(' ');
                result = operar.calculadora(resultado);
                Console.WriteLine(result);
                while(teste2 == false){
                    Console.WriteLine("\nQuer realizar outra operação? (Para s - sim, n - não)");
                    op = Console.ReadLine();
                    if(op == "s"){
                        Console.Clear();
                        Console.WriteLine("\nAté logo...");
                        //Thread.Sleep(2000);
                        teste2 = true;
                        teste1 = true;
                    }else{
                        if(op == "n"){
                            teste1 = true;
                        }else{
                            Console.WriteLine("Opção inválida!");
                        }
                    }
                }
               //System.Environment.Exit(0);
            }
        }
    }
}
