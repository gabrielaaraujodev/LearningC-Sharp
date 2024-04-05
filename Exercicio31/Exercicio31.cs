using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio31
{
    internal class Exercicio31
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua altura: ");
            var heigh = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu peso: ");
            var weight = double.Parse(Console.ReadLine());

            if (heigh < 1.20 && weight <= 60)
            {
                Console.WriteLine("Como sua altura vale " + heigh + " sua categoria é: A");
            } else if (heigh <= 1.70 && weight <= 60)
            {
                Console.WriteLine("Como sua altura vale " + heigh + " sua categoria é: B");

            } else if (heigh > 1.70 && weight <= 60)
            {
                Console.WriteLine("Como sua altura vale " + heigh + " sua categoria é: C");

            } else if (heigh < 1.20 && weight >= 60 && weight <= 90)
            {
                Console.WriteLine("Como sua altura vale " + heigh + " sua categoria é: D");
            } else if (heigh <= 1.70 && weight >= 60 && weight <= 90)
            {
                Console.WriteLine("Como sua altura vale " + heigh + " sua categoria é: E");
            } else if (heigh > 1.70 && weight >= 60 && weight <= 90)
            {
                Console.WriteLine("Como sua altura vale " + heigh + " sua categoria é: F");
            } else if (heigh < 1.20 && weight > 90)
            {
                Console.WriteLine("Como sua altura vale " + heigh + " sua categoria é: G");

            } else if (heigh <= 1.70 && weight > 90)
            {
                Console.WriteLine("Como sua altura vale " + heigh + " sua categoria é: H");
            } else
            {
                Console.WriteLine("Como sua altura vale " + heigh + " sua categoria é: I");
            }

            Console.ReadLine();
        }
    }
}
