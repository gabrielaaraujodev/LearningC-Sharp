using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio32
{
    internal class Exercicio32
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código do produto: ");
            var code = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade que irá querer do produto: ");
            var amount = int.Parse(Console.ReadLine());

            switch (code)
            {
                case 100:
                    Console.WriteLine("O valor a ser pago será " + (amount * 1.20));
                    break;

                case 101:
                    Console.WriteLine("O valor a ser pago será " + (amount * 1.30));
                    break;

                case 102:
                    Console.WriteLine("O valor a ser pago será " + (amount * 1.50));
                    break;

                case 103:
                    Console.WriteLine("O valor a ser pago será " + (amount * 1.20));
                    break;

                case 104:
                    Console.WriteLine("O valor a ser pago será " + (amount * 1.70));
                    break;

                case 105:
                    Console.WriteLine("O valor a ser pago será " + (amount * 2.20));
                    break;

                case 106:
                    Console.WriteLine("O valor a ser pago será " + (amount * 1.00));
                    break;
            }
            Console.ReadLine();
        }
    }
}
