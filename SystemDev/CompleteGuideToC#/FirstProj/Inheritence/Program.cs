using System;

namespace Inheritence
{
    class Program : Program1
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.name = "José";
            Program1 p1 = new Program1();
            p1.name1 = "Manuel";
            Console.WriteLine(p.getData());
            Console.WriteLine(p1.getData1());
        }
    }

    class Program1: Program2
    {
        public string name;
        public string getData()
        {
            return name;
        }
    }
    
    class Program2
    {
        public string name1;
        public string getData1()
        {
            return name1;
        }

    }
}
