using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício7
{
    internal class Exercicio7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informeo 1º número: ");
            var numberOne = double.Parse(Console.ReadLine());

            Console.WriteLine("Informeo 2º número: ");
            var numberTwo = double.Parse(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                Console.WriteLine("O maior número é: " + numberOne);
            } else if (numberOne < numberTwo)
            {
                Console.WriteLine("O maior número é: " + numberTwo);
            } else
            {
                Console.WriteLine("Números Iguais !");
            }

            Console.ReadLine();
        }
    }
}
