using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MethodOverriding
    {
        public static void Main(string[] args)
        {
            Hayvan hayvan = new Hayvan();
            hayvan.Ses();
            Kopek ciko = new Kopek();
            ciko.Ses();
            Kedi minik = new Kedi();
            minik.Ses();

        }
    }

    class Hayvan
    {
        public virtual void Ses() 
        {
            Console.WriteLine("----------");
        }
    }
    class Kopek:Hayvan 
    {
        public override void Ses()
        {
            Console.WriteLine("Hav");
        }
    }
    class Kedi : Hayvan
    {
        public override void Ses()
        {
            Console.WriteLine("Miyav");
        }
    }
}
