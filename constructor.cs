class constructor
{

    
    String name;
    int id;

    
    constructor(String name, int id)
    {
        this.name = name;
        this.id = id;
    }

    // Main Method
    public static void Main()
    {

        
        constructor const1 = new constructor("ela", 1);
        Console.WriteLine("Name = " + const1.name +
                         " and Id = " + const1.id);
    }
}
