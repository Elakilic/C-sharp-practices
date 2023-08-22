using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy
{
    internal class copyc
    {
        public string ad, konum;
        public copyc(string ad, string konum)
        {
            this.ad = ad;
            this.konum = konum;
        }
        public copyc(copyc s)
        {
            this.ad = s.ad;
            this.konum = s.konum;


        }

    }
    class copyConst
    {
        public static void Main(string[] args)
        {
            copyc s = new copyc("Ela Kılıç", "Diyarbakır");

            copyc s2 = new copyc(s);
            s2.ad = "Aram Kılıç";
            s2.konum = "Antalya";

            Console.WriteLine(s.ad + "," + s.konum);
            Console.WriteLine(s2.ad + "," + s2.konum);
        }

    }
}
