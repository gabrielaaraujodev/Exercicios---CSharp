using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    internal class Exercicio13
    {
        static void Main(string[] args)
        {
            int number;
            int cont = 0;

            Console.WriteLine("Informe um número: ");
            number = int.Parse(Console.ReadLine());

            while (number < 0 || number % 2 != 0)
            {
                Console.WriteLine("Informe um número: ");
                number = int.Parse(Console.ReadLine());
            }

            do
            {
                Console.Write(cont + " ");
                cont = cont + 2;
            }while(cont <= number);

            Console.ReadLine();
        }
    }
}
