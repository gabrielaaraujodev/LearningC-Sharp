using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio28
{
    internal class Exercicio28
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o 1º valor: ");
            var firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º valor: ");
            var secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 3º valor: ");
            var thirNumber = int.Parse(Console.ReadLine());

            if (firstNumber < 0 || secondNumber < 0 || thirNumber < 0)
            {
                Console.WriteLine("Os números não podem ser menores que zero !");
            } else
            {
                Console.WriteLine("Escolha uma média a calcular a partir de sua letra: ");

                Console.WriteLine("a - Geométrica");
                Console.WriteLine("b - Ponderada");
                Console.WriteLine("c - Harmônica");
                Console.WriteLine("d - Aritimética");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "a":
                        Console.WriteLine("O valor da média é: " + Math.Pow(firstNumber*secondNumber*thirNumber, 1/3));
                        break;

                    case "b":
                        Console.WriteLine("O valor da média é: " + (firstNumber + 2 * secondNumber + 3 * thirNumber) / 6);
                        break;

                    case "c":
                        Console.WriteLine("O valor da média é: " + (1 / 1 / firstNumber + 1 / secondNumber + 1 / thirNumber));
                        break;

                    case "d":
                        Console.WriteLine("O valor da média é: " + (firstNumber + secondNumber + thirNumber) / 3);
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
