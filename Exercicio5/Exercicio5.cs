using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Exercicio5
    {
        static void Main(string[] args)
        {
            int cont;
            double value;
            double soma = 0;

            for(cont = 1; cont <= 10; cont++)
            {
                Console.WriteLine("Informe um valor: ");
                value = double.Parse(Console.ReadLine());

                soma = soma + value;

            }

            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
