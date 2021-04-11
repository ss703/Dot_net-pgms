using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1, n;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            while(n>0)//2>0//1
            {
                //3!=3*2*1
                fact = fact * n;//1*3=3//3*2=6//6*1=6
                n--;//2//1
            }
            Console.WriteLine("factorial is" + fact);
            Console.ReadKey();
        }
    }
}
