using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio23
{
    internal class Exercicio23
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um ano: ");
            var year = int.Parse(Console.ReadLine());

            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("Este ano é bissexto !");
            } else
            {
                Console.WriteLine("Este ano não é bissexto !");
            }

            Console.ReadLine();
        }
    }
}
