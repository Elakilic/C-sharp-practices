
using System;
using System.Collections;

class arrayList
{
    public static void Main(string[] args)
    {
        ArrayList mylist = new ArrayList();

        mylist.Add("A");
        mylist.Add("B");    
        mylist.Add("C");
        mylist.Add("D");
        mylist.Add("E");
        mylist.Add("F");

        Console.WriteLine("Before addRange method");

        foreach(var i in mylist)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("After addRange method");

        mylist.AddRange(mylist);

        foreach(var i in mylist)
        {
            Console.WriteLine(i);
        }
    }
}