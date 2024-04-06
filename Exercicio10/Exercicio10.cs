using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Exercicio10
    {
        static void Main(string[] args)
        {
            int cont;
            int sequence = 0;

            for(cont = 0; cont <= 99; cont = cont + 2)
            {
                Console.WriteLine(sequence);
                sequence = sequence + 2;
            }

            Console.ReadLine();
        }
    }
}
