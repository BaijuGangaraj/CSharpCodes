using System;
using System.Collections.Generic;   
using System.Linq;

var list = new List<string>() { "Cat", "Rat", "Mouse" };
Console.WriteLine(list.FirstOrDefault());


var query1 = from element in list
             where element.Length > 10
             select element;
Console.WriteLine(query1.FirstOrDefault()); // Outputs: (null) since no element matches the condition

var query2 = from element in list
             where element.Length > 3
             select element;

Console.WriteLine(query2.FirstOrDefault()); // Outputs: Cat

int[] array = new int[0];
Console.WriteLine(array.FirstOrDefault()); // Outputs: 0 since the array is empty





