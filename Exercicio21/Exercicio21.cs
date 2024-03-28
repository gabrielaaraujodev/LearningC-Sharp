using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio21
{
    internal class Exercicio21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- Soma de 2 números");
            Console.WriteLine("2- Diferença entre 2 números");
            Console.WriteLine("3- Produto entre 2 números");
            Console.WriteLine("4- Divisão entre 2 números");
            var option = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 1º número: ");
            var firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º número: ");
            var secondValue = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(firstValue + secondValue);
                    break;

                case 2:
                    if (firstValue > secondValue)
                    {
                    Console.WriteLine(firstValue - secondValue);
                    } else
                    {
                        Console.WriteLine(secondValue - firstValue);
                    }
                    break;

                case 3:
                    Console.WriteLine(firstValue * secondValue);
                    break;

                case 4:
                    if (secondValue == 0)
                    {
                        Console.WriteLine("Não pode realizar a divisão !");
                    } else
                    {
                    Console.WriteLine(firstValue/secondValue);
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
