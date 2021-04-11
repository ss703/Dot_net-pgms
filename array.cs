using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "praveen", "soumya", "laddu" };
            //for(int i=0;i<names.Length;i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            

            //sorting->asceding order
     
            foreach(string a in names)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}


//syntax

//    foreach(datatype variablename in arrayname)
//    {
//    ///
//    }