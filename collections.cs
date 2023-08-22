using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopDersleri
{
    class collections
    {
        static void main(string[] args) {

            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("20");
            list.Add("ali");
            list.Add(null);

            var list2 = new ArrayList() {
                5,
                "ela",
                false,
                4.5,
                null
            };
            var sayi = Console.ReadLine();
        }
    }
}
