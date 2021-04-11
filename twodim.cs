using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_dimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];//declaring array
            arr[0, 0] = 1;
            arr[0, 1] = 10;//0
            arr[1, 2] = 20;//1
            arr[2, 0] = 30;//2

            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.WriteLine(arr[i, j] + "");
                }
            }
            Console.ReadLine();

        }
    }
}
