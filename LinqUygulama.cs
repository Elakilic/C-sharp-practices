using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinqUygulama
    {
        public static void Main(string[] args)
        {
            var values = new[] { 2, 9, 5, 0, 3, 7, 4, 8, 1 };
            Console.WriteLine("Orijinal array: ");

            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
            var filtered=
                from value in values
                where value >4
                select value;

            Console.WriteLine("Arrayin 4ten büyük olan değerleri: ");
            foreach(var value in filtered)
            {
                Console.WriteLine(value);
            }
            var sorted=
                from value in values
                orderby value
                select value;
            Console.WriteLine("Orijinal arrayin sıralı hali: ");
            foreach( var value in sorted)
            {
                Console.WriteLine(value);
            }
            var sortedFiltered =
                from value in filtered
                orderby value
                select value;

            Console.WriteLine("Filtrelenmiş dizi sıralaması:");
            foreach(var value in sortedFiltered)
            {
                Console.WriteLine(value);
            }

            var Value=
                from value in values
                select value;
            Console.WriteLine("Minimum Sayı:");
            Console.WriteLine(Value.Min());
            
            Console.WriteLine("Maximum Sayı:");
            Console.WriteLine(Value.Max());
        }
         
    }
}
