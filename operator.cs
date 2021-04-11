using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a operator");
            string op = Console.ReadLine();
            int result;
            if(op=="+")
            {
                result = a + b;
                Console.WriteLine("sum is" + result);
            }

           else if (op == "-")
            {
                result = a - b;
                Console.WriteLine("sub is" + result);
            }

           else if (op == "*")
            {
                result = a * b;
                Console.WriteLine("mul is" + result);
            }

            else if (op == "/")
            {
                result = a / b;
                Console.WriteLine("div is" + result);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
            Console.ReadLine();

        }
    }
}
