
using System.Collections;




namespace oopDersleri
{
    class collections
    {
        static void Main(string[] args) {

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
            int[] sayilar = {10,20,30};
            
            list.AddRange(sayilar);

            var eleman = (int)list[0];
            var isim = list[2].ToString();

            list.Insert(1, "ela");
            list.InsertRange(2, list2);

            // remove
            list.Remove(10);
            list.RemoveAt(2);
            list.RemoveRange(2, 3);

            // contains, indexOf
            Console.WriteLine(list.Contains(100));
            Console.WriteLine(list.IndexOf(10));
            
        }
    }
}
