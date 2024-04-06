using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    internal class Exercicio11
    {
        static void Main(string[] args)
        {
            int number;
            int cont = 0;

            Console.WriteLine("Informe um número: ");
            number = int.Parse(Console.ReadLine());

            while (number < 0)
            {
                Console.WriteLine("Infore um número: ");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("");

            do
            {
                Console.Write(cont + " ");
                cont++;
            } while (cont <= number);

            Console.ReadLine();
        }
    }
}
