using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio35
{
    internal class Exercicio35
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um dia: ");
            var day = int.Parse(Console.ReadLine());
            
            if (day <= 0 || day > 31)
            {
                Console.WriteLine("Estes dias ultrapassam os limites !");
            } else
            {
                Console.WriteLine("Informe um mês: ");
                var month = int.Parse(Console.ReadLine());

                if (month >= 1 && month <= 12)
                {
                    Console.WriteLine("Informe um ano: ");
                    var year = int.Parse(Console.ReadLine());
                    if (year <= 0)
                    {
                        Console.WriteLine("Não existe !");
                    } else
                    {

                        if (month == 2 && year % 400 == 0 && day == 29 || month == 2 && year % 4 == 0 && year % 100 != 0 && day == 29)
                        {
                            Console.WriteLine("Este dia existe em anos bissextos !");

                            Console.WriteLine("Completo: " + day + "/" + month + "/" + year);
                            var complete = int.Parse(Console.ReadLine());
                        }
                        else if (month == 2 && day > 28)
                        {
                            Console.WriteLine("Não existe esta data para esse mês !");
                        }
                        else
                        {
                            Console.WriteLine("Completo: " + day + "/" + month + "/" + year);
                            var complete = int.Parse(Console.ReadLine());
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Não existe !");
                }


            }

            Console.ReadLine();    

        }
    }
}
