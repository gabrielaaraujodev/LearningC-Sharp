using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    internal class Exercicio13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a 1º nota: ");
            var firstGrade = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a 2º nota: ");
            var secondGrade = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a 3º nota: ");
            var thirdGrade = double.Parse(Console.ReadLine());

            var media = (firstGrade + 2*secondGrade + 3*thirdGrade) / 6;
            Console.WriteLine("Sua média é: " + media);

            if (media >= 60)
            {
                Console.WriteLine("Você foi aprovado !");
            } else
            {
                Console.WriteLine("Você foi reprovado !");
            }

            Console.ReadLine();
        }
    }
}
