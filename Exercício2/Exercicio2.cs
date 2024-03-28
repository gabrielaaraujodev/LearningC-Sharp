using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2
{
    internal class Exercicio2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            var number = double.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine(Math.Sqrt(number));
            }
            else
            {
                Console.WriteLine("Número Inválido !");
            }

            Console.ReadLine();
        }
    }
}
