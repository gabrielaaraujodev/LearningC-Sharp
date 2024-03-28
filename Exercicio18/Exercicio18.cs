using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18
{
    internal class Exercicio18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            var option = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 1º valor: ");
            var firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º valor: ");
            var secondValue = double.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Console.WriteLine(firstValue + secondValue);
                    break;

                case 2:
                    Console.WriteLine(firstValue - secondValue);
                    break;

                case 3:
                    Console.WriteLine(firstValue * secondValue);
                    break;

                case 4:
                    if (secondValue == 0)
                    {
                        Console.WriteLine("Operação não pode ser realizada !");
                    } else { 
                    Console.WriteLine(firstValue / secondValue);
                    }
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
