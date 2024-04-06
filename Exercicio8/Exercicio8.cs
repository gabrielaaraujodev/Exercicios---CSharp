using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class Exercicio8
    {
        static void Main(string[] args)
        {
            int cont;

            double value;
            double maiorNum;
            double menorNum;

            Console.WriteLine("Informe um número: ");
            value = double.Parse(Console.ReadLine()); 

            maiorNum  = value;
            //7         //7
            menorNum = value; 
            //7        //7

            for(cont = 1; cont < 10; cont++)
            {
                Console.WriteLine("Informe um número: ");
                value = double.Parse(Console.ReadLine());
                // 5

                if (maiorNum < value)
                    //7        // 5
                {
                    maiorNum = value;
                }

                if (menorNum > value)
                    // 7       // 5
                {
                    menorNum = value;
                }
            }

            Console.WriteLine("O maior número da sequência é: " + maiorNum);
            Console.WriteLine("O menor número da sequência é: " + menorNum);

            Console.ReadLine();
        }
    }
}
