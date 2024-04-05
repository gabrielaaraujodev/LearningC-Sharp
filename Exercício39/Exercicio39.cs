using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício39
{
    internal class Exercicio39
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu salário atual: ");
            var salary = double.Parse(Console.ReadLine());

            Console.WriteLine("A quantos anos você trabalha na empresa: ");
            var pastTime = double.Parse(Console.ReadLine());

            if (salary <= 500 && pastTime  < 1)
            {
                Console.WriteLine("Seu novo salário será: " + (salary*0.25 + salary));
            } else if (salary <= 1000 && pastTime <= 3)
            {
                Console.WriteLine("Seu novo salário será com bonus de 100,00 será: " + (salary * 0.20 + salary + 100));
            } else if (salary <= 1500 && pastTime <= 6)
            {
                Console.WriteLine("Seu novo salário será com bonus de 200,00 será: " + (salary * 0.15 + salary + 200));
            } else if (salary <= 2000 && pastTime <= 10)
            {
                Console.WriteLine("Seu novo salário será com bonus de 300,00 será: " + (salary * 0.10 + salary + 300));
            } else
            {
                Console.WriteLine("Seu novo salário será com bonus de 500,00 será: " + (salary + 500));
            }

            Console.ReadLine();
        }
    }
}
