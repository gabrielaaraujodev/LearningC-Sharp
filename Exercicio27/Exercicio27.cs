using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio27
{
    internal class Exercicio27
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a sua idade: ");
            var age = int.Parse(Console.ReadLine());

            if (age >= 5 || age <= 7)
            {
                Console.WriteLine("Infantil A");
            } else if (age <= 10)
            {
                Console.WriteLine("Infantil B");
            } else if (age <= 13)
            {
                Console.WriteLine("Juvenil A");
            } else if (age <= 17)
            {
                Console.WriteLine("Juvenil B");
            } else {
                Console.WriteLine("Sênior");
            }

            Console.ReadLine();
        }
    }
}
