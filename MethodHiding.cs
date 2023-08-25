using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MethodHiding
    {
        public static void Main(string[] args)
        {
            Derived derived = new Derived();
            derived.message();


        }
    }
    class Base
    {
        public void message()
        {
            Console.WriteLine("Selam");

        }
    }
    class Derived:Base 
    {
        public new void message()
        {
            base.message();
            Console.WriteLine("Hello");

        }
    }
}
