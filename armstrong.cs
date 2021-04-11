using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            //153=1*1*1+5*5*5+3*3*3=1+125+27=153=aram
            //21=2*2+1*1=4+1=5 not
            int n, sum = 0, r;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            while(n!=0)//153,15,1
            {
                r = n % 10;//153%10=3,15%10=5
                sum = sum + (r * r * r);//0+27=27,27+125=152,27+125+1=153
                n = n / 10;//153/10=15,15/10=1,0
            }
            if(sum==temp)
            {
                Console.WriteLine("the given num is armstrong");
            }
            else
            {
                Console.WriteLine("Not a armstrong");
            }
            Console.ReadKey();

        }
    }
}
