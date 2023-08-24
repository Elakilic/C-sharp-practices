using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class RefandOutParameters
    {
        public static void Main(string[] args)
        {
            int a = 8;
            int b;

            Console.WriteLine("a'nın orijinal değeri: " + a);
            Console.WriteLine("b'ye bir değer ataması yapılmamış.");

            SquareRef(ref a);
            SquareOut(out b);

            Console.WriteLine("SquareRef metotundan sonra a değeri: " + a);
            Console.WriteLine("SquareOut metotoundan sonra b değeri: " + b);

            Square(a);
            Square(b);

            Console.WriteLine("Square metotundan sonra a değeri: " + a);
            Console.WriteLine("Square metotundan sonra b değeri: " + b);


        }
        static void SquareRef(ref int x)
        {
            x = x * x;
        }
        static void SquareOut(out int x) 
        {
            x = 7;
            x = x * x;
        
        }
        static void Square(int x) 
        {
            x = x * x;
        }
    }
}
