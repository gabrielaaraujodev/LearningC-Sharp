using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    internal class Exercicio11
    {
        static void Main(string[] args)
        {
            int digito;
            int soma = 0;

            Console.WriteLine("Informe um número inteiro maior que zero: ");
            var number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("O número deve ser diferente de zero !");
            }
            else
            {
                if (number != 0)
                {
                    while (number > 0)
                    {
                        digito = number % 10;
                        soma = soma + digito;
                        number = number / 10;
                    }
                    Console.WriteLine("A soma dos digitos do número é: " + soma);
                }
                else
                {
                    Console.WriteLine("Número inválido !");
                }
            }
            Console.ReadLine();
        }
    }
}
