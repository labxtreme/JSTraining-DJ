using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductEntities p1 = new ProductEntities();
            //select * from product;

            var result = from p in p1.PTs select p;
            foreach(var p in result)
            {
                Console.WriteLine(p.Id + "\t" + p.Name + "\t" + p.Price + "\t\t" + p.inStock );
            }
            //PT ob1 = new PT
            //{
            //    Id = 6,
            //    Name = "box",
            //    Price = 20,
            //    inStock=true
            //};

            //p1.PTs.Add(ob1);
            //p1.SaveChanges();

            Console.WriteLine("Enter Product ID to delete");
            int id = Convert.ToInt32(Console.ReadLine());

            var Result1 = (from p in p1.PTs where p.Id == id select p).FirstOrDefault();
            Result1.Name = "car";
            p1.SaveChanges();


            Console.WriteLine(Result1.Id + "\t" + Result1.Name);
            Console.ReadKey();

        }
    }
}
