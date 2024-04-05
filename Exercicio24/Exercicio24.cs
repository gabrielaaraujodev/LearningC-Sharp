using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio24
{
    internal class Exercicio24
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do prodruto");
            var value = double.Parse(Console.ReadLine());

            Console.WriteLine("1 - Minas Gerais");
            Console.WriteLine("2 - São Paulo");
            Console.WriteLine("3 - Rio de Janeiro");
            Console.WriteLine("4 - Mato Grosso do Sul");
            var option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("O valor do produto com imposto será: " + ((value*0.7) + value));
                    break;

                case 2:
                    Console.WriteLine("O valor do produto com imposto será: " + ((value * 1.2) + value));
                    break;

                case 3:
                    Console.WriteLine("O valor do produto com imposto será: " + ((value * 1.5) + value));
                    break;

                case 4:
                    Console.WriteLine("O valor do produto com imposto será: " + ((value * 0.8) + value));
                    break;
            }
            Console.ReadLine();
        }
    }
}
