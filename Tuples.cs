using System;

class Tuples
{
    static public void Main(string[] args)
    {

        Tuple<int, int, int, string, int, Tuple<int, int>> mytuple
            = new Tuple<int, int, int, string, int, Tuple<int, int>>(53, 65, 21, "Aram", 82, new Tuple<int, int>(57, 60));

        Console.WriteLine("1. değer: " + mytuple.Item1);
        Console.WriteLine("2. değer: " + mytuple.Item2);
        Console.WriteLine("3. değer: " + mytuple.Item3);
        Console.WriteLine("4. değer: " + mytuple.Item4);
        Console.WriteLine("5. değer: " + mytuple.Item5);
        Console.WriteLine("6. değer: " + mytuple.Item6);



    }
}   
