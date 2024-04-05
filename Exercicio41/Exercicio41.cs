using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio41
{
    internal class Exercicio41
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a sua altura: ");
            var height = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o seu peso: ");
            var weight = double.Parse(Console.ReadLine());  

            var imc = weight/Math.Pow(2, height);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso !");
            } else if (imc <24.9)
            {
                Console.WriteLine("Saudável");
            } else if (imc < 29.9)
            {
                Console.WriteLine("Peso em excesso !");
            } else if (imc < 34.9)
            {
                Console.WriteLine("Obesidade grau I");
            } else if (imc < 39.9)
            {
                Console.WriteLine("Obesidade grau II (Severa)");
            }
            else
            {
                Console.WriteLine("Obesidade grau III (Mórbida");
            }

            Console.ReadLine();
        }
    }
}
