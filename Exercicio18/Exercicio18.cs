using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18
{
    internal class Exercicio18
    {
        static void Main(string[] args)
        {
            double number;
            double value;
            int cont;

            double maiorNum;
            int contMaiorNum = 0;

            Console.WriteLine("Informe a quantidade de números que você quer possuir: ");
            number = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe um valor inicial: ");
            value = double.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            maiorNum = value;

            for(cont = 1; cont <= number; cont++)
            {
                Console.WriteLine("Informe um valor: ");
                value = double.Parse(Console.ReadLine());

                if (maiorNum < value)
                {
                    maiorNum = value;
                    contMaiorNum++;
                }
            }

            Console.WriteLine("A quantidade de números lidos foi: " + number);

            Console.WriteLine("O maior número da sequência é: " + maiorNum);

            Console.WriteLine("A quantidade de vezes que o maior número foi lido foi: " + contMaiorNum);

            Console.ReadLine();
        }
    }
}
