using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Exercicio6
    {
        static void Main(string[] args)
        {
            int cont;
            double soma = 0;

            for(cont = 1; cont <= 10; cont++)
            {
                Console.WriteLine("Informe um número: ");
                var value = double.Parse(Console.ReadLine());

                soma = soma + value;
            }

            Console.WriteLine("A média é: " + soma / 10);
            Console.ReadLine();
        }
    }
}
