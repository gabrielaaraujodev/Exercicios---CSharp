using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio20
{
    internal class Exercicio20
    {
        static void Main(string[] args)
        {
            int number;
            int cont;
            int contPar = 0;
            Console.WriteLine("Informe um número: ");
            number = int.Parse(Console.ReadLine());

            for(cont = 1; cont <= number; cont++)
            {
                if (cont % 2 == 0)
                {
                    contPar++;
                }

                if (cont == 1000)
                {
                    Console.ReadLine(); 
                }
            }


            Console.WriteLine("Foram digitador " + number + " números");

            Console.WriteLine("A quantidade de números pares é: " +  contPar);

            Console.ReadLine();
        }
    }
}
