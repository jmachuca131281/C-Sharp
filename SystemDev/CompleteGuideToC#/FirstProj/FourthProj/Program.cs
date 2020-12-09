using System;

namespace FourthProj
{
    class Program
    {
        static void Main(string[] args)
        {
            // First form
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // Second form
            int[] b;
            b = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Length index: " + a.Length);
            Console.WriteLine("First index of a: " + a[0]);
            Console.WriteLine("First index of b: " + b[0]);


        }
    }
}
