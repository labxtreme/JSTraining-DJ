using System;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add");
            int num1, num2, result;
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            result = num1 + num2;
            Console.WriteLine("result = " + result);
        }
    }
}
