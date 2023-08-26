using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Linq2
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>() {"ela", "ali", "özgür","aram", "avesta" };
            
            Console.WriteLine("Orijinal liste: ");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            var filtered =
                from item in list
                where item.StartsWith('a')
                select item;
            Console.WriteLine("a ile başlayanlar:");
            foreach(string item in filtered)
            {
                Console.WriteLine(item);
            }
            List<int> list2 = new List<int>() { 5, 10, 20, 43, 87, 65, 93, 72, 102 };
            Console.WriteLine("Orijinal liste : ");
            foreach(int item in list2)
            {
                Console.WriteLine(item);
            }
            var sıralı=
                from item in list2
                orderby item
                select item;
            Console.WriteLine("Sıralı liste: ");
            foreach(int item in sıralı )
            {
                Console.WriteLine(item);
            }
            Console.Write("Minimum değer: ");
            Console.WriteLine(list2.Min());

            Console.Write("Maximum değer: ");
            Console.WriteLine(list2.Max());

            var filtered2=
                from item in sıralı
                where item>25 && item<90
                select item;
            Console.WriteLine("Filtrelenmiş sıralı sayı listesi: ");
            foreach( int item in filtered2)
            {
                Console.WriteLine(item);
            }

        }
        
    }
}
