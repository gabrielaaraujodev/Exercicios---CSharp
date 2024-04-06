using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Exercicio7
    {
        static void Main(string[] args)
        {
            int cont;
            int contPositivos = 0;
            int value;
            int soma = 0;
            for(cont = 1; cont <= 10; cont++)
            {
                Console.WriteLine("Informe um número: ");
                value = int.Parse(Console.ReadLine());

                if (value > 0)
                {
                    soma = soma + value;
                    contPositivos++;
                }

            }
            Console.WriteLine("A média dos positivos é: " + soma / contPositivos);
            Console.ReadLine();
        }
    }
}
