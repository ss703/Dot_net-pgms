using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prgm
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, rev = 0;
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;//121=121
            while (n != 0)//121
            {
                r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }
            if (rev == temp)//131=121
            {
                Console.WriteLine("the number is palindrome");
            }
            else
            {
                Console.WriteLine("not a palindrome");
            }
            Console.ReadKey();
        }
    }
}
