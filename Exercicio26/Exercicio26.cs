using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio26
{
    internal class Exercicio26
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a distância percorrida em KM: " + " Km");
            var distance = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de litros gasto nesta distância: ");
            var oil = double.Parse(Console.ReadLine());

            var coast = distance / oil;

            if (coast < 8 )
            {
                Console.WriteLine("Venda o carro !");
            } else if (coast < 14)
            {
                Console.WriteLine("Econômico !");
            } else
            {
                Console.WriteLine("Super Econômico !");
            }
            Console.ReadLine();
        }
    }
}
