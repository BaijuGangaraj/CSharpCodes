using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

public class linqfirst 
{
    public void test()
    { 
    int[] test1 = { 10, 2, 3, 4, 5 };

    int[] test2 = new int[1];

        Console.WriteLine("FirstOrDefault: " + test1.FirstOrDefault()); // Output: 1


        Console.WriteLine("FirstOrDefault on empty array: " + test2.FirstOrDefault());
    }

    static void Main(String[] args)
    {
        linqfirst obj = new linqfirst();
        obj.test();

         // Output: 0
    }

}




