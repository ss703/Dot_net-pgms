using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 2, 7, 5, 6 };
            Array.Sort(num);
            foreach(int x in num)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
