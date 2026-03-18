using System;

public static class Program
{
    public static void Main()
    {
        string str = "Iam a Developer";
        string result = "";

        for (int i=str.Length-1;i>=0;i--)
        {
            result = result + str[i];
        }

        Console.WriteLine(result);
    }
}