using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Exercicio2
    {
        static void Main(string[] args)
        {
            int sequence = 1;

            for (sequence = 1; sequence <= 100; sequence++)
            {
                Console.WriteLine(sequence);
            }

            while (sequence <= 100)
            {
                Console.WriteLine(sequence);
                sequence++;
            }

            do
            {
                Console.WriteLine(sequence);
                sequence++;
            } while (sequence <= 100);

            Console.ReadLine();
        }
    }
}
