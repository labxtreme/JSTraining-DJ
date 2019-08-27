using System;
using System.Collections.Generic;
using System.Text;

namespace Ref_and_out_parameters
{
    class C1
    {

        public static void display(out int i)
        {
            i=129;
            Console.WriteLine(i);
        }
    }
}
