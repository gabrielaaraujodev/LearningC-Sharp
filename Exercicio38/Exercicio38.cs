using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio38
{
    internal class Exercicio38
    {
        static void Main(string[] args)
        {
            const int year = 2008;

            Console.WriteLine("Informe um dia: ");
            var day = int.Parse(Console.ReadLine());

            if (day <= 0 || day > 31)
            {
                Console.WriteLine("Estes dias ultrapassam os limites !");
            }
            else
            {
                Console.WriteLine("Informe um mês: ");
                var month = int.Parse(Console.ReadLine());

                if (month >= 1 && month <= 12)
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
                        else if (month == 4 && day <= 30 || month == 6 && day <= 30 || month == 9 && day <= 30 || month == 11 && day <= 30)
                        {
                            Console.WriteLine("Completo: " + day + "/" + month + "/" + year);
                            var complete = int.Parse(Console.ReadLine());
                        } else if (month == 4 && day == 31 || month == 6 && day == 31 || month == 9 && day == 31 || month == 11 && day == 31)
                        { 
                            Console.WriteLine("Data inválida para este mês !");
                            
                        } else { 
                             Console.WriteLine("Completo: " + day + "/" + month + "/" + year);
                            var complete = int.Parse(Console.ReadLine());
                        }
                }
                else
                {
                    Console.WriteLine("Não existe !");
                }

                Console.ReadLine();
            }
        }
    }
}
