using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Encap
    {
        private string isim;
        private int yas;

        public string Name
        {
            get { return isim; }
            set { isim = value; }
        }
        public int Age
        {
            get { return yas; }
            set { yas = value; }
        }

        
    }
    class Encapsulation
    {
        public static void Main(string[] args)
        {
            Encap kisi = new Encap();
            kisi.Name = "Ela";
            kisi.Age = 23;

            Console.WriteLine("Kişinin ismi: " +kisi.Name + " ve kişinin yaşı: " + kisi.Age);

        }
    }
}
