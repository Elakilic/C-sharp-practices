using System;


class genericList
{
    static void Main(string[] args){

        List<int> list = new List<int>();

        list.Add(1);
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);

        foreach(int i in list)
        {
            Console.WriteLine(i);
        }

    }
}
