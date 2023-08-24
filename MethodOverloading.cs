using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MethodOverloading
    {
        public int Toplam(int a, int b)
        {
            int sonuc = a + b;
            return sonuc;
        }
        public int Toplam(in int a, int b, int c)
        {
            int sonuc = a + b + c;
            return sonuc;
        }
        public static void Main(string[] args)
        {
            MethodOverloading obj = new MethodOverloading();

            int sonuc1=obj.Toplam(1, 2);
            Console.WriteLine("İki tamsayı değerinin toplamı: " + sonuc1);

            int sonuc2=obj.Toplam(1,2, 3);
            Console.WriteLine("Üç tamsayı değerinin toplamı: "+  sonuc2);
        }
    }
}
