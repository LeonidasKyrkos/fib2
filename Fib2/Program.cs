using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIBONACCI
{
    class Program                          //Class name
    {
        static void Main(string[] args)    //static = declaration of type of class, void = the type of method (void = doesn't return a value), main = name of the function
        {                                  //string = the parameter type 
            List<int> l = new List<int>(); //make a list of integers called l.
            int a = 1;                     //define them 
            int b = 0;
            int c = 0;
            l.Add(c);                      //we want to add c to our new list at the end of each loop. It's our latest fib number.

            while (c <= 4000000)           //only want the c values up to 4mil
            {
                c = a + b;                 //equation to follow the fib sequence is c = a + b
                l.Add(c);                  //Add c to our list after each loop
                a = b;                     //cycle the values <--
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