using System;

String [] names = { "Alice", "Bob", "Charlie" };    

foreach(string value in names)
    {
    Console.WriteLine("FOREACH LOOP : " + value);
}

foreach (string value in names.Reverse())
{
    Console.WriteLine("FOREACH LOOP REVERSE : " + value);
}