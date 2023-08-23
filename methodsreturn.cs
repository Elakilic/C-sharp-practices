using System;

class methodreturn
{
    static void Main(string[] args)
    {
        nesne o1 = new nesne();
        nesne o2 = new nesne();

        o1.setdata("Ela");
        o2.setdata("Aram");

        nesne o3 = o1.Astr(o2);

        o1.goruntule();
        o2.goruntule();
        o3.goruntule();

    }
}

class nesne
{
    private string str;

    public void setdata(string s)
    {
        str = s;
    }

    public void goruntule() {
        Console.WriteLine("String is: "+ str); 
    
    }
    public nesne Astr(nesne n)
    {
        nesne obj = new nesne();
        obj.str = str + n.str;
        return obj;
    }
}
