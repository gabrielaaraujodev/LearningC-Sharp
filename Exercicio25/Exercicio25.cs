using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio25
{
    internal class Exercicio25
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do coeficiente 'a': ");
            var coefA = double.Parse(Console.ReadLine());

            if (coefA == 0)
            {
                Console.WriteLine("O valor de 'a' NÃO pode ser ZERO, pois faz com que a equação deixe de ser do segundo grau !");
            } else
            {
            Console.WriteLine("Informe o valor do coeficiente 'b': ");
            var coefB = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do coeficiente 'c': ");
            var coefC = double.Parse(Console.ReadLine());   
                
            Console.WriteLine("Sua equação do 2º Grau é: " + coefA + "x² + " + coefB + "x + " + coefC + " = 0");

                var delta = Math.Pow(coefB, 2) - 4 * coefA * coefC;

            Console.WriteLine("O valor de delta é: " + delta);
                if (delta < 0)
                {
                    Console.WriteLine("Não existe raiz REAL !");
                } else if (delta == 0)
                {
                    var uniqueRoot = (-(coefB) + Math.Sqrt(delta)) / (2*coefA);

                    Console.WriteLine("Existe uma única raiz real: " + uniqueRoot);
                } else
                {
                    var uniqueRootOne = (-(coefB) + Math.Sqrt(delta)) / (2 * coefA);
                    var uniqueRootTwo = (-(coefB) - Math.Sqrt(delta)) / (2 * coefA);

                    Console.WriteLine("Existem duas raízes reais distintas: " + uniqueRootOne + " e " + uniqueRootTwo);
                }
            }


            Console.ReadLine();
        }
    }
}
