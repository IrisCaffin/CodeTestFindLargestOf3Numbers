using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTestFindLargestOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindLargestNumber(6, 3, 9));
        }

        // <summary>
        // Find the largest of three numbers
        // </summary>
        // <param name="a">first parameter</param>
        // <param name="b">second parameter</param>
        // <param name="c">third parameter</param>
        // <returns></returns>

        public static long FindLargestNumber(long a, long b, long c)
        {
            // Assume that the first value is the biggest
            long biggest = a;

            // Check if b is the biggest
            if (b > biggest)
                biggest = b;

            // check if c is the biggest
            if (c > biggest)
                biggest = c;

            return biggest;

            Console.ReadLine();
        }   
    }
}
