using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício6
{
    internal class Exercicio6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o 1º número: ");
            var firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º número: ");
            var secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("o número " + firstNumber + " é o maior deles.");
                Console.WriteLine("A diferença entre eles é: " + (firstNumber - secondNumber));
            } else if (secondNumber > firstNumber)
            {
                Console.WriteLine("o número " + secondNumber + " é o maior deles.");
                Console.WriteLine("A diferença entre eles é: " + (secondNumber - firstNumber));
            } else
            {
                Console.WriteLine("Os números são iguais");
                Console.WriteLine("A diferença entre eles é: " + (secondNumber - firstNumber));
            }

            Console.ReadLine();
        }
    }
}
