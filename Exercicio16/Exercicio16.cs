using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio16
{
    internal class Exercicio16
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("informe um número: ");
            number = int.Parse(Console.ReadLine());

            while (number < 0 || number % 2 == 0)
            {
                Console.WriteLine("informe um número: ");
                number = int.Parse(Console.ReadLine());
            }

            do
            {
                Console.Write(number + " ");
                number = number - 2;
            } while (number >= 1);

            Console.ReadLine();
        }
    }
}
