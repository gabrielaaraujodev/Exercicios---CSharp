using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio19
{
    internal class Exercicio19
    {
        static void Main(string[] args)
        {
            int number;
            int unidade;
            int dezena;
            int centena;

            Console.WriteLine("Informe um número entre 100 e 999");
            number = int.Parse(Console.ReadLine());

            while(number < 100 || number > 999)
            {
                Console.WriteLine("Informe um número entre 100 e 999");
                number = int.Parse(Console.ReadLine());
            }
            

            unidade = number % 10;

            number = (number - unidade) / 10;

            dezena = number % 10;

            number = (number - dezena) / 10;

            centena = number;
           

            Console.WriteLine(centena + " " + dezena + " " + unidade);
              


            Console.ReadLine();

        }
    }
}
