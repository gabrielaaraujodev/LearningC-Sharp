using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio30
{
    internal class Exercicio30
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o 1º número: ");
            var firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º número: ");
            var secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 3º número: ");
            var thirdNumber = double.Parse(Console.ReadLine());

            if ( firstNumber > secondNumber && secondNumber > thirdNumber )
            {
                Console.WriteLine(firstNumber + secondNumber + thirdNumber);
            } else if (firstNumber > secondNumber && thirdNumber > secondNumber )
            {
                Console.WriteLine(firstNumber + thirdNumber + secondNumber);
            } else if (secondNumber > firstNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine(secondNumber + firstNumber + thirdNumber);
            } else if (secondNumber > firstNumber && thirdNumber > firstNumber)
            {
                Console.WriteLine(secondNumber + thirdNumber + firstNumber);
            } else if ( thirdNumber > firstNumber && firstNumber > secondNumber )
            {
                Console.WriteLine(thirdNumber + firstNumber + secondNumber);
            } else
            {
                Console.WriteLine(thirdNumber + secondNumber + firstNumber);
            }
            Console.ReadLine();
        }
    }
}
