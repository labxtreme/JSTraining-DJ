using System;

namespace Partial_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Product a = new Product();
            Product b = new Product(100,"Bar");
            Product c = new Product(100,"Pub","Blue");
            a.Display();
            b.Display();
            c.Display();



        }
    }
}
