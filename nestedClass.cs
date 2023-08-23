using System;

class nestedClass
{
    static public void Main(string[] args)
    {
        Dis_Class obj1 = new Dis_Class();
        obj1.method1();

        Dis_Class.ic_Class obj2 = new Dis_Class.ic_Class();
        obj2.method2();

    }
}


public class Dis_Class
{
    public void method1()
    {
        Console.WriteLine("Dış Class Methodu.");
    }
    public class ic_Class
    {
        public void method2()
        {
            Console.WriteLine("İç Class Methodu.");
        }
    }
}