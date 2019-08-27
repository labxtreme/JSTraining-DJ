using System;

namespace Structure_in_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {   int x, y;
            Console.WriteLine("Enter length of Rectangle");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth of Rectangle");
            y = Int32.Parse(Console.ReadLine());
            var r1 = new rectangle(x, y);
            Console.WriteLine("Rectangle: ");
            Console.Write($"length and breadth are {r1.length} X {r1.breadth} hence Area=");
            r1.getarea();
            Console.ReadKey(true);
        }
        public struct rectangle
        {
            public int length, breadth;

            public rectangle(int l, int b)
            {
                length = l;
                breadth = b;
            }
            public void getarea()
            {
                Console.Write(length * breadth);
            }
        }
    }
}
