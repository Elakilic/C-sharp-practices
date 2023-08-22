// Dizi Metotları

string[] sehirler = { "istanbul", "antalya", "diyarbakır" };
int[] plakalar = { 67, 53, 41 };

//sehirler[0] = "mardin";
sehirler.SetValue("mardin", 0);

Console.WriteLine(sehirler[0]);
Console.WriteLine(sehirler.GetValue(1)); //1. indexi getirir
Console.WriteLine(sehirler.Length); //index sayısını verir
Console.WriteLine(Array.IndexOf(sehirler, "antalya")); //kaçıncı index olduğunu söyler.

Array.Sort(sehirler); //alfabetik sıralar.
Array.Sort(plakalar); //küçükten büyüğe sıralar.

Console.WriteLine(sehirler.GetValue(0));
Console.WriteLine(plakalar.GetValue(0));

Array.Reverse(plakalar); //ters çevirir.

Array.Clear(sehirler); //içini boşaltır. sehirler string old. için null değer olur defaultu.
//Array.Clear(plakalar); //plakalar int old. için 0 olur değeri.
Array.Clear(plakalar, 0, 1);//0. indexten itibaren 1 tane sil.


Console.WriteLine(plakalar.GetValue(0));
Console.WriteLine(plakalar.GetValue(1));
Console.WriteLine(plakalar.GetValue(2));

Console.WriteLine(sehirler.GetValue(0));






