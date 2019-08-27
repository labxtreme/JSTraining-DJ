using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 a = 0, b = 1, res;
            Console.WriteLine("Enter the number you want the fibonacci series : ");
            int limit = Int32.Parse(Console.ReadLine());
            if (limit == 1)
            {
                Console.Write("Series start :");
                Console.Write(a + " ");
            }
            else if (limit==2)
            {
                Console.Write("Series start :");
                Console.Write(a + " ");
                Console.Write(b + " ");
            }
            else
            {
                Console.WriteLine("Series start :");
                Console.Write(a + " ");
                Console.Write(b + " ");
                for (int i = 2; i < limit; i++)
                {
                    res = a + b;
                    Console.Write(res + " ");
                    a = b;
                    b = res;
                }
            }
            Console.ReadKey(true);
      
        }
    }
}
