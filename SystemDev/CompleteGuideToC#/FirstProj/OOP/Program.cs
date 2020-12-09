using System;

namespace OOP
{
    class Program
    {
        int a = 1, b = 2, sum = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.add();
        }

        public void add()
        {
            this.sum = this.a + this.b;
            Console.WriteLine(this.sum);
        }
    }
}
