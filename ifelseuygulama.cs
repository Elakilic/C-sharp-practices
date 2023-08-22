// if/else Uygulamaları

// 1- Kullanıcıya sunulan bir menü içinden seçilecek olan 4 işlem tipine göre hesaplama yapınız.

internal class ifelseuygulama
{
    private static void Main(string[] args)
    {
        Console.Write("Sayı1: ");
        var sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Sayı2: ");
        var sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Toplama için: +");
        Console.WriteLine("Çıkarma için: -");
        Console.WriteLine("Çarpma için:  *");
        Console.WriteLine("Bölme için:   /");
        Console.Write("Seçiminiz: ");
        var secim = Console.ReadLine();

        double sonuc = 0;
        bool ok = true;

        if (secim == "+")
        {
            sonuc = sayi1 + sayi2;
        }
        else if (secim == "-")
        {
            sonuc = sayi1 - sayi2;
        }
        else if (secim == "*")
        {
            sonuc = sayi1 * sayi2;
        }
        else if (secim == "/")
        {

            if (sayi2 == 0)
            {
                ok = false;
                Console.WriteLine("bölen 0 olamaz.");
            }
            else
            {
                sonuc = sayi1 / sayi2;
            }
        }
        else
        {
            ok = false;
            Console.WriteLine("yanlış seçim");
        }
        if (ok)
        {
            Console.WriteLine($"işlem sonucu: {sayi1} {secim} {sayi2} = {sonuc}");
        }
        // 2- Bir öğrencinin 2 yazılı 1 sözlü notunu alıp hesaplanan ortalamaya göre not aralığına karşılık gelen not bilgisini yazınız.

        // 0  -  24  => 0
        // 25 -  44  => 1
        // 45 -  54  => 2
        // 55 -  69  => 3
        // 70 -  84  => 4
        // 85 -  100 => 5

        Console.Write("yazılı1: ");
        var yazili1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("yazılı2: ");
        var yazili2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("sözlü1: ");
        var sozlu1 = Convert.ToInt32(Console.ReadLine());

        var sonuc2 = (yazili1 + yazili2 + sozlu1) / 3;

        if (sonuc2 > 0 && sonuc2 <= 24)
        {
            Console.WriteLine("Notu=0");
        }
        else if (sonuc2 >= 25 && sonuc2 <= 44)
        {
            Console.WriteLine("Notu=1");
        }
        else if (sonuc2 >= 45 && sonuc2 <= 54)
        {
            Console.WriteLine("Notu=2");
        }
        else if (sonuc2 >= 55 && sonuc2 <= 69)
        {
            Console.WriteLine("Notu=3");
        }
        else if (sonuc2 >= 70 && sonuc2 <= 84)
        {
            Console.WriteLine("Notu=4");
        }
        else
        {
            Console.WriteLine("Notu=5");
        }

        // 3- Girilen 3 sayıdan en büyüğünü bulunuz.
        Console.Write("s1:");
        var s1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("s2:");
        var s2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("s3:");
        var s3 = Convert.ToInt32(Console.ReadLine());

        if (s1 > s2)
        {
            if (s1 > s3)
            {
                Console.WriteLine("s1 büyük");
            }
            else
            {
                Console.WriteLine("s3 büyük");
            }
        }
        else if (s2 > s1)
        {
            if (s2 > s3)
            {
                Console.WriteLine("s2 büyük");
            }
            else
            {
                Console.WriteLine("s3 büyük");
            }
        }
        else
        {
            Console.WriteLine("s3 büyük");
        }
    }
}