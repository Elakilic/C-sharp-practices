// String Methods
internal class stringMethods {
    public static void main(String[] args)
    {

        string mesaj = "Ahmet Turan isimli kişi 20 yaşındadır.";

        var sonuc = mesaj.Length; //mesajın kelime uzunluğu
        var sonuc1 = mesaj.ToLower(); //tüm karakterleri küçük yap
        var sonuc2 = mesaj.ToUpper(); //  tüm karakterleri büyük yap.
        var sonuc3 = mesaj.Trim(); //baştaki ve sondaki boşlukları ayıklar.
        var sonuc4 = mesaj.Split(" "); //cümleyi "" içinde ne verdiysek ona göre öğelerine ayırıp sıralar.
        var sonuc5 = mesaj.Split(" ")[3];
        var sonuc6 = mesaj[0];//
        var sonuc7 = mesaj.StartsWith("A");//mesajın ne ile başladığının doğru mu yanlış mı bilgisi
        var sonuc8 = mesaj.EndsWith(".");//mesajın ne ile bittiğinin doğru mu yanlış mı bilgisi
        var sonuc9 = mesaj.Contains("Ali"); // böyle bir şey içeriyor mu diye sorar.
        var sonuc10 = mesaj.IndexOf("a"); //değerin bulunup bulunmadığını bakar ve bulunuyorsa kaçıncı uzunlukta olduğunu söyler.
        var sonuc11 = mesaj.Substring(6, 5); //mesajın 6. değerinden başla 5 değer al.



        Console.WriteLine(sonuc);
        Console.WriteLine(sonuc1);
        Console.WriteLine(sonuc2);
        Console.WriteLine(sonuc3);
        Console.WriteLine(sonuc4);
        Console.WriteLine(sonuc5);
        Console.WriteLine(sonuc6);
        Console.WriteLine(sonuc7);
        Console.WriteLine(sonuc8);
        Console.WriteLine(sonuc9);
        Console.WriteLine(sonuc10);
        Console.WriteLine(sonuc11);
    }

}
