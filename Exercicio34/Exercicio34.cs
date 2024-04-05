using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio34
{
    internal class Exercicio34
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua nota: ");
            var grade = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantas faltas você tem ?");
            var absense = int.Parse(Console.ReadLine());

            if (grade >= 9 && absense <= 20)
            {
                Console.WriteLine("Conecito A");
            } else if (grade >= 9 && absense > 20 || grade >= 7.5 && absense <= 20)
            {
                Console.WriteLine("Conceito B");
            } else if (grade >= 7.5 && absense > 20 || grade >= 5 && absense <= 20)
            {
                Console.WriteLine("Conceito C");
            } else if (grade >= 5 && absense > 20 || grade >= 4 && absense <= 20)
            {
                Console.WriteLine("Conceito D");
            } else if (grade >= 4 && absense > 20 || grade >= 0 && absense <= 20 || grade >= 0 && absense > 20)
            {
                Console.WriteLine("Conceito E");
            }

            Console.ReadLine();
        }
    }
}
