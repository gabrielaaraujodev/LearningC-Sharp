using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio33
{
    internal class Exercicio33
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o preço do produto sem a atualização: ");
            var price = double.Parse(Console.ReadLine());

            if (price <= 50)
            {
                Console.WriteLine("O novo valor do produto será: " + (price * 0.05 + price));

                if (price <= 80)
                {
                    Console.WriteLine("Barato");    
                } else if (price <= 120)
                {
                    Console.WriteLine("Normal");
                } else if (price <= 200)
                {
                    Console.WriteLine("Caro");
                } else
                {
                    Console.WriteLine("Muito Caro");
                }

            } else if (price <= 100)
            {
                Console.WriteLine("O novo valor do produto será: " + (price * 0.1 + price));

                if (price <= 80)
                {
                    Console.WriteLine("Barato");
                }
                else if (price <= 120)
                {
                    Console.WriteLine("Normal");
                }
                else if (price <= 200)
                {
                    Console.WriteLine("Caro");
                }
                else
                {
                    Console.WriteLine("Muito Caro");
                }

            } else
            {
                Console.WriteLine("O novo valor do produto será: " + (price * 0.15 + price));

                if (price <= 80)
                {
                    Console.WriteLine("Barato");
                }
                else if (price <= 120)
                {
                    Console.WriteLine("Normal");
                }
                else if (price <= 200)
                {
                    Console.WriteLine("Caro");
                }
                else
                {
                    Console.WriteLine("Muito Caro");
                }
            }

            Console.ReadLine();
        }
    }
}
