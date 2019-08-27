using System;

namespace Class_in_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Enter length : ");
              int x = Int32.Parse(Console.ReadLine());
              Console.WriteLine("Enter breadth : ");
              int y = Int32.Parse(Console.ReadLine());
              var r1 = new rectangle(x, y);
              r1.showarea(); */

            int counter = 1;
            var p1 = new Person();
            Console.WriteLine("Enter Age: ");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Salary : ");
            int salary = Int32.Parse(Console.ReadLine());
            p1.Age = age;
            p1.Salary = salary;
            p1.Name = name;
            p1.ID = counter;
            counter += 1;
            p1.display();
            var p2 = new Person();
            Console.WriteLine("Enter Age: ");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Salary : ");
            salary = Int32.Parse(Console.ReadLine());
            p2.Age = age;
            p2.Salary = salary;
            p2.Name = name;
            p2.ID = counter;
            counter += 1;
            p2.display();
            var p3 = new Person();
            Console.WriteLine("Enter Age: ");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Salary : ");
            salary = Int32.Parse(Console.ReadLine());
            p3.Age = age;
            p3.Salary = salary;
            p3.Name = name;
            p3.ID = counter;
            counter += 1;
            p3.display();
        }

        public class rectangle
        {
            public int length, breadth;
            public rectangle(int l,int b)
            {
                length = l; 
                breadth = b;
            }
            public void showarea()
            {
                Console.Write("Area = " + length * breadth);
            }
        }

        public class Person
        {
            private int age, salary;
            private static int counter = 1;
            public int ID { get; set; }
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    if (value<18)
                    {
                        Console.WriteLine("Error cannot insert Age setting defaults");
                        age = 18;
                    }
                    else
                    {
                        age = value;
                    }

                }
            }
            public int Salary
            {
                get
                {
                    return salary;
                }
                set
                {
                    if (value > 5000)
                    {
                        Console.WriteLine("Error cannont insert Salary setting defaults");
                        salary = 5000;
                    }
                    else
                    {
                        salary = value;
                    }
                }
            }
            public string Name { get; set; }
            public void display()
            {
                Console.WriteLine($"person {id} is {name} age is {age} and he earns {salary} his id is {id} \n\n\n\n\n\n\n");
            }

        }
    }
}
