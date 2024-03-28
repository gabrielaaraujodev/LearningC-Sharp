using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    internal class Exercicio9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o salário: ");
            var salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do empréstimo: ");
            var loan = double.Parse(Console.ReadLine());

            if (loan > (0.2*salary))
            {
                Console.WriteLine("Empréstimo não concedido !");
            } else
            {
                Console.WriteLine("Empréstimo concedido !");
            }

            Console.ReadLine();
        }
    }
}
