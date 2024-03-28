using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    internal class Exercicio14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a nota do laboratório: ");
            var lab = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota do AS: ");
            var semester = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota do exam: ");
            var exam = double.Parse(Console.ReadLine());

            var media = (lab*2 + semester*3 + exam*5)/ 10;
            Console.WriteLine("Sua média é: " + media);

            if (media >= 0 || media <= 2.9)
            {
                Console.WriteLine("Reprovado !");
            } else if (media <= 4.9)
            {
                Console.WriteLine("Recuperação");
            } else
            {
                Console.WriteLine("Aprovado !");
            }

            Console.ReadLine();
        }
    }
}
