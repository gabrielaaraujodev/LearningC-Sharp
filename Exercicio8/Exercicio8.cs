using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    internal class Exercicio8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a 1ª nota: ");
            var firstGrade = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a 2ª nota: ");
            var secondGrade = double.Parse(Console.ReadLine());

            if (firstGrade > 0 || firstGrade < 10 && secondGrade > 0 || secondGrade < 10) {
                Console.WriteLine("");
                Console.WriteLine((firstGrade + secondGrade) / 2);
            } else
            {
                Console.WriteLine("Notas Inválidas !");
            }

            Console.ReadLine();
        }
    }
}
