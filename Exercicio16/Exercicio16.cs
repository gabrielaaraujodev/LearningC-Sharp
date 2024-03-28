using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio16
{
    internal class Exercicio16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            var number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;

                case 2:
                    Console.WriteLine("Fevereiro");
                    break;

                case 3:
                    Console.WriteLine("Março");
                    break;

                case 4:
                    Console.WriteLine("Abril");
                    break;

                case 5:
                    Console.WriteLine("Maio");
                    break;

                case 6:
                    Console.WriteLine("Junho");
                    break;

                case 7:
                    Console.WriteLine("Julho");
                    break;
            }

            Console.ReadLine();
        }
    }
}
