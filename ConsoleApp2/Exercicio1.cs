using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Exercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o 1º número: ");
            var numberOne = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º número: ");
            var numberTwo = double.Parse(Console.ReadLine());

            if (numberOne > numberTwo) {
                Console.WriteLine("O Primeiro número é maior que o segundo");
            }
            else if (numberOne < numberTwo) { 
                Console.WriteLine("O segundo número é maior que o primeiro");
            }
            else
            {
                Console.WriteLine("Os números são iguas !");
            }
            Console.ReadLine();
        }
    }
}
