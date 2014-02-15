using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIBONACCI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>(); //make a list of integers called l.
            int a = 1;                     //define them 
            int b = 0;
            int c = 0;
            l.Add(c);                      //we want to add c to our new list at the end of each loop. It's our latest fib number.

            while (c <= 4000000)           //only want the c values up to 4mil
            {
                c = a + b;                 //equation c = a + b, cycle the letters left.
                l.Add(c);
                a = b;
                b = c;
            }

            int sum = 0;
            foreach (int element in l)
            {
                if (element % 2 == 0)
                    sum += element;
            }

            Console.WriteLine(sum);
            Console.Read();
        }
    }
}