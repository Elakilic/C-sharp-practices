// Mantıksal Operatörler Uygulamaları

// 1- Yaşı 18' den büyük ya da veli izni varsa bir işte çalışabilir durumunu kontrol ediniz.



internal class mantiksaloperatorler
{
    private static void Main(string[] args)
    {
        var yas = 17;
        bool veliIzni = false;
        var sonuc = yas > 18 || veliIzni == true ? "işte çalışabilir" : "işte çalışamaz";
        Console.WriteLine(sonuc);

        // 2- Ders notu 50-100 arasındaysa geçti değilse kalsın bilgisini yazdırınız.

        int not = 70;
        var sonuc2 = not >= 50 && not <= 100 ? "geçti" : "kaldı";
        Console.WriteLine(sonuc2);

        // 3- Ders ortalaması en az 70 puan ve zayıfı yoksa teşekkür belgesi alabilme durumunu kontrol ediniz.
        int notOrtalamasi = 65;
        bool zayifYok = true;
        var sonuc3 = notOrtalamasi >= 70 && zayifYok == true ? "teşekkür alabilir" : "teşekkür alamaz";
        Console.WriteLine(sonuc3);

        // 4- İşe girmek için en az önlisans ya da lisans mezunu olma durumunu kontrol ediniz. Sigara kullanmama koşulu.

        string egitim = "lise";
        bool sigaraIcme = false;
        var sonuc4 = (egitim == "lisans" || egitim == "önlisans") && sigaraIcme == true ? "mezun" : "kaldı";
        Console.WriteLine(sonuc4);

        //Uygulamaya giriş kontrolünü username ya da parola için yapalım.
        string username = "elakilic";
        string password = "12345";
        var sonuc5 = username == "elakilic" && password == "12345" ? "Başarılı" : "Başarısız";
        Console.WriteLine(sonuc5);
    }
}