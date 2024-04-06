using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    internal class Exercicio12
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Informe um número: ");
            number = int.Parse(Console.ReadLine());

            while(number < 0)
            {
                Console.WriteLine("Informe um número: ");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            do
            {
                Console.Write(number + " ");
                number--;
            }while(number >= 0);

            Console.ReadLine();
        }

    }
}
