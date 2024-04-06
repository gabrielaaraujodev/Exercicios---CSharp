using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Exercicio4
    {
        static void Main(string[] args)
        {
            int cont;

            for(cont = 0; cont <= 100000; cont = cont + 1000)
            {
                Console.WriteLine(cont);
            }

            Console.ReadLine();
        }
    }
}
