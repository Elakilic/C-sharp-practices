using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Factoriel
    {
        static void Main()
        {
            for (long i = 0; i<=10;i++)
            {
                Console.WriteLine($"{i}!= {FactorielHesap(i)}");
            }

        }

        static long FactorielHesap(long number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number = number * FactorielHesap(number - 1);
            }
        }
    }
}
