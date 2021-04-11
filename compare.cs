using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = { 1, 2, 3 };
            int[] n2 = n1;
            if(n1==n2)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
            Console.ReadLine();

        }
    }
}
