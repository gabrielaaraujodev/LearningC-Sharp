using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio20
{
    internal class Exercicio20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o 1º valor: ");
            var firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º valor: ");
            var secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 3º valor: ");
            var thirdValue = double.Parse(Console.ReadLine());

            if (firstValue + secondValue > thirdValue && firstValue + thirdValue > secondValue && secondValue + thirdValue > firstValue)
            {
                if ( firstValue == secondValue && secondValue == thirdValue)
                {
                    Console.WriteLine("Equilátero");
                } else if ( firstValue == secondValue || firstValue == thirdValue || secondValue == thirdValue)
                {
                    Console.WriteLine("Isósceles");
                } else
                {
                    Console.WriteLine("Escaleno");
                }
            } else
            {
                Console.WriteLine("Não é um triângulo !");
            }

            Console.ReadLine();
        }
    }
}
