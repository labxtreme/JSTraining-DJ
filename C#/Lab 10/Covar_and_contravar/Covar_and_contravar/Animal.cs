using System;
using System.Collections.Generic;
using System.Text;

namespace Covar_and_contravar
{
    public class Animal
    {
        protected int age;
        public void Display_age()
        {
            Console.WriteLine("Enter age of Animal ");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Age of dog set to " +age+"\n");
        }
    }
    public class Dog : Animal
    {
        protected string name;
        public void Display_name()
        {
            Display_age();
            Console.WriteLine("Enter name of Dog ");
            name = Console.ReadLine();
            Console.WriteLine("Name of dog set to " +name + "\n");

        }

    }
}
