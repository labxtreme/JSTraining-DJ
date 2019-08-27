using System;
using System.Collections.Generic;

namespace List_manupulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Ana", "James", "Merry" };
            int index = names.IndexOf("Ron");
            if (index != -1)
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }
            else
                Console.WriteLine("Name not found");
            names.Add("Harry");
            names.Add("Ron");
            names.Add("Ben");
            names.Remove("Ana");
            Console.WriteLine(names.Count);
            foreach (var name in names) 
            Console.WriteLine($"Hello {name.ToUpper()}!");
            Console.ReadKey(true);

        }
    }
}
