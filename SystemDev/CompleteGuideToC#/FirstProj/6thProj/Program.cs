using System;

namespace _6thProj
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 3, d = 4;
            Program p = new Program();
            Console.WriteLine(p.max(1,9));
            p.swap(ref c, ref d);
        }

        public int max(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public void swap(ref int c, ref int d)
        {
            int temp;
            temp = c;
            c = d;
            d = temp;
            Console.WriteLine(c + "\n" + d);
        }
    }
}
