using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Exercicio4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            var number = double.Parse(Console.ReadLine());

            if (number > 0) {
                Console.WriteLine(Math.Pow(number,2));
                Console.WriteLine(Math.Sqrt(number));
            }

            Console.ReadLine();
        }
    }
}
