using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio40
{
    internal class Exercicio40
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o custo de fábrica do veículo: ");
            var value = double.Parse(Console.ReadLine());   

            if (value <= 12000)
            {
                Console.WriteLine("O custo total ao consumidor será: " + (value * 0.05));
            } else if (value <= 25000)
            {
                Console.WriteLine("O custo total ao consumidor será: " + (value * 0.1 * 0.15));
            } else
            {
                Console.WriteLine("O custo total ao consumidor será: " + (value * 0.15 * 0.2));
            }

            Console.ReadLine();
        }
    }
}
