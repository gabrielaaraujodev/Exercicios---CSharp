using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class Exercicio9
    {
        static void Main(string[] args)
        {
            int contador;
            int value;
            int contImpar = 0;

            Console.WriteLine("Quatas vezes você quer repetir a sequência: ");
            var cont = int.Parse(Console.ReadLine());

            if (cont <= 0)
            {
                Console.WriteLine("Valor Incorreto !");
            } else
            {
                for(contador = cont; contador <= 10; contador++)
                {
                    Console.WriteLine("Informe um número: ");
                    value = int.Parse(Console.ReadLine());

                    if (value % 2 != 0)
                    {
                        contImpar++;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine(contImpar);
            Console.ReadLine();
        }
    }
}
