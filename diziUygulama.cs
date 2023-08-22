
// ogrenciler ve notlar isminde 2 tane dizi oluşturunuz ve dizi elemanlarını kullanıcıdan aldığınız değerlerle doldurunuz. (3 öğrenci)

// ogrenciler dizisi kaç elemanlıdır, yazdırınız.
// ilk 2 öğrencinin ad ve not bilgisini yazdırınız.
// tüm öğrencilerin not ortalaması nedir? 

internal class diziUygulama
{
    private static void Main(string[] args)
    {
        string[] ogrenci = new string[3];
        var notlar = new int[3];

        Console.Write("1. öğrencinin adı: ");
        ogrenci[0] = Console.ReadLine() ?? "";

        Console.Write("2. öğrencinin adı: ");
        ogrenci[1] = Console.ReadLine() ?? "";

        Console.Write("3. öğrencinin adı: ");
        ogrenci[2] = Console.ReadLine() ?? "";

        Console.Write("1. öğrencinin notu: ");
        notlar[0] = Convert.ToInt32(Console.ReadLine());

        Console.Write("2. öğrencinin notu: ");
        notlar[1] = Convert.ToInt32(Console.ReadLine());

        Console.Write("3. öğrencinin notu: ");
        notlar[2] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(ogrenci.Length);

        foreach (var ogrenciler in ogrenci[..2])
        {
            Console.WriteLine(ogrenciler);
        }

        foreach (var not in notlar[..2])
        {
            Console.WriteLine(not);
        }

        int not1 = notlar[0];
        int not2 = notlar[1];
        int not3 = notlar[2];

        int ortalama = (not1 + not2 + not3) / 3;
        Console.WriteLine("Öğrencilerin not ortalaması: " + ortalama);
    }
}