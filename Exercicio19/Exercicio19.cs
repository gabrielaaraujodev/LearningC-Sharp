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
            Console.WriteLine("Informe um número: ");
            var number = int.Parse(Console.ReadLine());

            if (number % 3 == 0 || number % 5 == 0)
            {
                Console.WriteLine("É divisível por um dos dois números !");
            }

            Console.ReadLine();
        }
    }
}
