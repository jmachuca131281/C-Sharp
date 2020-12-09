using System;

namespace Operator_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            double b = 4;
            Program p = new Program();
            p.Print(a);
            p.Print(b);
            p.Print(a, b);
        }

        public void Print(int a)
        {
            Console.WriteLine("INT");
        }

        public void Print(double a)
        {
            Console.WriteLine("double");
        }

        public void Print(int a, double b)
        {
            Console.WriteLine("Int and double");
        }
    }
}
