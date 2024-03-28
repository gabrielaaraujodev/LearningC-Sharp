using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício17
{
    internal class Exercicio17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base maior: ");
            var baseMaior = double.Parse(Console.ReadLine());

            Console.WriteLine("Base menor: ");
            var baseMenor = double.Parse(Console.ReadLine());

            if (baseMaior <= 0 || baseMenor <= 0)
            {
                Console.WriteLine("Valor Inválido ! Não pode ser negativo !");
            } else
            {
            Console.WriteLine("Altura: ");
            var altura = double.Parse(Console.ReadLine());

            var area = ((baseMaior + baseMenor) * altura)/2;

            Console.WriteLine("A área é: " + area);
            }
            Console.ReadLine();

        }
    }
}
