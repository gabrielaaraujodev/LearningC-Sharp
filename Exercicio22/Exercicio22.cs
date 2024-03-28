using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio22
{
    internal class Exercicio22
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a sua idade: ");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu tempo de trabalho: ");
            var timeWork = double.Parse(Console.ReadLine());

            if (age >= 65 || timeWork >= 30)
            {
                Console.WriteLine("Poderá se aposentar !");
            } else if (age >= 60 && timeWork >= 25)
            {
                Console.WriteLine("Poderá se aposentar !");
            } else
            {
                Console.WriteLine("Não poderá se aposentar no momento !");
            }
            Console.ReadLine();
        }
    }
}
