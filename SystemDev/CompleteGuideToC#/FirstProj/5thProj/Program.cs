using System;

namespace _5thProj
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7, b = 6;
            int[] c = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //if (a > b)
            //{
            //    Console.WriteLine("A is greater than b");
            //}
            //else
            //{
            //    Console.WriteLine("b is greater than a");
            //}
            //Console.WriteLine("Hello World!");

            //switch (a<b)
            //{
            //    case true: Console.WriteLine("A is greater than B");
            //        break;
            //    case false: Console.WriteLine("B is greater then A");
            //        break;
            //}

            // This is a example with loop for.
            Console.WriteLine("jFor");
            for(int i = 0; i<c.Length; i++)
            {
                Console.WriteLine("Index " + i + " value " + c[i]);
            }

            Console.WriteLine("While");
            // This is a example of while loop
            int ia = 0;
            while (ia < c.Length)
            {
                Console.WriteLine("index " + ia + " value " + c[ia]);
                ia++;
            }

            Console.WriteLine("Do while");
            int e = 0;
            do
            {
                Console.WriteLine("Index " + e + " value " + c[e]);
                e++;
            }
            while (e < c.Length);

            Console.WriteLine("Foreach");
            foreach(int value in c)
            {
                Console.WriteLine(value);
            }
        }
    }
}
