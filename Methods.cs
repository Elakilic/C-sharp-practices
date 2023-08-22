using System;

    namespace Methods
{
    public class My_Family
    {
        public void Member()
        {
            Console.WriteLine("Total number of family members=3");
        }

    }
    public class  My_Member: My_Family {
        public new void Member()
        {
            base.Member();
            Console.WriteLine("Name: Ela , Age: 23\nName:Ali, Age:25 \nName: Aram, Age:2");
        }
    
    
    
    }
    class Program
    {
        public static void Main(string[] args)
        {
            My_Member obj = new My_Member();
            obj.Member();

        }
    }  

}




