using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio36
{
    internal class Exercicio36
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor da venda: ");
            var trade = double.Parse(Console.ReadLine());

            if (trade >= 1000000)
            {
                Console.WriteLine("Comissão: " + (700 + (0.16 * trade)));
            } else if (trade >= 80000)
            {
                Console.WriteLine("Comissão: " + (650 + (0.14 * trade)));
            } else if (trade >= 60000)
            {
                Console.WriteLine("Comissão: " + (600 + (0.14 * trade)));
            } else if (trade >= 40000)
            {
                Console.WriteLine("Comissão: " + (550 + (0.14 * trade)));
            } else if (trade >= 20000)
            {
                Console.WriteLine("Comissão: " + (500 + (0.14 * trade)));
            } else
            {
                Console.WriteLine("Comissão: " + (400 + (0.14 * trade)));
            }

            Console.ReadLine();
        }
    }
}
