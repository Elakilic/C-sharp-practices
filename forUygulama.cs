//for 
// 1- "1-100" arasındaki sayıların toplamını hesaplayınız.

internal class forUygulama
{
    private static void Main(string[] args)
    {
        var toplam = 0;

        for (int i = 1; i <= 100; i++)
        {
            toplam += i;
        }
        Console.WriteLine(toplam);

        // var toplam = 0;
        // for(var i = 1; i <= 100; i++ ) { //1-100 arası tek sayıların toplamı
        //     if(i % 2 == 1) {
        //         toplam += i;
        //     }
        // }
        // Console.WriteLine(toplam);

        // 2- Klavyeden girilen başlangıç ve bitiş değerleri arasındaki tüm sayıların toplamını hesaplayınız.

        Console.Write("başlangıç: ");
        var baslangic = Convert.ToInt32(Console.ReadLine());

        Console.Write("bitiş: ");
        var bitis = Convert.ToInt32(Console.ReadLine());

        Console.Write("artış: ");
        var artis = Convert.ToInt32(Console.ReadLine());
        int toplam2 = 0;
        for (int i = baslangic; i < bitis; i = i + artis)
        {
            toplam2 += i;

        }
        Console.WriteLine(toplam2);

        // 3- {"ali","ahmet","can","yelda","seda"} dizindeki tüm elemanları ekrana yazdırın.

        string[] isimler = { "ali", "ahmet", "can", "yelda", "seda" };

        for (var i = 0; i <= isimler.Length; i++)
        {
            Console.WriteLine(isimler[i]);
        }

        // 4- {1,3,4,34,41,56,89} dizisindeki sayılardan hangisileri 3' ün katıdır?
        int[] dizi = { 1, 3, 4, 34, 41, 56, 89 };

        for (var i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] % 3 == 0)
            {
                Console.WriteLine(dizi[i]);
            }
        }
    }
}
