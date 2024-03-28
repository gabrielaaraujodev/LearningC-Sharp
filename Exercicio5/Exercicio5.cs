using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Exercicio5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            var number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Número PAR !");
            }
            else
            {
                Console.WriteLine("Número IMPAR !");
            }

            Console.ReadLine();
        }
    }
}
