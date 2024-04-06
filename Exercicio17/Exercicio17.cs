using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    internal class Exercicio17
    {
        static void Main(string[] args)
        {
            int number;
            int soma = 0;
            int cont = 0;

            Console.WriteLine("Informe um número: ");
            number = int.Parse(Console.ReadLine());

            while (number < 0) {
                Console.WriteLine("Informe um número: ");
                number = int.Parse(Console.ReadLine());
            }

            do
            {
                soma = soma + cont;
                cont++;
            } while (cont < number);

            Console.WriteLine(" ");

            Console.WriteLine("O valor da soma é: " + soma);

            Console.ReadLine();
        }
    }
}
