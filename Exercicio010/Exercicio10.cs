using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio010
{
    internal class Exercicio10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua altura: ");
            var height = double.Parse(Console.ReadLine());

            Console.WriteLine("informe seu sexo: ");
            var sexo = Console.ReadLine();

            if (sexo == "masculino" || sexo == "m")
            {
                Console.WriteLine((72.7*height) - 58);
            } else
            {
                Console.Write((62.1*height) - 44.7);
            }

            Console.ReadLine();
        }
    }
}
