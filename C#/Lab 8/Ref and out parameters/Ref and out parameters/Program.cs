using System;

namespace Ref_and_out_parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            C1.display(out count);
            Console.WriteLine(count);
                     
        }
    }
}
