using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    internal class Exercicio12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            var number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Número inválido !");
            }
            else
            {
                Console.WriteLine(Math.Log(number));
            }

            Console.ReadLine();
        }
    }
}
